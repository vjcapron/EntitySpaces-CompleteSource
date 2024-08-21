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

using System;

namespace EntitySpaces.MetadataEngine
{
	/// <summary>
	/// IResultColumn represents a column in the result set returned by a Procedure.
	/// </summary>
	/// <remarks>
	///	IResultColumn Collections:
	/// <list type="table">
	///		<item><term>Properties</term><description>A collection that can hold key/value pairs of your choosing</description></item>
	///	</list>
	/// </remarks>
	/// <example>
	/// VBScript
	/// <code>
	/// Dim objResultColumn
	/// For Each objResultColumn in objProcedure.ResultColumns
	///     output.writeLn objResultColumn.Name
	///	    output.writeLn objResultColumn.Alias
	/// Next
	/// </code>
	/// JScript
	/// <code>
	/// var objResultColumn;
	/// for (var j = 0; j &lt; objProcedure.ResultColumns; j++) 
	/// {
	///	    objResultColumn = objProcedure.ResultColumns.Item(j);
	///	    
	///	    output.writeln(objResultColumn.Name);
	///	    output.writeln(objResultColumn.Alias);
	/// }
	/// </code>
	/// </example>
	public interface IResultColumn
	{
		// Collections
		/// <summary>
		/// The Properties for this view. These are user defined and are typically stored in 'UserMetaData.xml' unless changed in the Default Settings dialog.
		/// Properties consist of key/value pairs.  You can populate this collection during your script or via the Dockable window.
		/// To save any data added to this collection call esMetadataEngine.SaveUserMetaData(). See <see cref="IProperty"/>
		/// </summary>
		IPropertyCollection Properties { get; }

		// User Meta Data
		string UserDataXPath { get; }

		// Properties
		/// <summary>
		/// You can override the physical name of the result column. If you do not provide an Alias the value of 'ResultColumn.Name' is returned.
		/// If your result column in your procedure  is 'Q99AAB' you might want to give it an Alias of 'Employees' so that your business object names will make sense.
		/// You can provide an Alias the User Meta Data window. You can also set this during a script and then call esMetadataEngine.SaveUserMetaData().
		/// See <see cref="Name"/>
		/// </summary>
		string Alias { get; set; }
	
		/// <summary>
		/// This is the physical table name as stored in your DBMS system. See <see cref="Alias"/>
		/// </summary>
		string Name { get; }

		/// <summary>
		/// N/A
		/// </summary>
		System.Int32 DataType { get; }

		/// <summary>
		/// The native data type as stored in your DBMS system, for instance a SQL 'nvarchar', or Access 'Memo'. See <see cref="DataTypeNameComplete"/>
		///	</summary>
		string DataTypeName { get; }

		/// <summary>
		/// This is the full data type name, whereas the DataType property might be 'nvarchar' the DataTypeName property would be 'nvarchar(200)', this varies from DBMS to DBMS.
		/// See <see cref="DataTypeName"/>
		/// </summary>
		string DataTypeNameComplete { get; }

		/// <summary>
		/// The Language Mappings window is where these are entered and they are stored in 'Languages.xml'. 
		/// If your DMBS system is Microsoft SQL and your language is C# then nvarchar will be mapped to a C# 'string'. 
		/// Anytime that you need to expose this columns value to your programming language use this value.
		/// See <see cref="DbTargetType"/>
		/// </summary>
		string LanguageType { get; }

		/// <summary>
		/// The ordinal of the result column. ResultColumns are numbered starting from one.
		/// </summary>
        System.Int32 Ordinal { get; }

        /// <summary>
        /// Fetch any database specific meta data through this generic interface by key. The keys will have to be defined by the specific database provider
        /// </summary>
        /// <param name="key">A key identifying the type of meta data desired.</param>
        /// <returns>A meta-data object or collection.</returns>
        object DatabaseSpecificMetaData(string key);
	}
}

