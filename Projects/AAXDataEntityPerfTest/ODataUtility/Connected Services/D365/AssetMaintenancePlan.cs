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
        /// There are no comments for AssetMaintenancePlanSingle in the schema.
        /// </summary>
    public partial class AssetMaintenancePlanSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenancePlan>
    {
        /// <summary>
        /// Initialize a new AssetMaintenancePlanSingle object.
        /// </summary>
        public AssetMaintenancePlanSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenancePlanSingle object.
        /// </summary>
        public AssetMaintenancePlanSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenancePlanSingle object.
        /// </summary>
        public AssetMaintenancePlanSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenancePlan> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceAssetMaintenancePlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetMaintenancePlan> AssetMaintenanceAssetMaintenancePlan
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAssetMaintenancePlan == null))
                {
                    this._AssetMaintenanceAssetMaintenancePlan = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetMaintenancePlan>(GetPath("AssetMaintenanceAssetMaintenancePlan"));
                }
                return this._AssetMaintenanceAssetMaintenancePlan;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetMaintenancePlan> _AssetMaintenanceAssetMaintenancePlan;
        /// <summary>
        /// There are no comments for AssetMaintenanceFunctionalLocationMaintenancePlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationMaintenancePlan> AssetMaintenanceFunctionalLocationMaintenancePlan
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceFunctionalLocationMaintenancePlan == null))
                {
                    this._AssetMaintenanceFunctionalLocationMaintenancePlan = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationMaintenancePlan>(GetPath("AssetMaintenanceFunctionalLocationMaintenancePlan"));
                }
                return this._AssetMaintenanceFunctionalLocationMaintenancePlan;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationMaintenancePlan> _AssetMaintenanceFunctionalLocationMaintenancePlan;
        /// <summary>
        /// There are no comments for AssetMaintenanceAssetCalendar in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar> AssetMaintenanceAssetCalendar
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAssetCalendar == null))
                {
                    this._AssetMaintenanceAssetCalendar = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar>(GetPath("AssetMaintenanceAssetCalendar"));
                }
                return this._AssetMaintenanceAssetCalendar;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar> _AssetMaintenanceAssetCalendar;
        /// <summary>
        /// There are no comments for AssetMaintenanceFunctionalLocationTypeMaintenanceSequense in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeMaintenanceSequense> AssetMaintenanceFunctionalLocationTypeMaintenanceSequense
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceFunctionalLocationTypeMaintenanceSequense == null))
                {
                    this._AssetMaintenanceFunctionalLocationTypeMaintenanceSequense = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeMaintenanceSequense>(GetPath("AssetMaintenanceFunctionalLocationTypeMaintenanceSequense"));
                }
                return this._AssetMaintenanceFunctionalLocationTypeMaintenanceSequense;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeMaintenanceSequense> _AssetMaintenanceFunctionalLocationTypeMaintenanceSequense;
    }
        /// <summary>
        /// There are no comments for AssetMaintenancePlan in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// MaintenancePlanId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "MaintenancePlanId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenancePlans")]
    public partial class AssetMaintenancePlan : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenancePlan object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="maintenancePlanId">Initial value of MaintenancePlanId.</param>
        /// <param name="maintenanceDate">Initial value of MaintenanceDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenancePlan CreateAssetMaintenancePlan(string dataAreaId, string maintenancePlanId, global::System.DateTimeOffset maintenanceDate)
        {
            AssetMaintenancePlan assetMaintenancePlan = new AssetMaintenancePlan();
            assetMaintenancePlan.dataAreaId = dataAreaId;
            assetMaintenancePlan.MaintenancePlanId = maintenancePlanId;
            assetMaintenancePlan.MaintenanceDate = maintenanceDate;
            return assetMaintenancePlan;
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
        /// There are no comments for Property MaintenancePlanId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MaintenancePlanId
        {
            get
            {
                return this._MaintenancePlanId;
            }
            set
            {
                this.OnMaintenancePlanIdChanging(value);
                this._MaintenancePlanId = value;
                this.OnMaintenancePlanIdChanged();
                this.OnPropertyChanged("MaintenancePlanId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MaintenancePlanId;
        partial void OnMaintenancePlanIdChanging(string value);
        partial void OnMaintenancePlanIdChanged();
        /// <summary>
        /// There are no comments for Property MaintenanceDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset MaintenanceDate
        {
            get
            {
                return this._MaintenanceDate;
            }
            set
            {
                this.OnMaintenanceDateChanging(value);
                this._MaintenanceDate = value;
                this.OnMaintenanceDateChanged();
                this.OnPropertyChanged("MaintenanceDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _MaintenanceDate;
        partial void OnMaintenanceDateChanging(global::System.DateTimeOffset value);
        partial void OnMaintenanceDateChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property MaintenancePlanActive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> MaintenancePlanActive
        {
            get
            {
                return this._MaintenancePlanActive;
            }
            set
            {
                this.OnMaintenancePlanActiveChanging(value);
                this._MaintenancePlanActive = value;
                this.OnMaintenancePlanActiveChanged();
                this.OnPropertyChanged("MaintenancePlanActive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _MaintenancePlanActive;
        partial void OnMaintenancePlanActiveChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnMaintenancePlanActiveChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceAssetMaintenancePlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetMaintenancePlan> AssetMaintenanceAssetMaintenancePlan
        {
            get
            {
                return this._AssetMaintenanceAssetMaintenancePlan;
            }
            set
            {
                this.OnAssetMaintenanceAssetMaintenancePlanChanging(value);
                this._AssetMaintenanceAssetMaintenancePlan = value;
                this.OnAssetMaintenanceAssetMaintenancePlanChanged();
                this.OnPropertyChanged("AssetMaintenanceAssetMaintenancePlan");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetMaintenancePlan> _AssetMaintenanceAssetMaintenancePlan = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetMaintenancePlan>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceAssetMaintenancePlanChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetMaintenancePlan> value);
        partial void OnAssetMaintenanceAssetMaintenancePlanChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceFunctionalLocationMaintenancePlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationMaintenancePlan> AssetMaintenanceFunctionalLocationMaintenancePlan
        {
            get
            {
                return this._AssetMaintenanceFunctionalLocationMaintenancePlan;
            }
            set
            {
                this.OnAssetMaintenanceFunctionalLocationMaintenancePlanChanging(value);
                this._AssetMaintenanceFunctionalLocationMaintenancePlan = value;
                this.OnAssetMaintenanceFunctionalLocationMaintenancePlanChanged();
                this.OnPropertyChanged("AssetMaintenanceFunctionalLocationMaintenancePlan");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationMaintenancePlan> _AssetMaintenanceFunctionalLocationMaintenancePlan = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationMaintenancePlan>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceFunctionalLocationMaintenancePlanChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationMaintenancePlan> value);
        partial void OnAssetMaintenanceFunctionalLocationMaintenancePlanChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceAssetCalendar in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar> AssetMaintenanceAssetCalendar
        {
            get
            {
                return this._AssetMaintenanceAssetCalendar;
            }
            set
            {
                this.OnAssetMaintenanceAssetCalendarChanging(value);
                this._AssetMaintenanceAssetCalendar = value;
                this.OnAssetMaintenanceAssetCalendarChanged();
                this.OnPropertyChanged("AssetMaintenanceAssetCalendar");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar> _AssetMaintenanceAssetCalendar = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceAssetCalendarChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetCalendar> value);
        partial void OnAssetMaintenanceAssetCalendarChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceFunctionalLocationTypeMaintenanceSequense in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeMaintenanceSequense> AssetMaintenanceFunctionalLocationTypeMaintenanceSequense
        {
            get
            {
                return this._AssetMaintenanceFunctionalLocationTypeMaintenanceSequense;
            }
            set
            {
                this.OnAssetMaintenanceFunctionalLocationTypeMaintenanceSequenseChanging(value);
                this._AssetMaintenanceFunctionalLocationTypeMaintenanceSequense = value;
                this.OnAssetMaintenanceFunctionalLocationTypeMaintenanceSequenseChanged();
                this.OnPropertyChanged("AssetMaintenanceFunctionalLocationTypeMaintenanceSequense");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeMaintenanceSequense> _AssetMaintenanceFunctionalLocationTypeMaintenanceSequense = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeMaintenanceSequense>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceFunctionalLocationTypeMaintenanceSequenseChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeMaintenanceSequense> value);
        partial void OnAssetMaintenanceFunctionalLocationTypeMaintenanceSequenseChanged();
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
