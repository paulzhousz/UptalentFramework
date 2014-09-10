
// This file was automatically generated by the PetaPoco T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `NorthWind`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `Data Source=.;Initial Catalog=NorthWind;Persist Security Info=True;User ID=sa;password=**zapped**;MultipleActiveResultSets=True`
//     Schema:                 ``
//     Include Views:          `False`

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace MVCTest.Models
{
	public partial class NorthWindDB : Database
	{
		public NorthWindDB() 
			: base("NorthWind")
		{
			CommonConstruct();
		}

		public NorthWindDB(string connectionStringName) 
			: base(connectionStringName)
		{
			CommonConstruct();
		}
		
		partial void CommonConstruct();
		
		public interface IFactory
		{
			NorthWindDB GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static NorthWindDB GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
				return new NorthWindDB();
        }

		[ThreadStatic] static NorthWindDB _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        
		public class Record<T> where T:new()
		{
			public static NorthWindDB repo { get { return NorthWindDB.GetInstance(); } }
			public bool IsNew() { return repo.IsNew(this); }
			public object Insert() { return repo.Insert(this); }
			public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
			public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
			public static int Update(Sql sql) { return repo.Update<T>(sql); }
			public int Delete() { return repo.Delete(this); }
			public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
			public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
			public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
			public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
			public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
			public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
			public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
			public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
			public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
			public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
			public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
			public static T Single(Sql sql) { return repo.Single<T>(sql); }
			public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
			public static T First(Sql sql) { return repo.First<T>(sql); }
			public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
			public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
			public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
			public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
			public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
			public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
			public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
			public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
			public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
			public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }
			
			private Dictionary<string,bool> ModifiedColumns;
			private void OnLoaded()
			{
				ModifiedColumns = new Dictionary<string,bool>();
			}
			protected void MarkColumnModified(string column_name)
			{
				if (ModifiedColumns!=null)
					ModifiedColumns[column_name]=true;
			}
			public int Update() 
			{ 
				if (ModifiedColumns==null)
					return repo.Update(this); 

				int retv = repo.Update(this, ModifiedColumns.Keys);
				ModifiedColumns.Clear();
				return retv;
			}
			public void Save() 
			{ 
				if (repo.IsNew(this))
					repo.Insert(this);
				else
					Update();
			}
		}
	}
	

    
	[TableName("Employees")]
	[PrimaryKey("EmployeeID")]
	[ExplicitColumns]
    public partial class Employee : NorthWindDB.Record<Employee>  
    {
        [Column] 
		public int EmployeeID 
		{ 
			get
			{
				return _EmployeeID;
			}
			set
			{
				_EmployeeID = value;
				MarkColumnModified("EmployeeID");
			}
		}
		private int _EmployeeID;

        [Column] 
		public string LastName 
		{ 
			get
			{
				return _LastName;
			}
			set
			{
				_LastName = value;
				MarkColumnModified("LastName");
			}
		}
		private string _LastName;

        [Column] 
		public string FirstName 
		{ 
			get
			{
				return _FirstName;
			}
			set
			{
				_FirstName = value;
				MarkColumnModified("FirstName");
			}
		}
		private string _FirstName;

        [Column] 
		public string Title 
		{ 
			get
			{
				return _Title;
			}
			set
			{
				_Title = value;
				MarkColumnModified("Title");
			}
		}
		private string _Title;

        [Column] 
		public string TitleOfCourtesy 
		{ 
			get
			{
				return _TitleOfCourtesy;
			}
			set
			{
				_TitleOfCourtesy = value;
				MarkColumnModified("TitleOfCourtesy");
			}
		}
		private string _TitleOfCourtesy;

        [Column] 
		public DateTime? BirthDate 
		{ 
			get
			{
				return _BirthDate;
			}
			set
			{
				_BirthDate = value;
				MarkColumnModified("BirthDate");
			}
		}
		private DateTime? _BirthDate;

        [Column] 
		public DateTime? HireDate 
		{ 
			get
			{
				return _HireDate;
			}
			set
			{
				_HireDate = value;
				MarkColumnModified("HireDate");
			}
		}
		private DateTime? _HireDate;

        [Column] 
		public string Address 
		{ 
			get
			{
				return _Address;
			}
			set
			{
				_Address = value;
				MarkColumnModified("Address");
			}
		}
		private string _Address;

        [Column] 
		public string City 
		{ 
			get
			{
				return _City;
			}
			set
			{
				_City = value;
				MarkColumnModified("City");
			}
		}
		private string _City;

        [Column] 
		public string Region 
		{ 
			get
			{
				return _Region;
			}
			set
			{
				_Region = value;
				MarkColumnModified("Region");
			}
		}
		private string _Region;

        [Column] 
		public string PostalCode 
		{ 
			get
			{
				return _PostalCode;
			}
			set
			{
				_PostalCode = value;
				MarkColumnModified("PostalCode");
			}
		}
		private string _PostalCode;

        [Column] 
		public string Country 
		{ 
			get
			{
				return _Country;
			}
			set
			{
				_Country = value;
				MarkColumnModified("Country");
			}
		}
		private string _Country;

        [Column] 
		public string HomePhone 
		{ 
			get
			{
				return _HomePhone;
			}
			set
			{
				_HomePhone = value;
				MarkColumnModified("HomePhone");
			}
		}
		private string _HomePhone;

        [Column] 
		public string Extension 
		{ 
			get
			{
				return _Extension;
			}
			set
			{
				_Extension = value;
				MarkColumnModified("Extension");
			}
		}
		private string _Extension;

        [Column] 
		public byte[] Photo 
		{ 
			get
			{
				return _Photo;
			}
			set
			{
				_Photo = value;
				MarkColumnModified("Photo");
			}
		}
		private byte[] _Photo;

        [Column] 
		public string Notes 
		{ 
			get
			{
				return _Notes;
			}
			set
			{
				_Notes = value;
				MarkColumnModified("Notes");
			}
		}
		private string _Notes;

        [Column] 
		public int? ReportsTo 
		{ 
			get
			{
				return _ReportsTo;
			}
			set
			{
				_ReportsTo = value;
				MarkColumnModified("ReportsTo");
			}
		}
		private int? _ReportsTo;

        [Column] 
		public string PhotoPath 
		{ 
			get
			{
				return _PhotoPath;
			}
			set
			{
				_PhotoPath = value;
				MarkColumnModified("PhotoPath");
			}
		}
		private string _PhotoPath;

	}
    
	[TableName("Categories")]
	[PrimaryKey("CategoryID")]
	[ExplicitColumns]
    public partial class Category : NorthWindDB.Record<Category>  
    {
        [Column] 
		public int CategoryID 
		{ 
			get
			{
				return _CategoryID;
			}
			set
			{
				_CategoryID = value;
				MarkColumnModified("CategoryID");
			}
		}
		private int _CategoryID;

        [Column] 
		public string CategoryName 
		{ 
			get
			{
				return _CategoryName;
			}
			set
			{
				_CategoryName = value;
				MarkColumnModified("CategoryName");
			}
		}
		private string _CategoryName;

        [Column] 
		public string Description 
		{ 
			get
			{
				return _Description;
			}
			set
			{
				_Description = value;
				MarkColumnModified("Description");
			}
		}
		private string _Description;

        [Column] 
		public byte[] Picture 
		{ 
			get
			{
				return _Picture;
			}
			set
			{
				_Picture = value;
				MarkColumnModified("Picture");
			}
		}
		private byte[] _Picture;

	}
    
	[TableName("Customers")]
	[PrimaryKey("CustomerID", autoIncrement=false)]
	[ExplicitColumns]
    public partial class Customer : NorthWindDB.Record<Customer>  
    {
        [Column] 
		public string CustomerID 
		{ 
			get
			{
				return _CustomerID;
			}
			set
			{
				_CustomerID = value;
				MarkColumnModified("CustomerID");
			}
		}
		private string _CustomerID;

        [Column] 
		public string CompanyName 
		{ 
			get
			{
				return _CompanyName;
			}
			set
			{
				_CompanyName = value;
				MarkColumnModified("CompanyName");
			}
		}
		private string _CompanyName;

        [Column] 
		public string ContactName 
		{ 
			get
			{
				return _ContactName;
			}
			set
			{
				_ContactName = value;
				MarkColumnModified("ContactName");
			}
		}
		private string _ContactName;

        [Column] 
		public string ContactTitle 
		{ 
			get
			{
				return _ContactTitle;
			}
			set
			{
				_ContactTitle = value;
				MarkColumnModified("ContactTitle");
			}
		}
		private string _ContactTitle;

        [Column] 
		public string Address 
		{ 
			get
			{
				return _Address;
			}
			set
			{
				_Address = value;
				MarkColumnModified("Address");
			}
		}
		private string _Address;

        [Column] 
		public string City 
		{ 
			get
			{
				return _City;
			}
			set
			{
				_City = value;
				MarkColumnModified("City");
			}
		}
		private string _City;

        [Column] 
		public string Region 
		{ 
			get
			{
				return _Region;
			}
			set
			{
				_Region = value;
				MarkColumnModified("Region");
			}
		}
		private string _Region;

        [Column] 
		public string PostalCode 
		{ 
			get
			{
				return _PostalCode;
			}
			set
			{
				_PostalCode = value;
				MarkColumnModified("PostalCode");
			}
		}
		private string _PostalCode;

        [Column] 
		public string Country 
		{ 
			get
			{
				return _Country;
			}
			set
			{
				_Country = value;
				MarkColumnModified("Country");
			}
		}
		private string _Country;

        [Column] 
		public string Phone 
		{ 
			get
			{
				return _Phone;
			}
			set
			{
				_Phone = value;
				MarkColumnModified("Phone");
			}
		}
		private string _Phone;

        [Column] 
		public string Fax 
		{ 
			get
			{
				return _Fax;
			}
			set
			{
				_Fax = value;
				MarkColumnModified("Fax");
			}
		}
		private string _Fax;

	}
    
	[TableName("Shippers")]
	[PrimaryKey("ShipperID")]
	[ExplicitColumns]
    public partial class Shipper : NorthWindDB.Record<Shipper>  
    {
        [Column] 
		public int ShipperID 
		{ 
			get
			{
				return _ShipperID;
			}
			set
			{
				_ShipperID = value;
				MarkColumnModified("ShipperID");
			}
		}
		private int _ShipperID;

        [Column] 
		public string CompanyName 
		{ 
			get
			{
				return _CompanyName;
			}
			set
			{
				_CompanyName = value;
				MarkColumnModified("CompanyName");
			}
		}
		private string _CompanyName;

        [Column] 
		public string Phone 
		{ 
			get
			{
				return _Phone;
			}
			set
			{
				_Phone = value;
				MarkColumnModified("Phone");
			}
		}
		private string _Phone;

	}
    
	[TableName("Suppliers")]
	[PrimaryKey("SupplierID")]
	[ExplicitColumns]
    public partial class Supplier : NorthWindDB.Record<Supplier>  
    {
        [Column] 
		public int SupplierID 
		{ 
			get
			{
				return _SupplierID;
			}
			set
			{
				_SupplierID = value;
				MarkColumnModified("SupplierID");
			}
		}
		private int _SupplierID;

        [Column] 
		public string CompanyName 
		{ 
			get
			{
				return _CompanyName;
			}
			set
			{
				_CompanyName = value;
				MarkColumnModified("CompanyName");
			}
		}
		private string _CompanyName;

        [Column] 
		public string ContactName 
		{ 
			get
			{
				return _ContactName;
			}
			set
			{
				_ContactName = value;
				MarkColumnModified("ContactName");
			}
		}
		private string _ContactName;

        [Column] 
		public string ContactTitle 
		{ 
			get
			{
				return _ContactTitle;
			}
			set
			{
				_ContactTitle = value;
				MarkColumnModified("ContactTitle");
			}
		}
		private string _ContactTitle;

        [Column] 
		public string Address 
		{ 
			get
			{
				return _Address;
			}
			set
			{
				_Address = value;
				MarkColumnModified("Address");
			}
		}
		private string _Address;

        [Column] 
		public string City 
		{ 
			get
			{
				return _City;
			}
			set
			{
				_City = value;
				MarkColumnModified("City");
			}
		}
		private string _City;

        [Column] 
		public string Region 
		{ 
			get
			{
				return _Region;
			}
			set
			{
				_Region = value;
				MarkColumnModified("Region");
			}
		}
		private string _Region;

        [Column] 
		public string PostalCode 
		{ 
			get
			{
				return _PostalCode;
			}
			set
			{
				_PostalCode = value;
				MarkColumnModified("PostalCode");
			}
		}
		private string _PostalCode;

        [Column] 
		public string Country 
		{ 
			get
			{
				return _Country;
			}
			set
			{
				_Country = value;
				MarkColumnModified("Country");
			}
		}
		private string _Country;

        [Column] 
		public string Phone 
		{ 
			get
			{
				return _Phone;
			}
			set
			{
				_Phone = value;
				MarkColumnModified("Phone");
			}
		}
		private string _Phone;

        [Column] 
		public string Fax 
		{ 
			get
			{
				return _Fax;
			}
			set
			{
				_Fax = value;
				MarkColumnModified("Fax");
			}
		}
		private string _Fax;

        [Column] 
		public string HomePage 
		{ 
			get
			{
				return _HomePage;
			}
			set
			{
				_HomePage = value;
				MarkColumnModified("HomePage");
			}
		}
		private string _HomePage;

	}
    
	[TableName("Orders")]
	[PrimaryKey("OrderID")]
	[ExplicitColumns]
    public partial class Order : NorthWindDB.Record<Order>  
    {
        [Column] 
		public int OrderID 
		{ 
			get
			{
				return _OrderID;
			}
			set
			{
				_OrderID = value;
				MarkColumnModified("OrderID");
			}
		}
		private int _OrderID;

        [Column] 
		public string CustomerID 
		{ 
			get
			{
				return _CustomerID;
			}
			set
			{
				_CustomerID = value;
				MarkColumnModified("CustomerID");
			}
		}
		private string _CustomerID;

        [Column] 
		public int? EmployeeID 
		{ 
			get
			{
				return _EmployeeID;
			}
			set
			{
				_EmployeeID = value;
				MarkColumnModified("EmployeeID");
			}
		}
		private int? _EmployeeID;

        [Column] 
		public DateTime? OrderDate 
		{ 
			get
			{
				return _OrderDate;
			}
			set
			{
				_OrderDate = value;
				MarkColumnModified("OrderDate");
			}
		}
		private DateTime? _OrderDate;

        [Column] 
		public DateTime? RequiredDate 
		{ 
			get
			{
				return _RequiredDate;
			}
			set
			{
				_RequiredDate = value;
				MarkColumnModified("RequiredDate");
			}
		}
		private DateTime? _RequiredDate;

        [Column] 
		public DateTime? ShippedDate 
		{ 
			get
			{
				return _ShippedDate;
			}
			set
			{
				_ShippedDate = value;
				MarkColumnModified("ShippedDate");
			}
		}
		private DateTime? _ShippedDate;

        [Column] 
		public int? ShipVia 
		{ 
			get
			{
				return _ShipVia;
			}
			set
			{
				_ShipVia = value;
				MarkColumnModified("ShipVia");
			}
		}
		private int? _ShipVia;

        [Column] 
		public decimal? Freight 
		{ 
			get
			{
				return _Freight;
			}
			set
			{
				_Freight = value;
				MarkColumnModified("Freight");
			}
		}
		private decimal? _Freight;

        [Column] 
		public string ShipName 
		{ 
			get
			{
				return _ShipName;
			}
			set
			{
				_ShipName = value;
				MarkColumnModified("ShipName");
			}
		}
		private string _ShipName;

        [Column] 
		public string ShipAddress 
		{ 
			get
			{
				return _ShipAddress;
			}
			set
			{
				_ShipAddress = value;
				MarkColumnModified("ShipAddress");
			}
		}
		private string _ShipAddress;

        [Column] 
		public string ShipCity 
		{ 
			get
			{
				return _ShipCity;
			}
			set
			{
				_ShipCity = value;
				MarkColumnModified("ShipCity");
			}
		}
		private string _ShipCity;

        [Column] 
		public string ShipRegion 
		{ 
			get
			{
				return _ShipRegion;
			}
			set
			{
				_ShipRegion = value;
				MarkColumnModified("ShipRegion");
			}
		}
		private string _ShipRegion;

        [Column] 
		public string ShipPostalCode 
		{ 
			get
			{
				return _ShipPostalCode;
			}
			set
			{
				_ShipPostalCode = value;
				MarkColumnModified("ShipPostalCode");
			}
		}
		private string _ShipPostalCode;

        [Column] 
		public string ShipCountry 
		{ 
			get
			{
				return _ShipCountry;
			}
			set
			{
				_ShipCountry = value;
				MarkColumnModified("ShipCountry");
			}
		}
		private string _ShipCountry;

	}
    
	[TableName("Products")]
	[PrimaryKey("ProductID")]
	[ExplicitColumns]
    public partial class Product : NorthWindDB.Record<Product>  
    {
        [Column] 
		public int ProductID 
		{ 
			get
			{
				return _ProductID;
			}
			set
			{
				_ProductID = value;
				MarkColumnModified("ProductID");
			}
		}
		private int _ProductID;

        [Column] 
		public string ProductName 
		{ 
			get
			{
				return _ProductName;
			}
			set
			{
				_ProductName = value;
				MarkColumnModified("ProductName");
			}
		}
		private string _ProductName;

        [Column] 
		public int? SupplierID 
		{ 
			get
			{
				return _SupplierID;
			}
			set
			{
				_SupplierID = value;
				MarkColumnModified("SupplierID");
			}
		}
		private int? _SupplierID;

        [Column] 
		public int? CategoryID 
		{ 
			get
			{
				return _CategoryID;
			}
			set
			{
				_CategoryID = value;
				MarkColumnModified("CategoryID");
			}
		}
		private int? _CategoryID;

        [Column] 
		public string QuantityPerUnit 
		{ 
			get
			{
				return _QuantityPerUnit;
			}
			set
			{
				_QuantityPerUnit = value;
				MarkColumnModified("QuantityPerUnit");
			}
		}
		private string _QuantityPerUnit;

        [Column] 
		public decimal? UnitPrice 
		{ 
			get
			{
				return _UnitPrice;
			}
			set
			{
				_UnitPrice = value;
				MarkColumnModified("UnitPrice");
			}
		}
		private decimal? _UnitPrice;

        [Column] 
		public short? UnitsInStock 
		{ 
			get
			{
				return _UnitsInStock;
			}
			set
			{
				_UnitsInStock = value;
				MarkColumnModified("UnitsInStock");
			}
		}
		private short? _UnitsInStock;

        [Column] 
		public short? UnitsOnOrder 
		{ 
			get
			{
				return _UnitsOnOrder;
			}
			set
			{
				_UnitsOnOrder = value;
				MarkColumnModified("UnitsOnOrder");
			}
		}
		private short? _UnitsOnOrder;

        [Column] 
		public short? ReorderLevel 
		{ 
			get
			{
				return _ReorderLevel;
			}
			set
			{
				_ReorderLevel = value;
				MarkColumnModified("ReorderLevel");
			}
		}
		private short? _ReorderLevel;

        [Column] 
		public bool Discontinued 
		{ 
			get
			{
				return _Discontinued;
			}
			set
			{
				_Discontinued = value;
				MarkColumnModified("Discontinued");
			}
		}
		private bool _Discontinued;

	}
    
	[TableName("Order Details")]
	[PrimaryKey("OrderID", autoIncrement=false)]
	[ExplicitColumns]
    public partial class Detail : NorthWindDB.Record<Detail>  
    {
        [Column] 
		public int OrderID 
		{ 
			get
			{
				return _OrderID;
			}
			set
			{
				_OrderID = value;
				MarkColumnModified("OrderID");
			}
		}
		private int _OrderID;

        [Column] 
		public int ProductID 
		{ 
			get
			{
				return _ProductID;
			}
			set
			{
				_ProductID = value;
				MarkColumnModified("ProductID");
			}
		}
		private int _ProductID;

        [Column] 
		public decimal UnitPrice 
		{ 
			get
			{
				return _UnitPrice;
			}
			set
			{
				_UnitPrice = value;
				MarkColumnModified("UnitPrice");
			}
		}
		private decimal _UnitPrice;

        [Column] 
		public short Quantity 
		{ 
			get
			{
				return _Quantity;
			}
			set
			{
				_Quantity = value;
				MarkColumnModified("Quantity");
			}
		}
		private short _Quantity;

        [Column] 
		public float Discount 
		{ 
			get
			{
				return _Discount;
			}
			set
			{
				_Discount = value;
				MarkColumnModified("Discount");
			}
		}
		private float _Discount;

	}
    
	[TableName("CustomerCustomerDemo")]
	[ExplicitColumns]
    public partial class CustomerCustomerDemo : NorthWindDB.Record<CustomerCustomerDemo>  
    {
        [Column] 
		public string CustomerID 
		{ 
			get
			{
				return _CustomerID;
			}
			set
			{
				_CustomerID = value;
				MarkColumnModified("CustomerID");
			}
		}
		private string _CustomerID;

        [Column] 
		public string CustomerTypeID 
		{ 
			get
			{
				return _CustomerTypeID;
			}
			set
			{
				_CustomerTypeID = value;
				MarkColumnModified("CustomerTypeID");
			}
		}
		private string _CustomerTypeID;

	}
    
	[TableName("Territories")]
	[ExplicitColumns]
    public partial class Territory : NorthWindDB.Record<Territory>  
    {
        [Column] 
		public string TerritoryID 
		{ 
			get
			{
				return _TerritoryID;
			}
			set
			{
				_TerritoryID = value;
				MarkColumnModified("TerritoryID");
			}
		}
		private string _TerritoryID;

        [Column] 
		public string TerritoryDescription 
		{ 
			get
			{
				return _TerritoryDescription;
			}
			set
			{
				_TerritoryDescription = value;
				MarkColumnModified("TerritoryDescription");
			}
		}
		private string _TerritoryDescription;

        [Column] 
		public int RegionID 
		{ 
			get
			{
				return _RegionID;
			}
			set
			{
				_RegionID = value;
				MarkColumnModified("RegionID");
			}
		}
		private int _RegionID;

	}
    
	[TableName("EmployeeTerritories")]
	[ExplicitColumns]
    public partial class EmployeeTerritory : NorthWindDB.Record<EmployeeTerritory>  
    {
        [Column] 
		public int EmployeeID 
		{ 
			get
			{
				return _EmployeeID;
			}
			set
			{
				_EmployeeID = value;
				MarkColumnModified("EmployeeID");
			}
		}
		private int _EmployeeID;

        [Column] 
		public string TerritoryID 
		{ 
			get
			{
				return _TerritoryID;
			}
			set
			{
				_TerritoryID = value;
				MarkColumnModified("TerritoryID");
			}
		}
		private string _TerritoryID;

	}
    
	[TableName("CustomerDemographics")]
	[ExplicitColumns]
    public partial class CustomerDemographic : NorthWindDB.Record<CustomerDemographic>  
    {
        [Column] 
		public string CustomerTypeID 
		{ 
			get
			{
				return _CustomerTypeID;
			}
			set
			{
				_CustomerTypeID = value;
				MarkColumnModified("CustomerTypeID");
			}
		}
		private string _CustomerTypeID;

        [Column] 
		public string CustomerDesc 
		{ 
			get
			{
				return _CustomerDesc;
			}
			set
			{
				_CustomerDesc = value;
				MarkColumnModified("CustomerDesc");
			}
		}
		private string _CustomerDesc;

	}
    
	[TableName("Region")]
	[ExplicitColumns]
    public partial class Region : NorthWindDB.Record<Region>  
    {
        [Column] 
		public int RegionID 
		{ 
			get
			{
				return _RegionID;
			}
			set
			{
				_RegionID = value;
				MarkColumnModified("RegionID");
			}
		}
		private int _RegionID;

        [Column] 
		public string RegionDescription 
		{ 
			get
			{
				return _RegionDescription;
			}
			set
			{
				_RegionDescription = value;
				MarkColumnModified("RegionDescription");
			}
		}
		private string _RegionDescription;

	}
}


