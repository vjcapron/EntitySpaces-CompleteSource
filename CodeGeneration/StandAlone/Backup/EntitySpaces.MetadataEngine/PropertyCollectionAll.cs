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
	public class PropertyCollectionAll : Collection, IPropertyCollection, IEnumerable, IEnumerator, ICollection
	{

		public PropertyCollectionAll()
		{

		}

		internal void Load(IPropertyCollection local, IPropertyCollection global)
		{
			this._local  = local;
			this._global = global;
		}

		#region IPropertyCollection

		public IProperty this[string key] 
		{ 
			get
			{
				if(this._local.ContainsKey(key))
				{
					return this._local[key];
				}
				else if(this._global.ContainsKey(key))
				{
					return this._global[key];
				}

				return null;
			}
		}

		/// <summary>
		/// This method will either add or update a key value pair.  If the key already exists in the collection the value will be updated.
		/// If this key doesn't exist the key/value pair will be added.  If only want to update, and not add new items, use <see cref="ContainsKey"/> to determine if the key already exists.
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public IProperty AddKeyValue(string key, string value)
		{
			throw new NotImplementedException("Cannot call AddKeyValue on this collection");
		}

		/// <summary>
		/// Removes a key/value pair from the collection, no error is thrown if the key doesn't exist.
		/// </summary>
		/// <param name="key">The key of the desired key/value pair</param>
		public void RemoveKey(string key)
		{
			throw new NotImplementedException("Cannot call AddKeyValue on this collection");
		}

		/// <summary>
		/// Use ContainsKey to determine if a key exists in the collection.
		/// </summary>
		/// <param name="key">The key of the desired key/value pair</param>
		/// <returns>True if the key exists, False if not</returns>
		public bool ContainsKey(string key)
		{
			if(this._local.ContainsKey(key))
			{
				return true;
			}
			else if(this._global.ContainsKey(key))
			{
				return true;
			}

			return false;
		}

		/// <summary>
		/// Removes all key/value pairs from the collection.
		/// </summary>
		new public void Clear()
		{
			throw new NotImplementedException("Cannot call AddKeyValue on this collection");
		}
		#endregion

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
			useLocalEnum = true;
			wereDone = false;
			_localEnumerator  = this._local.GetEnumerator();
			_globalEnumerator = this._global.GetEnumerator();
		}

		public object Current
		{
			get
			{
				IProperty prop = null;

				if(useLocalEnum)
				{
					prop = (IProperty)_localEnumerator.Current;
				}
				else
				{
					prop = (IProperty)_globalEnumerator.Current;
				}

				return prop;
			}
		}

		public bool MoveNext()
		{
			if(this.useLocalEnum)
			{
				if(_localEnumerator.MoveNext()) return true;
			}

			if(!wereDone)
			{
				this.useLocalEnum = false;

				while(true)
				{
					if(_globalEnumerator.MoveNext())
					{
						IProperty prop = (IProperty)_globalEnumerator.Current;

						if(!this._local.ContainsKey(prop.Key))
						{
							return true;
						}
					}
					else
					{
						break;
					}
				}
				
				wereDone = true;
			}	
			
			return false;
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

		private IPropertyCollection _local;
		private IPropertyCollection _global;

		bool useLocalEnum = true;
		bool wereDone = false;
		private IEnumerator _localEnumerator = null;
		private IEnumerator _globalEnumerator = null;
	}
}
