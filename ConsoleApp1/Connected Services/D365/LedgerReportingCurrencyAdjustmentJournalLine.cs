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
    /// There are no comments for LedgerReportingCurrencyAdjustmentJournalLineSingle in the schema.
    /// </summary>
    public partial class LedgerReportingCurrencyAdjustmentJournalLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LedgerReportingCurrencyAdjustmentJournalLine>
    {
        /// <summary>
        /// Initialize a new LedgerReportingCurrencyAdjustmentJournalLineSingle object.
        /// </summary>
        public LedgerReportingCurrencyAdjustmentJournalLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LedgerReportingCurrencyAdjustmentJournalLineSingle object.
        /// </summary>
        public LedgerReportingCurrencyAdjustmentJournalLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LedgerReportingCurrencyAdjustmentJournalLineSingle object.
        /// </summary>
        public LedgerReportingCurrencyAdjustmentJournalLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LedgerReportingCurrencyAdjustmentJournalLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for LedgerReportingCurrencyAdjustmentJournalLineCompany in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.LegalEntitySingle LedgerReportingCurrencyAdjustmentJournalLineCompany
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerReportingCurrencyAdjustmentJournalLineCompany == null))
                {
                    this._LedgerReportingCurrencyAdjustmentJournalLineCompany = new global::Microsoft.Dynamics.DataEntities.LegalEntitySingle(this.Context, GetPath("LedgerReportingCurrencyAdjustmentJournalLineCompany"));
                }
                return this._LedgerReportingCurrencyAdjustmentJournalLineCompany;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LegalEntitySingle _LedgerReportingCurrencyAdjustmentJournalLineCompany;
        /// <summary>
        /// There are no comments for LedgerReportingCurrencyAdjustmentJournalLineCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CurrencySingle LedgerReportingCurrencyAdjustmentJournalLineCurrency
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerReportingCurrencyAdjustmentJournalLineCurrency == null))
                {
                    this._LedgerReportingCurrencyAdjustmentJournalLineCurrency = new global::Microsoft.Dynamics.DataEntities.CurrencySingle(this.Context, GetPath("LedgerReportingCurrencyAdjustmentJournalLineCurrency"));
                }
                return this._LedgerReportingCurrencyAdjustmentJournalLineCurrency;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CurrencySingle _LedgerReportingCurrencyAdjustmentJournalLineCurrency;
        /// <summary>
        /// There are no comments for LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.LegalEntitySingle LegalEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LegalEntity == null))
                {
                    this._LegalEntity = new global::Microsoft.Dynamics.DataEntities.LegalEntitySingle(this.Context, GetPath("LegalEntity"));
                }
                return this._LegalEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LegalEntitySingle _LegalEntity;
        /// <summary>
        /// There are no comments for LedgerReportingCurrencyAdjustmentJournalHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.LedgerReportingCurrencyAdjustmentJournalHeaderSingle LedgerReportingCurrencyAdjustmentJournalHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerReportingCurrencyAdjustmentJournalHeader == null))
                {
                    this._LedgerReportingCurrencyAdjustmentJournalHeader = new global::Microsoft.Dynamics.DataEntities.LedgerReportingCurrencyAdjustmentJournalHeaderSingle(this.Context, GetPath("LedgerReportingCurrencyAdjustmentJournalHeader"));
                }
                return this._LedgerReportingCurrencyAdjustmentJournalHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LedgerReportingCurrencyAdjustmentJournalHeaderSingle _LedgerReportingCurrencyAdjustmentJournalHeader;
        /// <summary>
        /// There are no comments for LedgerReportingCurrencyAdjustmentJournalLineLedgerDimension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle LedgerReportingCurrencyAdjustmentJournalLineLedgerDimension
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerReportingCurrencyAdjustmentJournalLineLedgerDimension == null))
                {
                    this._LedgerReportingCurrencyAdjustmentJournalLineLedgerDimension = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("LedgerReportingCurrencyAdjustmentJournalLineLedgerDimension"));
                }
                return this._LedgerReportingCurrencyAdjustmentJournalLineLedgerDimension;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _LedgerReportingCurrencyAdjustmentJournalLineLedgerDimension;
    }
    /// <summary>
    /// There are no comments for LedgerReportingCurrencyAdjustmentJournalLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// JournalBatchNumber
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "JournalBatchNumber", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("LedgerReportingCurrencyAdjustmentJournalLines")]
    public partial class LedgerReportingCurrencyAdjustmentJournalLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LedgerReportingCurrencyAdjustmentJournalLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="journalBatchNumber">Initial value of JournalBatchNumber.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="creditAmount">Initial value of CreditAmount.</param>
        /// <param name="transDate">Initial value of TransDate.</param>
        /// <param name="debitAmount">Initial value of DebitAmount.</param>
        /// <param name="ledgerReportingCurrencyAdjustmentJournalLineCurrency">Initial value of LedgerReportingCurrencyAdjustmentJournalLineCurrency.</param>
        /// <param name="ledgerReportingCurrencyAdjustmentJournalHeader">Initial value of LedgerReportingCurrencyAdjustmentJournalHeader.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LedgerReportingCurrencyAdjustmentJournalLine CreateLedgerReportingCurrencyAdjustmentJournalLine(string dataAreaId, 
                    string journalBatchNumber, 
                    decimal lineNumber, 
                    decimal creditAmount, 
                    global::System.DateTimeOffset transDate, 
                    decimal debitAmount, 
                    global::Microsoft.Dynamics.DataEntities.Currency ledgerReportingCurrencyAdjustmentJournalLineCurrency, 
                    global::Microsoft.Dynamics.DataEntities.LedgerReportingCurrencyAdjustmentJournalHeader ledgerReportingCurrencyAdjustmentJournalHeader)
        {
            LedgerReportingCurrencyAdjustmentJournalLine ledgerReportingCurrencyAdjustmentJournalLine = new LedgerReportingCurrencyAdjustmentJournalLine();
            ledgerReportingCurrencyAdjustmentJournalLine.dataAreaId = dataAreaId;
            ledgerReportingCurrencyAdjustmentJournalLine.JournalBatchNumber = journalBatchNumber;
            ledgerReportingCurrencyAdjustmentJournalLine.LineNumber = lineNumber;
            ledgerReportingCurrencyAdjustmentJournalLine.CreditAmount = creditAmount;
            ledgerReportingCurrencyAdjustmentJournalLine.TransDate = transDate;
            ledgerReportingCurrencyAdjustmentJournalLine.DebitAmount = debitAmount;
            if ((ledgerReportingCurrencyAdjustmentJournalLineCurrency == null))
            {
                throw new global::System.ArgumentNullException("ledgerReportingCurrencyAdjustmentJournalLineCurrency");
            }
            ledgerReportingCurrencyAdjustmentJournalLine.LedgerReportingCurrencyAdjustmentJournalLineCurrency = ledgerReportingCurrencyAdjustmentJournalLineCurrency;
            if ((ledgerReportingCurrencyAdjustmentJournalHeader == null))
            {
                throw new global::System.ArgumentNullException("ledgerReportingCurrencyAdjustmentJournalHeader");
            }
            ledgerReportingCurrencyAdjustmentJournalLine.LedgerReportingCurrencyAdjustmentJournalHeader = ledgerReportingCurrencyAdjustmentJournalHeader;
            return ledgerReportingCurrencyAdjustmentJournalLine;
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
        /// There are no comments for Property JournalBatchNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JournalBatchNumber
        {
            get
            {
                return this._JournalBatchNumber;
            }
            set
            {
                this.OnJournalBatchNumberChanging(value);
                this._JournalBatchNumber = value;
                this.OnJournalBatchNumberChanged();
                this.OnPropertyChanged("JournalBatchNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalBatchNumber;
        partial void OnJournalBatchNumberChanging(string value);
        partial void OnJournalBatchNumberChanged();
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LineNumber;
        partial void OnLineNumberChanging(decimal value);
        partial void OnLineNumberChanged();
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
        /// There are no comments for Property JournalName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JournalName
        {
            get
            {
                return this._JournalName;
            }
            set
            {
                this.OnJournalNameChanging(value);
                this._JournalName = value;
                this.OnJournalNameChanged();
                this.OnPropertyChanged("JournalName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalName;
        partial void OnJournalNameChanging(string value);
        partial void OnJournalNameChanged();
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
        /// There are no comments for Property CreditAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal CreditAmount
        {
            get
            {
                return this._CreditAmount;
            }
            set
            {
                this.OnCreditAmountChanging(value);
                this._CreditAmount = value;
                this.OnCreditAmountChanged();
                this.OnPropertyChanged("CreditAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CreditAmount;
        partial void OnCreditAmountChanging(decimal value);
        partial void OnCreditAmountChanged();
        /// <summary>
        /// There are no comments for Property TransDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset TransDate
        {
            get
            {
                return this._TransDate;
            }
            set
            {
                this.OnTransDateChanging(value);
                this._TransDate = value;
                this.OnTransDateChanged();
                this.OnPropertyChanged("TransDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _TransDate;
        partial void OnTransDateChanging(global::System.DateTimeOffset value);
        partial void OnTransDateChanged();
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
        /// There are no comments for Property DebitAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal DebitAmount
        {
            get
            {
                return this._DebitAmount;
            }
            set
            {
                this.OnDebitAmountChanging(value);
                this._DebitAmount = value;
                this.OnDebitAmountChanged();
                this.OnPropertyChanged("DebitAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DebitAmount;
        partial void OnDebitAmountChanging(decimal value);
        partial void OnDebitAmountChanged();
        /// <summary>
        /// There are no comments for Property Text in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Text
        {
            get
            {
                return this._Text;
            }
            set
            {
                this.OnTextChanging(value);
                this._Text = value;
                this.OnTextChanged();
                this.OnPropertyChanged("Text");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Text;
        partial void OnTextChanging(string value);
        partial void OnTextChanged();
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
        /// There are no comments for Property LedgerReportingCurrencyAdjustmentJournalLineCompany in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.LegalEntity LedgerReportingCurrencyAdjustmentJournalLineCompany
        {
            get
            {
                return this._LedgerReportingCurrencyAdjustmentJournalLineCompany;
            }
            set
            {
                this.OnLedgerReportingCurrencyAdjustmentJournalLineCompanyChanging(value);
                this._LedgerReportingCurrencyAdjustmentJournalLineCompany = value;
                this.OnLedgerReportingCurrencyAdjustmentJournalLineCompanyChanged();
                this.OnPropertyChanged("LedgerReportingCurrencyAdjustmentJournalLineCompany");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LegalEntity _LedgerReportingCurrencyAdjustmentJournalLineCompany;
        partial void OnLedgerReportingCurrencyAdjustmentJournalLineCompanyChanging(global::Microsoft.Dynamics.DataEntities.LegalEntity value);
        partial void OnLedgerReportingCurrencyAdjustmentJournalLineCompanyChanged();
        /// <summary>
        /// There are no comments for Property LedgerReportingCurrencyAdjustmentJournalLineCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Currency LedgerReportingCurrencyAdjustmentJournalLineCurrency
        {
            get
            {
                return this._LedgerReportingCurrencyAdjustmentJournalLineCurrency;
            }
            set
            {
                this.OnLedgerReportingCurrencyAdjustmentJournalLineCurrencyChanging(value);
                this._LedgerReportingCurrencyAdjustmentJournalLineCurrency = value;
                this.OnLedgerReportingCurrencyAdjustmentJournalLineCurrencyChanged();
                this.OnPropertyChanged("LedgerReportingCurrencyAdjustmentJournalLineCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Currency _LedgerReportingCurrencyAdjustmentJournalLineCurrency;
        partial void OnLedgerReportingCurrencyAdjustmentJournalLineCurrencyChanging(global::Microsoft.Dynamics.DataEntities.Currency value);
        partial void OnLedgerReportingCurrencyAdjustmentJournalLineCurrencyChanged();
        /// <summary>
        /// There are no comments for Property LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.LegalEntity LegalEntity
        {
            get
            {
                return this._LegalEntity;
            }
            set
            {
                this.OnLegalEntityChanging(value);
                this._LegalEntity = value;
                this.OnLegalEntityChanged();
                this.OnPropertyChanged("LegalEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LegalEntity _LegalEntity;
        partial void OnLegalEntityChanging(global::Microsoft.Dynamics.DataEntities.LegalEntity value);
        partial void OnLegalEntityChanged();
        /// <summary>
        /// There are no comments for Property LedgerReportingCurrencyAdjustmentJournalHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.LedgerReportingCurrencyAdjustmentJournalHeader LedgerReportingCurrencyAdjustmentJournalHeader
        {
            get
            {
                return this._LedgerReportingCurrencyAdjustmentJournalHeader;
            }
            set
            {
                this.OnLedgerReportingCurrencyAdjustmentJournalHeaderChanging(value);
                this._LedgerReportingCurrencyAdjustmentJournalHeader = value;
                this.OnLedgerReportingCurrencyAdjustmentJournalHeaderChanged();
                this.OnPropertyChanged("LedgerReportingCurrencyAdjustmentJournalHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LedgerReportingCurrencyAdjustmentJournalHeader _LedgerReportingCurrencyAdjustmentJournalHeader;
        partial void OnLedgerReportingCurrencyAdjustmentJournalHeaderChanging(global::Microsoft.Dynamics.DataEntities.LedgerReportingCurrencyAdjustmentJournalHeader value);
        partial void OnLedgerReportingCurrencyAdjustmentJournalHeaderChanged();
        /// <summary>
        /// There are no comments for Property LedgerReportingCurrencyAdjustmentJournalLineLedgerDimension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination LedgerReportingCurrencyAdjustmentJournalLineLedgerDimension
        {
            get
            {
                return this._LedgerReportingCurrencyAdjustmentJournalLineLedgerDimension;
            }
            set
            {
                this.OnLedgerReportingCurrencyAdjustmentJournalLineLedgerDimensionChanging(value);
                this._LedgerReportingCurrencyAdjustmentJournalLineLedgerDimension = value;
                this.OnLedgerReportingCurrencyAdjustmentJournalLineLedgerDimensionChanged();
                this.OnPropertyChanged("LedgerReportingCurrencyAdjustmentJournalLineLedgerDimension");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _LedgerReportingCurrencyAdjustmentJournalLineLedgerDimension;
        partial void OnLedgerReportingCurrencyAdjustmentJournalLineLedgerDimensionChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnLedgerReportingCurrencyAdjustmentJournalLineLedgerDimensionChanged();
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
