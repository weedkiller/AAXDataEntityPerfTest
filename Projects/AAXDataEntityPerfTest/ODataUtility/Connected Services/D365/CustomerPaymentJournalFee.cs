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
        /// There are no comments for CustomerPaymentJournalFeeSingle in the schema.
        /// </summary>
    public partial class CustomerPaymentJournalFeeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CustomerPaymentJournalFee>
    {
        /// <summary>
        /// Initialize a new CustomerPaymentJournalFeeSingle object.
        /// </summary>
        public CustomerPaymentJournalFeeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CustomerPaymentJournalFeeSingle object.
        /// </summary>
        public CustomerPaymentJournalFeeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CustomerPaymentJournalFeeSingle object.
        /// </summary>
        public CustomerPaymentJournalFeeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CustomerPaymentJournalFee> query)
            : base(query) {}

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
        /// <summary>
        /// There are no comments for CustomerPaymentFee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CustomerPaymentFeeSingle CustomerPaymentFee
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CustomerPaymentFee == null))
                {
                    this._CustomerPaymentFee = new global::Microsoft.Dynamics.DataEntities.CustomerPaymentFeeSingle(this.Context, GetPath("CustomerPaymentFee"));
                }
                return this._CustomerPaymentFee;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CustomerPaymentFeeSingle _CustomerPaymentFee;
        /// <summary>
        /// There are no comments for CustomerPaymentJournalLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLineSingle CustomerPaymentJournalLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CustomerPaymentJournalLine == null))
                {
                    this._CustomerPaymentJournalLine = new global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLineSingle(this.Context, GetPath("CustomerPaymentJournalLine"));
                }
                return this._CustomerPaymentJournalLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLineSingle _CustomerPaymentJournalLine;
        /// <summary>
        /// There are no comments for DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSetSingle DimensionSet
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionSet == null))
                {
                    this._DimensionSet = new global::Microsoft.Dynamics.DataEntities.DimensionSetSingle(this.Context, GetPath("DimensionSet"));
                }
                return this._DimensionSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSetSingle _DimensionSet;
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
        /// There are no comments for DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle DimensionCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionCombination == null))
                {
                    this._DimensionCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("DimensionCombination"));
                }
                return this._DimensionCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _DimensionCombination;
    }
        /// <summary>
        /// There are no comments for CustomerPaymentJournalFee in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// SourceJournalBatchNumber
    /// SourceJournalLineNumber
    /// PaymentFeeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "SourceJournalBatchNumber", "SourceJournalLineNumber", "PaymentFeeId")]
    [global::Microsoft.OData.Client.EntitySet("CustomerPaymentJournalFees")]
    public partial class CustomerPaymentJournalFee : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CustomerPaymentJournalFee object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="sourceJournalBatchNumber">Initial value of SourceJournalBatchNumber.</param>
        /// <param name="sourceJournalLineNumber">Initial value of SourceJournalLineNumber.</param>
        /// <param name="paymentFeeId">Initial value of PaymentFeeId.</param>
        /// <param name="amount">Initial value of Amount.</param>
        /// <param name="currency">Initial value of Currency.</param>
        /// <param name="customerPaymentFee">Initial value of CustomerPaymentFee.</param>
        /// <param name="customerPaymentJournalLine">Initial value of CustomerPaymentJournalLine.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CustomerPaymentJournalFee CreateCustomerPaymentJournalFee(string dataAreaId, 
                    string sourceJournalBatchNumber, 
                    decimal sourceJournalLineNumber, 
                    string paymentFeeId, 
                    decimal amount, 
                    global::Microsoft.Dynamics.DataEntities.Currency currency, 
                    global::Microsoft.Dynamics.DataEntities.CustomerPaymentFee customerPaymentFee, 
                    global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine customerPaymentJournalLine)
        {
            CustomerPaymentJournalFee customerPaymentJournalFee = new CustomerPaymentJournalFee();
            customerPaymentJournalFee.dataAreaId = dataAreaId;
            customerPaymentJournalFee.SourceJournalBatchNumber = sourceJournalBatchNumber;
            customerPaymentJournalFee.SourceJournalLineNumber = sourceJournalLineNumber;
            customerPaymentJournalFee.PaymentFeeId = paymentFeeId;
            customerPaymentJournalFee.Amount = amount;
            if ((currency == null))
            {
                throw new global::System.ArgumentNullException("currency");
            }
            customerPaymentJournalFee.Currency = currency;
            if ((customerPaymentFee == null))
            {
                throw new global::System.ArgumentNullException("customerPaymentFee");
            }
            customerPaymentJournalFee.CustomerPaymentFee = customerPaymentFee;
            if ((customerPaymentJournalLine == null))
            {
                throw new global::System.ArgumentNullException("customerPaymentJournalLine");
            }
            customerPaymentJournalFee.CustomerPaymentJournalLine = customerPaymentJournalLine;
            return customerPaymentJournalFee;
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
        /// There are no comments for Property SourceJournalBatchNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SourceJournalBatchNumber
        {
            get
            {
                return this._SourceJournalBatchNumber;
            }
            set
            {
                this.OnSourceJournalBatchNumberChanging(value);
                this._SourceJournalBatchNumber = value;
                this.OnSourceJournalBatchNumberChanged();
                this.OnPropertyChanged("SourceJournalBatchNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SourceJournalBatchNumber;
        partial void OnSourceJournalBatchNumberChanging(string value);
        partial void OnSourceJournalBatchNumberChanged();
        /// <summary>
        /// There are no comments for Property SourceJournalLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal SourceJournalLineNumber
        {
            get
            {
                return this._SourceJournalLineNumber;
            }
            set
            {
                this.OnSourceJournalLineNumberChanging(value);
                this._SourceJournalLineNumber = value;
                this.OnSourceJournalLineNumberChanged();
                this.OnPropertyChanged("SourceJournalLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SourceJournalLineNumber;
        partial void OnSourceJournalLineNumberChanging(decimal value);
        partial void OnSourceJournalLineNumberChanged();
        /// <summary>
        /// There are no comments for Property PaymentFeeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PaymentFeeId
        {
            get
            {
                return this._PaymentFeeId;
            }
            set
            {
                this.OnPaymentFeeIdChanging(value);
                this._PaymentFeeId = value;
                this.OnPaymentFeeIdChanged();
                this.OnPropertyChanged("PaymentFeeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PaymentFeeId;
        partial void OnPaymentFeeIdChanging(string value);
        partial void OnPaymentFeeIdChanged();
        /// <summary>
        /// There are no comments for Property DefaultDimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DefaultDimensionDisplayValue
        {
            get
            {
                return this._DefaultDimensionDisplayValue;
            }
            set
            {
                this.OnDefaultDimensionDisplayValueChanging(value);
                this._DefaultDimensionDisplayValue = value;
                this.OnDefaultDimensionDisplayValueChanged();
                this.OnPropertyChanged("DefaultDimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultDimensionDisplayValue;
        partial void OnDefaultDimensionDisplayValueChanging(string value);
        partial void OnDefaultDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property IsWithholdingCalculationEnabled in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsWithholdingCalculationEnabled
        {
            get
            {
                return this._IsWithholdingCalculationEnabled;
            }
            set
            {
                this.OnIsWithholdingCalculationEnabledChanging(value);
                this._IsWithholdingCalculationEnabled = value;
                this.OnIsWithholdingCalculationEnabledChanged();
                this.OnPropertyChanged("IsWithholdingCalculationEnabled");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsWithholdingCalculationEnabled;
        partial void OnIsWithholdingCalculationEnabledChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsWithholdingCalculationEnabledChanged();
        /// <summary>
        /// There are no comments for Property CurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CurrencyCode
        {
            get
            {
                return this._CurrencyCode;
            }
            set
            {
                this.OnCurrencyCodeChanging(value);
                this._CurrencyCode = value;
                this.OnCurrencyCodeChanged();
                this.OnPropertyChanged("CurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CurrencyCode;
        partial void OnCurrencyCodeChanging(string value);
        partial void OnCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property AccountType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerJournalACType> AccountType
        {
            get
            {
                return this._AccountType;
            }
            set
            {
                this.OnAccountTypeChanging(value);
                this._AccountType = value;
                this.OnAccountTypeChanged();
                this.OnPropertyChanged("AccountType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerJournalACType> _AccountType;
        partial void OnAccountTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerJournalACType> value);
        partial void OnAccountTypeChanged();
        /// <summary>
        /// There are no comments for Property ItemSalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ItemSalesTaxGroup
        {
            get
            {
                return this._ItemSalesTaxGroup;
            }
            set
            {
                this.OnItemSalesTaxGroupChanging(value);
                this._ItemSalesTaxGroup = value;
                this.OnItemSalesTaxGroupChanged();
                this.OnPropertyChanged("ItemSalesTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemSalesTaxGroup;
        partial void OnItemSalesTaxGroupChanging(string value);
        partial void OnItemSalesTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property Amount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Amount
        {
            get
            {
                return this._Amount;
            }
            set
            {
                this.OnAmountChanging(value);
                this._Amount = value;
                this.OnAmountChanged();
                this.OnPropertyChanged("Amount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Amount;
        partial void OnAmountChanging(decimal value);
        partial void OnAmountChanged();
        /// <summary>
        /// There are no comments for Property SalesTaxDirection in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.VendPaymFeeTaxDirection_JP> SalesTaxDirection
        {
            get
            {
                return this._SalesTaxDirection;
            }
            set
            {
                this.OnSalesTaxDirectionChanging(value);
                this._SalesTaxDirection = value;
                this.OnSalesTaxDirectionChanged();
                this.OnPropertyChanged("SalesTaxDirection");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.VendPaymFeeTaxDirection_JP> _SalesTaxDirection;
        partial void OnSalesTaxDirectionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.VendPaymFeeTaxDirection_JP> value);
        partial void OnSalesTaxDirectionChanged();
        /// <summary>
        /// There are no comments for Property ItemWithholdingTaxGroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ItemWithholdingTaxGroupCode
        {
            get
            {
                return this._ItemWithholdingTaxGroupCode;
            }
            set
            {
                this.OnItemWithholdingTaxGroupCodeChanging(value);
                this._ItemWithholdingTaxGroupCode = value;
                this.OnItemWithholdingTaxGroupCodeChanged();
                this.OnPropertyChanged("ItemWithholdingTaxGroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemWithholdingTaxGroupCode;
        partial void OnItemWithholdingTaxGroupCodeChanging(string value);
        partial void OnItemWithholdingTaxGroupCodeChanged();
        /// <summary>
        /// There are no comments for Property SalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SalesTaxGroup
        {
            get
            {
                return this._SalesTaxGroup;
            }
            set
            {
                this.OnSalesTaxGroupChanging(value);
                this._SalesTaxGroup = value;
                this.OnSalesTaxGroupChanged();
                this.OnPropertyChanged("SalesTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesTaxGroup;
        partial void OnSalesTaxGroupChanging(string value);
        partial void OnSalesTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property AccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AccountDisplayValue
        {
            get
            {
                return this._AccountDisplayValue;
            }
            set
            {
                this.OnAccountDisplayValueChanging(value);
                this._AccountDisplayValue = value;
                this.OnAccountDisplayValueChanged();
                this.OnPropertyChanged("AccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountDisplayValue;
        partial void OnAccountDisplayValueChanging(string value);
        partial void OnAccountDisplayValueChanged();
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
        /// There are no comments for Property CustomerPaymentFee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CustomerPaymentFee CustomerPaymentFee
        {
            get
            {
                return this._CustomerPaymentFee;
            }
            set
            {
                this.OnCustomerPaymentFeeChanging(value);
                this._CustomerPaymentFee = value;
                this.OnCustomerPaymentFeeChanged();
                this.OnPropertyChanged("CustomerPaymentFee");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CustomerPaymentFee _CustomerPaymentFee;
        partial void OnCustomerPaymentFeeChanging(global::Microsoft.Dynamics.DataEntities.CustomerPaymentFee value);
        partial void OnCustomerPaymentFeeChanged();
        /// <summary>
        /// There are no comments for Property CustomerPaymentJournalLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine CustomerPaymentJournalLine
        {
            get
            {
                return this._CustomerPaymentJournalLine;
            }
            set
            {
                this.OnCustomerPaymentJournalLineChanging(value);
                this._CustomerPaymentJournalLine = value;
                this.OnCustomerPaymentJournalLineChanged();
                this.OnPropertyChanged("CustomerPaymentJournalLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine _CustomerPaymentJournalLine;
        partial void OnCustomerPaymentJournalLineChanging(global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine value);
        partial void OnCustomerPaymentJournalLineChanged();
        /// <summary>
        /// There are no comments for Property DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSet DimensionSet
        {
            get
            {
                return this._DimensionSet;
            }
            set
            {
                this.OnDimensionSetChanging(value);
                this._DimensionSet = value;
                this.OnDimensionSetChanged();
                this.OnPropertyChanged("DimensionSet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSet _DimensionSet;
        partial void OnDimensionSetChanging(global::Microsoft.Dynamics.DataEntities.DimensionSet value);
        partial void OnDimensionSetChanged();
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
        /// There are no comments for Property DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination DimensionCombination
        {
            get
            {
                return this._DimensionCombination;
            }
            set
            {
                this.OnDimensionCombinationChanging(value);
                this._DimensionCombination = value;
                this.OnDimensionCombinationChanged();
                this.OnPropertyChanged("DimensionCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _DimensionCombination;
        partial void OnDimensionCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnDimensionCombinationChanged();
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
