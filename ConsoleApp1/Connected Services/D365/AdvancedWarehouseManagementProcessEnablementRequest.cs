﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 9/11/2020 3:24:26 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for AdvancedWarehouseManagementProcessEnablementRequestSingle in the schema.
    /// </summary>
    public partial class AdvancedWarehouseManagementProcessEnablementRequestSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AdvancedWarehouseManagementProcessEnablementRequest>
    {
        /// <summary>
        /// Initialize a new AdvancedWarehouseManagementProcessEnablementRequestSingle object.
        /// </summary>
        public AdvancedWarehouseManagementProcessEnablementRequestSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AdvancedWarehouseManagementProcessEnablementRequestSingle object.
        /// </summary>
        public AdvancedWarehouseManagementProcessEnablementRequestSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AdvancedWarehouseManagementProcessEnablementRequestSingle object.
        /// </summary>
        public AdvancedWarehouseManagementProcessEnablementRequestSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AdvancedWarehouseManagementProcessEnablementRequest> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for AdvancedWarehouseManagementProcessEnablementRequest in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// WarehouseId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "WarehouseId")]
    [global::Microsoft.OData.Client.EntitySet("AdvancedWarehouseManagementProcessEnablementRequests")]
    public partial class AdvancedWarehouseManagementProcessEnablementRequest : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AdvancedWarehouseManagementProcessEnablementRequest object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="warehouseId">Initial value of WarehouseId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AdvancedWarehouseManagementProcessEnablementRequest CreateAdvancedWarehouseManagementProcessEnablementRequest(string dataAreaId, string warehouseId)
        {
            AdvancedWarehouseManagementProcessEnablementRequest advancedWarehouseManagementProcessEnablementRequest = new AdvancedWarehouseManagementProcessEnablementRequest();
            advancedWarehouseManagementProcessEnablementRequest.dataAreaId = dataAreaId;
            advancedWarehouseManagementProcessEnablementRequest.WarehouseId = warehouseId;
            return advancedWarehouseManagementProcessEnablementRequest;
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
        /// There are no comments for Property WarehouseId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WarehouseId
        {
            get
            {
                return this._WarehouseId;
            }
            set
            {
                this.OnWarehouseIdChanging(value);
                this._WarehouseId = value;
                this.OnWarehouseIdChanged();
                this.OnPropertyChanged("WarehouseId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WarehouseId;
        partial void OnWarehouseIdChanging(string value);
        partial void OnWarehouseIdChanged();
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
