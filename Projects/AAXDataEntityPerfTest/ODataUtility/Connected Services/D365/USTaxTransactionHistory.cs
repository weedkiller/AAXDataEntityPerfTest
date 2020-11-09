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
        /// There are no comments for USTaxTransactionHistorySingle in the schema.
        /// </summary>
    public partial class USTaxTransactionHistorySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<USTaxTransactionHistory>
    {
        /// <summary>
        /// Initialize a new USTaxTransactionHistorySingle object.
        /// </summary>
        public USTaxTransactionHistorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new USTaxTransactionHistorySingle object.
        /// </summary>
        public USTaxTransactionHistorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new USTaxTransactionHistorySingle object.
        /// </summary>
        public USTaxTransactionHistorySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<USTaxTransactionHistory> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle Worker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Worker == null))
                {
                    this._Worker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("Worker"));
                }
                return this._Worker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _Worker;
        /// <summary>
        /// There are no comments for PayStatementHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayStatementHeaderSingle PayStatementHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PayStatementHeader == null))
                {
                    this._PayStatementHeader = new global::Microsoft.Dynamics.DataEntities.PayStatementHeaderSingle(this.Context, GetPath("PayStatementHeader"));
                }
                return this._PayStatementHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayStatementHeaderSingle _PayStatementHeader;
    }
        /// <summary>
        /// There are no comments for USTaxTransactionHistory in the schema.
        /// </summary>
    /// <KeyProperties>
    /// PersonnelNumber
    /// TaxCodeId
    /// TransDate
    /// CountryRegionId
    /// SequenceNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PersonnelNumber", "TaxCodeId", "TransDate", "CountryRegionId", "SequenceNumber")]
    [global::Microsoft.OData.Client.EntitySet("USTaxTransactionHistories")]
    public partial class USTaxTransactionHistory : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new USTaxTransactionHistory object.
        /// </summary>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="taxCodeId">Initial value of TaxCodeId.</param>
        /// <param name="transDate">Initial value of TransDate.</param>
        /// <param name="countryRegionId">Initial value of CountryRegionId.</param>
        /// <param name="sequenceNumber">Initial value of SequenceNumber.</param>
        /// <param name="grossSubjectWages">Initial value of GrossSubjectWages.</param>
        /// <param name="rate">Initial value of Rate.</param>
        /// <param name="priorStateWageAmount">Initial value of PriorStateWageAmount.</param>
        /// <param name="subjectWages">Initial value of SubjectWages.</param>
        /// <param name="wageBase">Initial value of WageBase.</param>
        /// <param name="hours">Initial value of Hours.</param>
        /// <param name="grossWages">Initial value of GrossWages.</param>
        /// <param name="calculatedTaxAmount">Initial value of CalculatedTaxAmount.</param>
        /// <param name="excessWages">Initial value of ExcessWages.</param>
        /// <param name="worker">Initial value of Worker.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static USTaxTransactionHistory CreateUSTaxTransactionHistory(string personnelNumber, 
                    string taxCodeId, 
                    global::System.DateTimeOffset transDate, 
                    string countryRegionId, 
                    int sequenceNumber, 
                    decimal grossSubjectWages, 
                    decimal rate, 
                    decimal priorStateWageAmount, 
                    decimal subjectWages, 
                    decimal wageBase, 
                    decimal hours, 
                    decimal grossWages, 
                    decimal calculatedTaxAmount, 
                    decimal excessWages, 
                    global::Microsoft.Dynamics.DataEntities.Worker worker)
        {
            USTaxTransactionHistory uSTaxTransactionHistory = new USTaxTransactionHistory();
            uSTaxTransactionHistory.PersonnelNumber = personnelNumber;
            uSTaxTransactionHistory.TaxCodeId = taxCodeId;
            uSTaxTransactionHistory.TransDate = transDate;
            uSTaxTransactionHistory.CountryRegionId = countryRegionId;
            uSTaxTransactionHistory.SequenceNumber = sequenceNumber;
            uSTaxTransactionHistory.GrossSubjectWages = grossSubjectWages;
            uSTaxTransactionHistory.Rate = rate;
            uSTaxTransactionHistory.PriorStateWageAmount = priorStateWageAmount;
            uSTaxTransactionHistory.SubjectWages = subjectWages;
            uSTaxTransactionHistory.WageBase = wageBase;
            uSTaxTransactionHistory.Hours = hours;
            uSTaxTransactionHistory.GrossWages = grossWages;
            uSTaxTransactionHistory.CalculatedTaxAmount = calculatedTaxAmount;
            uSTaxTransactionHistory.ExcessWages = excessWages;
            if ((worker == null))
            {
                throw new global::System.ArgumentNullException("worker");
            }
            uSTaxTransactionHistory.Worker = worker;
            return uSTaxTransactionHistory;
        }
        /// <summary>
        /// There are no comments for Property PersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PersonnelNumber
        {
            get
            {
                return this._PersonnelNumber;
            }
            set
            {
                this.OnPersonnelNumberChanging(value);
                this._PersonnelNumber = value;
                this.OnPersonnelNumberChanged();
                this.OnPropertyChanged("PersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonnelNumber;
        partial void OnPersonnelNumberChanging(string value);
        partial void OnPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property TaxCodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxCodeId
        {
            get
            {
                return this._TaxCodeId;
            }
            set
            {
                this.OnTaxCodeIdChanging(value);
                this._TaxCodeId = value;
                this.OnTaxCodeIdChanged();
                this.OnPropertyChanged("TaxCodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxCodeId;
        partial void OnTaxCodeIdChanging(string value);
        partial void OnTaxCodeIdChanged();
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
        /// There are no comments for Property SequenceNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int SequenceNumber
        {
            get
            {
                return this._SequenceNumber;
            }
            set
            {
                this.OnSequenceNumberChanging(value);
                this._SequenceNumber = value;
                this.OnSequenceNumberChanged();
                this.OnPropertyChanged("SequenceNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _SequenceNumber;
        partial void OnSequenceNumberChanging(int value);
        partial void OnSequenceNumberChanged();
        /// <summary>
        /// There are no comments for Property Residency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollTaxResidency> Residency
        {
            get
            {
                return this._Residency;
            }
            set
            {
                this.OnResidencyChanging(value);
                this._Residency = value;
                this.OnResidencyChanged();
                this.OnPropertyChanged("Residency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollTaxResidency> _Residency;
        partial void OnResidencyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollTaxResidency> value);
        partial void OnResidencyChanged();
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
        /// There are no comments for Property PayStatementNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PayStatementNumber
        {
            get
            {
                return this._PayStatementNumber;
            }
            set
            {
                this.OnPayStatementNumberChanging(value);
                this._PayStatementNumber = value;
                this.OnPayStatementNumberChanged();
                this.OnPropertyChanged("PayStatementNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PayStatementNumber;
        partial void OnPayStatementNumberChanging(string value);
        partial void OnPayStatementNumberChanged();
        /// <summary>
        /// There are no comments for Property GrossSubjectWages in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal GrossSubjectWages
        {
            get
            {
                return this._GrossSubjectWages;
            }
            set
            {
                this.OnGrossSubjectWagesChanging(value);
                this._GrossSubjectWages = value;
                this.OnGrossSubjectWagesChanged();
                this.OnPropertyChanged("GrossSubjectWages");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _GrossSubjectWages;
        partial void OnGrossSubjectWagesChanging(decimal value);
        partial void OnGrossSubjectWagesChanged();
        /// <summary>
        /// There are no comments for Property Rate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Rate
        {
            get
            {
                return this._Rate;
            }
            set
            {
                this.OnRateChanging(value);
                this._Rate = value;
                this.OnRateChanged();
                this.OnPropertyChanged("Rate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Rate;
        partial void OnRateChanging(decimal value);
        partial void OnRateChanged();
        /// <summary>
        /// There are no comments for Property PriorStateWageAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal PriorStateWageAmount
        {
            get
            {
                return this._PriorStateWageAmount;
            }
            set
            {
                this.OnPriorStateWageAmountChanging(value);
                this._PriorStateWageAmount = value;
                this.OnPriorStateWageAmountChanged();
                this.OnPropertyChanged("PriorStateWageAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PriorStateWageAmount;
        partial void OnPriorStateWageAmountChanging(decimal value);
        partial void OnPriorStateWageAmountChanged();
        /// <summary>
        /// There are no comments for Property PriorState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollUSState> PriorState
        {
            get
            {
                return this._PriorState;
            }
            set
            {
                this.OnPriorStateChanging(value);
                this._PriorState = value;
                this.OnPriorStateChanged();
                this.OnPropertyChanged("PriorState");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollUSState> _PriorState;
        partial void OnPriorStateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollUSState> value);
        partial void OnPriorStateChanged();
        /// <summary>
        /// There are no comments for Property SubjectWages in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal SubjectWages
        {
            get
            {
                return this._SubjectWages;
            }
            set
            {
                this.OnSubjectWagesChanging(value);
                this._SubjectWages = value;
                this.OnSubjectWagesChanged();
                this.OnPropertyChanged("SubjectWages");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SubjectWages;
        partial void OnSubjectWagesChanging(decimal value);
        partial void OnSubjectWagesChanged();
        /// <summary>
        /// There are no comments for Property PoliticalSubDivisionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PoliticalSubDivisionId
        {
            get
            {
                return this._PoliticalSubDivisionId;
            }
            set
            {
                this.OnPoliticalSubDivisionIdChanging(value);
                this._PoliticalSubDivisionId = value;
                this.OnPoliticalSubDivisionIdChanged();
                this.OnPropertyChanged("PoliticalSubDivisionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PoliticalSubDivisionId;
        partial void OnPoliticalSubDivisionIdChanging(string value);
        partial void OnPoliticalSubDivisionIdChanged();
        /// <summary>
        /// There are no comments for Property WageBase in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal WageBase
        {
            get
            {
                return this._WageBase;
            }
            set
            {
                this.OnWageBaseChanging(value);
                this._WageBase = value;
                this.OnWageBaseChanged();
                this.OnPropertyChanged("WageBase");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _WageBase;
        partial void OnWageBaseChanging(decimal value);
        partial void OnWageBaseChanged();
        /// <summary>
        /// There are no comments for Property Hours in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Hours
        {
            get
            {
                return this._Hours;
            }
            set
            {
                this.OnHoursChanging(value);
                this._Hours = value;
                this.OnHoursChanged();
                this.OnPropertyChanged("Hours");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Hours;
        partial void OnHoursChanging(decimal value);
        partial void OnHoursChanged();
        /// <summary>
        /// There are no comments for Property TaxPayType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PrlTaxPayType> TaxPayType
        {
            get
            {
                return this._TaxPayType;
            }
            set
            {
                this.OnTaxPayTypeChanging(value);
                this._TaxPayType = value;
                this.OnTaxPayTypeChanged();
                this.OnPropertyChanged("TaxPayType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PrlTaxPayType> _TaxPayType;
        partial void OnTaxPayTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PrlTaxPayType> value);
        partial void OnTaxPayTypeChanged();
        /// <summary>
        /// There are no comments for Property UniqueTaxId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string UniqueTaxId
        {
            get
            {
                return this._UniqueTaxId;
            }
            set
            {
                this.OnUniqueTaxIdChanging(value);
                this._UniqueTaxId = value;
                this.OnUniqueTaxIdChanged();
                this.OnPropertyChanged("UniqueTaxId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UniqueTaxId;
        partial void OnUniqueTaxIdChanging(string value);
        partial void OnUniqueTaxIdChanged();
        /// <summary>
        /// There are no comments for Property GrossWages in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal GrossWages
        {
            get
            {
                return this._GrossWages;
            }
            set
            {
                this.OnGrossWagesChanging(value);
                this._GrossWages = value;
                this.OnGrossWagesChanged();
                this.OnPropertyChanged("GrossWages");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _GrossWages;
        partial void OnGrossWagesChanging(decimal value);
        partial void OnGrossWagesChanged();
        /// <summary>
        /// There are no comments for Property TaxationState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollUSState> TaxationState
        {
            get
            {
                return this._TaxationState;
            }
            set
            {
                this.OnTaxationStateChanging(value);
                this._TaxationState = value;
                this.OnTaxationStateChanged();
                this.OnPropertyChanged("TaxationState");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollUSState> _TaxationState;
        partial void OnTaxationStateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollUSState> value);
        partial void OnTaxationStateChanged();
        /// <summary>
        /// There are no comments for Property CalculatedTaxAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal CalculatedTaxAmount
        {
            get
            {
                return this._CalculatedTaxAmount;
            }
            set
            {
                this.OnCalculatedTaxAmountChanging(value);
                this._CalculatedTaxAmount = value;
                this.OnCalculatedTaxAmountChanged();
                this.OnPropertyChanged("CalculatedTaxAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CalculatedTaxAmount;
        partial void OnCalculatedTaxAmountChanging(decimal value);
        partial void OnCalculatedTaxAmountChanged();
        /// <summary>
        /// There are no comments for Property ExcessWages in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ExcessWages
        {
            get
            {
                return this._ExcessWages;
            }
            set
            {
                this.OnExcessWagesChanging(value);
                this._ExcessWages = value;
                this.OnExcessWagesChanged();
                this.OnPropertyChanged("ExcessWages");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ExcessWages;
        partial void OnExcessWagesChanging(decimal value);
        partial void OnExcessWagesChanged();
        /// <summary>
        /// There are no comments for Property State in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string State
        {
            get
            {
                return this._State;
            }
            set
            {
                this.OnStateChanging(value);
                this._State = value;
                this.OnStateChanged();
                this.OnPropertyChanged("State");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _State;
        partial void OnStateChanging(string value);
        partial void OnStateChanged();
        /// <summary>
        /// There are no comments for Property Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Worker Worker
        {
            get
            {
                return this._Worker;
            }
            set
            {
                this.OnWorkerChanging(value);
                this._Worker = value;
                this.OnWorkerChanged();
                this.OnPropertyChanged("Worker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _Worker;
        partial void OnWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnWorkerChanged();
        /// <summary>
        /// There are no comments for Property PayStatementHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PayStatementHeader PayStatementHeader
        {
            get
            {
                return this._PayStatementHeader;
            }
            set
            {
                this.OnPayStatementHeaderChanging(value);
                this._PayStatementHeader = value;
                this.OnPayStatementHeaderChanged();
                this.OnPropertyChanged("PayStatementHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PayStatementHeader _PayStatementHeader;
        partial void OnPayStatementHeaderChanging(global::Microsoft.Dynamics.DataEntities.PayStatementHeader value);
        partial void OnPayStatementHeaderChanged();
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
