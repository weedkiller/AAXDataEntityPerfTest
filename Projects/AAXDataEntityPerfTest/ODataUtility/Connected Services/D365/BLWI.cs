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
    /// There are no comments for BLWISingle in the schema.
    /// </summary>
    public partial class BLWISingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BLWI>
    {
        /// <summary>
        /// Initialize a new BLWISingle object.
        /// </summary>
        public BLWISingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BLWISingle object.
        /// </summary>
        public BLWISingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BLWISingle object.
        /// </summary>
        public BLWISingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BLWI> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for BLWI in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// Company
    /// BLWITransaction
    /// AccountNumber
    /// Voucher
    /// Invoice
    /// TransactionDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Company", "BLWITransaction", "AccountNumber", "Voucher", "Invoice", "TransactionDate")]
    [global::Microsoft.OData.Client.EntitySet("BLWI")]
    public partial class BLWI : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BLWI object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="company">Initial value of Company.</param>
        /// <param name="accountNumber">Initial value of AccountNumber.</param>
        /// <param name="voucher">Initial value of Voucher.</param>
        /// <param name="invoice">Initial value of Invoice.</param>
        /// <param name="transactionDate">Initial value of TransactionDate.</param>
        /// <param name="reportingDate">Initial value of ReportingDate.</param>
        /// <param name="surveyCode">Initial value of SurveyCode.</param>
        /// <param name="countryRegionGroupRowNumber">Initial value of CountryRegionGroupRowNumber.</param>
        /// <param name="amount">Initial value of Amount.</param>
        /// <param name="originalAmount">Initial value of OriginalAmount.</param>
        /// <param name="amountInTransactionCurrency">Initial value of AmountInTransactionCurrency.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BLWI CreateBLWI(string dataAreaId, 
                    string company, 
                    string accountNumber, 
                    string voucher, 
                    string invoice, 
                    global::System.DateTimeOffset transactionDate, 
                    global::System.DateTimeOffset reportingDate, 
                    long surveyCode, 
                    int countryRegionGroupRowNumber, 
                    decimal amount, 
                    decimal originalAmount, 
                    decimal amountInTransactionCurrency)
        {
            BLWI bLWI = new BLWI();
            bLWI.dataAreaId = dataAreaId;
            bLWI.Company = company;
            bLWI.AccountNumber = accountNumber;
            bLWI.Voucher = voucher;
            bLWI.Invoice = invoice;
            bLWI.TransactionDate = transactionDate;
            bLWI.ReportingDate = reportingDate;
            bLWI.SurveyCode = surveyCode;
            bLWI.CountryRegionGroupRowNumber = countryRegionGroupRowNumber;
            bLWI.Amount = amount;
            bLWI.OriginalAmount = originalAmount;
            bLWI.AmountInTransactionCurrency = amountInTransactionCurrency;
            return bLWI;
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
        /// There are no comments for Property BLWITransaction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TradeBLWICustVend> BLWITransaction
        {
            get
            {
                return this._BLWITransaction;
            }
            set
            {
                this.OnBLWITransactionChanging(value);
                this._BLWITransaction = value;
                this.OnBLWITransactionChanged();
                this.OnPropertyChanged("BLWITransaction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TradeBLWICustVend> _BLWITransaction;
        partial void OnBLWITransactionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TradeBLWICustVend> value);
        partial void OnBLWITransactionChanged();
        /// <summary>
        /// There are no comments for Property AccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AccountNumber
        {
            get
            {
                return this._AccountNumber;
            }
            set
            {
                this.OnAccountNumberChanging(value);
                this._AccountNumber = value;
                this.OnAccountNumberChanged();
                this.OnPropertyChanged("AccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountNumber;
        partial void OnAccountNumberChanging(string value);
        partial void OnAccountNumberChanged();
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
        /// There are no comments for Property Invoice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Invoice
        {
            get
            {
                return this._Invoice;
            }
            set
            {
                this.OnInvoiceChanging(value);
                this._Invoice = value;
                this.OnInvoiceChanged();
                this.OnPropertyChanged("Invoice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Invoice;
        partial void OnInvoiceChanging(string value);
        partial void OnInvoiceChanged();
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
        /// There are no comments for Property PurposeCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PurposeCode
        {
            get
            {
                return this._PurposeCode;
            }
            set
            {
                this.OnPurposeCodeChanging(value);
                this._PurposeCode = value;
                this.OnPurposeCodeChanged();
                this.OnPropertyChanged("PurposeCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PurposeCode;
        partial void OnPurposeCodeChanging(string value);
        partial void OnPurposeCodeChanged();
        /// <summary>
        /// There are no comments for Property CountryRegionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CountryRegionId
        {
            get
            {
                return this._CountryRegionId;
            }
            set
            {
                this.OnCountryRegionIdChanging(value);
                this._CountryRegionId = value;
                this.OnCountryRegionIdChanged();
                this.OnPropertyChanged("CountryRegionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CountryRegionId;
        partial void OnCountryRegionIdChanging(string value);
        partial void OnCountryRegionIdChanged();
        /// <summary>
        /// There are no comments for Property CountryRegionGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CountryRegionGroupId
        {
            get
            {
                return this._CountryRegionGroupId;
            }
            set
            {
                this.OnCountryRegionGroupIdChanging(value);
                this._CountryRegionGroupId = value;
                this.OnCountryRegionGroupIdChanged();
                this.OnPropertyChanged("CountryRegionGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CountryRegionGroupId;
        partial void OnCountryRegionGroupIdChanging(string value);
        partial void OnCountryRegionGroupIdChanged();
        /// <summary>
        /// There are no comments for Property ReportingDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ReportingDate
        {
            get
            {
                return this._ReportingDate;
            }
            set
            {
                this.OnReportingDateChanging(value);
                this._ReportingDate = value;
                this.OnReportingDateChanged();
                this.OnPropertyChanged("ReportingDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ReportingDate;
        partial void OnReportingDateChanging(global::System.DateTimeOffset value);
        partial void OnReportingDateChanged();
        /// <summary>
        /// There are no comments for Property AutoGenerated in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AutoGenerated
        {
            get
            {
                return this._AutoGenerated;
            }
            set
            {
                this.OnAutoGeneratedChanging(value);
                this._AutoGenerated = value;
                this.OnAutoGeneratedChanged();
                this.OnPropertyChanged("AutoGenerated");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AutoGenerated;
        partial void OnAutoGeneratedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAutoGeneratedChanged();
        /// <summary>
        /// There are no comments for Property Included in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Included
        {
            get
            {
                return this._Included;
            }
            set
            {
                this.OnIncludedChanging(value);
                this._Included = value;
                this.OnIncludedChanged();
                this.OnPropertyChanged("Included");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Included;
        partial void OnIncludedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIncludedChanged();
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
        /// There are no comments for Property SurveyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long SurveyCode
        {
            get
            {
                return this._SurveyCode;
            }
            set
            {
                this.OnSurveyCodeChanging(value);
                this._SurveyCode = value;
                this.OnSurveyCodeChanged();
                this.OnPropertyChanged("SurveyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _SurveyCode;
        partial void OnSurveyCodeChanging(long value);
        partial void OnSurveyCodeChanged();
        /// <summary>
        /// There are no comments for Property CountryRegionGroupRowNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int CountryRegionGroupRowNumber
        {
            get
            {
                return this._CountryRegionGroupRowNumber;
            }
            set
            {
                this.OnCountryRegionGroupRowNumberChanging(value);
                this._CountryRegionGroupRowNumber = value;
                this.OnCountryRegionGroupRowNumberChanged();
                this.OnPropertyChanged("CountryRegionGroupRowNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _CountryRegionGroupRowNumber;
        partial void OnCountryRegionGroupRowNumberChanging(int value);
        partial void OnCountryRegionGroupRowNumberChanged();
        /// <summary>
        /// There are no comments for Property CountryRegionName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CountryRegionName
        {
            get
            {
                return this._CountryRegionName;
            }
            set
            {
                this.OnCountryRegionNameChanging(value);
                this._CountryRegionName = value;
                this.OnCountryRegionNameChanged();
                this.OnPropertyChanged("CountryRegionName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CountryRegionName;
        partial void OnCountryRegionNameChanging(string value);
        partial void OnCountryRegionNameChanged();
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
        /// There are no comments for Property CountryRegionGroupBLWIReporting in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> CountryRegionGroupBLWIReporting
        {
            get
            {
                return this._CountryRegionGroupBLWIReporting;
            }
            set
            {
                this.OnCountryRegionGroupBLWIReportingChanging(value);
                this._CountryRegionGroupBLWIReporting = value;
                this.OnCountryRegionGroupBLWIReportingChanged();
                this.OnPropertyChanged("CountryRegionGroupBLWIReporting");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _CountryRegionGroupBLWIReporting;
        partial void OnCountryRegionGroupBLWIReportingChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnCountryRegionGroupBLWIReportingChanged();
        /// <summary>
        /// There are no comments for Property CountryRegionGroupDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CountryRegionGroupDescription
        {
            get
            {
                return this._CountryRegionGroupDescription;
            }
            set
            {
                this.OnCountryRegionGroupDescriptionChanging(value);
                this._CountryRegionGroupDescription = value;
                this.OnCountryRegionGroupDescriptionChanged();
                this.OnPropertyChanged("CountryRegionGroupDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CountryRegionGroupDescription;
        partial void OnCountryRegionGroupDescriptionChanging(string value);
        partial void OnCountryRegionGroupDescriptionChanged();
        /// <summary>
        /// There are no comments for Property OriginalAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal OriginalAmount
        {
            get
            {
                return this._OriginalAmount;
            }
            set
            {
                this.OnOriginalAmountChanging(value);
                this._OriginalAmount = value;
                this.OnOriginalAmountChanged();
                this.OnPropertyChanged("OriginalAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _OriginalAmount;
        partial void OnOriginalAmountChanging(decimal value);
        partial void OnOriginalAmountChanged();
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
