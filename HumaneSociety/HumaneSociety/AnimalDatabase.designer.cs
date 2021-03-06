﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HumaneSociety
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HumaneSociety")]
	public partial class AnimalDatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAnimal(Animal instance);
    partial void UpdateAnimal(Animal instance);
    partial void DeleteAnimal(Animal instance);
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertRoom_Number(Room_Number instance);
    partial void UpdateRoom_Number(Room_Number instance);
    partial void DeleteRoom_Number(Room_Number instance);
    #endregion
		
		public AnimalDatabaseDataContext() : 
				base(global::HumaneSociety.Properties.Settings.Default.HumaneSocietyConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AnimalDatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AnimalDatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AnimalDatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AnimalDatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Animal> Animals
		{
			get
			{
				return this.GetTable<Animal>();
			}
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<Room_Number> Room_Numbers
		{
			get
			{
				return this.GetTable<Room_Number>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Animals")]
	public partial class Animal : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Animal_Type;
		
		private string _Gender;
		
		private string _Name;
		
		private string _Adoption_Status;
		
		private string _Age;
		
		private string _Shots;
		
		private string _Food;
		
		private string _Breed;
		
		private System.Nullable<int> _RoomId;
		
		private System.Nullable<int> _CustomerID;
		
		private string _Activity_Level;
		
		private string _Price;
		
		private EntityRef<Customer> _Customer;
		
		private EntityRef<Room_Number> _Room_Number;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnAnimal_TypeChanging(string value);
    partial void OnAnimal_TypeChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAdoption_StatusChanging(string value);
    partial void OnAdoption_StatusChanged();
    partial void OnAgeChanging(string value);
    partial void OnAgeChanged();
    partial void OnShotsChanging(string value);
    partial void OnShotsChanged();
    partial void OnFoodChanging(string value);
    partial void OnFoodChanged();
    partial void OnBreedChanging(string value);
    partial void OnBreedChanged();
    partial void OnRoomIdChanging(System.Nullable<int> value);
    partial void OnRoomIdChanged();
    partial void OnCustomerIDChanging(System.Nullable<int> value);
    partial void OnCustomerIDChanged();
    partial void OnActivity_LevelChanging(string value);
    partial void OnActivity_LevelChanged();
    partial void OnPriceChanging(string value);
    partial void OnPriceChanged();
    #endregion
		
		public Animal()
		{
			this._Customer = default(EntityRef<Customer>);
			this._Room_Number = default(EntityRef<Room_Number>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Animal_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Animal_Type
		{
			get
			{
				return this._Animal_Type;
			}
			set
			{
				if ((this._Animal_Type != value))
				{
					this.OnAnimal_TypeChanging(value);
					this.SendPropertyChanging();
					this._Animal_Type = value;
					this.SendPropertyChanged("Animal_Type");
					this.OnAnimal_TypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adoption_Status", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Adoption_Status
		{
			get
			{
				return this._Adoption_Status;
			}
			set
			{
				if ((this._Adoption_Status != value))
				{
					this.OnAdoption_StatusChanging(value);
					this.SendPropertyChanging();
					this._Adoption_Status = value;
					this.SendPropertyChanged("Adoption_Status");
					this.OnAdoption_StatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Shots", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Shots
		{
			get
			{
				return this._Shots;
			}
			set
			{
				if ((this._Shots != value))
				{
					this.OnShotsChanging(value);
					this.SendPropertyChanging();
					this._Shots = value;
					this.SendPropertyChanged("Shots");
					this.OnShotsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Food", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Food
		{
			get
			{
				return this._Food;
			}
			set
			{
				if ((this._Food != value))
				{
					this.OnFoodChanging(value);
					this.SendPropertyChanging();
					this._Food = value;
					this.SendPropertyChanged("Food");
					this.OnFoodChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Breed", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Breed
		{
			get
			{
				return this._Breed;
			}
			set
			{
				if ((this._Breed != value))
				{
					this.OnBreedChanging(value);
					this.SendPropertyChanging();
					this._Breed = value;
					this.SendPropertyChanged("Breed");
					this.OnBreedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoomId", DbType="Int")]
		public System.Nullable<int> RoomId
		{
			get
			{
				return this._RoomId;
			}
			set
			{
				if ((this._RoomId != value))
				{
					if (this._Room_Number.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRoomIdChanging(value);
					this.SendPropertyChanging();
					this._RoomId = value;
					this.SendPropertyChanged("RoomId");
					this.OnRoomIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="Int")]
		public System.Nullable<int> CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					if (this._Customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Activity_Level", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Activity_Level
		{
			get
			{
				return this._Activity_Level;
			}
			set
			{
				if ((this._Activity_Level != value))
				{
					this.OnActivity_LevelChanging(value);
					this.SendPropertyChanging();
					this._Activity_Level = value;
					this.SendPropertyChanged("Activity_Level");
					this.OnActivity_LevelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Animal", Storage="_Customer", ThisKey="CustomerID", OtherKey="Id", IsForeignKey=true)]
		public Customer Customer
		{
			get
			{
				return this._Customer.Entity;
			}
			set
			{
				Customer previousValue = this._Customer.Entity;
				if (((previousValue != value) 
							|| (this._Customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer.Entity = null;
						previousValue.Animals.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.Animals.Add(this);
						this._CustomerID = value.Id;
					}
					else
					{
						this._CustomerID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Customer");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Room_Number_Animal", Storage="_Room_Number", ThisKey="RoomId", OtherKey="Id", IsForeignKey=true)]
		public Room_Number Room_Number
		{
			get
			{
				return this._Room_Number.Entity;
			}
			set
			{
				Room_Number previousValue = this._Room_Number.Entity;
				if (((previousValue != value) 
							|| (this._Room_Number.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Room_Number.Entity = null;
						previousValue.Animals.Remove(this);
					}
					this._Room_Number.Entity = value;
					if ((value != null))
					{
						value.Animals.Add(this);
						this._RoomId = value.Id;
					}
					else
					{
						this._RoomId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Room_Number");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _First_Name;
		
		private string _Last_Name;
		
		private string _Phone_Number;
		
		private string _Address_;
		
		private string _Activity_Level;
		
		private string _Own_Rent;
		
		private string _Occupation;
		
		private string _Annual_Income;
		
		private string _Housing;
		
		private EntitySet<Animal> _Animals;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFirst_NameChanging(string value);
    partial void OnFirst_NameChanged();
    partial void OnLast_NameChanging(string value);
    partial void OnLast_NameChanged();
    partial void OnPhone_NumberChanging(string value);
    partial void OnPhone_NumberChanged();
    partial void OnAddress_Changing(string value);
    partial void OnAddress_Changed();
    partial void OnActivity_LevelChanging(string value);
    partial void OnActivity_LevelChanged();
    partial void OnOwn_RentChanging(string value);
    partial void OnOwn_RentChanged();
    partial void OnOccupationChanging(string value);
    partial void OnOccupationChanged();
    partial void OnAnnual_IncomeChanging(string value);
    partial void OnAnnual_IncomeChanged();
    partial void OnHousingChanging(string value);
    partial void OnHousingChanged();
    #endregion
		
		public Customer()
		{
			this._Animals = new EntitySet<Animal>(new Action<Animal>(this.attach_Animals), new Action<Animal>(this.detach_Animals));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_First_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string First_Name
		{
			get
			{
				return this._First_Name;
			}
			set
			{
				if ((this._First_Name != value))
				{
					this.OnFirst_NameChanging(value);
					this.SendPropertyChanging();
					this._First_Name = value;
					this.SendPropertyChanged("First_Name");
					this.OnFirst_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Last_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Last_Name
		{
			get
			{
				return this._Last_Name;
			}
			set
			{
				if ((this._Last_Name != value))
				{
					this.OnLast_NameChanging(value);
					this.SendPropertyChanging();
					this._Last_Name = value;
					this.SendPropertyChanged("Last_Name");
					this.OnLast_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone_Number", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string Phone_Number
		{
			get
			{
				return this._Phone_Number;
			}
			set
			{
				if ((this._Phone_Number != value))
				{
					this.OnPhone_NumberChanging(value);
					this.SendPropertyChanging();
					this._Phone_Number = value;
					this.SendPropertyChanged("Phone_Number");
					this.OnPhone_NumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address_", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string Address_
		{
			get
			{
				return this._Address_;
			}
			set
			{
				if ((this._Address_ != value))
				{
					this.OnAddress_Changing(value);
					this.SendPropertyChanging();
					this._Address_ = value;
					this.SendPropertyChanged("Address_");
					this.OnAddress_Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Activity_Level", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Activity_Level
		{
			get
			{
				return this._Activity_Level;
			}
			set
			{
				if ((this._Activity_Level != value))
				{
					this.OnActivity_LevelChanging(value);
					this.SendPropertyChanging();
					this._Activity_Level = value;
					this.SendPropertyChanged("Activity_Level");
					this.OnActivity_LevelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Own/Rent]", Storage="_Own_Rent", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Own_Rent
		{
			get
			{
				return this._Own_Rent;
			}
			set
			{
				if ((this._Own_Rent != value))
				{
					this.OnOwn_RentChanging(value);
					this.SendPropertyChanging();
					this._Own_Rent = value;
					this.SendPropertyChanged("Own_Rent");
					this.OnOwn_RentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Occupation", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Occupation
		{
			get
			{
				return this._Occupation;
			}
			set
			{
				if ((this._Occupation != value))
				{
					this.OnOccupationChanging(value);
					this.SendPropertyChanging();
					this._Occupation = value;
					this.SendPropertyChanged("Occupation");
					this.OnOccupationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Annual_Income", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Annual_Income
		{
			get
			{
				return this._Annual_Income;
			}
			set
			{
				if ((this._Annual_Income != value))
				{
					this.OnAnnual_IncomeChanging(value);
					this.SendPropertyChanging();
					this._Annual_Income = value;
					this.SendPropertyChanged("Annual_Income");
					this.OnAnnual_IncomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Housing", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Housing
		{
			get
			{
				return this._Housing;
			}
			set
			{
				if ((this._Housing != value))
				{
					this.OnHousingChanging(value);
					this.SendPropertyChanging();
					this._Housing = value;
					this.SendPropertyChanged("Housing");
					this.OnHousingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Animal", Storage="_Animals", ThisKey="Id", OtherKey="CustomerID")]
		public EntitySet<Animal> Animals
		{
			get
			{
				return this._Animals;
			}
			set
			{
				this._Animals.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Animals(Animal entity)
		{
			this.SendPropertyChanging();
			entity.Customer = this;
		}
		
		private void detach_Animals(Animal entity)
		{
			this.SendPropertyChanging();
			entity.Customer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Room_Number")]
	public partial class Room_Number : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _RoomNumber;
		
		private EntitySet<Animal> _Animals;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnRoomNumberChanging(int value);
    partial void OnRoomNumberChanged();
    #endregion
		
		public Room_Number()
		{
			this._Animals = new EntitySet<Animal>(new Action<Animal>(this.attach_Animals), new Action<Animal>(this.detach_Animals));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoomNumber", DbType="Int NOT NULL")]
		public int RoomNumber
		{
			get
			{
				return this._RoomNumber;
			}
			set
			{
				if ((this._RoomNumber != value))
				{
					this.OnRoomNumberChanging(value);
					this.SendPropertyChanging();
					this._RoomNumber = value;
					this.SendPropertyChanged("RoomNumber");
					this.OnRoomNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Room_Number_Animal", Storage="_Animals", ThisKey="Id", OtherKey="RoomId")]
		public EntitySet<Animal> Animals
		{
			get
			{
				return this._Animals;
			}
			set
			{
				this._Animals.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Animals(Animal entity)
		{
			this.SendPropertyChanging();
			entity.Room_Number = this;
		}
		
		private void detach_Animals(Animal entity)
		{
			this.SendPropertyChanging();
			entity.Room_Number = null;
		}
	}
}
#pragma warning restore 1591
