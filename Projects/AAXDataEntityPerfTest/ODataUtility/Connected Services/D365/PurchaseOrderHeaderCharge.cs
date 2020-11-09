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
        /// There are no comments for PurchaseOrderHeaderChargeSingle in the schema.
        /// </summary>
    public partial class PurchaseOrderHeaderChargeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PurchaseOrderHeaderCharge>
    {
        /// <summary>
        /// Initialize a new PurchaseOrderHeaderChargeSingle object.
        /// </summary>
        public PurchaseOrderHeaderChargeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PurchaseOrderHeaderChargeSingle object.
        /// </summary>
        public PurchaseOrderHeaderChargeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PurchaseOrderHeaderChargeSingle object.
        /// </summary>
        public PurchaseOrderHeaderChargeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PurchaseOrderHeaderCharge> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PurchaseOrderHeaderV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PurchaseOrderHeaderV2Single PurchaseOrderHeaderV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PurchaseOrderHeaderV2 == null))
                {
                    this._PurchaseOrderHeaderV2 = new global::Microsoft.Dynamics.DataEntities.PurchaseOrderHeaderV2Single(this.Context, GetPath("PurchaseOrderHeaderV2"));
                }
                return this._PurchaseOrderHeaderV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PurchaseOrderHeaderV2Single _PurchaseOrderHeaderV2;
        /// <summary>
        /// There are no comments for Currency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CurrencySingle Currency
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Currency == null))
                {
                    this._Currency = new global::Microsoft.Dynamics.DataEntities.CurrencySingle(this.Context, GetPath("Currency"));
                }
                return this._Currency;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CurrencySingle _Currency;
        /// <summary>
        /// There are no comments for TaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TaxGroupSingle TaxGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TaxGroup == null))
                {
                    this._TaxGroup = new global::Microsoft.Dynamics.DataEntities.TaxGroupSingle(this.Context, GetPath("TaxGroup"));
                }
                return this._TaxGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TaxGroupSingle _TaxGroup;
        /// <summary>
        /// There are no comments for TaxItemGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TaxItemGroupSingle TaxItemGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TaxItemGroup == null))
                {
                    this._TaxItemGroup = new global::Microsoft.Dynamics.DataEntities.TaxItemGroupSingle(this.Context, GetPath("TaxItemGroup"));
                }
                return this._TaxItemGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TaxItemGroupSingle _TaxItemGroup;
    }
        /// <summary>
        /// There are no comments for PurchaseOrderHeaderCharge in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// PurchaseOrderNumber
    /// ChargeLineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PurchaseOrderNumber", "ChargeLineNumber")]
    [global::Microsoft.OData.Client.EntitySet("PurchaseOrderHeaderCharges")]
    public partial class PurchaseOrderHeaderCharge : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PurchaseOrderHeaderCharge object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="purchaseOrderNumber">Initial value of PurchaseOrderNumber.</param>
        /// <param name="chargeLineNumber">Initial value of ChargeLineNumber.</param>
        /// <param name="proportionalChargeAmount">Initial value of ProportionalChargeAmount.</param>
        /// <param name="chargePercentage">Initial value of ChargePercentage.</param>
        /// <param name="fixedChargeAmount">Initial value of FixedChargeAmount.</param>
        /// <param name="externalChargeAmount">Initial value of ExternalChargeAmount.</param>
        /// <param name="purchaseOrderHeaderV2">Initial value of PurchaseOrderHeaderV2.</param>
        /// <param name="currency">Initial value of Currency.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PurchaseOrderHeaderCharge CreatePurchaseOrderHeaderCharge(string dataAreaId, 
                    string purchaseOrderNumber, 
                    decimal chargeLineNumber, 
                    decimal proportionalChargeAmount, 
                    decimal chargePercentage, 
                    decimal fixedChargeAmount, 
                    decimal externalChargeAmount, 
                    global::Microsoft.Dynamics.DataEntities.PurchaseOrderHeaderV2 purchaseOrderHeaderV2, 
                    global::Microsoft.Dynamics.DataEntities.Currency currency)
        {
            PurchaseOrderHeaderCharge purchaseOrderHeaderCharge = new PurchaseOrderHeaderCharge();
            purchaseOrderHeaderCharge.dataAreaId = dataAreaId;
            purchaseOrderHeaderCharge.PurchaseOrderNumber = purchaseOrderNumber;
            purchaseOrderHeaderCharge.ChargeLineNumber = chargeLineNumber;
            purchaseOrderHeaderCharge.ProportionalChargeAmount = proportionalChargeAmount;
            purchaseOrderHeaderCharge.ChargePercentage = chargePercentage;
            purchaseOrderHeaderCharge.FixedChargeAmount = fixedChargeAmount;
            purchaseOrderHeaderCharge.ExternalChargeAmount = externalChargeAmount;
            if ((purchaseOrderHeaderV2 == null))
            {
                throw new global::System.ArgumentNullException("purchaseOrderHeaderV2");
            }
            purchaseOrderHeaderCharge.PurchaseOrderHeaderV2 = purchaseOrderHeaderV2;
            if ((currency == null))
            {
                throw new global::System.ArgumentNullException("currency");
            }
            purchaseOrderHeaderCharge.Currency = currency;
            return purchaseOrderHeaderCharge;
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
        /// There are no comments for Property PurchaseOrderNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PurchaseOrderNumber
        {
            get
            {
                return this._PurchaseOrderNumber;
            }
            set
            {
                this.OnPurchaseOrderNumberChanging(value);
                this._PurchaseOrderNumber = value;
                this.OnPurchaseOrderNumberChanged();
                this.OnPropertyChanged("PurchaseOrderNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PurchaseOrderNumber;
        partial void OnPurchaseOrderNumberChanging(string value);
        partial void OnPurchaseOrderNumberChanged();
        /// <summary>
        /// There are no comments for Property ChargeLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ChargeLineNumber
        {
            get
            {
                return this._ChargeLineNumber;
            }
            set
            {
                this.OnChargeLineNumberChanging(value);
                this._ChargeLineNumber = value;
                this.OnChargeLineNumberChanged();
                this.OnPropertyChanged("ChargeLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ChargeLineNumber;
        partial void OnChargeLineNumberChanging(decimal value);
        partial void OnChargeLineNumberChanged();
        /// <summary>
        /// There are no comments for Property ProportionalChargeAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ProportionalChargeAmount
        {
            get
            {
                return this._ProportionalChargeAmount;
            }
            set
            {
                this.OnProportionalChargeAmountChanging(value);
                this._ProportionalChargeAmount = value;
                this.OnProportionalChargeAmountChanged();
                this.OnPropertyChanged("ProportionalChargeAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ProportionalChargeAmount;
        partial void OnProportionalChargeAmountChanging(decimal value);
        partial void OnProportionalChargeAmountChanged();
        /// <summary>
        /// There are no comments for Property ChargeAccountingCurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ChargeAccountingCurrencyCode
        {
            get
            {
                return this._ChargeAccountingCurrencyCode;
            }
            set
            {
                this.OnChargeAccountingCurrencyCodeChanging(value);
                this._ChargeAccountingCurrencyCode = value;
                this.OnChargeAccountingCurrencyCodeChanged();
                this.OnPropertyChanged("ChargeAccountingCurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ChargeAccountingCurrencyCode;
        partial void OnChargeAccountingCurrencyCodeChanging(string value);
        partial void OnChargeAccountingCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property SalesTaxGroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SalesTaxGroupCode
        {
            get
            {
                return this._SalesTaxGroupCode;
            }
            set
            {
                this.OnSalesTaxGroupCodeChanging(value);
                this._SalesTaxGroupCode = value;
                this.OnSalesTaxGroupCodeChanged();
                this.OnPropertyChanged("SalesTaxGroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesTaxGroupCode;
        partial void OnSalesTaxGroupCodeChanging(string value);
        partial void OnSalesTaxGroupCodeChanged();
        /// <summary>
        /// There are no comments for Property ChargeDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ChargeDescription
        {
            get
            {
                return this._ChargeDescription;
            }
            set
            {
                this.OnChargeDescriptionChanging(value);
                this._ChargeDescription = value;
                this.OnChargeDescriptionChanged();
                this.OnPropertyChanged("ChargeDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ChargeDescription;
        partial void OnChargeDescriptionChanging(string value);
        partial void OnChargeDescriptionChanged();
        /// <summary>
        /// There are no comments for Property PurchaseChargeCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PurchaseChargeCode
        {
            get
            {
                return this._PurchaseChargeCode;
            }
            set
            {
                this.OnPurchaseChargeCodeChanging(value);
                this._PurchaseChargeCode = value;
                this.OnPurchaseChargeCodeChanged();
                this.OnPropertyChanged("PurchaseChargeCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PurchaseChargeCode;
        partial void OnPurchaseChargeCodeChanging(string value);
        partial void OnPurchaseChargeCodeChanged();
        /// <summary>
        /// There are no comments for Property IsIntercompanyCharge in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsIntercompanyCharge
        {
            get
            {
                return this._IsIntercompanyCharge;
            }
            set
            {
                this.OnIsIntercompanyChargeChanging(value);
                this._IsIntercompanyCharge = value;
                this.OnIsIntercompanyChargeChanged();
                this.OnPropertyChanged("IsIntercompanyCharge");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsIntercompanyCharge;
        partial void OnIsIntercompanyChargeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsIntercompanyChargeChanged();
        /// <summary>
        /// There are no comments for Property ChargePercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ChargePercentage
        {
            get
            {
                return this._ChargePercentage;
            }
            set
            {
                this.OnChargePercentageChanging(value);
                this._ChargePercentage = value;
                this.OnChargePercentageChanged();
                this.OnPropertyChanged("ChargePercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ChargePercentage;
        partial void OnChargePercentageChanging(decimal value);
        partial void OnChargePercentageChanged();
        /// <summary>
        /// There are no comments for Property SalesTaxItemGroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SalesTaxItemGroupCode
        {
            get
            {
                return this._SalesTaxItemGroupCode;
            }
            set
            {
                this.OnSalesTaxItemGroupCodeChanging(value);
                this._SalesTaxItemGroupCode = value;
                this.OnSalesTaxItemGroupCodeChanged();
                this.OnPropertyChanged("SalesTaxItemGroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesTaxItemGroupCode;
        partial void OnSalesTaxItemGroupCodeChanging(string value);
        partial void OnSalesTaxItemGroupCodeChanged();
        /// <summary>
        /// There are no comments for Property FixedChargeAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal FixedChargeAmount
        {
            get
            {
                return this._FixedChargeAmount;
            }
            set
            {
                this.OnFixedChargeAmountChanging(value);
                this._FixedChargeAmount = value;
                this.OnFixedChargeAmountChanged();
                this.OnPropertyChanged("FixedChargeAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _FixedChargeAmount;
        partial void OnFixedChargeAmountChanging(decimal value);
        partial void OnFixedChargeAmountChanged();
        /// <summary>
        /// There are no comments for Property ExternalChargeAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ExternalChargeAmount
        {
            get
            {
                return this._ExternalChargeAmount;
            }
            set
            {
                this.OnExternalChargeAmountChanging(value);
                this._ExternalChargeAmount = value;
                this.OnExternalChargeAmountChanged();
                this.OnPropertyChanged("ExternalChargeAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ExternalChargeAmount;
        partial void OnExternalChargeAmountChanging(decimal value);
        partial void OnExternalChargeAmountChanged();
        /// <summary>
        /// There are no comments for Property ChargeCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MarkupCategory> ChargeCategory
        {
            get
            {
                return this._ChargeCategory;
            }
            set
            {
                this.OnChargeCategoryChanging(value);
                this._ChargeCategory = value;
                this.OnChargeCategoryChanged();
                this.OnPropertyChanged("ChargeCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MarkupCategory> _ChargeCategory;
        partial void OnChargeCategoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MarkupCategory> value);
        partial void OnChargeCategoryChanged();
        /// <summary>
        /// There are no comments for Property PurchaseOrderHeaderV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PurchaseOrderHeaderV2 PurchaseOrderHeaderV2
        {
            get
            {
                return this._PurchaseOrderHeaderV2;
            }
            set
            {
                this.OnPurchaseOrderHeaderV2Changing(value);
                this._PurchaseOrderHeaderV2 = value;
                this.OnPurchaseOrderHeaderV2Changed();
                this.OnPropertyChanged("PurchaseOrderHeaderV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PurchaseOrderHeaderV2 _PurchaseOrderHeaderV2;
        partial void OnPurchaseOrderHeaderV2Changing(global::Microsoft.Dynamics.DataEntities.PurchaseOrderHeaderV2 value);
        partial void OnPurchaseOrderHeaderV2Changed();
        /// <summary>
        /// There are no comments for Property Currency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Currency Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                this.OnCurrencyChanging(value);
                this._Currency = value;
                this.OnCurrencyChanged();
                this.OnPropertyChanged("Currency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Currency _Currency;
        partial void OnCurrencyChanging(global::Microsoft.Dynamics.DataEntities.Currency value);
        partial void OnCurrencyChanged();
        /// <summary>
        /// There are no comments for Property TaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TaxGroup TaxGroup
        {
            get
            {
                return this._TaxGroup;
            }
            set
            {
                this.OnTaxGroupChanging(value);
                this._TaxGroup = value;
                this.OnTaxGroupChanged();
                this.OnPropertyChanged("TaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TaxGroup _TaxGroup;
        partial void OnTaxGroupChanging(global::Microsoft.Dynamics.DataEntities.TaxGroup value);
        partial void OnTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property TaxItemGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TaxItemGroup TaxItemGroup
        {
            get
            {
                return this._TaxItemGroup;
            }
            set
            {
                this.OnTaxItemGroupChanging(value);
                this._TaxItemGroup = value;
                this.OnTaxItemGroupChanged();
                this.OnPropertyChanged("TaxItemGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TaxItemGroup _TaxItemGroup;
        partial void OnTaxItemGroupChanging(global::Microsoft.Dynamics.DataEntities.TaxItemGroup value);
        partial void OnTaxItemGroupChanged();
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
