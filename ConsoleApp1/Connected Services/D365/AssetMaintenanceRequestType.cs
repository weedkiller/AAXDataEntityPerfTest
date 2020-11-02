﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 10/4/2020 2:24:13 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for AssetMaintenanceRequestTypeSingle in the schema.
    /// </summary>
    public partial class AssetMaintenanceRequestTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceRequestType>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceRequestTypeSingle object.
        /// </summary>
        public AssetMaintenanceRequestTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceRequestTypeSingle object.
        /// </summary>
        public AssetMaintenanceRequestTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceRequestTypeSingle object.
        /// </summary>
        public AssetMaintenanceRequestTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceRequestType> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceRequestLifecycleModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleModelSingle AssetMaintenanceRequestLifecycleModel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceRequestLifecycleModel == null))
                {
                    this._AssetMaintenanceRequestLifecycleModel = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleModelSingle(this.Context, GetPath("AssetMaintenanceRequestLifecycleModel"));
                }
                return this._AssetMaintenanceRequestLifecycleModel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleModelSingle _AssetMaintenanceRequestLifecycleModel;
        /// <summary>
        /// There are no comments for AssetMaintenanceWorkOrderType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderTypeSingle AssetMaintenanceWorkOrderType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceWorkOrderType == null))
                {
                    this._AssetMaintenanceWorkOrderType = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderTypeSingle(this.Context, GetPath("AssetMaintenanceWorkOrderType"));
                }
                return this._AssetMaintenanceWorkOrderType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderTypeSingle _AssetMaintenanceWorkOrderType;
    }
    /// <summary>
    /// There are no comments for AssetMaintenanceRequestType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// RequestTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RequestTypeId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceRequestTypes")]
    public partial class AssetMaintenanceRequestType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceRequestType object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="requestTypeId">Initial value of RequestTypeId.</param>
        /// <param name="assetMaintenanceRequestLifecycleModel">Initial value of AssetMaintenanceRequestLifecycleModel.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceRequestType CreateAssetMaintenanceRequestType(string dataAreaId, string requestTypeId, global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleModel assetMaintenanceRequestLifecycleModel)
        {
            AssetMaintenanceRequestType assetMaintenanceRequestType = new AssetMaintenanceRequestType();
            assetMaintenanceRequestType.dataAreaId = dataAreaId;
            assetMaintenanceRequestType.RequestTypeId = requestTypeId;
            if ((assetMaintenanceRequestLifecycleModel == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceRequestLifecycleModel");
            }
            assetMaintenanceRequestType.AssetMaintenanceRequestLifecycleModel = assetMaintenanceRequestLifecycleModel;
            return assetMaintenanceRequestType;
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
        /// There are no comments for Property RequestTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RequestTypeId
        {
            get
            {
                return this._RequestTypeId;
            }
            set
            {
                this.OnRequestTypeIdChanging(value);
                this._RequestTypeId = value;
                this.OnRequestTypeIdChanged();
                this.OnPropertyChanged("RequestTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RequestTypeId;
        partial void OnRequestTypeIdChanging(string value);
        partial void OnRequestTypeIdChanged();
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
        /// There are no comments for Property RequestLifecycleModelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RequestLifecycleModelId
        {
            get
            {
                return this._RequestLifecycleModelId;
            }
            set
            {
                this.OnRequestLifecycleModelIdChanging(value);
                this._RequestLifecycleModelId = value;
                this.OnRequestLifecycleModelIdChanged();
                this.OnPropertyChanged("RequestLifecycleModelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RequestLifecycleModelId;
        partial void OnRequestLifecycleModelIdChanging(string value);
        partial void OnRequestLifecycleModelIdChanged();
        /// <summary>
        /// There are no comments for Property WorkOrderTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WorkOrderTypeId
        {
            get
            {
                return this._WorkOrderTypeId;
            }
            set
            {
                this.OnWorkOrderTypeIdChanging(value);
                this._WorkOrderTypeId = value;
                this.OnWorkOrderTypeIdChanged();
                this.OnPropertyChanged("WorkOrderTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkOrderTypeId;
        partial void OnWorkOrderTypeIdChanging(string value);
        partial void OnWorkOrderTypeIdChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceRequestLifecycleModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleModel AssetMaintenanceRequestLifecycleModel
        {
            get
            {
                return this._AssetMaintenanceRequestLifecycleModel;
            }
            set
            {
                this.OnAssetMaintenanceRequestLifecycleModelChanging(value);
                this._AssetMaintenanceRequestLifecycleModel = value;
                this.OnAssetMaintenanceRequestLifecycleModelChanged();
                this.OnPropertyChanged("AssetMaintenanceRequestLifecycleModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleModel _AssetMaintenanceRequestLifecycleModel;
        partial void OnAssetMaintenanceRequestLifecycleModelChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceRequestLifecycleModel value);
        partial void OnAssetMaintenanceRequestLifecycleModelChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceWorkOrderType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderType AssetMaintenanceWorkOrderType
        {
            get
            {
                return this._AssetMaintenanceWorkOrderType;
            }
            set
            {
                this.OnAssetMaintenanceWorkOrderTypeChanging(value);
                this._AssetMaintenanceWorkOrderType = value;
                this.OnAssetMaintenanceWorkOrderTypeChanged();
                this.OnPropertyChanged("AssetMaintenanceWorkOrderType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderType _AssetMaintenanceWorkOrderType;
        partial void OnAssetMaintenanceWorkOrderTypeChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceWorkOrderType value);
        partial void OnAssetMaintenanceWorkOrderTypeChanged();
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
