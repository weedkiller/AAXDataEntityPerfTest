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
    /// There are no comments for RAssetJournalLineSingle in the schema.
    /// </summary>
    public partial class RAssetJournalLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RAssetJournalLine>
    {
        /// <summary>
        /// Initialize a new RAssetJournalLineSingle object.
        /// </summary>
        public RAssetJournalLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RAssetJournalLineSingle object.
        /// </summary>
        public RAssetJournalLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RAssetJournalLineSingle object.
        /// </summary>
        public RAssetJournalLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RAssetJournalLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetJournalHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetJournalHeaderSingle AssetJournalHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetJournalHeader == null))
                {
                    this._AssetJournalHeader = new global::Microsoft.Dynamics.DataEntities.AssetJournalHeaderSingle(this.Context, GetPath("AssetJournalHeader"));
                }
                return this._AssetJournalHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetJournalHeaderSingle _AssetJournalHeader;
        /// <summary>
        /// There are no comments for RAssetJournalLineOffsetLedgerDimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle RAssetJournalLineOffsetLedgerDimensionCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RAssetJournalLineOffsetLedgerDimensionCombination == null))
                {
                    this._RAssetJournalLineOffsetLedgerDimensionCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("RAssetJournalLineOffsetLedgerDimensionCombination"));
                }
                return this._RAssetJournalLineOffsetLedgerDimensionCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _RAssetJournalLineOffsetLedgerDimensionCombination;
        /// <summary>
        /// There are no comments for RAssetJournalLineCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CurrencySingle RAssetJournalLineCurrency
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RAssetJournalLineCurrency == null))
                {
                    this._RAssetJournalLineCurrency = new global::Microsoft.Dynamics.DataEntities.CurrencySingle(this.Context, GetPath("RAssetJournalLineCurrency"));
                }
                return this._RAssetJournalLineCurrency;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CurrencySingle _RAssetJournalLineCurrency;
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
        /// There are no comments for RAssetJournalLineLedgerDimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle RAssetJournalLineLedgerDimensionCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RAssetJournalLineLedgerDimensionCombination == null))
                {
                    this._RAssetJournalLineLedgerDimensionCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("RAssetJournalLineLedgerDimensionCombination"));
                }
                return this._RAssetJournalLineLedgerDimensionCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _RAssetJournalLineLedgerDimensionCombination;
    }
    /// <summary>
    /// There are no comments for RAssetJournalLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// JournalBatchNumber
    /// LineNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "JournalBatchNumber", "LineNumber")]
    [global::Microsoft.OData.Client.EntitySet("RAssetJournalLines")]
    public partial class RAssetJournalLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RAssetJournalLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="journalBatchNumber">Initial value of JournalBatchNumber.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="creditAmount">Initial value of CreditAmount.</param>
        /// <param name="transDate">Initial value of TransDate.</param>
        /// <param name="debitAmount">Initial value of DebitAmount.</param>
        /// <param name="assetJournalHeader">Initial value of AssetJournalHeader.</param>
        /// <param name="rAssetJournalLineCurrency">Initial value of RAssetJournalLineCurrency.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RAssetJournalLine CreateRAssetJournalLine(string dataAreaId, 
                    string journalBatchNumber, 
                    decimal lineNumber, 
                    decimal creditAmount, 
                    global::System.DateTimeOffset transDate, 
                    decimal debitAmount, 
                    global::Microsoft.Dynamics.DataEntities.AssetJournalHeader assetJournalHeader, 
                    global::Microsoft.Dynamics.DataEntities.Currency rAssetJournalLineCurrency)
        {
            RAssetJournalLine rAssetJournalLine = new RAssetJournalLine();
            rAssetJournalLine.dataAreaId = dataAreaId;
            rAssetJournalLine.JournalBatchNumber = journalBatchNumber;
            rAssetJournalLine.LineNumber = lineNumber;
            rAssetJournalLine.CreditAmount = creditAmount;
            rAssetJournalLine.TransDate = transDate;
            rAssetJournalLine.DebitAmount = debitAmount;
            if ((assetJournalHeader == null))
            {
                throw new global::System.ArgumentNullException("assetJournalHeader");
            }
            rAssetJournalLine.AssetJournalHeader = assetJournalHeader;
            if ((rAssetJournalLineCurrency == null))
            {
                throw new global::System.ArgumentNullException("rAssetJournalLineCurrency");
            }
            rAssetJournalLine.RAssetJournalLineCurrency = rAssetJournalLineCurrency;
            return rAssetJournalLine;
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
        /// There are no comments for Property Voucher in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Voucher
        {
            get
            {
                return this._Voucher;
            }
            set
            {
                this.OnVoucherChanging(value);
                this._Voucher = value;
                this.OnVoucherChanged();
                this.OnPropertyChanged("Voucher");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Voucher;
        partial void OnVoucherChanging(string value);
        partial void OnVoucherChanged();
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
        /// There are no comments for Property TransactionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RAssetTransType> TransactionType
        {
            get
            {
                return this._TransactionType;
            }
            set
            {
                this.OnTransactionTypeChanging(value);
                this._TransactionType = value;
                this.OnTransactionTypeChanged();
                this.OnPropertyChanged("TransactionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RAssetTransType> _TransactionType;
        partial void OnTransactionTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RAssetTransType> value);
        partial void OnTransactionTypeChanged();
        /// <summary>
        /// There are no comments for Property OffsetAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OffsetAccountDisplayValue
        {
            get
            {
                return this._OffsetAccountDisplayValue;
            }
            set
            {
                this.OnOffsetAccountDisplayValueChanging(value);
                this._OffsetAccountDisplayValue = value;
                this.OnOffsetAccountDisplayValueChanged();
                this.OnPropertyChanged("OffsetAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OffsetAccountDisplayValue;
        partial void OnOffsetAccountDisplayValueChanging(string value);
        partial void OnOffsetAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property OffsetAccountType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerJournalACType> OffsetAccountType
        {
            get
            {
                return this._OffsetAccountType;
            }
            set
            {
                this.OnOffsetAccountTypeChanging(value);
                this._OffsetAccountType = value;
                this.OnOffsetAccountTypeChanged();
                this.OnPropertyChanged("OffsetAccountType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerJournalACType> _OffsetAccountType;
        partial void OnOffsetAccountTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerJournalACType> value);
        partial void OnOffsetAccountTypeChanged();
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
        /// There are no comments for Property ValueModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ValueModel
        {
            get
            {
                return this._ValueModel;
            }
            set
            {
                this.OnValueModelChanging(value);
                this._ValueModel = value;
                this.OnValueModelChanged();
                this.OnPropertyChanged("ValueModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ValueModel;
        partial void OnValueModelChanging(string value);
        partial void OnValueModelChanged();
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
        /// There are no comments for Property DepreciationBonus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DepreciationBonus
        {
            get
            {
                return this._DepreciationBonus;
            }
            set
            {
                this.OnDepreciationBonusChanging(value);
                this._DepreciationBonus = value;
                this.OnDepreciationBonusChanged();
                this.OnPropertyChanged("DepreciationBonus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DepreciationBonus;
        partial void OnDepreciationBonusChanging(string value);
        partial void OnDepreciationBonusChanged();
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
        /// There are no comments for Property AssetJournalHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AssetJournalHeader AssetJournalHeader
        {
            get
            {
                return this._AssetJournalHeader;
            }
            set
            {
                this.OnAssetJournalHeaderChanging(value);
                this._AssetJournalHeader = value;
                this.OnAssetJournalHeaderChanged();
                this.OnPropertyChanged("AssetJournalHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AssetJournalHeader _AssetJournalHeader;
        partial void OnAssetJournalHeaderChanging(global::Microsoft.Dynamics.DataEntities.AssetJournalHeader value);
        partial void OnAssetJournalHeaderChanged();
        /// <summary>
        /// There are no comments for Property RAssetJournalLineOffsetLedgerDimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination RAssetJournalLineOffsetLedgerDimensionCombination
        {
            get
            {
                return this._RAssetJournalLineOffsetLedgerDimensionCombination;
            }
            set
            {
                this.OnRAssetJournalLineOffsetLedgerDimensionCombinationChanging(value);
                this._RAssetJournalLineOffsetLedgerDimensionCombination = value;
                this.OnRAssetJournalLineOffsetLedgerDimensionCombinationChanged();
                this.OnPropertyChanged("RAssetJournalLineOffsetLedgerDimensionCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _RAssetJournalLineOffsetLedgerDimensionCombination;
        partial void OnRAssetJournalLineOffsetLedgerDimensionCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnRAssetJournalLineOffsetLedgerDimensionCombinationChanged();
        /// <summary>
        /// There are no comments for Property RAssetJournalLineCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Currency RAssetJournalLineCurrency
        {
            get
            {
                return this._RAssetJournalLineCurrency;
            }
            set
            {
                this.OnRAssetJournalLineCurrencyChanging(value);
                this._RAssetJournalLineCurrency = value;
                this.OnRAssetJournalLineCurrencyChanged();
                this.OnPropertyChanged("RAssetJournalLineCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Currency _RAssetJournalLineCurrency;
        partial void OnRAssetJournalLineCurrencyChanging(global::Microsoft.Dynamics.DataEntities.Currency value);
        partial void OnRAssetJournalLineCurrencyChanged();
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
        /// There are no comments for Property RAssetJournalLineLedgerDimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination RAssetJournalLineLedgerDimensionCombination
        {
            get
            {
                return this._RAssetJournalLineLedgerDimensionCombination;
            }
            set
            {
                this.OnRAssetJournalLineLedgerDimensionCombinationChanging(value);
                this._RAssetJournalLineLedgerDimensionCombination = value;
                this.OnRAssetJournalLineLedgerDimensionCombinationChanged();
                this.OnPropertyChanged("RAssetJournalLineLedgerDimensionCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _RAssetJournalLineLedgerDimensionCombination;
        partial void OnRAssetJournalLineLedgerDimensionCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnRAssetJournalLineLedgerDimensionCombinationChanged();
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
