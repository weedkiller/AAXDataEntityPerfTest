﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 2/4/2021 7:24:30 AM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for AssetMaintenanceStopSingle in the schema.
        /// </summary>
    public partial class AssetMaintenanceStopSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceStop>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceStopSingle object.
        /// </summary>
        public AssetMaintenanceStopSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceStopSingle object.
        /// </summary>
        public AssetMaintenanceStopSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceStopSingle object.
        /// </summary>
        public AssetMaintenanceStopSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceStop> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceStopObject in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceStopObject> AssetMaintenanceStopObject
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceStopObject == null))
                {
                    this._AssetMaintenanceStopObject = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceStopObject>(GetPath("AssetMaintenanceStopObject"));
                }
                return this._AssetMaintenanceStopObject;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceStopObject> _AssetMaintenanceStopObject;
    }
        /// <summary>
        /// There are no comments for AssetMaintenanceStop in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// MaintenanceStopId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "MaintenanceStopId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceStops")]
    public partial class AssetMaintenanceStop : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceStop object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="maintenanceStopId">Initial value of MaintenanceStopId.</param>
        /// <param name="fromDateTime">Initial value of FromDateTime.</param>
        /// <param name="toDateTime">Initial value of ToDateTime.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceStop CreateAssetMaintenanceStop(string dataAreaId, string maintenanceStopId, global::System.DateTimeOffset fromDateTime, global::System.DateTimeOffset toDateTime)
        {
            AssetMaintenanceStop assetMaintenanceStop = new AssetMaintenanceStop();
            assetMaintenanceStop.dataAreaId = dataAreaId;
            assetMaintenanceStop.MaintenanceStopId = maintenanceStopId;
            assetMaintenanceStop.FromDateTime = fromDateTime;
            assetMaintenanceStop.ToDateTime = toDateTime;
            return assetMaintenanceStop;
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
        /// There are no comments for Property MaintenanceStopId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MaintenanceStopId
        {
            get
            {
                return this._MaintenanceStopId;
            }
            set
            {
                this.OnMaintenanceStopIdChanging(value);
                this._MaintenanceStopId = value;
                this.OnMaintenanceStopIdChanged();
                this.OnPropertyChanged("MaintenanceStopId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MaintenanceStopId;
        partial void OnMaintenanceStopIdChanging(string value);
        partial void OnMaintenanceStopIdChanged();
        /// <summary>
        /// There are no comments for Property FromDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset FromDateTime
        {
            get
            {
                return this._FromDateTime;
            }
            set
            {
                this.OnFromDateTimeChanging(value);
                this._FromDateTime = value;
                this.OnFromDateTimeChanged();
                this.OnPropertyChanged("FromDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _FromDateTime;
        partial void OnFromDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnFromDateTimeChanged();
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
        /// There are no comments for Property ToDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ToDateTime
        {
            get
            {
                return this._ToDateTime;
            }
            set
            {
                this.OnToDateTimeChanging(value);
                this._ToDateTime = value;
                this.OnToDateTimeChanged();
                this.OnPropertyChanged("ToDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ToDateTime;
        partial void OnToDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnToDateTimeChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceStopObject in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceStopObject> AssetMaintenanceStopObject
        {
            get
            {
                return this._AssetMaintenanceStopObject;
            }
            set
            {
                this.OnAssetMaintenanceStopObjectChanging(value);
                this._AssetMaintenanceStopObject = value;
                this.OnAssetMaintenanceStopObjectChanged();
                this.OnPropertyChanged("AssetMaintenanceStopObject");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceStopObject> _AssetMaintenanceStopObject = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceStopObject>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceStopObjectChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceStopObject> value);
        partial void OnAssetMaintenanceStopObjectChanged();
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
