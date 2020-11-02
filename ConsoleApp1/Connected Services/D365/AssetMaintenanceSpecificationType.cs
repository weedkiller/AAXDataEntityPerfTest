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
    /// There are no comments for AssetMaintenanceSpecificationTypeSingle in the schema.
    /// </summary>
    public partial class AssetMaintenanceSpecificationTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceSpecificationType>
    {
        /// <summary>
        /// Initialize a new AssetMaintenanceSpecificationTypeSingle object.
        /// </summary>
        public AssetMaintenanceSpecificationTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceSpecificationTypeSingle object.
        /// </summary>
        public AssetMaintenanceSpecificationTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetMaintenanceSpecificationTypeSingle object.
        /// </summary>
        public AssetMaintenanceSpecificationTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetMaintenanceSpecificationType> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetMaintenanceAssetAttribute in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetAttribute> AssetMaintenanceAssetAttribute
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAssetAttribute == null))
                {
                    this._AssetMaintenanceAssetAttribute = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetAttribute>(GetPath("AssetMaintenanceAssetAttribute"));
                }
                return this._AssetMaintenanceAssetAttribute;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetAttribute> _AssetMaintenanceAssetAttribute;
        /// <summary>
        /// There are no comments for AssetMaintenanceAssetTypeAttribute in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeAttribute> AssetMaintenanceAssetTypeAttribute
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceAssetTypeAttribute == null))
                {
                    this._AssetMaintenanceAssetTypeAttribute = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeAttribute>(GetPath("AssetMaintenanceAssetTypeAttribute"));
                }
                return this._AssetMaintenanceAssetTypeAttribute;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeAttribute> _AssetMaintenanceAssetTypeAttribute;
        /// <summary>
        /// There are no comments for AssetMaintenanceFunctionalLocationAttribute in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationAttribute> AssetMaintenanceFunctionalLocationAttribute
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceFunctionalLocationAttribute == null))
                {
                    this._AssetMaintenanceFunctionalLocationAttribute = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationAttribute>(GetPath("AssetMaintenanceFunctionalLocationAttribute"));
                }
                return this._AssetMaintenanceFunctionalLocationAttribute;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationAttribute> _AssetMaintenanceFunctionalLocationAttribute;
        /// <summary>
        /// There are no comments for AssetMaintenanceFunctionalLocationAttributeSpecification in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationAttributeSpecification> AssetMaintenanceFunctionalLocationAttributeSpecification
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetMaintenanceFunctionalLocationAttributeSpecification == null))
                {
                    this._AssetMaintenanceFunctionalLocationAttributeSpecification = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationAttributeSpecification>(GetPath("AssetMaintenanceFunctionalLocationAttributeSpecification"));
                }
                return this._AssetMaintenanceFunctionalLocationAttributeSpecification;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationAttributeSpecification> _AssetMaintenanceFunctionalLocationAttributeSpecification;
    }
    /// <summary>
    /// There are no comments for AssetMaintenanceSpecificationType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// AttributeTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "AttributeTypeId")]
    [global::Microsoft.OData.Client.EntitySet("AssetMaintenanceSpecificationTypes")]
    public partial class AssetMaintenanceSpecificationType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetMaintenanceSpecificationType object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="attributeTypeId">Initial value of AttributeTypeId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetMaintenanceSpecificationType CreateAssetMaintenanceSpecificationType(string dataAreaId, string attributeTypeId)
        {
            AssetMaintenanceSpecificationType assetMaintenanceSpecificationType = new AssetMaintenanceSpecificationType();
            assetMaintenanceSpecificationType.dataAreaId = dataAreaId;
            assetMaintenanceSpecificationType.AttributeTypeId = attributeTypeId;
            return assetMaintenanceSpecificationType;
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
        /// There are no comments for Property AttributeTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AttributeTypeId
        {
            get
            {
                return this._AttributeTypeId;
            }
            set
            {
                this.OnAttributeTypeIdChanging(value);
                this._AttributeTypeId = value;
                this.OnAttributeTypeIdChanged();
                this.OnPropertyChanged("AttributeTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AttributeTypeId;
        partial void OnAttributeTypeIdChanging(string value);
        partial void OnAttributeTypeIdChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property DataType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetConditionType> DataType
        {
            get
            {
                return this._DataType;
            }
            set
            {
                this.OnDataTypeChanging(value);
                this._DataType = value;
                this.OnDataTypeChanged();
                this.OnPropertyChanged("DataType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetConditionType> _DataType;
        partial void OnDataTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EntAssetConditionType> value);
        partial void OnDataTypeChanged();
        /// <summary>
        /// There are no comments for Property UnitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string UnitId
        {
            get
            {
                return this._UnitId;
            }
            set
            {
                this.OnUnitIdChanging(value);
                this._UnitId = value;
                this.OnUnitIdChanged();
                this.OnPropertyChanged("UnitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitId;
        partial void OnUnitIdChanging(string value);
        partial void OnUnitIdChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceAssetAttribute in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetAttribute> AssetMaintenanceAssetAttribute
        {
            get
            {
                return this._AssetMaintenanceAssetAttribute;
            }
            set
            {
                this.OnAssetMaintenanceAssetAttributeChanging(value);
                this._AssetMaintenanceAssetAttribute = value;
                this.OnAssetMaintenanceAssetAttributeChanged();
                this.OnPropertyChanged("AssetMaintenanceAssetAttribute");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetAttribute> _AssetMaintenanceAssetAttribute = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetAttribute>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceAssetAttributeChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetAttribute> value);
        partial void OnAssetMaintenanceAssetAttributeChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceAssetTypeAttribute in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeAttribute> AssetMaintenanceAssetTypeAttribute
        {
            get
            {
                return this._AssetMaintenanceAssetTypeAttribute;
            }
            set
            {
                this.OnAssetMaintenanceAssetTypeAttributeChanging(value);
                this._AssetMaintenanceAssetTypeAttribute = value;
                this.OnAssetMaintenanceAssetTypeAttributeChanged();
                this.OnPropertyChanged("AssetMaintenanceAssetTypeAttribute");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeAttribute> _AssetMaintenanceAssetTypeAttribute = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeAttribute>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceAssetTypeAttributeChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceAssetTypeAttribute> value);
        partial void OnAssetMaintenanceAssetTypeAttributeChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceFunctionalLocationAttribute in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationAttribute> AssetMaintenanceFunctionalLocationAttribute
        {
            get
            {
                return this._AssetMaintenanceFunctionalLocationAttribute;
            }
            set
            {
                this.OnAssetMaintenanceFunctionalLocationAttributeChanging(value);
                this._AssetMaintenanceFunctionalLocationAttribute = value;
                this.OnAssetMaintenanceFunctionalLocationAttributeChanged();
                this.OnPropertyChanged("AssetMaintenanceFunctionalLocationAttribute");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationAttribute> _AssetMaintenanceFunctionalLocationAttribute = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationAttribute>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceFunctionalLocationAttributeChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationAttribute> value);
        partial void OnAssetMaintenanceFunctionalLocationAttributeChanged();
        /// <summary>
        /// There are no comments for Property AssetMaintenanceFunctionalLocationAttributeSpecification in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationAttributeSpecification> AssetMaintenanceFunctionalLocationAttributeSpecification
        {
            get
            {
                return this._AssetMaintenanceFunctionalLocationAttributeSpecification;
            }
            set
            {
                this.OnAssetMaintenanceFunctionalLocationAttributeSpecificationChanging(value);
                this._AssetMaintenanceFunctionalLocationAttributeSpecification = value;
                this.OnAssetMaintenanceFunctionalLocationAttributeSpecificationChanged();
                this.OnPropertyChanged("AssetMaintenanceFunctionalLocationAttributeSpecification");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationAttributeSpecification> _AssetMaintenanceFunctionalLocationAttributeSpecification = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationAttributeSpecification>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetMaintenanceFunctionalLocationAttributeSpecificationChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetMaintenanceFunctionalLocationAttributeSpecification> value);
        partial void OnAssetMaintenanceFunctionalLocationAttributeSpecificationChanged();
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
