/*  New BSD License
-------------------------------------------------------------------------------
Copyright (c) 2006-2012, EntitySpaces, LLC
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:
    * Redistributions of source code must retain the above copyright
      notice, this list of conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright
      notice, this list of conditions and the following disclaimer in the
      documentation and/or other materials provided with the distribution.
    * Neither the name of the EntitySpaces, LLC nor the
      names of its contributors may be used to endorse or promote products
      derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL EntitySpaces, LLC BE LIABLE FOR ANY
DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
-------------------------------------------------------------------------------
*/

// #define PLUGINS_FROM_SUBDIRS  // if defined Plugins can also live in subdirectories of the MyMeta-bin-dir
/*
 * PLUGINS_FROM_SUBDIRS disabled because k3b found no way to use dll-s in scrips
 *  tried <%#REFERENCE subdir\myDll.dll  %> ==> script compiler error not found
 *  csc.exe /lib:plugins  ==> script compiler error not found
 */


using System;
using System.Text;
using System.IO;
using System.Xml;
using System.Data;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Collections;
using System.Reflection;
using System.Diagnostics;

using Microsoft.Win32;

namespace EntitySpaces.MetadataEngine
{
	public class Root 
    {
        private esSettings settings;

		public Root(esSettings settings)
		{
			Reset();
            this.settings = settings;
		}

        public esPlugIn esPlugIn
        {
            get
            {
                if (this._esPlugIn == null)
                {
                    this._esPlugIn = new esPlugIn(this.settings);
                }
                return _esPlugIn;
            }
        }

        public esSettings Settings
        {
            get
            {
                return this.settings;
            }
        }

        private esSettingsDriverInfo driverInfo;
        public esSettingsDriverInfo SettingsDriverInfo
        {
            get
            {
                if (driverInfo == null)
                {
                    driverInfo = settings.FindDriverInfoCollection(settings.Driver);
                }

                return driverInfo;
            }
        }

        public Hashtable Input
        {
            get { return _input; }
            set { _input = value; }
        }

        public T GetInput<T>(string name, T defaultValue)
        {
            if (_input.ContainsKey(name))
            {
                return (T)Input[name];
            }
            return defaultValue;
        }

        public T GetInput<T>(string name)
        {
            return (T)Input[name];
        }

		private void Reset()
		{
			UserData = null;

			IgnoreCase = true;
			requiredDatabaseName = false;
			requiresSchemaName = false;
			StripTrailingNulls = false;
			TrailingNull = ((char)0x0).ToString();

			ClassFactory = null;

			_showSystemData = false;

			_driver = dbDriver.None;
			_driverString = "NONE";
			_databases = null;
			_connectionString = "";
			_theConnection = new OleDbConnection();
			_isConnected = false;
			_parsedConnectionString = null;
			_defaultDatabase = "";

			// Language
			_languageMappingFileName = string.Empty;
			_language = string.Empty;
			_languageDoc = null;
			LanguageNode = null;
            UserData = null;
		}

		#region Properties

		public IDatabases Databases
		{
			get
			{
				if(null == _databases)
				{
					if(this.ClassFactory != null)
					{
						_databases = (Databases)ClassFactory.CreateDatabases();
						_databases.dbRoot = this;
						_databases.LoadAll();
					}
				}

				return _databases;
			}
		}

		public IDatabase DefaultDatabase
		{
			get
			{
				IDatabase  defDatabase = null;
				try
				{
					Databases dbases = this.Databases as Databases;

					if(this._defaultDatabase != null && this._defaultDatabase != "")
						defDatabase =  dbases.GetByPhysicalName(this._defaultDatabase);				
					else
					{
						if(dbases.Count == 1)
						{
							defDatabase = dbases[0];
						}
					}
				}
				catch {}

				return defDatabase;
			}
		}

		public IProviderTypes ProviderTypes
		{
			get
			{
				if(null == _providerTypes)
				{
					_providerTypes = (ProviderTypes)ClassFactory.CreateProviderTypes();
					_providerTypes.dbRoot = this;
					_providerTypes.LoadAll();
				}

				return _providerTypes;
			}
		}

		#endregion

		#region Connection 

		public IDbConnection BuildConnection(string driver, string connectionString) 
		{
			IDbConnection conn = null;
			switch(driver.ToUpper())
			{
                case esMetaDrivers.MySql:
                    MySql.MySqlDatabases.LoadAssembly();
                    conn = MySql.MySqlDatabases.CreateConnection(connectionString);
					break;

                case esMetaDrivers.PostgreSQL:
                    PostgreSQL.PostgreSQLDatabases.LoadAssembly();
                    conn = PostgreSQL.PostgreSQLDatabases.CreateConnection(connectionString);
					break;

				default:

                    if (Plugins.ContainsKey(driver))
                    {
                        conn = this.GetConnectionFromPlugin(driver, connectionString);
                    }
                    else
                    {
                        conn = new OleDbConnection(connectionString);
                    }
					break;
			}
			return conn;
        }

		public bool Connect(string driverIn, string connectionString)
		{
            string driver = driverIn.ToUpper();

            if (driver == "POSTGRESQL8") driver = "POSTGRESQL";
            if (driver == "MYSQL2")      driver = "MYSQL";
            if (driver == "VISTADB3X")   driver = "VISTADB";

            switch (driver)
            {
                case esMetaDrivers.None:
                    return true;

                case esMetaDrivers.SQL:
                case esMetaDrivers.Oracle:
				case esMetaDrivers.Access:
                case esMetaDrivers.MySql:
                case esMetaDrivers.PostgreSQL:

                    return this.Connect(esMetaDrivers.GetDbDriverFromName(driver), driver,  connectionString);

				default:

                    if (Plugins.ContainsKey(driver))
                    {
                        return this.Connect(dbDriver.Plugin, driver, connectionString);
                    }
                    else
                    {
                        return false;
                    }
			}
		}

        public bool Connect(dbDriver driver, string connectionString)
        {
            return Connect(driver, string.Empty, connectionString);
        }

		public bool Connect(dbDriver driver, string pluginName, string connectionString)
		{
			Reset();

			string dbName;
			int index;

			this._connectionString = connectionString.Replace("\"", "");
			this._driver = driver;

			switch(_driver)
			{
				case dbDriver.SQL:

					ConnectUsingOleDb(_driver, _connectionString);
                    this._driverString = esMetaDrivers.SQL;
					this.StripTrailingNulls = false;
					this.requiredDatabaseName = true;
                    ClassFactory = new Sql.ClassFactory();
					break;

				case dbDriver.Oracle:

					ConnectUsingOleDb(_driver, _connectionString);
                    this._driverString = esMetaDrivers.Oracle;
					this.StripTrailingNulls = false;
					this.requiredDatabaseName = true;
                    ClassFactory = new Oracle.ClassFactory();
					break;

				case dbDriver.Access:

					ConnectUsingOleDb(_driver, _connectionString);
                    this._driverString = esMetaDrivers.Access;
					this.StripTrailingNulls = false;
					this.requiredDatabaseName = false;
                    ClassFactory = new Access.ClassFactory();
					break;

                case dbDriver.MySql:

                    this.ConnectToMySql();
                    break;

				case dbDriver.PostgreSQL:

                    this.ConnectToPostgreSql();
					break;

                case dbDriver.Plugin:

                    IPlugin plugin;
                    using (IDbConnection connection = this.GetConnectionFromPlugin(pluginName, _connectionString, out plugin))
                    {
                        if (connection != null && connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }
                        dbName = connection.Database;
                    }
                    this._driverString = pluginName;
                    this.StripTrailingNulls = plugin.StripTrailingNulls;
                    this.requiredDatabaseName = plugin.RequiredDatabaseName;
                    ClassFactory = new Plugin.ClassFactory(plugin);
                    break;

				case dbDriver.None:

                    this._driverString = esMetaDrivers.None;
					break;
			}

			_isConnected = true;
			return true;
		}

		private void ConnectUsingOleDb(dbDriver driver, string connectionString)
		{
			try
			{
				OleDbConnection cn = new OleDbConnection(connectionString.Replace("\"", "")); 
				cn.Open();
				this._defaultDatabase = GetDefaultDatabase(cn, driver);
				cn.Close();
			}
			catch(OleDbException Ex)
			{
				throw Ex;
			}
		}

        private bool ConnectToMySql()
        {
            MySql.MySqlDatabases.LoadAssembly();
            IDbConnection conn = MySql.MySqlDatabases.CreateConnection(_connectionString);
            conn.Open();
            this._defaultDatabase = conn.Database;
            conn.Close();
            conn.Dispose();

            this._driverString = "MYSQL";
            this.StripTrailingNulls = true;
            this.requiredDatabaseName = true;
            ClassFactory = new MySql.ClassFactory();
            return true;
        }

        private bool ConnectToPostgreSql()
        {
            PostgreSQL.PostgreSQLDatabases.LoadAssembly();
            IDbConnection conn = PostgreSQL.PostgreSQLDatabases.CreateConnection(_connectionString);
            conn.Open();
            this._defaultDatabase = conn.Database;
            conn.Close();
            conn.Dispose();

            this._driverString = esMetaDrivers.PostgreSQL;
            this.StripTrailingNulls = false;
            this.requiredDatabaseName = false;
            ClassFactory = new PostgreSQL.ClassFactory();
            return true;
        }

		internal OleDbConnection TheConnection
		{
			get
			{
				if(this._theConnection.State != ConnectionState.Open)
				{
					this._theConnection.ConnectionString = this._connectionString;
					this._theConnection.Open();
				}

				return this._theConnection;
			}
		}

		private string GetDefaultDatabase(OleDbConnection cn, dbDriver driver)
		{
			string databaseName = string.Empty;

			switch(driver)
			{
				case dbDriver.Access:

					int i = cn.DataSource.LastIndexOf(@"\");

					if(i == -1) 
						databaseName = cn.DataSource;
					else
						databaseName = cn.DataSource.Substring(++i);

					break;

				default:

					databaseName = cn.Database;
					break;
			}

			return databaseName;
		}


		public bool IsConnected
		{
			get { return  _isConnected;	}
		}

		public dbDriver Driver	
        {
			get	{ return _driver; }
		}

		public string DriverString
		{
			get	{ return _driverString; }
		}

		public string ConnectionString
		{
			get	{ return _connectionString; }
		}

		internal Hashtable ParsedConnectionString
		{
			get
			{
				if(null == _parsedConnectionString)
				{
					string[] first = ConnectionString.Split(new char[] {';'});

					_parsedConnectionString = new Hashtable(first.GetUpperBound(0));

					string[] kv = null;

					for(int i = 0; i < first.GetUpperBound(0); i++)
					{
						kv = first[i].Split(new char[] {'='});

						if(1 == kv.GetUpperBound(0))
						{
							_parsedConnectionString.Add(kv[0].ToUpper(), kv[1]);
						}
						else
						{
							_parsedConnectionString.Add(kv[0].ToUpper(), "");
						}
					}
				}

				return _parsedConnectionString;
			}
		}

		#endregion

		#region Settings

		public bool ShowSystemData
		{
			get	{ return _showSystemData;   }
			set	{ _showSystemData = value ; }
		}

		public bool DomainOverride
		{
			get	{ return _domainOverride;   }
			set	{ _domainOverride = value ; }
		}

		#endregion

        #region Plugin Members

        private IDbConnection GetConnectionFromPlugin(string providerName, string pluginConnectionString)
        {
            IPlugin plugin;

            return GetConnectionFromPlugin(providerName, pluginConnectionString, out plugin);
        }

        private IDbConnection GetConnectionFromPlugin(string providerName, string pluginConnectionString, out IPlugin plugin)
        {
            PluginContext pluginContext = new PluginContext(providerName, pluginConnectionString);

            IDbConnection connection = null;
            if (!Plugins.ContainsKey(providerName))
            {
                throw new Exception("EntitySpaces.MetadataEngine Plugin \"" + providerName + "\" not registered.");
            }
            else
            {
                plugin = Plugins[providerName] as IPlugin;
                plugin.Initialize(pluginContext);

                connection = plugin.NewConnection;
            }

            return connection;
        }

        private static Hashtable plugins;

        public Hashtable Plugins
        {
            get
            {
                if (plugins == null)
                {
                    plugins = new Hashtable();

                    try
                    {
                        string path = this.settings.CompilerAssemblyPath;
                        if (!path.EndsWith(@"\"))
                        {
                            path += @"\";
                        }

                        FileInfo info = new FileInfo(path);
                        DirectoryInfo di = info.Directory;
                        FileInfo[] files = di.GetFiles("EntitySpaces.MetadataEngine.*.dll");

                        foreach (FileInfo f in files)
                        {
                            try
                            {
                                LoadPlugin(f.FullName, plugins);
                            }
                            catch (Exception ex)
                            {
                                string s = ex.Message;
                            }
                        }
                        
                    }
                    catch(Exception ex)
                    {
                        string s = ex.Message;
                    }
                }

                return plugins;
            }
        }

        static public void UnLoadPlugins()
        {
            if (plugins != null)
            {
                foreach (IPlugin plugin in plugins.Values)
                {
                    plugin.OnUnload();
                }

                plugins.Clear();
                plugins = null; // so it will be reloaded when accessed again
            }
        }
        
        
		static private void LoadPlugin(string filename, Hashtable plugins)
		{
            Assembly assembly = Assembly.LoadFile(filename);

            foreach (Type type in assembly.GetTypes())
            {
                Type[] interfaces = type.GetInterfaces();
                foreach (Type iface in interfaces)
                {
                    if (iface == typeof(IPlugin))
                    {
                        try
                        {
                            ConstructorInfo[] constructors = type.GetConstructors();
                            ConstructorInfo constructor = constructors[0];

                            IPlugin plugin = constructor.Invoke(BindingFlags.CreateInstance, null, new object[] { }, null) as IPlugin;
                          //  InternalDriver.Register(plugin.ProviderUniqueKey, new PluginDriver(plugin));
                            plugin.OnLoad();

                            plugins[plugin.ProviderUniqueKey] = plugin; // after register because if exception in register, donot remeber plugin
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Trace.WriteLine("Cannot load plugin " + filename);
                            while (ex != null)
                            {
                                System.Diagnostics.Trace.WriteLine(ex.Message);
                                System.Diagnostics.Trace.WriteLine(ex.StackTrace);
                                ex = ex.InnerException;
                            }
                        }
                    }
                }
            }
		}

        static Module assembly_ModuleResolve(object sender, ResolveEventArgs e)
        {
            // throw new Exception("The method or operation is not implemented.");
            return null;
        }

        #endregion
        
        #region XML User Data

		public string UserDataXPath
		{ 
			get
			{
				return @"//esUserData";
			} 
		}

		internal bool GetXmlNode(out XmlNode outNode, bool forceCreate)
		{
			outNode = null;
			bool success = false;
            XmlNode parent;
            XmlNode node;
            XmlAttribute attr;

            // See if we can find it first
            _xmlNode = UserData.SelectSingleNode("./esUserData/Drivers/Driver[@Name='" + this._driverString + "']");

			if(null == _xmlNode)
			{
                node = UserData.SelectSingleNode("./esUserData");
                if (node == null)
                {
                    node = UserData.CreateNode(XmlNodeType.Element, "esUserData", null);
                    UserData.AppendChild(node);

                    attr = _userData.CreateAttribute("Version");
                    attr.Value = esPlugIn.esVersion;

                    node.Attributes.Append(attr);

                    parent = node;
                }
                else parent = node;

                node = UserData.SelectSingleNode("./esUserData/Drivers");
                if (node == null)
                {
                    node = _userData.CreateNode(XmlNodeType.Element, "Drivers", null);
                    parent.AppendChild(node);
                    parent = node;
                }
                else parent = node;

                // By definition we have to create the driver because we checked first above ...
                node = _userData.CreateNode(XmlNodeType.Element, "Driver", null);
                parent.AppendChild(node);

                attr = _userData.CreateAttribute("Name");
                attr.Value = this._driverString;

                node.Attributes.Append(attr);

                _xmlNode = node;
			}

			if(null != _xmlNode)
			{
                outNode = _xmlNode;
				success = true;
			}

			return success;
		}

		public string UserMetaDataFileName
		{
			get	{ return settings.UserMetadataFile; }
		}

		public bool SaveUserMetaData()
		{
            if (null != UserData && string.Empty != UserMetaDataFileName)
            {
                FileInfo f = new FileInfo(UserMetaDataFileName);
                if (!f.Exists)
                {
                    if (!f.Directory.Exists) f.Directory.Create();
                }

                UserData.Save(UserMetaDataFileName);
                return true;
            }

			return false;
		}

        internal XmlDocument UserData
        {
            get
            {
                try
                {
                    // One Time Initializations
                    if (_userData == null)
                    {
                        esXmlUserDataMigration converter = new esXmlUserDataMigration(settings.UserMetadataFile, this.DriverString, "2012.1.0930.0");
                        converter.PerformMigration();

                        _userData = new XmlDocument();
                        _userData.Load(settings.UserMetadataFile);
                    }
                }
                catch
                {
                    _userData = new XmlDocument();
                }

                return _userData;
            }

            set
            {
                _userData = value;
            }
        }

		#endregion

		#region XML Language Mapping

		public string LanguageMappingFileName
		{
			get { return settings.LanguageMappingFile; }
		}

		public string[] GetLanguageMappings()
		{
			return GetLanguageMappings(_driverString);
		}

		public string[] GetLanguageMappings(string driverString)
		{
            try
            {
                // One Time Initialization 
                if (_languageDoc == null)
                {
                    _languageDoc = new XmlDocument();
                    _languageDoc.Load(settings.LanguageMappingFile);
                    LanguageNode = null;
                }
            }
            catch { }			

			string[] mappings = null;

			if ((null != _languageDoc) && (driverString != null))
			{
                driverString = driverString.ToUpper();
				string xPath = @"//Languages/Language[@From='" + driverString + "']";
				XmlNodeList nodes = _languageDoc.SelectNodes(xPath, null);

				if ((null != nodes) && (nodes.Count > 0))
				{
					int nodeCount = nodes.Count;
					mappings = new string[nodeCount];

					for(int i = 0; i < nodeCount; i++)
					{
						mappings[i] = nodes[i].Attributes["To"].Value;
					}
				}
			}

			return mappings;
		}

		public string Language
		{
			get
			{
				return _language;
			}

			set
			{
                // One Time Initialization 
                if (_languageDoc == null)
                {
                    _languageDoc = new XmlDocument();
                    _languageDoc.Load(settings.LanguageMappingFile);
                    LanguageNode = null;
                }

				if(null != _languageDoc)
				{
					_language = value;
					string xPath = @"//Languages/Language[@From='" + _driverString + "' and @To='" + _language + "']";
					LanguageNode = _languageDoc.SelectSingleNode(xPath, null);
				}
			}
		}

		private string _languageMappingFileName = string.Empty;
		private string _language = string.Empty;
		private XmlDocument _languageDoc;
		internal XmlNode LanguageNode = null;

		#endregion

        private XmlDocument _userData = null;

		internal bool IgnoreCase = true;
		internal bool requiredDatabaseName = false;
		internal bool requiresSchemaName = false;
		internal bool StripTrailingNulls = false;

		internal string TrailingNull = null;

		internal IClassFactory ClassFactory = null;

		private bool _showSystemData = false;

		private dbDriver _driver = dbDriver.None;
		private string _driverString = "NONE";
		private string _defaultDatabase = "";
		private Databases _databases = null;
		private ProviderTypes _providerTypes = null;
		private string _connectionString = "";
		private bool _isConnected = false;
		private Hashtable _parsedConnectionString = null;
        private bool _domainOverride = true;

		private XmlNode _xmlNode = null;

		private OleDbConnection _theConnection = new OleDbConnection();

        private esPlugIn _esPlugIn;
        private Hashtable _input = new Hashtable();

        private string _esMetadataPluginPath = "";
	}

	/// <summary>
	/// The current list of support dbDrivers. Typically VBScript and JScript use the string version as defined by esMetadataEngine.DriverString.
	/// </summary>
	public enum dbDriver
	{
		/// <summary>
		/// String form is "SQL" for DriverString property
		/// </summary>
		SQL,

		/// <summary>
		/// String form is "ORACLE" for DriverString property
		/// </summary>
		Oracle,

		/// <summary>
		/// String form is "ACCESS" for DriverString property
		/// </summary>
		Access,

		/// <summary>
		/// String form is "MYSQL" for DriverString property
		/// </summary>
		MySql,

		/// <summary>
		/// String form is "POSTGRESQL" for DriverString property
		/// </summary>
		PostgreSQL,

		/// <summary>
		/// String form is "VISTADB" for DriverString property
		/// </summary>
		VistaDB,

        /// <summary>
        /// String form is "VISTADB4" for DriverString property
        /// </summary>
        VistaDB4,

        /// <summary>
        /// Microsoft SQL Server CE
        /// </summary>
        SQLCE,

        /// <summary>
        /// Microsoft SQL Azure
        /// </summary>
        SQLAzure,

        /// <summary>
        /// The EffiProzDB .NET & ASP.NET Database 
        /// </summary>
        EffiProzDB,

        /// <summary>
        /// This is a placeholder for plugin providers
        /// </summary>
        Plugin,

        None
    }

    #region esMetaDrivers string Constants
    public static class esMetaDrivers
    {
        public const string Access = "ACCESS";
        public const string MySql = "MYSQL";
        public const string None = "NONE";
        public const string Oracle = "ORACLE";
        public const string PostgreSQL = "POSTGRESQL";
        public const string SQL = "SQL";
        public const string VistaDB = "VISTADB";
        public const string VistaDB4 = "VISTADB4";
        public const string SQLCE = "SQLCE";
        public const string SQLAZURE = "SQLAZURE";
        public const string EffiProzDB = "EFFIPROZDB";

        public static dbDriver GetDbDriverFromName(string name)
        {
            switch (name)
            {
                case esMetaDrivers.SQL:        return dbDriver.SQL;
                case esMetaDrivers.Oracle:     return dbDriver.Oracle;
                case esMetaDrivers.Access:     return dbDriver.Access;
                case esMetaDrivers.MySql:      return dbDriver.MySql;
                case esMetaDrivers.PostgreSQL: return dbDriver.PostgreSQL;
                case esMetaDrivers.VistaDB:    return dbDriver.VistaDB;
                case esMetaDrivers.VistaDB4:   return dbDriver.VistaDB4;
                case esMetaDrivers.SQLCE:      return dbDriver.SQLCE;
                case esMetaDrivers.SQLAZURE:   return dbDriver.SQLAzure;
                case esMetaDrivers.EffiProzDB: return dbDriver.EffiProzDB;
                case esMetaDrivers.None:       return dbDriver.None;

                default:  return dbDriver.Plugin;
            }
        }
    }
    #endregion

    public enum dbEntityType
    {
        Tables,
        Views
    }
}

