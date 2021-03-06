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
	public partial class CSVSheetTableDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public CSVSheetTableDataContext() : 
				base(global::LoadNeuseCSV.Properties.Settings.Default.nssncConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CSVSheetTableDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CSVSheetTableDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CSVSheetTableDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CSVSheetTableDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Sheet1_> Sheet1_s
		{
			get
			{
				return this.GetTable<Sheet1_>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sheet1$")]
	public partial class Sheet1_
	{
		
		private string _brandName;
		
		private string _modelName;
		
		private string _modelYear;
		
		private System.Nullable<double> _modelSKU;
		
		private string _modelDescription;
		
		private string _modelImage;
		
		private string _imageCaption;
		
		private string _gender;
		
		private System.Nullable<double> _categoryID;
		
		private string _sku;
		
		private string _mpn;
		
		private System.Nullable<double> _gtin1;
		
		private string _gtin2;
		
		private System.Nullable<double> _msrp;
		
		private System.Nullable<double> _dealerCost;
		
		private System.Nullable<double> _specialCost;
		
		private System.Nullable<double> _lowMsrp;
		
		private string _length;
		
		private string _width;
		
		private string _height;
		
		private string _weight;
		
		private string _image;
		
		private string _unit;
		
		private string _hazmatCode;
		
		private System.Nullable<double> _taxable;
		
		private System.Nullable<double> _shippable;
		
		private System.Nullable<double> _shipGround;
		
		private System.Nullable<double> _shipAir;
		
		private System.Nullable<double> _ormd;
		
		private System.Nullable<double> _FFLrequired;
		
		private System.Nullable<double> _NFArequired;
		
		private string _variHash;
		
		private string _name;
		
		private string _id;
		
		private string _text;
		
		public Sheet1_()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_brandName", DbType="NVarChar(255)")]
		public string brandName
		{
			get
			{
				return this._brandName;
			}
			set
			{
				if ((this._brandName != value))
				{
					this._brandName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_modelName", DbType="NVarChar(255)")]
		public string modelName
		{
			get
			{
				return this._modelName;
			}
			set
			{
				if ((this._modelName != value))
				{
					this._modelName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_modelYear", DbType="NVarChar(255)")]
		public string modelYear
		{
			get
			{
				return this._modelYear;
			}
			set
			{
				if ((this._modelYear != value))
				{
					this._modelYear = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_modelSKU", DbType="Float")]
		public System.Nullable<double> modelSKU
		{
			get
			{
				return this._modelSKU;
			}
			set
			{
				if ((this._modelSKU != value))
				{
					this._modelSKU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_modelDescription", DbType="NVarChar(MAX)")]
		public string modelDescription
		{
			get
			{
				return this._modelDescription;
			}
			set
			{
				if ((this._modelDescription != value))
				{
					this._modelDescription = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_modelImage", DbType="NVarChar(255)")]
		public string modelImage
		{
			get
			{
				return this._modelImage;
			}
			set
			{
				if ((this._modelImage != value))
				{
					this._modelImage = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imageCaption", DbType="NVarChar(255)")]
		public string imageCaption
		{
			get
			{
				return this._imageCaption;
			}
			set
			{
				if ((this._imageCaption != value))
				{
					this._imageCaption = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gender", DbType="NVarChar(255)")]
		public string gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if ((this._gender != value))
				{
					this._gender = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_categoryID", DbType="Float")]
		public System.Nullable<double> categoryID
		{
			get
			{
				return this._categoryID;
			}
			set
			{
				if ((this._categoryID != value))
				{
					this._categoryID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sku", DbType="NVarChar(255)")]
		public string sku
		{
			get
			{
				return this._sku;
			}
			set
			{
				if ((this._sku != value))
				{
					this._sku = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mpn", DbType="NVarChar(255)")]
		public string mpn
		{
			get
			{
				return this._mpn;
			}
			set
			{
				if ((this._mpn != value))
				{
					this._mpn = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gtin1", DbType="Float")]
		public System.Nullable<double> gtin1
		{
			get
			{
				return this._gtin1;
			}
			set
			{
				if ((this._gtin1 != value))
				{
					this._gtin1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gtin2", DbType="NVarChar(255)")]
		public string gtin2
		{
			get
			{
				return this._gtin2;
			}
			set
			{
				if ((this._gtin2 != value))
				{
					this._gtin2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_msrp", DbType="Float")]
		public System.Nullable<double> msrp
		{
			get
			{
				return this._msrp;
			}
			set
			{
				if ((this._msrp != value))
				{
					this._msrp = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dealerCost", DbType="Float")]
		public System.Nullable<double> dealerCost
		{
			get
			{
				return this._dealerCost;
			}
			set
			{
				if ((this._dealerCost != value))
				{
					this._dealerCost = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_specialCost", DbType="Float")]
		public System.Nullable<double> specialCost
		{
			get
			{
				return this._specialCost;
			}
			set
			{
				if ((this._specialCost != value))
				{
					this._specialCost = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lowMsrp", DbType="Float")]
		public System.Nullable<double> lowMsrp
		{
			get
			{
				return this._lowMsrp;
			}
			set
			{
				if ((this._lowMsrp != value))
				{
					this._lowMsrp = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_length", DbType="NVarChar(255)")]
		public string length
		{
			get
			{
				return this._length;
			}
			set
			{
				if ((this._length != value))
				{
					this._length = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_width", DbType="NVarChar(255)")]
		public string width
		{
			get
			{
				return this._width;
			}
			set
			{
				if ((this._width != value))
				{
					this._width = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_height", DbType="NVarChar(255)")]
		public string height
		{
			get
			{
				return this._height;
			}
			set
			{
				if ((this._height != value))
				{
					this._height = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_weight", DbType="NVarChar(255)")]
		public string weight
		{
			get
			{
				return this._weight;
			}
			set
			{
				if ((this._weight != value))
				{
					this._weight = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_image", DbType="NVarChar(255)")]
		public string image
		{
			get
			{
				return this._image;
			}
			set
			{
				if ((this._image != value))
				{
					this._image = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_unit", DbType="NVarChar(255)")]
		public string unit
		{
			get
			{
				return this._unit;
			}
			set
			{
				if ((this._unit != value))
				{
					this._unit = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hazmatCode", DbType="NVarChar(255)")]
		public string hazmatCode
		{
			get
			{
				return this._hazmatCode;
			}
			set
			{
				if ((this._hazmatCode != value))
				{
					this._hazmatCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_taxable", DbType="Float")]
		public System.Nullable<double> taxable
		{
			get
			{
				return this._taxable;
			}
			set
			{
				if ((this._taxable != value))
				{
					this._taxable = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_shippable", DbType="Float")]
		public System.Nullable<double> shippable
		{
			get
			{
				return this._shippable;
			}
			set
			{
				if ((this._shippable != value))
				{
					this._shippable = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_shipGround", DbType="Float")]
		public System.Nullable<double> shipGround
		{
			get
			{
				return this._shipGround;
			}
			set
			{
				if ((this._shipGround != value))
				{
					this._shipGround = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_shipAir", DbType="Float")]
		public System.Nullable<double> shipAir
		{
			get
			{
				return this._shipAir;
			}
			set
			{
				if ((this._shipAir != value))
				{
					this._shipAir = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ormd", DbType="Float")]
		public System.Nullable<double> ormd
		{
			get
			{
				return this._ormd;
			}
			set
			{
				if ((this._ormd != value))
				{
					this._ormd = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FFLrequired", DbType="Float")]
		public System.Nullable<double> FFLrequired
		{
			get
			{
				return this._FFLrequired;
			}
			set
			{
				if ((this._FFLrequired != value))
				{
					this._FFLrequired = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NFArequired", DbType="Float")]
		public System.Nullable<double> NFArequired
		{
			get
			{
				return this._NFArequired;
			}
			set
			{
				if ((this._NFArequired != value))
				{
					this._NFArequired = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_variHash", DbType="NVarChar(255)")]
		public string variHash
		{
			get
			{
				return this._variHash;
			}
			set
			{
				if ((this._variHash != value))
				{
					this._variHash = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(255)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this._name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="NVarChar(255)")]
		public string id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_text", DbType="NVarChar(255)")]
		public string text
		{
			get
			{
				return this._text;
			}
			set
			{
				if ((this._text != value))
				{
					this._text = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
