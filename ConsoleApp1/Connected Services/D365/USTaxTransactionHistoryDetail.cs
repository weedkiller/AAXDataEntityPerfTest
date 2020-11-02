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
    /// There are no comments for USTaxTransactionHistoryDetailSingle in the schema.
    /// </summary>
    public partial class USTaxTransactionHistoryDetailSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<USTaxTransactionHistoryDetail>
    {
        /// <summary>
        /// Initialize a new USTaxTransactionHistoryDetailSingle object.
        /// </summary>
        public USTaxTransactionHistoryDetailSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new USTaxTransactionHistoryDetailSingle object.
        /// </summary>
        public USTaxTransactionHistoryDetailSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new USTaxTransactionHistoryDetailSingle object.
        /// </summary>
        public USTaxTransactionHistoryDetailSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<USTaxTransactionHistoryDetail> query)
            : base(query) {}

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
    /// There are no comments for USTaxTransactionHistoryDetail in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// PersonnelNumber
    /// TransDate
    /// PayStatementNumber
    /// Code
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PersonnelNumber", "TransDate", "PayStatementNumber", "Code")]
    [global::Microsoft.OData.Client.EntitySet("USTaxTransactionHistoryDetails")]
    public partial class USTaxTransactionHistoryDetail : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new USTaxTransactionHistoryDetail object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="transDate">Initial value of TransDate.</param>
        /// <param name="payStatementNumber">Initial value of PayStatementNumber.</param>
        /// <param name="code">Initial value of Code.</param>
        /// <param name="grossSubjectWages">Initial value of GrossSubjectWages.</param>
        /// <param name="priorStateWageAmount">Initial value of PriorStateWageAmount.</param>
        /// <param name="rate">Initial value of Rate.</param>
        /// <param name="subjectWages">Initial value of SubjectWages.</param>
        /// <param name="wageBase">Initial value of WageBase.</param>
        /// <param name="hours">Initial value of Hours.</param>
        /// <param name="grossWages">Initial value of GrossWages.</param>
        /// <param name="calculatedTaxAmount">Initial value of CalculatedTaxAmount.</param>
        /// <param name="excessWages">Initial value of ExcessWages.</param>
        /// <param name="payStatementHeader">Initial value of PayStatementHeader.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static USTaxTransactionHistoryDetail CreateUSTaxTransactionHistoryDetail(string dataAreaId, 
                    string personnelNumber, 
                    global::System.DateTimeOffset transDate, 
                    string payStatementNumber, 
                    string code, 
                    decimal grossSubjectWages, 
                    decimal priorStateWageAmount, 
                    decimal rate, 
                    decimal subjectWages, 
                    decimal wageBase, 
                    decimal hours, 
                    decimal grossWages, 
                    decimal calculatedTaxAmount, 
                    decimal excessWages, 
                    global::Microsoft.Dynamics.DataEntities.PayStatementHeader payStatementHeader)
        {
            USTaxTransactionHistoryDetail uSTaxTransactionHistoryDetail = new USTaxTransactionHistoryDetail();
            uSTaxTransactionHistoryDetail.dataAreaId = dataAreaId;
            uSTaxTransactionHistoryDetail.PersonnelNumber = personnelNumber;
            uSTaxTransactionHistoryDetail.TransDate = transDate;
            uSTaxTransactionHistoryDetail.PayStatementNumber = payStatementNumber;
            uSTaxTransactionHistoryDetail.Code = code;
            uSTaxTransactionHistoryDetail.GrossSubjectWages = grossSubjectWages;
            uSTaxTransactionHistoryDetail.PriorStateWageAmount = priorStateWageAmount;
            uSTaxTransactionHistoryDetail.Rate = rate;
            uSTaxTransactionHistoryDetail.SubjectWages = subjectWages;
            uSTaxTransactionHistoryDetail.WageBase = wageBase;
            uSTaxTransactionHistoryDetail.Hours = hours;
            uSTaxTransactionHistoryDetail.GrossWages = grossWages;
            uSTaxTransactionHistoryDetail.CalculatedTaxAmount = calculatedTaxAmount;
            uSTaxTransactionHistoryDetail.ExcessWages = excessWages;
            if ((payStatementHeader == null))
            {
                throw new global::System.ArgumentNullException("payStatementHeader");
            }
            uSTaxTransactionHistoryDetail.PayStatementHeader = payStatementHeader;
            return uSTaxTransactionHistoryDetail;
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
        /// There are no comments for Property Code in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Code
        {
            get
            {
                return this._Code;
            }
            set
            {
                this.OnCodeChanging(value);
                this._Code = value;
                this.OnCodeChanged();
                this.OnPropertyChanged("Code");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Code;
        partial void OnCodeChanging(string value);
        partial void OnCodeChanged();
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
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollTaxCodeType> Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this.OnTypeChanging(value);
                this._Type = value;
                this.OnTypeChanged();
                this.OnPropertyChanged("Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollTaxCodeType> _Type;
        partial void OnTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollTaxCodeType> value);
        partial void OnTypeChanged();
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
        /// There are no comments for Property Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Worker
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
        private string _Worker;
        partial void OnWorkerChanging(string value);
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
