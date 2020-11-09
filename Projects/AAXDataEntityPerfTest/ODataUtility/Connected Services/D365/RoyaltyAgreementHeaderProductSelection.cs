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
        /// There are no comments for RoyaltyAgreementHeaderProductSelectionSingle in the schema.
        /// </summary>
    public partial class RoyaltyAgreementHeaderProductSelectionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RoyaltyAgreementHeaderProductSelection>
    {
        /// <summary>
        /// Initialize a new RoyaltyAgreementHeaderProductSelectionSingle object.
        /// </summary>
        public RoyaltyAgreementHeaderProductSelectionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RoyaltyAgreementHeaderProductSelectionSingle object.
        /// </summary>
        public RoyaltyAgreementHeaderProductSelectionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RoyaltyAgreementHeaderProductSelectionSingle object.
        /// </summary>
        public RoyaltyAgreementHeaderProductSelectionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RoyaltyAgreementHeaderProductSelection> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RoyaltyAgreementHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeaderSingle RoyaltyAgreementHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RoyaltyAgreementHeader == null))
                {
                    this._RoyaltyAgreementHeader = new global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeaderSingle(this.Context, GetPath("RoyaltyAgreementHeader"));
                }
                return this._RoyaltyAgreementHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeaderSingle _RoyaltyAgreementHeader;
    }
        /// <summary>
        /// There are no comments for RoyaltyAgreementHeaderProductSelection in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// RoyaltyAgreementId
    /// ItemNumber
    /// SalesUnitSymbol
    /// QualifyingSiteId
    /// QualifyingWarehouseId
    /// ProductConfigurationId
    /// ProductColorId
    /// ProductSizeId
    /// ProductStyleId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RoyaltyAgreementId", "ItemNumber", "SalesUnitSymbol", "QualifyingSiteId", "QualifyingWarehouseId", "ProductConfigurationId", "ProductColorId", "ProductSizeId", "ProductStyleId")]
    [global::Microsoft.OData.Client.EntitySet("RoyaltyAgreementHeaderProductSelections")]
    public partial class RoyaltyAgreementHeaderProductSelection : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RoyaltyAgreementHeaderProductSelection object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="royaltyAgreementId">Initial value of RoyaltyAgreementId.</param>
        /// <param name="itemNumber">Initial value of ItemNumber.</param>
        /// <param name="salesUnitSymbol">Initial value of SalesUnitSymbol.</param>
        /// <param name="qualifyingSiteId">Initial value of QualifyingSiteId.</param>
        /// <param name="qualifyingWarehouseId">Initial value of QualifyingWarehouseId.</param>
        /// <param name="productConfigurationId">Initial value of ProductConfigurationId.</param>
        /// <param name="productColorId">Initial value of ProductColorId.</param>
        /// <param name="productSizeId">Initial value of ProductSizeId.</param>
        /// <param name="productStyleId">Initial value of ProductStyleId.</param>
        /// <param name="royaltyAgreementHeader">Initial value of RoyaltyAgreementHeader.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RoyaltyAgreementHeaderProductSelection CreateRoyaltyAgreementHeaderProductSelection(string dataAreaId, 
                    string royaltyAgreementId, 
                    string itemNumber, 
                    string salesUnitSymbol, 
                    string qualifyingSiteId, 
                    string qualifyingWarehouseId, 
                    string productConfigurationId, 
                    string productColorId, 
                    string productSizeId, 
                    string productStyleId, 
                    global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeader royaltyAgreementHeader)
        {
            RoyaltyAgreementHeaderProductSelection royaltyAgreementHeaderProductSelection = new RoyaltyAgreementHeaderProductSelection();
            royaltyAgreementHeaderProductSelection.dataAreaId = dataAreaId;
            royaltyAgreementHeaderProductSelection.RoyaltyAgreementId = royaltyAgreementId;
            royaltyAgreementHeaderProductSelection.ItemNumber = itemNumber;
            royaltyAgreementHeaderProductSelection.SalesUnitSymbol = salesUnitSymbol;
            royaltyAgreementHeaderProductSelection.QualifyingSiteId = qualifyingSiteId;
            royaltyAgreementHeaderProductSelection.QualifyingWarehouseId = qualifyingWarehouseId;
            royaltyAgreementHeaderProductSelection.ProductConfigurationId = productConfigurationId;
            royaltyAgreementHeaderProductSelection.ProductColorId = productColorId;
            royaltyAgreementHeaderProductSelection.ProductSizeId = productSizeId;
            royaltyAgreementHeaderProductSelection.ProductStyleId = productStyleId;
            if ((royaltyAgreementHeader == null))
            {
                throw new global::System.ArgumentNullException("royaltyAgreementHeader");
            }
            royaltyAgreementHeaderProductSelection.RoyaltyAgreementHeader = royaltyAgreementHeader;
            return royaltyAgreementHeaderProductSelection;
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
        /// There are no comments for Property RoyaltyAgreementId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RoyaltyAgreementId
        {
            get
            {
                return this._RoyaltyAgreementId;
            }
            set
            {
                this.OnRoyaltyAgreementIdChanging(value);
                this._RoyaltyAgreementId = value;
                this.OnRoyaltyAgreementIdChanged();
                this.OnPropertyChanged("RoyaltyAgreementId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RoyaltyAgreementId;
        partial void OnRoyaltyAgreementIdChanging(string value);
        partial void OnRoyaltyAgreementIdChanged();
        /// <summary>
        /// There are no comments for Property ItemNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ItemNumber
        {
            get
            {
                return this._ItemNumber;
            }
            set
            {
                this.OnItemNumberChanging(value);
                this._ItemNumber = value;
                this.OnItemNumberChanged();
                this.OnPropertyChanged("ItemNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemNumber;
        partial void OnItemNumberChanging(string value);
        partial void OnItemNumberChanged();
        /// <summary>
        /// There are no comments for Property SalesUnitSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SalesUnitSymbol
        {
            get
            {
                return this._SalesUnitSymbol;
            }
            set
            {
                this.OnSalesUnitSymbolChanging(value);
                this._SalesUnitSymbol = value;
                this.OnSalesUnitSymbolChanged();
                this.OnPropertyChanged("SalesUnitSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesUnitSymbol;
        partial void OnSalesUnitSymbolChanging(string value);
        partial void OnSalesUnitSymbolChanged();
        /// <summary>
        /// There are no comments for Property QualifyingSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string QualifyingSiteId
        {
            get
            {
                return this._QualifyingSiteId;
            }
            set
            {
                this.OnQualifyingSiteIdChanging(value);
                this._QualifyingSiteId = value;
                this.OnQualifyingSiteIdChanged();
                this.OnPropertyChanged("QualifyingSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _QualifyingSiteId;
        partial void OnQualifyingSiteIdChanging(string value);
        partial void OnQualifyingSiteIdChanged();
        /// <summary>
        /// There are no comments for Property QualifyingWarehouseId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string QualifyingWarehouseId
        {
            get
            {
                return this._QualifyingWarehouseId;
            }
            set
            {
                this.OnQualifyingWarehouseIdChanging(value);
                this._QualifyingWarehouseId = value;
                this.OnQualifyingWarehouseIdChanged();
                this.OnPropertyChanged("QualifyingWarehouseId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _QualifyingWarehouseId;
        partial void OnQualifyingWarehouseIdChanging(string value);
        partial void OnQualifyingWarehouseIdChanged();
        /// <summary>
        /// There are no comments for Property ProductConfigurationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductConfigurationId
        {
            get
            {
                return this._ProductConfigurationId;
            }
            set
            {
                this.OnProductConfigurationIdChanging(value);
                this._ProductConfigurationId = value;
                this.OnProductConfigurationIdChanged();
                this.OnPropertyChanged("ProductConfigurationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductConfigurationId;
        partial void OnProductConfigurationIdChanging(string value);
        partial void OnProductConfigurationIdChanged();
        /// <summary>
        /// There are no comments for Property ProductColorId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductColorId
        {
            get
            {
                return this._ProductColorId;
            }
            set
            {
                this.OnProductColorIdChanging(value);
                this._ProductColorId = value;
                this.OnProductColorIdChanged();
                this.OnPropertyChanged("ProductColorId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductColorId;
        partial void OnProductColorIdChanging(string value);
        partial void OnProductColorIdChanged();
        /// <summary>
        /// There are no comments for Property ProductSizeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductSizeId
        {
            get
            {
                return this._ProductSizeId;
            }
            set
            {
                this.OnProductSizeIdChanging(value);
                this._ProductSizeId = value;
                this.OnProductSizeIdChanged();
                this.OnPropertyChanged("ProductSizeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductSizeId;
        partial void OnProductSizeIdChanging(string value);
        partial void OnProductSizeIdChanged();
        /// <summary>
        /// There are no comments for Property ProductStyleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductStyleId
        {
            get
            {
                return this._ProductStyleId;
            }
            set
            {
                this.OnProductStyleIdChanging(value);
                this._ProductStyleId = value;
                this.OnProductStyleIdChanged();
                this.OnPropertyChanged("ProductStyleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductStyleId;
        partial void OnProductStyleIdChanging(string value);
        partial void OnProductStyleIdChanged();
        /// <summary>
        /// There are no comments for Property DefaultVendorAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DefaultVendorAccountNumber
        {
            get
            {
                return this._DefaultVendorAccountNumber;
            }
            set
            {
                this.OnDefaultVendorAccountNumberChanging(value);
                this._DefaultVendorAccountNumber = value;
                this.OnDefaultVendorAccountNumberChanged();
                this.OnPropertyChanged("DefaultVendorAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultVendorAccountNumber;
        partial void OnDefaultVendorAccountNumberChanging(string value);
        partial void OnDefaultVendorAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property RoyaltyAgreementHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeader RoyaltyAgreementHeader
        {
            get
            {
                return this._RoyaltyAgreementHeader;
            }
            set
            {
                this.OnRoyaltyAgreementHeaderChanging(value);
                this._RoyaltyAgreementHeader = value;
                this.OnRoyaltyAgreementHeaderChanged();
                this.OnPropertyChanged("RoyaltyAgreementHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeader _RoyaltyAgreementHeader;
        partial void OnRoyaltyAgreementHeaderChanging(global::Microsoft.Dynamics.DataEntities.RoyaltyAgreementHeader value);
        partial void OnRoyaltyAgreementHeaderChanged();
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
