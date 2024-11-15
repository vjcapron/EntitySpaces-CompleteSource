
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 9/23/2012 6:16:11 PM
===============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Data;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

using EntitySpaces.Core;
using EntitySpaces.Interfaces;
using EntitySpaces.DynamicQuery;



namespace BusinessObjects
{
	/// <summary>
	/// Encapsulates the 'Products' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(Products))]	
	[XmlType("Products")]
	public partial class Products : esProducts
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Products();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 productID)
		{
			var obj = new Products();
			obj.ProductID = productID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 productID, esSqlAccessType sqlAccessType)
		{
			var obj = new Products();
			obj.ProductID = productID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("ProductsCollection")]
	public partial class ProductsCollection : esProductsCollection, IEnumerable<Products>
	{
		public Products FindByPrimaryKey(System.Int32 productID)
		{
			return this.SingleOrDefault(e => e.ProductID == productID);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(Products))]
		public class ProductsCollectionWCFPacket : esCollectionWCFPacket<ProductsCollection>
		{
			public static implicit operator ProductsCollection(ProductsCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ProductsCollectionWCFPacket(ProductsCollection collection)
			{
				return new ProductsCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class ProductsQuery : esProductsQuery
	{
		public ProductsQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ProductsQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ProductsQuery query)
		{
			return ProductsQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ProductsQuery(string query)
		{
			return (ProductsQuery)ProductsQuery.SerializeHelper.FromXml(query, typeof(ProductsQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esProducts : esEntity
	{
		public esProducts()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 productID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(productID);
			else
				return LoadByPrimaryKeyStoredProcedure(productID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 productID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(productID);
			else
				return LoadByPrimaryKeyStoredProcedure(productID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 productID)
		{
			ProductsQuery query = new ProductsQuery();
			query.Where(query.ProductID == productID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 productID)
		{
			esParameters parms = new esParameters();
			parms.Add("ProductID", productID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to Products.ProductID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? ProductID
		{
			get
			{
				return base.GetSystemInt32(ProductsMetadata.ColumnNames.ProductID);
			}
			
			set
			{
				if(base.SetSystemInt32(ProductsMetadata.ColumnNames.ProductID, value))
				{
					OnPropertyChanged(ProductsMetadata.PropertyNames.ProductID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Products.ProductName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ProductName
		{
			get
			{
				return base.GetSystemString(ProductsMetadata.ColumnNames.ProductName);
			}
			
			set
			{
				if(base.SetSystemString(ProductsMetadata.ColumnNames.ProductName, value))
				{
					OnPropertyChanged(ProductsMetadata.PropertyNames.ProductName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Products.SupplierID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? SupplierID
		{
			get
			{
				return base.GetSystemInt32(ProductsMetadata.ColumnNames.SupplierID);
			}
			
			set
			{
				if(base.SetSystemInt32(ProductsMetadata.ColumnNames.SupplierID, value))
				{
					OnPropertyChanged(ProductsMetadata.PropertyNames.SupplierID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Products.CategoryID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? CategoryID
		{
			get
			{
				return base.GetSystemInt32(ProductsMetadata.ColumnNames.CategoryID);
			}
			
			set
			{
				if(base.SetSystemInt32(ProductsMetadata.ColumnNames.CategoryID, value))
				{
					this._UpToCategoriesByCategoryID = null;
					this.OnPropertyChanged("UpToCategoriesByCategoryID");
					OnPropertyChanged(ProductsMetadata.PropertyNames.CategoryID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Products.QuantityPerUnit
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String QuantityPerUnit
		{
			get
			{
				return base.GetSystemString(ProductsMetadata.ColumnNames.QuantityPerUnit);
			}
			
			set
			{
				if(base.SetSystemString(ProductsMetadata.ColumnNames.QuantityPerUnit, value))
				{
					OnPropertyChanged(ProductsMetadata.PropertyNames.QuantityPerUnit);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Products.UnitPrice
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Decimal? UnitPrice
		{
			get
			{
				return base.GetSystemDecimal(ProductsMetadata.ColumnNames.UnitPrice);
			}
			
			set
			{
				if(base.SetSystemDecimal(ProductsMetadata.ColumnNames.UnitPrice, value))
				{
					OnPropertyChanged(ProductsMetadata.PropertyNames.UnitPrice);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Products.UnitsInStock
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int16? UnitsInStock
		{
			get
			{
				return base.GetSystemInt16(ProductsMetadata.ColumnNames.UnitsInStock);
			}
			
			set
			{
				if(base.SetSystemInt16(ProductsMetadata.ColumnNames.UnitsInStock, value))
				{
					OnPropertyChanged(ProductsMetadata.PropertyNames.UnitsInStock);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Products.UnitsOnOrder
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int16? UnitsOnOrder
		{
			get
			{
				return base.GetSystemInt16(ProductsMetadata.ColumnNames.UnitsOnOrder);
			}
			
			set
			{
				if(base.SetSystemInt16(ProductsMetadata.ColumnNames.UnitsOnOrder, value))
				{
					OnPropertyChanged(ProductsMetadata.PropertyNames.UnitsOnOrder);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Products.ReorderLevel
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int16? ReorderLevel
		{
			get
			{
				return base.GetSystemInt16(ProductsMetadata.ColumnNames.ReorderLevel);
			}
			
			set
			{
				if(base.SetSystemInt16(ProductsMetadata.ColumnNames.ReorderLevel, value))
				{
					OnPropertyChanged(ProductsMetadata.PropertyNames.ReorderLevel);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Products.Discontinued
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? Discontinued
		{
			get
			{
				return base.GetSystemBoolean(ProductsMetadata.ColumnNames.Discontinued);
			}
			
			set
			{
				if(base.SetSystemBoolean(ProductsMetadata.ColumnNames.Discontinued, value))
				{
					OnPropertyChanged(ProductsMetadata.PropertyNames.Discontinued);
				}
			}
		}		
		
		[CLSCompliant(false)]
		internal protected Categories _UpToCategoriesByCategoryID;
		#endregion	

		#region .str() Properties
		
		public override void SetProperties(IDictionary values)
		{
			foreach (string propertyName in values.Keys)
			{
				this.SetProperty(propertyName, values[propertyName]);
			}
		}
		
		public override void SetProperty(string name, object value)
		{
			esColumnMetadata col = this.Meta.Columns.FindByPropertyName(name);
			if (col != null)
			{
				if(value == null || value is System.String)
				{				
					// Use the strongly typed property
					switch (name)
					{							
						case "ProductID": this.str().ProductID = (string)value; break;							
						case "ProductName": this.str().ProductName = (string)value; break;							
						case "SupplierID": this.str().SupplierID = (string)value; break;							
						case "CategoryID": this.str().CategoryID = (string)value; break;							
						case "QuantityPerUnit": this.str().QuantityPerUnit = (string)value; break;							
						case "UnitPrice": this.str().UnitPrice = (string)value; break;							
						case "UnitsInStock": this.str().UnitsInStock = (string)value; break;							
						case "UnitsOnOrder": this.str().UnitsOnOrder = (string)value; break;							
						case "ReorderLevel": this.str().ReorderLevel = (string)value; break;							
						case "Discontinued": this.str().Discontinued = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "ProductID":
						
							if (value == null || value is System.Int32)
								this.ProductID = (System.Int32?)value;
								OnPropertyChanged(ProductsMetadata.PropertyNames.ProductID);
							break;
						
						case "SupplierID":
						
							if (value == null || value is System.Int32)
								this.SupplierID = (System.Int32?)value;
								OnPropertyChanged(ProductsMetadata.PropertyNames.SupplierID);
							break;
						
						case "CategoryID":
						
							if (value == null || value is System.Int32)
								this.CategoryID = (System.Int32?)value;
								OnPropertyChanged(ProductsMetadata.PropertyNames.CategoryID);
							break;
						
						case "UnitPrice":
						
							if (value == null || value is System.Decimal)
								this.UnitPrice = (System.Decimal?)value;
								OnPropertyChanged(ProductsMetadata.PropertyNames.UnitPrice);
							break;
						
						case "UnitsInStock":
						
							if (value == null || value is System.Int16)
								this.UnitsInStock = (System.Int16?)value;
								OnPropertyChanged(ProductsMetadata.PropertyNames.UnitsInStock);
							break;
						
						case "UnitsOnOrder":
						
							if (value == null || value is System.Int16)
								this.UnitsOnOrder = (System.Int16?)value;
								OnPropertyChanged(ProductsMetadata.PropertyNames.UnitsOnOrder);
							break;
						
						case "ReorderLevel":
						
							if (value == null || value is System.Int16)
								this.ReorderLevel = (System.Int16?)value;
								OnPropertyChanged(ProductsMetadata.PropertyNames.ReorderLevel);
							break;
						
						case "Discontinued":
						
							if (value == null || value is System.Boolean)
								this.Discontinued = (System.Boolean?)value;
								OnPropertyChanged(ProductsMetadata.PropertyNames.Discontinued);
							break;
					

						default:
							break;
					}
				}
			}
            else if (this.ContainsColumn(name))
            {
                this.SetColumn(name, value);
            }
			else
			{
				throw new Exception("SetProperty Error: '" + name + "' not found");
			}
		}		

		public esStrings str()
		{
			if (esstrings == null)
			{
				esstrings = new esStrings(this);
			}
			return esstrings;
		}

		sealed public class esStrings
		{
			public esStrings(esProducts entity)
			{
				this.entity = entity;
			}
			
	
			public System.String ProductID
			{
				get
				{
					System.Int32? data = entity.ProductID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ProductID = null;
					else entity.ProductID = Convert.ToInt32(value);
				}
			}
				
			public System.String ProductName
			{
				get
				{
					System.String data = entity.ProductName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ProductName = null;
					else entity.ProductName = Convert.ToString(value);
				}
			}
				
			public System.String SupplierID
			{
				get
				{
					System.Int32? data = entity.SupplierID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SupplierID = null;
					else entity.SupplierID = Convert.ToInt32(value);
				}
			}
				
			public System.String CategoryID
			{
				get
				{
					System.Int32? data = entity.CategoryID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CategoryID = null;
					else entity.CategoryID = Convert.ToInt32(value);
				}
			}
				
			public System.String QuantityPerUnit
			{
				get
				{
					System.String data = entity.QuantityPerUnit;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.QuantityPerUnit = null;
					else entity.QuantityPerUnit = Convert.ToString(value);
				}
			}
				
			public System.String UnitPrice
			{
				get
				{
					System.Decimal? data = entity.UnitPrice;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.UnitPrice = null;
					else entity.UnitPrice = Convert.ToDecimal(value);
				}
			}
				
			public System.String UnitsInStock
			{
				get
				{
					System.Int16? data = entity.UnitsInStock;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.UnitsInStock = null;
					else entity.UnitsInStock = Convert.ToInt16(value);
				}
			}
				
			public System.String UnitsOnOrder
			{
				get
				{
					System.Int16? data = entity.UnitsOnOrder;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.UnitsOnOrder = null;
					else entity.UnitsOnOrder = Convert.ToInt16(value);
				}
			}
				
			public System.String ReorderLevel
			{
				get
				{
					System.Int16? data = entity.ReorderLevel;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ReorderLevel = null;
					else entity.ReorderLevel = Convert.ToInt16(value);
				}
			}
				
			public System.String Discontinued
			{
				get
				{
					System.Boolean? data = entity.Discontinued;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Discontinued = null;
					else entity.Discontinued = Convert.ToBoolean(value);
				}
			}
			

			private esProducts entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ProductsMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ProductsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProductsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ProductsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ProductsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ProductsQuery query;		
	}



	[Serializable]
	abstract public partial class esProductsCollection : esEntityCollection<Products>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ProductsMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ProductsCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ProductsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProductsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ProductsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ProductsQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ProductsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ProductsQuery)query);
		}

		#endregion
		
		private ProductsQuery query;
	}



	[Serializable]
	abstract public partial class esProductsQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ProductsMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "ProductID": return this.ProductID;
				case "ProductName": return this.ProductName;
				case "SupplierID": return this.SupplierID;
				case "CategoryID": return this.CategoryID;
				case "QuantityPerUnit": return this.QuantityPerUnit;
				case "UnitPrice": return this.UnitPrice;
				case "UnitsInStock": return this.UnitsInStock;
				case "UnitsOnOrder": return this.UnitsOnOrder;
				case "ReorderLevel": return this.ReorderLevel;
				case "Discontinued": return this.Discontinued;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem ProductID
		{
			get { return new esQueryItem(this, ProductsMetadata.ColumnNames.ProductID, esSystemType.Int32); }
		} 
		
		public esQueryItem ProductName
		{
			get { return new esQueryItem(this, ProductsMetadata.ColumnNames.ProductName, esSystemType.String); }
		} 
		
		public esQueryItem SupplierID
		{
			get { return new esQueryItem(this, ProductsMetadata.ColumnNames.SupplierID, esSystemType.Int32); }
		} 
		
		public esQueryItem CategoryID
		{
			get { return new esQueryItem(this, ProductsMetadata.ColumnNames.CategoryID, esSystemType.Int32); }
		} 
		
		public esQueryItem QuantityPerUnit
		{
			get { return new esQueryItem(this, ProductsMetadata.ColumnNames.QuantityPerUnit, esSystemType.String); }
		} 
		
		public esQueryItem UnitPrice
		{
			get { return new esQueryItem(this, ProductsMetadata.ColumnNames.UnitPrice, esSystemType.Decimal); }
		} 
		
		public esQueryItem UnitsInStock
		{
			get { return new esQueryItem(this, ProductsMetadata.ColumnNames.UnitsInStock, esSystemType.Int16); }
		} 
		
		public esQueryItem UnitsOnOrder
		{
			get { return new esQueryItem(this, ProductsMetadata.ColumnNames.UnitsOnOrder, esSystemType.Int16); }
		} 
		
		public esQueryItem ReorderLevel
		{
			get { return new esQueryItem(this, ProductsMetadata.ColumnNames.ReorderLevel, esSystemType.Int16); }
		} 
		
		public esQueryItem Discontinued
		{
			get { return new esQueryItem(this, ProductsMetadata.ColumnNames.Discontinued, esSystemType.Boolean); }
		} 
		
		#endregion
		
	}


	
	public partial class Products : esProducts
	{

				
		#region UpToCategoriesByCategoryID - Many To One
		/// <summary>
		/// Many to One
		/// Foreign Key Name - FK_Products_Categories
		/// </summary>

		[XmlIgnore]
					
		public Categories UpToCategoriesByCategoryID
		{
			get
			{
				if (this.es.IsLazyLoadDisabled) return null;
				
				if(this._UpToCategoriesByCategoryID == null && CategoryID != null)
				{
					this._UpToCategoriesByCategoryID = new Categories();
					this._UpToCategoriesByCategoryID.es.Connection.Name = this.es.Connection.Name;
					this.SetPreSave("UpToCategoriesByCategoryID", this._UpToCategoriesByCategoryID);
					this._UpToCategoriesByCategoryID.Query.Where(this._UpToCategoriesByCategoryID.Query.CategoryID == this.CategoryID);
					this._UpToCategoriesByCategoryID.Query.Load();
				}	
				return this._UpToCategoriesByCategoryID;
			}
			
			set
			{
				this.RemovePreSave("UpToCategoriesByCategoryID");
				
				bool changed = this._UpToCategoriesByCategoryID != value;

				if(value == null)
				{
					this.CategoryID = null;
					this._UpToCategoriesByCategoryID = null;
				}
				else
				{
					this.CategoryID = value.CategoryID;
					this._UpToCategoriesByCategoryID = value;
					this.SetPreSave("UpToCategoriesByCategoryID", this._UpToCategoriesByCategoryID);
				}
				
				if( changed )
				{
					this.OnPropertyChanged("UpToCategoriesByCategoryID");
				}
			}
		}
		#endregion
		

		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PreSave.
		/// </summary>
		protected override void ApplyPreSaveKeys()
		{
			if(!this.es.IsDeleted && this._UpToCategoriesByCategoryID != null)
			{
				this.CategoryID = this._UpToCategoriesByCategoryID.CategoryID;
			}
		}
		
	}
	



	[Serializable]
	public partial class ProductsMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ProductsMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ProductsMetadata.ColumnNames.ProductID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProductsMetadata.PropertyNames.ProductID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductsMetadata.ColumnNames.ProductName, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ProductsMetadata.PropertyNames.ProductName;
			c.CharacterMaxLength = 40;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductsMetadata.ColumnNames.SupplierID, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProductsMetadata.PropertyNames.SupplierID;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductsMetadata.ColumnNames.CategoryID, 3, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProductsMetadata.PropertyNames.CategoryID;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductsMetadata.ColumnNames.QuantityPerUnit, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = ProductsMetadata.PropertyNames.QuantityPerUnit;
			c.CharacterMaxLength = 20;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductsMetadata.ColumnNames.UnitPrice, 5, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = ProductsMetadata.PropertyNames.UnitPrice;
			c.NumericPrecision = 19;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductsMetadata.ColumnNames.UnitsInStock, 6, typeof(System.Int16), esSystemType.Int16);
			c.PropertyName = ProductsMetadata.PropertyNames.UnitsInStock;
			c.NumericPrecision = 5;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductsMetadata.ColumnNames.UnitsOnOrder, 7, typeof(System.Int16), esSystemType.Int16);
			c.PropertyName = ProductsMetadata.PropertyNames.UnitsOnOrder;
			c.NumericPrecision = 5;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductsMetadata.ColumnNames.ReorderLevel, 8, typeof(System.Int16), esSystemType.Int16);
			c.PropertyName = ProductsMetadata.PropertyNames.ReorderLevel;
			c.NumericPrecision = 5;
			c.HasDefault = true;
			c.Default = @"(0)";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ProductsMetadata.ColumnNames.Discontinued, 9, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ProductsMetadata.PropertyNames.Discontinued;
			c.HasDefault = true;
			c.Default = @"(0)";
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ProductsMetadata Meta()
		{
			return meta;
		}	
		
		public Guid DataID
		{
			get { return base.m_dataID; }
		}	
		
		public bool MultiProviderMode
		{
			get { return false; }
		}		

		public esColumnMetadataCollection Columns
		{
			get	{ return base.m_columns; }
		}
		
		#region ColumnNames
		public class ColumnNames
		{ 
			 public const string ProductID = "ProductID";
			 public const string ProductName = "ProductName";
			 public const string SupplierID = "SupplierID";
			 public const string CategoryID = "CategoryID";
			 public const string QuantityPerUnit = "QuantityPerUnit";
			 public const string UnitPrice = "UnitPrice";
			 public const string UnitsInStock = "UnitsInStock";
			 public const string UnitsOnOrder = "UnitsOnOrder";
			 public const string ReorderLevel = "ReorderLevel";
			 public const string Discontinued = "Discontinued";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string ProductID = "ProductID";
			 public const string ProductName = "ProductName";
			 public const string SupplierID = "SupplierID";
			 public const string CategoryID = "CategoryID";
			 public const string QuantityPerUnit = "QuantityPerUnit";
			 public const string UnitPrice = "UnitPrice";
			 public const string UnitsInStock = "UnitsInStock";
			 public const string UnitsOnOrder = "UnitsOnOrder";
			 public const string ReorderLevel = "ReorderLevel";
			 public const string Discontinued = "Discontinued";
		}
		#endregion	

		public esProviderSpecificMetadata GetProviderMetadata(string mapName)
		{
			MapToMeta mapMethod = mapDelegates[mapName];

			if (mapMethod != null)
				return mapMethod(mapName);
			else
				return null;
		}
		
		#region MAP esDefault
		
		static private int RegisterDelegateesDefault()
		{
			// This is only executed once per the life of the application
			lock (typeof(ProductsMetadata))
			{
				if(ProductsMetadata.mapDelegates == null)
				{
					ProductsMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ProductsMetadata.meta == null)
				{
					ProductsMetadata.meta = new ProductsMetadata();
				}
				
				MapToMeta mapMethod = new MapToMeta(meta.esDefault);
				mapDelegates.Add("esDefault", mapMethod);
				mapMethod("esDefault");
			}
			return 0;
		}			

		private esProviderSpecificMetadata esDefault(string mapName)
		{
			if(!m_providerMetadataMaps.ContainsKey(mapName))
			{
				esProviderSpecificMetadata meta = new esProviderSpecificMetadata();			


				meta.AddTypeMap("ProductID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("ProductName", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("SupplierID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("CategoryID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("QuantityPerUnit", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("UnitPrice", new esTypeMap("money", "System.Decimal"));
				meta.AddTypeMap("UnitsInStock", new esTypeMap("smallint", "System.Int16"));
				meta.AddTypeMap("UnitsOnOrder", new esTypeMap("smallint", "System.Int16"));
				meta.AddTypeMap("ReorderLevel", new esTypeMap("smallint", "System.Int16"));
				meta.AddTypeMap("Discontinued", new esTypeMap("bit", "System.Boolean"));			
				
				
				
				meta.Source = "Products";
				meta.Destination = "Products";
				
				meta.spInsert = "proc_ProductsInsert";				
				meta.spUpdate = "proc_ProductsUpdate";		
				meta.spDelete = "proc_ProductsDelete";
				meta.spLoadAll = "proc_ProductsLoadAll";
				meta.spLoadByPrimaryKey = "proc_ProductsLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ProductsMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
