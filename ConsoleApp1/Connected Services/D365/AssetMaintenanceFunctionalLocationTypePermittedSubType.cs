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
    /// There are no comments for AssetMaintenanceFunctionalLocationTypePermittedSubTypeSingle in the schema.
    /// </summary>
    public partial class AssetMaintenanceFunctionalLocationTypePermittedSubTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceFunctionalLocationTypePermittedSubType>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceFunctionalLocationTypePermittedSubTypeSingle object.
        /// </summary>
        public AssetMaintenanceFunctionalLocationTypePermittedSubTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceFunctionalLocationTypePermittedSubTypeSingle object.
        /// </summary>
        public AssetMaintenanceFunctionalLocationTypePermittedSubTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceFunctionalLocationTypePermittedSubTypeSingle object.
        /// </summary>
        public AssetMaintenanceFunctionalLocationTypePermittedSubTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceFunctionalLocationTypePermittedSubType> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceFunctionalLocationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeSingle AssetMaintenanceFunctionalLocationType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceFunctionalLocationType == null))
                {
                    this._AssetMaintenanceFunctionalLocationType = new global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeSingle(this.Context, GetPath("AssetMaintenanceFunctionalLocationType"));
                }
                return this._AssetMaintenanceFunctionalLocationType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationTypeSingle _AssetMaintenanceFunctionalLocationType;
    }
    /// <summary>
    /// There are no comments for AssetMaintenanceFunctionalLocationTypePermittedSubType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// FunctionalLocationTypeId
    /// PermittedFunctionalLocationTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "FunctionalLocationTypeId", "PermittedFunctionalLocationTypeId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceFunctionalLocationTypePermittedSubTypes")]
    public partial class AssetMaintenanceFunctionalLocationTypePermittedSubType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceFunctionalLocationTypePermittedSubType object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="functionalLocationTypeId">Initial value of FunctionalLocationTypeId.</param>
        /// <param name="permittedFunctionalLocationTypeId">Initial value of PermittedFunctionalLocationTypeId.</param>
        /// <param name="assetMaintenanceFunctionalLocationType">Initial value of AssetMaintenanceFunctionalLocationType.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceFunctionalLocationTypePermittedSubType CreateAssetMaintenanceFunctionalLocationTypePermittedSubType(string dataAreaId, string functionalLocationTypeId, string permittedFunctionalLocationTypeId, global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationType assetMaintenanceFunctionalLocationType)
        {
            AssetMaintenanceFunctionalLocationTypePermittedSubType assetMaintenanceFunctionalLocationTypePermittedSubType = new AssetMaintenanceFunctionalLocationTypePermittedSubType();
            assetMaintenanceFunctionalLocationTypePermittedSubType.dataAreaId = dataAreaId;
            assetMaintenanceFunctionalLocationTypePermittedSubType.FunctionalLocationTypeId = functionalLocationTypeId;
            assetMaintenanceFunctionalLocationTypePermittedSubType.PermittedFunctionalLocationTypeId = permittedFunctionalLocationTypeId;
            if ((assetMaintenanceFunctionalLocationType == null))
            {
                throw new global::System.ArgumentNullException("assetMaintenanceFunctionalLocationType");
            }
            assetMaintenanceFunctionalLocationTypePermittedSubType.AssetMaintenanceFunctionalLocationType = assetMaintenanceFunctionalLocationType;
            return assetMaintenanceFunctionalLocationTypePermittedSubType;
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
        /// There are no comments for Property FunctionalLocationTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FunctionalLocationTypeId
        {
            get
            {
                return this._FunctionalLocationTypeId;
            }
            set
            {
                this.OnFunctionalLocationTypeIdChanging(value);
                this._FunctionalLocationTypeId = value;
                this.OnFunctionalLocationTypeIdChanged();
                this.OnPropertyChanged("FunctionalLocationTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FunctionalLocationTypeId;
        partial void OnFunctionalLocationTypeIdChanging(string value);
        partial void OnFunctionalLocationTypeIdChanged();
        /// <summary>
        /// There are no comments for Property PermittedFunctionalLocationTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PermittedFunctionalLocationTypeId
        {
            get
            {
                return this._PermittedFunctionalLocationTypeId;
            }
            set
            {
                this.OnPermittedFunctionalLocationTypeIdChanging(value);
                this._PermittedFunctionalLocationTypeId = value;
                this.OnPermittedFunctionalLocationTypeIdChanged();
                this.OnPropertyChanged("PermittedFunctionalLocationTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PermittedFunctionalLocationTypeId;
        partial void OnPermittedFunctionalLocationTypeIdChanging(string value);
        partial void OnPermittedFunctionalLocationTypeIdChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceFunctionalLocationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationType AssetMaintenanceFunctionalLocationType
        {
            get
            {
                return this._AssetMaintenanceFunctionalLocationType;
            }
            set
            {
                this.OnAssetMaintenanceFunctionalLocationTypeChanging(value);
                this._AssetMaintenanceFunctionalLocationType = value;
                this.OnAssetMaintenanceFunctionalLocationTypeChanged();
                this.OnPropertyChanged("AssetMaintenanceFunctionalLocationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationType _AssetMaintenanceFunctionalLocationType;
        partial void OnAssetMaintenanceFunctionalLocationTypeChanging(global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationType value);
        partial void OnAssetMaintenanceFunctionalLocationTypeChanged();
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
