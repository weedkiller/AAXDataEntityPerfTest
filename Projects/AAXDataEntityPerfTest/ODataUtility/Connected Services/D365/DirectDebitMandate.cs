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
    /// There are no comments for DirectDebitMandateSingle in the schema.
    /// </summary>
    public partial class DirectDebitMandateSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DirectDebitMandate>
    {
        /// <summary>
        /// Initialize a new DirectDebitMandateSingle object.
        /// </summary>
        public DirectDebitMandateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DirectDebitMandateSingle object.
        /// </summary>
        public DirectDebitMandateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DirectDebitMandateSingle object.
        /// </summary>
        public DirectDebitMandateSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DirectDebitMandate> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for DirectDebitMandate in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// MandateId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "MandateId")]
    [global::Microsoft.OData.Client.EntitySet("DirectDebitMandates")]
    public partial class DirectDebitMandate : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DirectDebitMandate object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="mandateId">Initial value of MandateId.</param>
        /// <param name="daysForRecurringPrenotification">Initial value of DaysForRecurringPrenotification.</param>
        /// <param name="daysForRecurringBankSubmission">Initial value of DaysForRecurringBankSubmission.</param>
        /// <param name="daysForFirstBankSubmission">Initial value of DaysForFirstBankSubmission.</param>
        /// <param name="daysForFirstPrenotification">Initial value of DaysForFirstPrenotification.</param>
        /// <param name="usageCount">Initial value of UsageCount.</param>
        /// <param name="cancellationDate">Initial value of CancellationDate.</param>
        /// <param name="signatureDate">Initial value of SignatureDate.</param>
        /// <param name="expectedNumberOfPayments">Initial value of ExpectedNumberOfPayments.</param>
        /// <param name="expirationDate">Initial value of ExpirationDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DirectDebitMandate CreateDirectDebitMandate(string dataAreaId, 
                    string mandateId, 
                    int daysForRecurringPrenotification, 
                    int daysForRecurringBankSubmission, 
                    int daysForFirstBankSubmission, 
                    int daysForFirstPrenotification, 
                    int usageCount, 
                    global::System.DateTimeOffset cancellationDate, 
                    global::System.DateTimeOffset signatureDate, 
                    int expectedNumberOfPayments, 
                    global::System.DateTimeOffset expirationDate)
        {
            DirectDebitMandate directDebitMandate = new DirectDebitMandate();
            directDebitMandate.dataAreaId = dataAreaId;
            directDebitMandate.MandateId = mandateId;
            directDebitMandate.DaysForRecurringPrenotification = daysForRecurringPrenotification;
            directDebitMandate.DaysForRecurringBankSubmission = daysForRecurringBankSubmission;
            directDebitMandate.DaysForFirstBankSubmission = daysForFirstBankSubmission;
            directDebitMandate.DaysForFirstPrenotification = daysForFirstPrenotification;
            directDebitMandate.UsageCount = usageCount;
            directDebitMandate.CancellationDate = cancellationDate;
            directDebitMandate.SignatureDate = signatureDate;
            directDebitMandate.ExpectedNumberOfPayments = expectedNumberOfPayments;
            directDebitMandate.ExpirationDate = expirationDate;
            return directDebitMandate;
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
        /// There are no comments for Property MandateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MandateId
        {
            get
            {
                return this._MandateId;
            }
            set
            {
                this.OnMandateIdChanging(value);
                this._MandateId = value;
                this.OnMandateIdChanged();
                this.OnPropertyChanged("MandateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MandateId;
        partial void OnMandateIdChanging(string value);
        partial void OnMandateIdChanged();
        /// <summary>
        /// There are no comments for Property DaysForRecurringPrenotification in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int DaysForRecurringPrenotification
        {
            get
            {
                return this._DaysForRecurringPrenotification;
            }
            set
            {
                this.OnDaysForRecurringPrenotificationChanging(value);
                this._DaysForRecurringPrenotification = value;
                this.OnDaysForRecurringPrenotificationChanged();
                this.OnPropertyChanged("DaysForRecurringPrenotification");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _DaysForRecurringPrenotification;
        partial void OnDaysForRecurringPrenotificationChanging(int value);
        partial void OnDaysForRecurringPrenotificationChanged();
        /// <summary>
        /// There are no comments for Property CustomerAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CustomerAccount
        {
            get
            {
                return this._CustomerAccount;
            }
            set
            {
                this.OnCustomerAccountChanging(value);
                this._CustomerAccount = value;
                this.OnCustomerAccountChanged();
                this.OnPropertyChanged("CustomerAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerAccount;
        partial void OnCustomerAccountChanging(string value);
        partial void OnCustomerAccountChanged();
        /// <summary>
        /// There are no comments for Property MandatePaymentType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustMandatePaymentType> MandatePaymentType
        {
            get
            {
                return this._MandatePaymentType;
            }
            set
            {
                this.OnMandatePaymentTypeChanging(value);
                this._MandatePaymentType = value;
                this.OnMandatePaymentTypeChanged();
                this.OnPropertyChanged("MandatePaymentType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustMandatePaymentType> _MandatePaymentType;
        partial void OnMandatePaymentTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustMandatePaymentType> value);
        partial void OnMandatePaymentTypeChanged();
        /// <summary>
        /// There are no comments for Property MandateScheme in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustMandateScheme> MandateScheme
        {
            get
            {
                return this._MandateScheme;
            }
            set
            {
                this.OnMandateSchemeChanging(value);
                this._MandateScheme = value;
                this.OnMandateSchemeChanged();
                this.OnPropertyChanged("MandateScheme");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustMandateScheme> _MandateScheme;
        partial void OnMandateSchemeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustMandateScheme> value);
        partial void OnMandateSchemeChanged();
        /// <summary>
        /// There are no comments for Property DaysForRecurringBankSubmission in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int DaysForRecurringBankSubmission
        {
            get
            {
                return this._DaysForRecurringBankSubmission;
            }
            set
            {
                this.OnDaysForRecurringBankSubmissionChanging(value);
                this._DaysForRecurringBankSubmission = value;
                this.OnDaysForRecurringBankSubmissionChanged();
                this.OnPropertyChanged("DaysForRecurringBankSubmission");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _DaysForRecurringBankSubmission;
        partial void OnDaysForRecurringBankSubmissionChanging(int value);
        partial void OnDaysForRecurringBankSubmissionChanged();
        /// <summary>
        /// There are no comments for Property DaysForFirstBankSubmission in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int DaysForFirstBankSubmission
        {
            get
            {
                return this._DaysForFirstBankSubmission;
            }
            set
            {
                this.OnDaysForFirstBankSubmissionChanging(value);
                this._DaysForFirstBankSubmission = value;
                this.OnDaysForFirstBankSubmissionChanged();
                this.OnPropertyChanged("DaysForFirstBankSubmission");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _DaysForFirstBankSubmission;
        partial void OnDaysForFirstBankSubmissionChanging(int value);
        partial void OnDaysForFirstBankSubmissionChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustMandateStatus> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustMandateStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CustMandateStatus> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property CustomerBankAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CustomerBankAccount
        {
            get
            {
                return this._CustomerBankAccount;
            }
            set
            {
                this.OnCustomerBankAccountChanging(value);
                this._CustomerBankAccount = value;
                this.OnCustomerBankAccountChanged();
                this.OnPropertyChanged("CustomerBankAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerBankAccount;
        partial void OnCustomerBankAccountChanging(string value);
        partial void OnCustomerBankAccountChanged();
        /// <summary>
        /// There are no comments for Property DaysForFirstPrenotification in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int DaysForFirstPrenotification
        {
            get
            {
                return this._DaysForFirstPrenotification;
            }
            set
            {
                this.OnDaysForFirstPrenotificationChanging(value);
                this._DaysForFirstPrenotification = value;
                this.OnDaysForFirstPrenotificationChanged();
                this.OnPropertyChanged("DaysForFirstPrenotification");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _DaysForFirstPrenotification;
        partial void OnDaysForFirstPrenotificationChanging(int value);
        partial void OnDaysForFirstPrenotificationChanged();
        /// <summary>
        /// There are no comments for Property SignatureLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SignatureLocation
        {
            get
            {
                return this._SignatureLocation;
            }
            set
            {
                this.OnSignatureLocationChanging(value);
                this._SignatureLocation = value;
                this.OnSignatureLocationChanged();
                this.OnPropertyChanged("SignatureLocation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SignatureLocation;
        partial void OnSignatureLocationChanging(string value);
        partial void OnSignatureLocationChanged();
        /// <summary>
        /// There are no comments for Property CustomerAddress in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CustomerAddress
        {
            get
            {
                return this._CustomerAddress;
            }
            set
            {
                this.OnCustomerAddressChanging(value);
                this._CustomerAddress = value;
                this.OnCustomerAddressChanged();
                this.OnPropertyChanged("CustomerAddress");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerAddress;
        partial void OnCustomerAddressChanging(string value);
        partial void OnCustomerAddressChanged();
        /// <summary>
        /// There are no comments for Property CreditorBankAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CreditorBankAccount
        {
            get
            {
                return this._CreditorBankAccount;
            }
            set
            {
                this.OnCreditorBankAccountChanging(value);
                this._CreditorBankAccount = value;
                this.OnCreditorBankAccountChanged();
                this.OnPropertyChanged("CreditorBankAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CreditorBankAccount;
        partial void OnCreditorBankAccountChanging(string value);
        partial void OnCreditorBankAccountChanged();
        /// <summary>
        /// There are no comments for Property UsageCount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int UsageCount
        {
            get
            {
                return this._UsageCount;
            }
            set
            {
                this.OnUsageCountChanging(value);
                this._UsageCount = value;
                this.OnUsageCountChanged();
                this.OnPropertyChanged("UsageCount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _UsageCount;
        partial void OnUsageCountChanging(int value);
        partial void OnUsageCountChanged();
        /// <summary>
        /// There are no comments for Property CancellationDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset CancellationDate
        {
            get
            {
                return this._CancellationDate;
            }
            set
            {
                this.OnCancellationDateChanging(value);
                this._CancellationDate = value;
                this.OnCancellationDateChanged();
                this.OnPropertyChanged("CancellationDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _CancellationDate;
        partial void OnCancellationDateChanging(global::System.DateTimeOffset value);
        partial void OnCancellationDateChanged();
        /// <summary>
        /// There are no comments for Property SignatureDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset SignatureDate
        {
            get
            {
                return this._SignatureDate;
            }
            set
            {
                this.OnSignatureDateChanging(value);
                this._SignatureDate = value;
                this.OnSignatureDateChanged();
                this.OnPropertyChanged("SignatureDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _SignatureDate;
        partial void OnSignatureDateChanging(global::System.DateTimeOffset value);
        partial void OnSignatureDateChanged();
        /// <summary>
        /// There are no comments for Property ExpectedNumberOfPayments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int ExpectedNumberOfPayments
        {
            get
            {
                return this._ExpectedNumberOfPayments;
            }
            set
            {
                this.OnExpectedNumberOfPaymentsChanging(value);
                this._ExpectedNumberOfPayments = value;
                this.OnExpectedNumberOfPaymentsChanged();
                this.OnPropertyChanged("ExpectedNumberOfPayments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ExpectedNumberOfPayments;
        partial void OnExpectedNumberOfPaymentsChanging(int value);
        partial void OnExpectedNumberOfPaymentsChanged();
        /// <summary>
        /// There are no comments for Property ExpirationDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ExpirationDate
        {
            get
            {
                return this._ExpirationDate;
            }
            set
            {
                this.OnExpirationDateChanging(value);
                this._ExpirationDate = value;
                this.OnExpirationDateChanged();
                this.OnPropertyChanged("ExpirationDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ExpirationDate;
        partial void OnExpirationDateChanging(global::System.DateTimeOffset value);
        partial void OnExpirationDateChanged();
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
