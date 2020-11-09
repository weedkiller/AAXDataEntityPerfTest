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
        /// There are no comments for AssetMaintenanceWorkOrderLifecycleModelSingle in the schema.
        /// </summary>
    public partial class AssetMaintenanceWorkOrderLifecycleModelSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceWorkOrderLifecycleModel>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceWorkOrderLifecycleModelSingle object.
        /// </summary>
        public AssetMaintenanceWorkOrderLifecycleModelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceWorkOrderLifecycleModelSingle object.
        /// </summary>
        public AssetMaintenanceWorkOrderLifecycleModelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceWorkOrderLifecycleModelSingle object.
        /// </summary>
        public AssetMaintenanceWorkOrderLifecycleModelSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceWorkOrderLifecycleModel> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceWorkOrderLifecycleModelState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleModelState> AssetMaintenanceWorkOrderLifecycleModelState
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceWorkOrderLifecycleModelState == null))
                {
                    this._AssetMaintenanceWorkOrderLifecycleModelState = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleModelState>(GetPath("AssetMaintenanceWorkOrderLifecycleModelState"));
                }
                return this._AssetMaintenanceWorkOrderLifecycleModelState;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleModelState> _AssetMaintenanceWorkOrderLifecycleModelState;
    }
        /// <summary>
        /// There are no comments for AssetMaintenanceWorkOrderLifecycleModel in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// LifecycleModelId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LifecycleModelId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceWorkOrderLifecycleModels")]
    public partial class AssetMaintenanceWorkOrderLifecycleModel : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceWorkOrderLifecycleModel object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="lifecycleModelId">Initial value of LifecycleModelId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceWorkOrderLifecycleModel CreateAssetMaintenanceWorkOrderLifecycleModel(string dataAreaId, string lifecycleModelId)
        {
            AssetMaintenanceWorkOrderLifecycleModel assetMaintenanceWorkOrderLifecycleModel = new AssetMaintenanceWorkOrderLifecycleModel();
            assetMaintenanceWorkOrderLifecycleModel.dataAreaId = dataAreaId;
            assetMaintenanceWorkOrderLifecycleModel.LifecycleModelId = lifecycleModelId;
            return assetMaintenanceWorkOrderLifecycleModel;
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
        /// There are no comments for Property LifecycleModelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LifecycleModelId
        {
            get
            {
                return this._LifecycleModelId;
            }
            set
            {
                this.OnLifecycleModelIdChanging(value);
                this._LifecycleModelId = value;
                this.OnLifecycleModelIdChanged();
                this.OnPropertyChanged("LifecycleModelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LifecycleModelId;
        partial void OnLifecycleModelIdChanging(string value);
        partial void OnLifecycleModelIdChanged();
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
        /// There are no comments for Property ScheduledLifecycleStateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ScheduledLifecycleStateId
        {
            get
            {
                return this._ScheduledLifecycleStateId;
            }
            set
            {
                this.OnScheduledLifecycleStateIdChanging(value);
                this._ScheduledLifecycleStateId = value;
                this.OnScheduledLifecycleStateIdChanged();
                this.OnPropertyChanged("ScheduledLifecycleStateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ScheduledLifecycleStateId;
        partial void OnScheduledLifecycleStateIdChanging(string value);
        partial void OnScheduledLifecycleStateIdChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceWorkOrderLifecycleModelState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleModelState> AssetMaintenanceWorkOrderLifecycleModelState
        {
            get
            {
                return this._AssetMaintenanceWorkOrderLifecycleModelState;
            }
            set
            {
                this.OnAssetMaintenanceWorkOrderLifecycleModelStateChanging(value);
                this._AssetMaintenanceWorkOrderLifecycleModelState = value;
                this.OnAssetMaintenanceWorkOrderLifecycleModelStateChanged();
                this.OnPropertyChanged("AssetMaintenanceWorkOrderLifecycleModelState");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleModelState> _AssetMaintenanceWorkOrderLifecycleModelState = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleModelState>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceWorkOrderLifecycleModelStateChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderLifecycleModelState> value);
        partial void OnAssetMaintenanceWorkOrderLifecycleModelStateChanged();
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
