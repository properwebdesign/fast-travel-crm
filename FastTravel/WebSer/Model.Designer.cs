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
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("FastTravelModel", "FK_RelatredHotel", "Hotel", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(WebSer.Hotel), "Hotel1", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(WebSer.Hotel), true)]

#endregion

namespace WebSer
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class FastTravelEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new FastTravelEntities object using the connection string found in the 'FastTravelEntities' section of the application configuration file.
        /// </summary>
        public FastTravelEntities() : base("name=FastTravelEntities", "FastTravelEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new FastTravelEntities object.
        /// </summary>
        public FastTravelEntities(string connectionString) : base(connectionString, "FastTravelEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new FastTravelEntities object.
        /// </summary>
        public FastTravelEntities(EntityConnection connection) : base(connection, "FastTravelEntities")
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
        public ObjectSet<Hotel> Hotels
        {
            get
            {
                if ((_Hotels == null))
                {
                    _Hotels = base.CreateObjectSet<Hotel>("Hotels");
                }
                return _Hotels;
            }
        }
        private ObjectSet<Hotel> _Hotels;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Hotels EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToHotels(Hotel hotel)
        {
            base.AddObject("Hotels", hotel);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="FastTravelModel", Name="Hotel")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Hotel : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Hotel object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="gUID">Initial value of the GUID property.</param>
        /// <param name="isArchive">Initial value of the IsArchive property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="roomsCount">Initial value of the RoomsCount property.</param>
        /// <param name="roomsCategory">Initial value of the RoomsCategory property.</param>
        /// <param name="description">Initial value of the Description property.</param>
        /// <param name="addedDate">Initial value of the AddedDate property.</param>
        /// <param name="starLevel">Initial value of the StarLevel property.</param>
        /// <param name="floorCount">Initial value of the FloorCount property.</param>
        public static Hotel CreateHotel(global::System.Int32 id, global::System.Guid gUID, global::System.Boolean isArchive, global::System.String name, global::System.Int32 roomsCount, global::System.String roomsCategory, global::System.String description, global::System.DateTime addedDate, global::System.Int32 starLevel, global::System.Int32 floorCount)
        {
            Hotel hotel = new Hotel();
            hotel.ID = id;
            hotel.GUID = gUID;
            hotel.IsArchive = isArchive;
            hotel.Name = name;
            hotel.RoomsCount = roomsCount;
            hotel.RoomsCategory = roomsCategory;
            hotel.Description = description;
            hotel.AddedDate = addedDate;
            hotel.StarLevel = starLevel;
            hotel.FloorCount = floorCount;
            return hotel;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid GUID
        {
            get
            {
                return _GUID;
            }
            set
            {
                OnGUIDChanging(value);
                ReportPropertyChanging("GUID");
                _GUID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("GUID");
                OnGUIDChanged();
            }
        }
        private global::System.Guid _GUID;
        partial void OnGUIDChanging(global::System.Guid value);
        partial void OnGUIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsArchive
        {
            get
            {
                return _IsArchive;
            }
            set
            {
                OnIsArchiveChanging(value);
                ReportPropertyChanging("IsArchive");
                _IsArchive = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsArchive");
                OnIsArchiveChanged();
            }
        }
        private global::System.Boolean _IsArchive;
        partial void OnIsArchiveChanging(global::System.Boolean value);
        partial void OnIsArchiveChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> RestorationYear
        {
            get
            {
                return _RestorationYear;
            }
            set
            {
                OnRestorationYearChanging(value);
                ReportPropertyChanging("RestorationYear");
                _RestorationYear = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("RestorationYear");
                OnRestorationYearChanged();
            }
        }
        private Nullable<global::System.Int32> _RestorationYear;
        partial void OnRestorationYearChanging(Nullable<global::System.Int32> value);
        partial void OnRestorationYearChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> BuildYear
        {
            get
            {
                return _BuildYear;
            }
            set
            {
                OnBuildYearChanging(value);
                ReportPropertyChanging("BuildYear");
                _BuildYear = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("BuildYear");
                OnBuildYearChanged();
            }
        }
        private Nullable<global::System.Int32> _BuildYear;
        partial void OnBuildYearChanging(Nullable<global::System.Int32> value);
        partial void OnBuildYearChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 RoomsCount
        {
            get
            {
                return _RoomsCount;
            }
            set
            {
                OnRoomsCountChanging(value);
                ReportPropertyChanging("RoomsCount");
                _RoomsCount = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("RoomsCount");
                OnRoomsCountChanged();
            }
        }
        private global::System.Int32 _RoomsCount;
        partial void OnRoomsCountChanging(global::System.Int32 value);
        partial void OnRoomsCountChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String RoomsCategory
        {
            get
            {
                return _RoomsCategory;
            }
            set
            {
                OnRoomsCategoryChanging(value);
                ReportPropertyChanging("RoomsCategory");
                _RoomsCategory = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("RoomsCategory");
                OnRoomsCategoryChanged();
            }
        }
        private global::System.String _RoomsCategory;
        partial void OnRoomsCategoryChanging(global::System.String value);
        partial void OnRoomsCategoryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime AddedDate
        {
            get
            {
                return _AddedDate;
            }
            set
            {
                OnAddedDateChanging(value);
                ReportPropertyChanging("AddedDate");
                _AddedDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("AddedDate");
                OnAddedDateChanged();
            }
        }
        private global::System.DateTime _AddedDate;
        partial void OnAddedDateChanging(global::System.DateTime value);
        partial void OnAddedDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 StarLevel
        {
            get
            {
                return _StarLevel;
            }
            set
            {
                OnStarLevelChanging(value);
                ReportPropertyChanging("StarLevel");
                _StarLevel = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("StarLevel");
                OnStarLevelChanged();
            }
        }
        private global::System.Int32 _StarLevel;
        partial void OnStarLevelChanging(global::System.Int32 value);
        partial void OnStarLevelChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 FloorCount
        {
            get
            {
                return _FloorCount;
            }
            set
            {
                OnFloorCountChanging(value);
                ReportPropertyChanging("FloorCount");
                _FloorCount = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("FloorCount");
                OnFloorCountChanged();
            }
        }
        private global::System.Int32 _FloorCount;
        partial void OnFloorCountChanging(global::System.Int32 value);
        partial void OnFloorCountChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Resort_ID
        {
            get
            {
                return _Resort_ID;
            }
            set
            {
                OnResort_IDChanging(value);
                ReportPropertyChanging("Resort_ID");
                _Resort_ID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Resort_ID");
                OnResort_IDChanged();
            }
        }
        private Nullable<global::System.Int32> _Resort_ID;
        partial void OnResort_IDChanging(Nullable<global::System.Int32> value);
        partial void OnResort_IDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> NearestHotel_ID
        {
            get
            {
                return _NearestHotel_ID;
            }
            set
            {
                OnNearestHotel_IDChanging(value);
                ReportPropertyChanging("NearestHotel_ID");
                _NearestHotel_ID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("NearestHotel_ID");
                OnNearestHotel_IDChanged();
            }
        }
        private Nullable<global::System.Int32> _NearestHotel_ID;
        partial void OnNearestHotel_IDChanging(Nullable<global::System.Int32> value);
        partial void OnNearestHotel_IDChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("FastTravelModel", "FK_RelatredHotel", "Hotel1")]
        public EntityCollection<Hotel> Hotel1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Hotel>("FastTravelModel.FK_RelatredHotel", "Hotel1");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Hotel>("FastTravelModel.FK_RelatredHotel", "Hotel1", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("FastTravelModel", "FK_RelatredHotel", "Hotel")]
        public Hotel Hotel2
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Hotel>("FastTravelModel.FK_RelatredHotel", "Hotel").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Hotel>("FastTravelModel.FK_RelatredHotel", "Hotel").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Hotel> Hotel2Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Hotel>("FastTravelModel.FK_RelatredHotel", "Hotel");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Hotel>("FastTravelModel.FK_RelatredHotel", "Hotel", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
