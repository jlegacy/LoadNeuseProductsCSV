﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoadNeuseCSV
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="nssnc")]
	public partial class sheetdriverDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public sheetdriverDataContext() : 
				base(global::LoadNeuseCSV.Properties.Settings.Default.nssncConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public sheetdriverDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public sheetdriverDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public sheetdriverDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public sheetdriverDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<SheetDRV> SheetDRVs
		{
			get
			{
				return this.GetTable<SheetDRV>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SheetDRV")]
	public partial class SheetDRV
	{
		
		private System.Nullable<double> _id;
		
		private System.Nullable<double> _parent;
		
		private System.Nullable<double> _level;
		
		private string _type;
		
		private string _code;
		
		private string _description;
		
		private string _sort;
		
		public SheetDRV()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Float")]
		public System.Nullable<double> id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_parent", DbType="Float")]
		public System.Nullable<double> parent
		{
			get
			{
				return this._parent;
			}
			set
			{
				if ((this._parent != value))
				{
					this._parent = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[level]", Storage="_level", DbType="Float")]
		public System.Nullable<double> level
		{
			get
			{
				return this._level;
			}
			set
			{
				if ((this._level != value))
				{
					this._level = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type", DbType="NVarChar(255)")]
		public string type
		{
			get
			{
				return this._type;
			}
			set
			{
				if ((this._type != value))
				{
					this._type = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_code", DbType="NVarChar(255)")]
		public string code
		{
			get
			{
				return this._code;
			}
			set
			{
				if ((this._code != value))
				{
					this._code = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(255)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this._description = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sort", DbType="NVarChar(255)")]
		public string sort
		{
			get
			{
				return this._sort;
			}
			set
			{
				if ((this._sort != value))
				{
					this._sort = value;
				}
			}
		}
	}
}
#pragma warning restore 1591