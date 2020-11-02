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
    /// There are no comments for ExpenseCashAdvanceSingle in the schema.
    /// </summary>
    public partial class ExpenseCashAdvanceSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ExpenseCashAdvance>
    {
        /// <summary>
        /// Initialize a new ExpenseCashAdvanceSingle object.
        /// </summary>
        public ExpenseCashAdvanceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ExpenseCashAdvanceSingle object.
        /// </summary>
        public ExpenseCashAdvanceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ExpenseCashAdvanceSingle object.
        /// </summary>
        public ExpenseCashAdvanceSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ExpenseCashAdvance> query)
            : base(query) {}

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
    }
    /// <summary>
    /// There are no comments for ExpenseCashAdvance in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// CashAdvanceNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CashAdvanceNumber")]
    [global::Microsoft.OData.Client.EntitySet("ExpenseCashAdvances")]
    public partial class ExpenseCashAdvance : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ExpenseCashAdvance object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="cashAdvanceNumber">Initial value of CashAdvanceNumber.</param>
        /// <param name="amountInTransactionCurrency">Initial value of AmountInTransactionCurrency.</param>
        /// <param name="paidAmountMST">Initial value of PaidAmountMST.</param>
        /// <param name="requestedDate">Initial value of RequestedDate.</param>
        /// <param name="paidDate">Initial value of PaidDate.</param>
        /// <param name="exchangeRate">Initial value of ExchangeRate.</param>
        /// <param name="requestedAmount">Initial value of RequestedAmount.</param>
        /// <param name="amount">Initial value of Amount.</param>
        /// <param name="paidAmount">Initial value of PaidAmount.</param>
        /// <param name="balance">Initial value of Balance.</param>
        /// <param name="transactionDate">Initial value of TransactionDate.</param>
        /// <param name="requestAmountMST">Initial value of RequestAmountMST.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ExpenseCashAdvance CreateExpenseCashAdvance(string dataAreaId, 
                    string cashAdvanceNumber, 
                    decimal amountInTransactionCurrency, 
                    decimal paidAmountMST, 
                    global::System.DateTimeOffset requestedDate, 
                    global::System.DateTimeOffset paidDate, 
                    decimal exchangeRate, 
                    decimal requestedAmount, 
                    decimal amount, 
                    decimal paidAmount, 
                    decimal balance, 
                    global::System.DateTimeOffset transactionDate, 
                    decimal requestAmountMST)
        {
            ExpenseCashAdvance expenseCashAdvance = new ExpenseCashAdvance();
            expenseCashAdvance.dataAreaId = dataAreaId;
            expenseCashAdvance.CashAdvanceNumber = cashAdvanceNumber;
            expenseCashAdvance.AmountInTransactionCurrency = amountInTransactionCurrency;
            expenseCashAdvance.PaidAmountMST = paidAmountMST;
            expenseCashAdvance.RequestedDate = requestedDate;
            expenseCashAdvance.PaidDate = paidDate;
            expenseCashAdvance.ExchangeRate = exchangeRate;
            expenseCashAdvance.RequestedAmount = requestedAmount;
            expenseCashAdvance.Amount = amount;
            expenseCashAdvance.PaidAmount = paidAmount;
            expenseCashAdvance.Balance = balance;
            expenseCashAdvance.TransactionDate = transactionDate;
            expenseCashAdvance.RequestAmountMST = requestAmountMST;
            return expenseCashAdvance;
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
        /// There are no comments for Property CashAdvanceNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CashAdvanceNumber
        {
            get
            {
                return this._CashAdvanceNumber;
            }
            set
            {
                this.OnCashAdvanceNumberChanging(value);
                this._CashAdvanceNumber = value;
                this.OnCashAdvanceNumberChanged();
                this.OnPropertyChanged("CashAdvanceNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CashAdvanceNumber;
        partial void OnCashAdvanceNumberChanging(string value);
        partial void OnCashAdvanceNumberChanged();
        /// <summary>
        /// There are no comments for Property AmountInTransactionCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal AmountInTransactionCurrency
        {
            get
            {
                return this._AmountInTransactionCurrency;
            }
            set
            {
                this.OnAmountInTransactionCurrencyChanging(value);
                this._AmountInTransactionCurrency = value;
                this.OnAmountInTransactionCurrencyChanged();
                this.OnPropertyChanged("AmountInTransactionCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AmountInTransactionCurrency;
        partial void OnAmountInTransactionCurrencyChanging(decimal value);
        partial void OnAmountInTransactionCurrencyChanged();
        /// <summary>
        /// There are no comments for Property PaidAmountMST in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal PaidAmountMST
        {
            get
            {
                return this._PaidAmountMST;
            }
            set
            {
                this.OnPaidAmountMSTChanging(value);
                this._PaidAmountMST = value;
                this.OnPaidAmountMSTChanged();
                this.OnPropertyChanged("PaidAmountMST");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PaidAmountMST;
        partial void OnPaidAmountMSTChanging(decimal value);
        partial void OnPaidAmountMSTChanged();
        /// <summary>
        /// There are no comments for Property PayingWorkerPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PayingWorkerPersonnelNumber
        {
            get
            {
                return this._PayingWorkerPersonnelNumber;
            }
            set
            {
                this.OnPayingWorkerPersonnelNumberChanging(value);
                this._PayingWorkerPersonnelNumber = value;
                this.OnPayingWorkerPersonnelNumberChanged();
                this.OnPropertyChanged("PayingWorkerPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PayingWorkerPersonnelNumber;
        partial void OnPayingWorkerPersonnelNumberChanging(string value);
        partial void OnPayingWorkerPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property RequestedDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset RequestedDate
        {
            get
            {
                return this._RequestedDate;
            }
            set
            {
                this.OnRequestedDateChanging(value);
                this._RequestedDate = value;
                this.OnRequestedDateChanged();
                this.OnPropertyChanged("RequestedDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _RequestedDate;
        partial void OnRequestedDateChanging(global::System.DateTimeOffset value);
        partial void OnRequestedDateChanged();
        /// <summary>
        /// There are no comments for Property PaidDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset PaidDate
        {
            get
            {
                return this._PaidDate;
            }
            set
            {
                this.OnPaidDateChanging(value);
                this._PaidDate = value;
                this.OnPaidDateChanged();
                this.OnPropertyChanged("PaidDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PaidDate;
        partial void OnPaidDateChanging(global::System.DateTimeOffset value);
        partial void OnPaidDateChanged();
        /// <summary>
        /// There are no comments for Property Currency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Currency
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
        private string _Currency;
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
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
        /// There are no comments for Property CashAdvanceStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvWorkflowCashAdvanceStatus> CashAdvanceStatus
        {
            get
            {
                return this._CashAdvanceStatus;
            }
            set
            {
                this.OnCashAdvanceStatusChanging(value);
                this._CashAdvanceStatus = value;
                this.OnCashAdvanceStatusChanged();
                this.OnPropertyChanged("CashAdvanceStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvWorkflowCashAdvanceStatus> _CashAdvanceStatus;
        partial void OnCashAdvanceStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvWorkflowCashAdvanceStatus> value);
        partial void OnCashAdvanceStatusChanged();
        /// <summary>
        /// There are no comments for Property ExchangeRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ExchangeRate
        {
            get
            {
                return this._ExchangeRate;
            }
            set
            {
                this.OnExchangeRateChanging(value);
                this._ExchangeRate = value;
                this.OnExchangeRateChanged();
                this.OnPropertyChanged("ExchangeRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ExchangeRate;
        partial void OnExchangeRateChanging(decimal value);
        partial void OnExchangeRateChanged();
        /// <summary>
        /// There are no comments for Property RequestedAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal RequestedAmount
        {
            get
            {
                return this._RequestedAmount;
            }
            set
            {
                this.OnRequestedAmountChanging(value);
                this._RequestedAmount = value;
                this.OnRequestedAmountChanged();
                this.OnPropertyChanged("RequestedAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _RequestedAmount;
        partial void OnRequestedAmountChanging(decimal value);
        partial void OnRequestedAmountChanged();
        /// <summary>
        /// There are no comments for Property Company in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Company
        {
            get
            {
                return this._Company;
            }
            set
            {
                this.OnCompanyChanging(value);
                this._Company = value;
                this.OnCompanyChanged();
                this.OnPropertyChanged("Company");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Company;
        partial void OnCompanyChanging(string value);
        partial void OnCompanyChanged();
        /// <summary>
        /// There are no comments for Property MainAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MainAccountDisplayValue
        {
            get
            {
                return this._MainAccountDisplayValue;
            }
            set
            {
                this.OnMainAccountDisplayValueChanging(value);
                this._MainAccountDisplayValue = value;
                this.OnMainAccountDisplayValueChanged();
                this.OnPropertyChanged("MainAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MainAccountDisplayValue;
        partial void OnMainAccountDisplayValueChanging(string value);
        partial void OnMainAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property RequestingWorkerPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RequestingWorkerPersonnelNumber
        {
            get
            {
                return this._RequestingWorkerPersonnelNumber;
            }
            set
            {
                this.OnRequestingWorkerPersonnelNumberChanging(value);
                this._RequestingWorkerPersonnelNumber = value;
                this.OnRequestingWorkerPersonnelNumberChanged();
                this.OnPropertyChanged("RequestingWorkerPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RequestingWorkerPersonnelNumber;
        partial void OnRequestingWorkerPersonnelNumberChanging(string value);
        partial void OnRequestingWorkerPersonnelNumberChanged();
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
        /// There are no comments for Property Note in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Note
        {
            get
            {
                return this._Note;
            }
            set
            {
                this.OnNoteChanging(value);
                this._Note = value;
                this.OnNoteChanged();
                this.OnPropertyChanged("Note");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Note;
        partial void OnNoteChanging(string value);
        partial void OnNoteChanged();
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
        /// There are no comments for Property PaidAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal PaidAmount
        {
            get
            {
                return this._PaidAmount;
            }
            set
            {
                this.OnPaidAmountChanging(value);
                this._PaidAmount = value;
                this.OnPaidAmountChanged();
                this.OnPropertyChanged("PaidAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PaidAmount;
        partial void OnPaidAmountChanging(decimal value);
        partial void OnPaidAmountChanged();
        /// <summary>
        /// There are no comments for Property Purpose in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Purpose
        {
            get
            {
                return this._Purpose;
            }
            set
            {
                this.OnPurposeChanging(value);
                this._Purpose = value;
                this.OnPurposeChanged();
                this.OnPropertyChanged("Purpose");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Purpose;
        partial void OnPurposeChanging(string value);
        partial void OnPurposeChanged();
        /// <summary>
        /// There are no comments for Property Balance in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Balance
        {
            get
            {
                return this._Balance;
            }
            set
            {
                this.OnBalanceChanging(value);
                this._Balance = value;
                this.OnBalanceChanged();
                this.OnPropertyChanged("Balance");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Balance;
        partial void OnBalanceChanging(decimal value);
        partial void OnBalanceChanged();
        /// <summary>
        /// There are no comments for Property DimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DimensionDisplayValue
        {
            get
            {
                return this._DimensionDisplayValue;
            }
            set
            {
                this.OnDimensionDisplayValueChanging(value);
                this._DimensionDisplayValue = value;
                this.OnDimensionDisplayValueChanged();
                this.OnPropertyChanged("DimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DimensionDisplayValue;
        partial void OnDimensionDisplayValueChanging(string value);
        partial void OnDimensionDisplayValueChanged();
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
        /// There are no comments for Property TransactionDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset TransactionDate
        {
            get
            {
                return this._TransactionDate;
            }
            set
            {
                this.OnTransactionDateChanging(value);
                this._TransactionDate = value;
                this.OnTransactionDateChanged();
                this.OnPropertyChanged("TransactionDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _TransactionDate;
        partial void OnTransactionDateChanging(global::System.DateTimeOffset value);
        partial void OnTransactionDateChanged();
        /// <summary>
        /// There are no comments for Property Location in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Location
        {
            get
            {
                return this._Location;
            }
            set
            {
                this.OnLocationChanging(value);
                this._Location = value;
                this.OnLocationChanged();
                this.OnPropertyChanged("Location");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Location;
        partial void OnLocationChanging(string value);
        partial void OnLocationChanged();
        /// <summary>
        /// There are no comments for Property RequestAmountMST in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal RequestAmountMST
        {
            get
            {
                return this._RequestAmountMST;
            }
            set
            {
                this.OnRequestAmountMSTChanging(value);
                this._RequestAmountMST = value;
                this.OnRequestAmountMSTChanged();
                this.OnPropertyChanged("RequestAmountMST");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _RequestAmountMST;
        partial void OnRequestAmountMSTChanging(decimal value);
        partial void OnRequestAmountMSTChanged();
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
