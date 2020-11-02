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
    /// There are no comments for TradeAllowanceAgreementProductSingle in the schema.
    /// </summary>
    public partial class TradeAllowanceAgreementProductSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TradeAllowanceAgreementProduct>
    {
        /// <summary>
        /// Initialize a new TradeAllowanceAgreementProductSingle object.
        /// </summary>
        public TradeAllowanceAgreementProductSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TradeAllowanceAgreementProductSingle object.
        /// </summary>
        public TradeAllowanceAgreementProductSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TradeAllowanceAgreementProductSingle object.
        /// </summary>
        public TradeAllowanceAgreementProductSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TradeAllowanceAgreementProduct> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PromotionalProductUnitOfMeasure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle PromotionalProductUnitOfMeasure
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PromotionalProductUnitOfMeasure == null))
                {
                    this._PromotionalProductUnitOfMeasure = new global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle(this.Context, GetPath("PromotionalProductUnitOfMeasure"));
                }
                return this._PromotionalProductUnitOfMeasure;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UnitOfMeasureSingle _PromotionalProductUnitOfMeasure;
        /// <summary>
        /// There are no comments for ReleasedProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single ReleasedProduct
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProduct == null))
                {
                    this._ReleasedProduct = new global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single(this.Context, GetPath("ReleasedProduct"));
                }
                return this._ReleasedProduct;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single _ReleasedProduct;
        /// <summary>
        /// There are no comments for TradeAllowanceAgreementHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementHeaderSingle TradeAllowanceAgreementHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TradeAllowanceAgreementHeader == null))
                {
                    this._TradeAllowanceAgreementHeader = new global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementHeaderSingle(this.Context, GetPath("TradeAllowanceAgreementHeader"));
                }
                return this._TradeAllowanceAgreementHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementHeaderSingle _TradeAllowanceAgreementHeader;
    }
    /// <summary>
    /// There are no comments for TradeAllowanceAgreementProduct in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// TradeAllowanceAgreementId
    /// CustomerAccountNumber
    /// ItemNumber
    /// PromotionalProductUnitSymbol
    /// ProductColorId
    /// ProductStyleId
    /// ProductSizeId
    /// ProductConfigurationId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TradeAllowanceAgreementId", "CustomerAccountNumber", "ItemNumber", "PromotionalProductUnitSymbol", "ProductColorId", "ProductStyleId", "ProductSizeId", "ProductConfigurationId")]
    [global::Microsoft.OData.Client.EntitySet("TradeAllowanceAgreementProducts")]
    public partial class TradeAllowanceAgreementProduct : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TradeAllowanceAgreementProduct object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="tradeAllowanceAgreementId">Initial value of TradeAllowanceAgreementId.</param>
        /// <param name="customerAccountNumber">Initial value of CustomerAccountNumber.</param>
        /// <param name="itemNumber">Initial value of ItemNumber.</param>
        /// <param name="promotionalProductUnitSymbol">Initial value of PromotionalProductUnitSymbol.</param>
        /// <param name="productColorId">Initial value of ProductColorId.</param>
        /// <param name="productStyleId">Initial value of ProductStyleId.</param>
        /// <param name="productSizeId">Initial value of ProductSizeId.</param>
        /// <param name="productConfigurationId">Initial value of ProductConfigurationId.</param>
        /// <param name="weightingFactor">Initial value of WeightingFactor.</param>
        /// <param name="promotionalProductUnitOfMeasure">Initial value of PromotionalProductUnitOfMeasure.</param>
        /// <param name="releasedProduct">Initial value of ReleasedProduct.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TradeAllowanceAgreementProduct CreateTradeAllowanceAgreementProduct(string dataAreaId, 
                    string tradeAllowanceAgreementId, 
                    string customerAccountNumber, 
                    string itemNumber, 
                    string promotionalProductUnitSymbol, 
                    string productColorId, 
                    string productStyleId, 
                    string productSizeId, 
                    string productConfigurationId, 
                    decimal weightingFactor, 
                    global::Microsoft.Dynamics.DataEntities.UnitOfMeasure promotionalProductUnitOfMeasure, 
                    global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 releasedProduct)
        {
            TradeAllowanceAgreementProduct tradeAllowanceAgreementProduct = new TradeAllowanceAgreementProduct();
            tradeAllowanceAgreementProduct.dataAreaId = dataAreaId;
            tradeAllowanceAgreementProduct.TradeAllowanceAgreementId = tradeAllowanceAgreementId;
            tradeAllowanceAgreementProduct.CustomerAccountNumber = customerAccountNumber;
            tradeAllowanceAgreementProduct.ItemNumber = itemNumber;
            tradeAllowanceAgreementProduct.PromotionalProductUnitSymbol = promotionalProductUnitSymbol;
            tradeAllowanceAgreementProduct.ProductColorId = productColorId;
            tradeAllowanceAgreementProduct.ProductStyleId = productStyleId;
            tradeAllowanceAgreementProduct.ProductSizeId = productSizeId;
            tradeAllowanceAgreementProduct.ProductConfigurationId = productConfigurationId;
            tradeAllowanceAgreementProduct.WeightingFactor = weightingFactor;
            if ((promotionalProductUnitOfMeasure == null))
            {
                throw new global::System.ArgumentNullException("promotionalProductUnitOfMeasure");
            }
            tradeAllowanceAgreementProduct.PromotionalProductUnitOfMeasure = promotionalProductUnitOfMeasure;
            if ((releasedProduct == null))
            {
                throw new global::System.ArgumentNullException("releasedProduct");
            }
            tradeAllowanceAgreementProduct.ReleasedProduct = releasedProduct;
            return tradeAllowanceAgreementProduct;
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
        /// There are no comments for Property TradeAllowanceAgreementId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TradeAllowanceAgreementId
        {
            get
            {
                return this._TradeAllowanceAgreementId;
            }
            set
            {
                this.OnTradeAllowanceAgreementIdChanging(value);
                this._TradeAllowanceAgreementId = value;
                this.OnTradeAllowanceAgreementIdChanged();
                this.OnPropertyChanged("TradeAllowanceAgreementId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TradeAllowanceAgreementId;
        partial void OnTradeAllowanceAgreementIdChanging(string value);
        partial void OnTradeAllowanceAgreementIdChanged();
        /// <summary>
        /// There are no comments for Property CustomerAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CustomerAccountNumber
        {
            get
            {
                return this._CustomerAccountNumber;
            }
            set
            {
                this.OnCustomerAccountNumberChanging(value);
                this._CustomerAccountNumber = value;
                this.OnCustomerAccountNumberChanged();
                this.OnPropertyChanged("CustomerAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerAccountNumber;
        partial void OnCustomerAccountNumberChanging(string value);
        partial void OnCustomerAccountNumberChanged();
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
        /// There are no comments for Property PromotionalProductUnitSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PromotionalProductUnitSymbol
        {
            get
            {
                return this._PromotionalProductUnitSymbol;
            }
            set
            {
                this.OnPromotionalProductUnitSymbolChanging(value);
                this._PromotionalProductUnitSymbol = value;
                this.OnPromotionalProductUnitSymbolChanged();
                this.OnPropertyChanged("PromotionalProductUnitSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PromotionalProductUnitSymbol;
        partial void OnPromotionalProductUnitSymbolChanging(string value);
        partial void OnPromotionalProductUnitSymbolChanged();
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
        /// There are no comments for Property WeightingFactor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal WeightingFactor
        {
            get
            {
                return this._WeightingFactor;
            }
            set
            {
                this.OnWeightingFactorChanging(value);
                this._WeightingFactor = value;
                this.OnWeightingFactorChanged();
                this.OnPropertyChanged("WeightingFactor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _WeightingFactor;
        partial void OnWeightingFactorChanging(decimal value);
        partial void OnWeightingFactorChanged();
        /// <summary>
        /// There are no comments for Property PromotionalProductUnitOfMeasure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UnitOfMeasure PromotionalProductUnitOfMeasure
        {
            get
            {
                return this._PromotionalProductUnitOfMeasure;
            }
            set
            {
                this.OnPromotionalProductUnitOfMeasureChanging(value);
                this._PromotionalProductUnitOfMeasure = value;
                this.OnPromotionalProductUnitOfMeasureChanged();
                this.OnPropertyChanged("PromotionalProductUnitOfMeasure");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UnitOfMeasure _PromotionalProductUnitOfMeasure;
        partial void OnPromotionalProductUnitOfMeasureChanging(global::Microsoft.Dynamics.DataEntities.UnitOfMeasure value);
        partial void OnPromotionalProductUnitOfMeasureChanged();
        /// <summary>
        /// There are no comments for Property ReleasedProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 ReleasedProduct
        {
            get
            {
                return this._ReleasedProduct;
            }
            set
            {
                this.OnReleasedProductChanging(value);
                this._ReleasedProduct = value;
                this.OnReleasedProductChanged();
                this.OnPropertyChanged("ReleasedProduct");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 _ReleasedProduct;
        partial void OnReleasedProductChanging(global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 value);
        partial void OnReleasedProductChanged();
        /// <summary>
        /// There are no comments for Property TradeAllowanceAgreementHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementHeader TradeAllowanceAgreementHeader
        {
            get
            {
                return this._TradeAllowanceAgreementHeader;
            }
            set
            {
                this.OnTradeAllowanceAgreementHeaderChanging(value);
                this._TradeAllowanceAgreementHeader = value;
                this.OnTradeAllowanceAgreementHeaderChanged();
                this.OnPropertyChanged("TradeAllowanceAgreementHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementHeader _TradeAllowanceAgreementHeader;
        partial void OnTradeAllowanceAgreementHeaderChanging(global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementHeader value);
        partial void OnTradeAllowanceAgreementHeaderChanged();
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
