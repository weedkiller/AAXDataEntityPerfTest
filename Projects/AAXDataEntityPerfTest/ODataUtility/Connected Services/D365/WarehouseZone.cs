﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 11/8/2020 8:07:52 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for WarehouseZoneSingle in the schema.
        /// </summary>
    public partial class WarehouseZoneSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WarehouseZone>
    {
        /// <summary>
        /// Initialize a new WarehouseZoneSingle object.
        /// </summary>
        public WarehouseZoneSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WarehouseZoneSingle object.
        /// </summary>
        public WarehouseZoneSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WarehouseZoneSingle object.
        /// </summary>
        public WarehouseZoneSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WarehouseZone> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for WarehouseZoneGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WarehouseZoneGroupSingle WarehouseZoneGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WarehouseZoneGroup == null))
                {
                    this._WarehouseZoneGroup = new global::Microsoft.Dynamics.DataEntities.WarehouseZoneGroupSingle(this.Context, GetPath("WarehouseZoneGroup"));
                }
                return this._WarehouseZoneGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WarehouseZoneGroupSingle _WarehouseZoneGroup;
        /// <summary>
        /// There are no comments for SecondAdditionalZoneWarehouseLocations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WarehouseLocation> SecondAdditionalZoneWarehouseLocations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SecondAdditionalZoneWarehouseLocations == null))
                {
                    this._SecondAdditionalZoneWarehouseLocations = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WarehouseLocation>(GetPath("SecondAdditionalZoneWarehouseLocations"));
                }
                return this._SecondAdditionalZoneWarehouseLocations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WarehouseLocation> _SecondAdditionalZoneWarehouseLocations;
        /// <summary>
        /// There are no comments for FirstAdditionalZoneWarehouseLocations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WarehouseLocation> FirstAdditionalZoneWarehouseLocations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FirstAdditionalZoneWarehouseLocations == null))
                {
                    this._FirstAdditionalZoneWarehouseLocations = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WarehouseLocation>(GetPath("FirstAdditionalZoneWarehouseLocations"));
                }
                return this._FirstAdditionalZoneWarehouseLocations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WarehouseLocation> _FirstAdditionalZoneWarehouseLocations;
        /// <summary>
        /// There are no comments for ThirdAdditionalZoneWarehouseLocations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WarehouseLocation> ThirdAdditionalZoneWarehouseLocations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ThirdAdditionalZoneWarehouseLocations == null))
                {
                    this._ThirdAdditionalZoneWarehouseLocations = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WarehouseLocation>(GetPath("ThirdAdditionalZoneWarehouseLocations"));
                }
                return this._ThirdAdditionalZoneWarehouseLocations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WarehouseLocation> _ThirdAdditionalZoneWarehouseLocations;
        /// <summary>
        /// There are no comments for WarehouseLocations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WarehouseLocation> WarehouseLocations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WarehouseLocations == null))
                {
                    this._WarehouseLocations = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WarehouseLocation>(GetPath("WarehouseLocations"));
                }
                return this._WarehouseLocations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WarehouseLocation> _WarehouseLocations;
    }
        /// <summary>
        /// There are no comments for WarehouseZone in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ZoneId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ZoneId")]
    [global::Microsoft.OData.Client.EntitySet("WarehouseZones")]
    public partial class WarehouseZone : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WarehouseZone object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="zoneId">Initial value of ZoneId.</param>
        /// <param name="warehouseZoneGroup">Initial value of WarehouseZoneGroup.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WarehouseZone CreateWarehouseZone(string dataAreaId, string zoneId, global::Microsoft.Dynamics.DataEntities.WarehouseZoneGroup warehouseZoneGroup)
        {
            WarehouseZone warehouseZone = new WarehouseZone();
            warehouseZone.dataAreaId = dataAreaId;
            warehouseZone.ZoneId = zoneId;
            if ((warehouseZoneGroup == null))
            {
                throw new global::System.ArgumentNullException("warehouseZoneGroup");
            }
            warehouseZone.WarehouseZoneGroup = warehouseZoneGroup;
            return warehouseZone;
        }
        /// <summary>
        /// There are no comments for Property dataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string dataAreaId
        {
            get
            {
                return this._dataAreaId;
            }
            set
            {
                this.OndataAreaIdChanging(value);
                this._dataAreaId = value;
                this.OndataAreaIdChanged();
                this.OnPropertyChanged("dataAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _dataAreaId;
        partial void OndataAreaIdChanging(string value);
        partial void OndataAreaIdChanged();
        /// <summary>
        /// There are no comments for Property ZoneId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ZoneId
        {
            get
            {
                return this._ZoneId;
            }
            set
            {
                this.OnZoneIdChanging(value);
                this._ZoneId = value;
                this.OnZoneIdChanged();
                this.OnPropertyChanged("ZoneId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ZoneId;
        partial void OnZoneIdChanging(string value);
        partial void OnZoneIdChanged();
        /// <summary>
        /// There are no comments for Property ZoneName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ZoneName
        {
            get
            {
                return this._ZoneName;
            }
            set
            {
                this.OnZoneNameChanging(value);
                this._ZoneName = value;
                this.OnZoneNameChanged();
                this.OnPropertyChanged("ZoneName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ZoneName;
        partial void OnZoneNameChanging(string value);
        partial void OnZoneNameChanged();
        /// <summary>
        /// There are no comments for Property WarehouseZoneGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WarehouseZoneGroupId
        {
            get
            {
                return this._WarehouseZoneGroupId;
            }
            set
            {
                this.OnWarehouseZoneGroupIdChanging(value);
                this._WarehouseZoneGroupId = value;
                this.OnWarehouseZoneGroupIdChanged();
                this.OnPropertyChanged("WarehouseZoneGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WarehouseZoneGroupId;
        partial void OnWarehouseZoneGroupIdChanging(string value);
        partial void OnWarehouseZoneGroupIdChanged();
        /// <summary>
        /// There are no comments for Property WarehouseZoneGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WarehouseZoneGroup WarehouseZoneGroup
        {
            get
            {
                return this._WarehouseZoneGroup;
            }
            set
            {
                this.OnWarehouseZoneGroupChanging(value);
                this._WarehouseZoneGroup = value;
                this.OnWarehouseZoneGroupChanged();
                this.OnPropertyChanged("WarehouseZoneGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WarehouseZoneGroup _WarehouseZoneGroup;
        partial void OnWarehouseZoneGroupChanging(global::Microsoft.Dynamics.DataEntities.WarehouseZoneGroup value);
        partial void OnWarehouseZoneGroupChanged();
        /// <summary>
        /// There are no comments for Property SecondAdditionalZoneWarehouseLocations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseLocation> SecondAdditionalZoneWarehouseLocations
        {
            get
            {
                return this._SecondAdditionalZoneWarehouseLocations;
            }
            set
            {
                this.OnSecondAdditionalZoneWarehouseLocationsChanging(value);
                this._SecondAdditionalZoneWarehouseLocations = value;
                this.OnSecondAdditionalZoneWarehouseLocationsChanged();
                this.OnPropertyChanged("SecondAdditionalZoneWarehouseLocations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseLocation> _SecondAdditionalZoneWarehouseLocations = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseLocation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnSecondAdditionalZoneWarehouseLocationsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseLocation> value);
        partial void OnSecondAdditionalZoneWarehouseLocationsChanged();
        /// <summary>
        /// There are no comments for Property FirstAdditionalZoneWarehouseLocations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseLocation> FirstAdditionalZoneWarehouseLocations
        {
            get
            {
                return this._FirstAdditionalZoneWarehouseLocations;
            }
            set
            {
                this.OnFirstAdditionalZoneWarehouseLocationsChanging(value);
                this._FirstAdditionalZoneWarehouseLocations = value;
                this.OnFirstAdditionalZoneWarehouseLocationsChanged();
                this.OnPropertyChanged("FirstAdditionalZoneWarehouseLocations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseLocation> _FirstAdditionalZoneWarehouseLocations = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseLocation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnFirstAdditionalZoneWarehouseLocationsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseLocation> value);
        partial void OnFirstAdditionalZoneWarehouseLocationsChanged();
        /// <summary>
        /// There are no comments for Property ThirdAdditionalZoneWarehouseLocations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseLocation> ThirdAdditionalZoneWarehouseLocations
        {
            get
            {
                return this._ThirdAdditionalZoneWarehouseLocations;
            }
            set
            {
                this.OnThirdAdditionalZoneWarehouseLocationsChanging(value);
                this._ThirdAdditionalZoneWarehouseLocations = value;
                this.OnThirdAdditionalZoneWarehouseLocationsChanged();
                this.OnPropertyChanged("ThirdAdditionalZoneWarehouseLocations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseLocation> _ThirdAdditionalZoneWarehouseLocations = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseLocation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnThirdAdditionalZoneWarehouseLocationsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseLocation> value);
        partial void OnThirdAdditionalZoneWarehouseLocationsChanged();
        /// <summary>
        /// There are no comments for Property WarehouseLocations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseLocation> WarehouseLocations
        {
            get
            {
                return this._WarehouseLocations;
            }
            set
            {
                this.OnWarehouseLocationsChanging(value);
                this._WarehouseLocations = value;
                this.OnWarehouseLocationsChanged();
                this.OnPropertyChanged("WarehouseLocations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseLocation> _WarehouseLocations = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseLocation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWarehouseLocationsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WarehouseLocation> value);
        partial void OnWarehouseLocationsChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}