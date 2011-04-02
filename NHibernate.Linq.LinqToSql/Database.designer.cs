﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NHibernate.Linq.LinqToSql
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
	
	
	public partial class Database : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEntityA(EntityA instance);
    partial void UpdateEntityA(EntityA instance);
    partial void DeleteEntityA(EntityA instance);
    partial void InsertPrimitive(Primitive instance);
    partial void UpdatePrimitive(Primitive instance);
    partial void DeletePrimitive(Primitive instance);
    #endregion
		
		public Database(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Database(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Database(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Database(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<EntityA> EntityAs
		{
			get
			{
				return this.GetTable<EntityA>();
			}
		}
		
		public System.Data.Linq.Table<Primitive> Primitives
		{
			get
			{
				return this.GetTable<Primitive>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute()]
	public partial class EntityA : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _PrimitiveId;
		
		private EntityRef<Primitive> _Primitive;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnPrimitiveIdChanging(System.Nullable<int> value);
    partial void OnPrimitiveIdChanged();
    #endregion
		
		public EntityA()
		{
			this._Primitive = default(EntityRef<Primitive>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrimitiveId", DbType="Int")]
		public System.Nullable<int> PrimitiveId
		{
			get
			{
				return this._PrimitiveId;
			}
			set
			{
				if ((this._PrimitiveId != value))
				{
					if (this._Primitive.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPrimitiveIdChanging(value);
					this.SendPropertyChanging();
					this._PrimitiveId = value;
					this.SendPropertyChanged("PrimitiveId");
					this.OnPrimitiveIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Primitive_EntityA", Storage="_Primitive", ThisKey="PrimitiveId", OtherKey="Id", IsForeignKey=true)]
		public Primitive Primitive
		{
			get
			{
				return this._Primitive.Entity;
			}
			set
			{
				Primitive previousValue = this._Primitive.Entity;
				if (((previousValue != value) 
							|| (this._Primitive.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Primitive.Entity = null;
						previousValue.EntityAs.Remove(this);
					}
					this._Primitive.Entity = value;
					if ((value != null))
					{
						value.EntityAs.Add(this);
						this._PrimitiveId = value.Id;
					}
					else
					{
						this._PrimitiveId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Primitive");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute()]
	public partial class Primitive : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _Decimal;
		
		private System.Nullable<decimal> _NullableDecimal;
		
		private string _String;
		
		private int _Id;
		
		private EntitySet<EntityA> _EntityAs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDecimalChanging(decimal value);
    partial void OnDecimalChanged();
    partial void OnNullableDecimalChanging(System.Nullable<decimal> value);
    partial void OnNullableDecimalChanged();
    partial void OnStringChanging(string value);
    partial void OnStringChanged();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    #endregion
		
		public Primitive()
		{
			this._EntityAs = new EntitySet<EntityA>(new Action<EntityA>(this.attach_EntityAs), new Action<EntityA>(this.detach_EntityAs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Decimal", DbType="Decimal(19,4) NOT NULL")]
		public decimal Decimal
		{
			get
			{
				return this._Decimal;
			}
			set
			{
				if ((this._Decimal != value))
				{
					this.OnDecimalChanging(value);
					this.SendPropertyChanging();
					this._Decimal = value;
					this.SendPropertyChanged("Decimal");
					this.OnDecimalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NullableDecimal", DbType="Decimal(19,4)")]
		public System.Nullable<decimal> NullableDecimal
		{
			get
			{
				return this._NullableDecimal;
			}
			set
			{
				if ((this._NullableDecimal != value))
				{
					this.OnNullableDecimalChanging(value);
					this.SendPropertyChanging();
					this._NullableDecimal = value;
					this.SendPropertyChanged("NullableDecimal");
					this.OnNullableDecimalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_String", DbType="NVarChar(100)")]
		public string String
		{
			get
			{
				return this._String;
			}
			set
			{
				if ((this._String != value))
				{
					this.OnStringChanging(value);
					this.SendPropertyChanging();
					this._String = value;
					this.SendPropertyChanged("String");
					this.OnStringChanged();
				}
			}
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Primitive_EntityA", Storage="_EntityAs", ThisKey="Id", OtherKey="PrimitiveId")]
		public EntitySet<EntityA> EntityAs
		{
			get
			{
				return this._EntityAs;
			}
			set
			{
				this._EntityAs.Assign(value);
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
		
		private void attach_EntityAs(EntityA entity)
		{
			this.SendPropertyChanging();
			entity.Primitive = this;
		}
		
		private void detach_EntityAs(EntityA entity)
		{
			this.SendPropertyChanging();
			entity.Primitive = null;
		}
	}
}
#pragma warning restore 1591
