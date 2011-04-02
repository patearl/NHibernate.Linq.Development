﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace NHibernate.Linq.EntityFramework
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DatabaseEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DatabaseEntities object using the connection string found in the 'DatabaseEntities' section of the application configuration file.
        /// </summary>
        public DatabaseEntities() : base("name=DatabaseEntities", "DatabaseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DatabaseEntities object.
        /// </summary>
        public DatabaseEntities(string connectionString) : base(connectionString, "DatabaseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DatabaseEntities object.
        /// </summary>
        public DatabaseEntities(EntityConnection connection) : base(connection, "DatabaseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Primitive> Primitives
        {
            get
            {
                if ((_Primitives == null))
                {
                    _Primitives = base.CreateObjectSet<Primitive>("Primitives");
                }
                return _Primitives;
            }
        }
        private ObjectSet<Primitive> _Primitives;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Primitives EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPrimitives(Primitive primitive)
        {
            base.AddObject("Primitives", primitive);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DatabaseModel", Name="Primitive")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Primitive : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Primitive object.
        /// </summary>
        /// <param name="decimal">Initial value of the Decimal property.</param>
        /// <param name="id">Initial value of the Id property.</param>
        public static Primitive CreatePrimitive(global::System.Decimal @decimal, global::System.Int32 id)
        {
            Primitive primitive = new Primitive();
            primitive.Decimal = @decimal;
            primitive.Id = id;
            return primitive;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Decimal
        {
            get
            {
                return _Decimal;
            }
            set
            {
                OnDecimalChanging(value);
                ReportPropertyChanging("Decimal");
                _Decimal = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Decimal");
                OnDecimalChanged();
            }
        }
        private global::System.Decimal _Decimal;
        partial void OnDecimalChanging(global::System.Decimal value);
        partial void OnDecimalChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> NullableDecimal
        {
            get
            {
                return _NullableDecimal;
            }
            set
            {
                OnNullableDecimalChanging(value);
                ReportPropertyChanging("NullableDecimal");
                _NullableDecimal = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("NullableDecimal");
                OnNullableDecimalChanged();
            }
        }
        private Nullable<global::System.Decimal> _NullableDecimal;
        partial void OnNullableDecimalChanging(Nullable<global::System.Decimal> value);
        partial void OnNullableDecimalChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String String
        {
            get
            {
                return _String;
            }
            set
            {
                OnStringChanging(value);
                ReportPropertyChanging("String");
                _String = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("String");
                OnStringChanged();
            }
        }
        private global::System.String _String;
        partial void OnStringChanging(global::System.String value);
        partial void OnStringChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();

        #endregion
    
    }

    #endregion
    
}