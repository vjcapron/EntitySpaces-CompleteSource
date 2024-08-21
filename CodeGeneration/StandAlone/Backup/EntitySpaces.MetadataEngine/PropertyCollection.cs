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
using System.Xml;
using System.Collections;
using System.Data;
using System.Data.OleDb;

namespace EntitySpaces.MetadataEngine
{
	/// <summary>
	/// Summary description for Collection.
	/// </summary>
	/// 
	public class PropertyCollection : Collection, IPropertyCollection, IEnumerable, IEnumerator, ICollection
	{
		public PropertyCollection()
		{

		}

		virtual internal void LoadAll()
		{
			string xPath;

			//-----------------------------------------
			// Local User Meta Data
			//-----------------------------------------
			if(null == _xmlNode)
			{
				// Get the parent node
				XmlNode parentNode = null;
				if(this._parent.GetXmlNode(out parentNode, false))
				{
					// See if our user data already exists
					xPath = @"./Properties";
					if(GetUserData(xPath, parentNode, out _xmlNode))
					{
						foreach(XmlNode propNode in _xmlNode.ChildNodes)
						{
							XmlAttributeCollection attrs = propNode.Attributes;
							this.QuickCreateProperty(attrs["k"].Value, attrs["v"].Value, false);							
						}
					}
				}
			}
		}

		virtual internal void LoadAllGlobal(XmlNode node)
		{
			//-----------------------------------------
			// Global User Meta Data
			//-----------------------------------------
			if(node != null)
			{
				string xPath = @"./Properties";
				if(!GetUserData(xPath, node, out _xmlNode))
				{
					this.CreateUserMetaData(node);
					GetUserData(xPath, node, out _xmlNode);
				}

				foreach(XmlNode propNode in _xmlNode.ChildNodes)
				{
					XmlAttributeCollection attrs = propNode.Attributes;
					if(attrs.Count >= 2)
					{
						this.QuickCreateProperty(attrs["k"].Value, attrs["v"].Value, true);		
					}
				}
			}
		}

		#region XML User Data

		override public string UserDataXPath
		{ 
			get
			{
				return _parent.UserDataXPath + @"/Properties";
			} 
		}

		override internal bool GetXmlNode(out XmlNode node, bool forceCreate)
		{
			node = null;
			bool success = false;

			if(null == _xmlNode)
			{
				// Get the parent node
				XmlNode parentNode = null;
				if(this._parent.GetXmlNode(out parentNode, forceCreate))
				{
					// See if our user data already exists
					string xPath = @"./Properties";
					if(!GetUserData(xPath, parentNode, out _xmlNode)  && forceCreate)
					{
						// Create it, and try again
						this.CreateUserMetaData(parentNode);
						GetUserData(xPath, parentNode, out _xmlNode);
					}
				}
			}

			if(null != _xmlNode)
			{
				node = _xmlNode;
				success = true;
			}

			return success;
		}

		override public void CreateUserMetaData(XmlNode parentNode)
		{
			XmlNode myNode = parentNode.OwnerDocument.CreateNode(XmlNodeType.Element, "Properties", null);
			parentNode.AppendChild(myNode);
		}

		#endregion

		public IProperty this[string key]
		{
			get
			{
				return this._collection[key] as IProperty;
			}
		}

		private void QuickCreateProperty(string key, string value, bool isGlobal)
		{
			Property prop = new Property();
			prop.Parent = this;
			prop.QuickCreate(key, value, isGlobal);
			this._collection.Add(key, prop);
		}

		public IProperty AddKeyValue(string key, string value)
		{
			Property prop = null;

			XmlNode node = null;
			if(this.GetXmlNode(out node, true))
			{
				if(this._collection.ContainsKey(key))
				{
					// Modify
					prop = this._collection[key] as Property;
					prop.Value = value;
				}
				else
				{
					// Add
					prop = new Property();
					prop.Parent = this;

					prop.SetKey(key);
					prop.Value = value as string;

					this._collection.Add(key, prop);
				}
			}

			return prop as IProperty;
		}

		public void RemoveKey(string key)
		{
			Property prop = null;

			XmlNode node = null;
			if(this.GetXmlNode(out node, true))
			{
				if(this._collection.ContainsKey(key))
				{
					prop = this[key] as Property;

					XmlNode propNode = node.SelectSingleNode( @"./Property[@k='" + prop.Key + "']");

					if(null != propNode)
					{
						node.RemoveChild(propNode);
					}

					this._collection.Remove(key);
				}
			}
		}

		new public void Clear()
		{
			XmlNode node = null;
			if(this.GetXmlNode(out node, true))
			{
				node.RemoveAll();
			}

			this._collection.Clear();
		}

		public new int Count
		{
			get
			{
				return _collection.Count;
			}
		}

		public bool ContainsKey(string key)
		{
			if(this._collection.ContainsKey(key)) 
				return true;
			else
				return false;
		}

		#region IEnumerable Members

		public IEnumerator GetEnumerator()
		{
			Reset();
			return (this as IEnumerator);
		}

		#endregion

		#region IEnumerator Members

		public void Reset()
		{
			_enumerator = this._collection.GetEnumerator();
		}

		public object Current
		{
			get
			{
				DictionaryEntry entry =  (DictionaryEntry)_enumerator.Current;
				return this._collection[entry.Key]; 
			}
		}

		public bool MoveNext()
		{
			return _enumerator.MoveNext();
		}

		#endregion

		#region ICollection Members

		public new  bool IsSynchronized
		{
			get
			{
				// TODO:  Add Databases.IsSynchronized getter implementation
				return false;
			}
		}

		public new void CopyTo(Array array, int index)
		{
			// TODO:  Add Databases.CopyTo implementation
		}

		public new object SyncRoot
		{
			get
			{
				// TODO:  Add Databases.SyncRoot getter implementation
				return null;
			}
		}

		#endregion

		internal MetaObject Parent
		{
			set
			{
				_parent = value;
			}
		}

		private IEnumerator _enumerator = null;
		private SortedList	_collection = new SortedList();
		private MetaObject	_parent = null;
	}
}
