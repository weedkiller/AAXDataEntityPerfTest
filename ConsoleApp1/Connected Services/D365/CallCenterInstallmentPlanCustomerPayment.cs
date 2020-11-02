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
    /// There are no comments for CallCenterInstallmentPlanCustomerPaymentSingle in the schema.
    /// </summary>
    public partial class CallCenterInstallmentPlanCustomerPaymentSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CallCenterInstallmentPlanCustomerPayment>
    {
        /// <summary>
        /// Initialize a new CallCenterInstallmentPlanCustomerPaymentSingle object.
        /// </summary>
        public CallCenterInstallmentPlanCustomerPaymentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CallCenterInstallmentPlanCustomerPaymentSingle object.
        /// </summary>
        public CallCenterInstallmentPlanCustomerPaymentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CallCenterInstallmentPlanCustomerPaymentSingle object.
        /// </summary>
        public CallCenterInstallmentPlanCustomerPaymentSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CallCenterInstallmentPlanCustomerPayment> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CallCenterInstallmentPlanCustomerPayment in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// LineNumber
    /// InstallmentSalesOrderId
    /// InstallmentPaymentScheduleId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LineNumber", "InstallmentSalesOrderId", "InstallmentPaymentScheduleId")]
    [global::Microsoft.OData.Client.EntitySet("CallCenterInstallmentPlanCustomerPayments")]
    public partial class CallCenterInstallmentPlanCustomerPayment : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CallCenterInstallmentPlanCustomerPayment object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="lineNumber">Initial value of LineNumber.</param>
        /// <param name="installmentSalesOrderId">Initial value of InstallmentSalesOrderId.</param>
        /// <param name="installmentPaymentScheduleId">Initial value of InstallmentPaymentScheduleId.</param>
        /// <param name="percentAmount">Initial value of PercentAmount.</param>
        /// <param name="originalRefundLineNumber">Initial value of OriginalRefundLineNumber.</param>
        /// <param name="authorizationRetryNumber">Initial value of AuthorizationRetryNumber.</param>
        /// <param name="amount">Initial value of Amount.</param>
        /// <param name="postedAmount">Initial value of PostedAmount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CallCenterInstallmentPlanCustomerPayment CreateCallCenterInstallmentPlanCustomerPayment(string dataAreaId, 
                    decimal lineNumber, 
                    string installmentSalesOrderId, 
                    string installmentPaymentScheduleId, 
                    decimal percentAmount, 
                    decimal originalRefundLineNumber, 
                    int authorizationRetryNumber, 
                    decimal amount, 
                    decimal postedAmount)
        {
            CallCenterInstallmentPlanCustomerPayment callCenterInstallmentPlanCustomerPayment = new CallCenterInstallmentPlanCustomerPayment();
            callCenterInstallmentPlanCustomerPayment.dataAreaId = dataAreaId;
            callCenterInstallmentPlanCustomerPayment.LineNumber = lineNumber;
            callCenterInstallmentPlanCustomerPayment.InstallmentSalesOrderId = installmentSalesOrderId;
            callCenterInstallmentPlanCustomerPayment.InstallmentPaymentScheduleId = installmentPaymentScheduleId;
            callCenterInstallmentPlanCustomerPayment.PercentAmount = percentAmount;
            callCenterInstallmentPlanCustomerPayment.OriginalRefundLineNumber = originalRefundLineNumber;
            callCenterInstallmentPlanCustomerPayment.AuthorizationRetryNumber = authorizationRetryNumber;
            callCenterInstallmentPlanCustomerPayment.Amount = amount;
            callCenterInstallmentPlanCustomerPayment.PostedAmount = postedAmount;
            return callCenterInstallmentPlanCustomerPayment;
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
        /// There are no comments for Property InstallmentSalesOrderId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InstallmentSalesOrderId
        {
            get
            {
                return this._InstallmentSalesOrderId;
            }
            set
            {
                this.OnInstallmentSalesOrderIdChanging(value);
                this._InstallmentSalesOrderId = value;
                this.OnInstallmentSalesOrderIdChanged();
                this.OnPropertyChanged("InstallmentSalesOrderId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InstallmentSalesOrderId;
        partial void OnInstallmentSalesOrderIdChanging(string value);
        partial void OnInstallmentSalesOrderIdChanged();
        /// <summary>
        /// There are no comments for Property InstallmentPaymentScheduleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InstallmentPaymentScheduleId
        {
            get
            {
                return this._InstallmentPaymentScheduleId;
            }
            set
            {
                this.OnInstallmentPaymentScheduleIdChanging(value);
                this._InstallmentPaymentScheduleId = value;
                this.OnInstallmentPaymentScheduleIdChanged();
                this.OnPropertyChanged("InstallmentPaymentScheduleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InstallmentPaymentScheduleId;
        partial void OnInstallmentPaymentScheduleIdChanging(string value);
        partial void OnInstallmentPaymentScheduleIdChanged();
        /// <summary>
        /// There are no comments for Property OriginalRefundSalesOrderId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OriginalRefundSalesOrderId
        {
            get
            {
                return this._OriginalRefundSalesOrderId;
            }
            set
            {
                this.OnOriginalRefundSalesOrderIdChanging(value);
                this._OriginalRefundSalesOrderId = value;
                this.OnOriginalRefundSalesOrderIdChanged();
                this.OnPropertyChanged("OriginalRefundSalesOrderId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OriginalRefundSalesOrderId;
        partial void OnOriginalRefundSalesOrderIdChanging(string value);
        partial void OnOriginalRefundSalesOrderIdChanged();
        /// <summary>
        /// There are no comments for Property IsPlanRefund in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsPlanRefund
        {
            get
            {
                return this._IsPlanRefund;
            }
            set
            {
                this.OnIsPlanRefundChanging(value);
                this._IsPlanRefund = value;
                this.OnIsPlanRefundChanged();
                this.OnPropertyChanged("IsPlanRefund");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsPlanRefund;
        partial void OnIsPlanRefundChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsPlanRefundChanged();
        /// <summary>
        /// There are no comments for Property OriginalRefundPaymentScheduleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OriginalRefundPaymentScheduleId
        {
            get
            {
                return this._OriginalRefundPaymentScheduleId;
            }
            set
            {
                this.OnOriginalRefundPaymentScheduleIdChanging(value);
                this._OriginalRefundPaymentScheduleId = value;
                this.OnOriginalRefundPaymentScheduleIdChanged();
                this.OnPropertyChanged("OriginalRefundPaymentScheduleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OriginalRefundPaymentScheduleId;
        partial void OnOriginalRefundPaymentScheduleIdChanging(string value);
        partial void OnOriginalRefundPaymentScheduleIdChanged();
        /// <summary>
        /// There are no comments for Property RetailChannelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RetailChannelId
        {
            get
            {
                return this._RetailChannelId;
            }
            set
            {
                this.OnRetailChannelIdChanging(value);
                this._RetailChannelId = value;
                this.OnRetailChannelIdChanged();
                this.OnPropertyChanged("RetailChannelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RetailChannelId;
        partial void OnRetailChannelIdChanging(string value);
        partial void OnRetailChannelIdChanged();
        /// <summary>
        /// There are no comments for Property UniqueCreditCardId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string UniqueCreditCardId
        {
            get
            {
                return this._UniqueCreditCardId;
            }
            set
            {
                this.OnUniqueCreditCardIdChanging(value);
                this._UniqueCreditCardId = value;
                this.OnUniqueCreditCardIdChanged();
                this.OnPropertyChanged("UniqueCreditCardId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UniqueCreditCardId;
        partial void OnUniqueCreditCardIdChanging(string value);
        partial void OnUniqueCreditCardIdChanged();
        /// <summary>
        /// There are no comments for Property RetailGiftCardId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RetailGiftCardId
        {
            get
            {
                return this._RetailGiftCardId;
            }
            set
            {
                this.OnRetailGiftCardIdChanging(value);
                this._RetailGiftCardId = value;
                this.OnRetailGiftCardIdChanged();
                this.OnPropertyChanged("RetailGiftCardId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RetailGiftCardId;
        partial void OnRetailGiftCardIdChanging(string value);
        partial void OnRetailGiftCardIdChanged();
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
        /// There are no comments for Property PercentAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal PercentAmount
        {
            get
            {
                return this._PercentAmount;
            }
            set
            {
                this.OnPercentAmountChanging(value);
                this._PercentAmount = value;
                this.OnPercentAmountChanged();
                this.OnPropertyChanged("PercentAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PercentAmount;
        partial void OnPercentAmountChanging(decimal value);
        partial void OnPercentAmountChanged();
        /// <summary>
        /// There are no comments for Property IsCreditCardProcessed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsCreditCardProcessed
        {
            get
            {
                return this._IsCreditCardProcessed;
            }
            set
            {
                this.OnIsCreditCardProcessedChanging(value);
                this._IsCreditCardProcessed = value;
                this.OnIsCreditCardProcessedChanged();
                this.OnPropertyChanged("IsCreditCardProcessed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsCreditCardProcessed;
        partial void OnIsCreditCardProcessedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsCreditCardProcessedChanged();
        /// <summary>
        /// There are no comments for Property CheckNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CheckNumber
        {
            get
            {
                return this._CheckNumber;
            }
            set
            {
                this.OnCheckNumberChanging(value);
                this._CheckNumber = value;
                this.OnCheckNumberChanged();
                this.OnPropertyChanged("CheckNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CheckNumber;
        partial void OnCheckNumberChanging(string value);
        partial void OnCheckNumberChanged();
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
        /// There are no comments for Property IsCheckAuthorized in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsCheckAuthorized
        {
            get
            {
                return this._IsCheckAuthorized;
            }
            set
            {
                this.OnIsCheckAuthorizedChanging(value);
                this._IsCheckAuthorized = value;
                this.OnIsCheckAuthorizedChanged();
                this.OnPropertyChanged("IsCheckAuthorized");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsCheckAuthorized;
        partial void OnIsCheckAuthorizedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsCheckAuthorizedChanged();
        /// <summary>
        /// There are no comments for Property OriginalRefundLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal OriginalRefundLineNumber
        {
            get
            {
                return this._OriginalRefundLineNumber;
            }
            set
            {
                this.OnOriginalRefundLineNumberChanging(value);
                this._OriginalRefundLineNumber = value;
                this.OnOriginalRefundLineNumberChanged();
                this.OnPropertyChanged("OriginalRefundLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _OriginalRefundLineNumber;
        partial void OnOriginalRefundLineNumberChanging(decimal value);
        partial void OnOriginalRefundLineNumberChanged();
        /// <summary>
        /// There are no comments for Property AuthorizationRetryNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int AuthorizationRetryNumber
        {
            get
            {
                return this._AuthorizationRetryNumber;
            }
            set
            {
                this.OnAuthorizationRetryNumberChanging(value);
                this._AuthorizationRetryNumber = value;
                this.OnAuthorizationRetryNumberChanged();
                this.OnPropertyChanged("AuthorizationRetryNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _AuthorizationRetryNumber;
        partial void OnAuthorizationRetryNumberChanging(int value);
        partial void OnAuthorizationRetryNumberChanged();
        /// <summary>
        /// There are no comments for Property IsPrepay in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsPrepay
        {
            get
            {
                return this._IsPrepay;
            }
            set
            {
                this.OnIsPrepayChanging(value);
                this._IsPrepay = value;
                this.OnIsPrepayChanged();
                this.OnPropertyChanged("IsPrepay");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsPrepay;
        partial void OnIsPrepayChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsPrepayChanged();
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
        /// There are no comments for Property IsOnAccountAuthorized in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsOnAccountAuthorized
        {
            get
            {
                return this._IsOnAccountAuthorized;
            }
            set
            {
                this.OnIsOnAccountAuthorizedChanging(value);
                this._IsOnAccountAuthorized = value;
                this.OnIsOnAccountAuthorizedChanged();
                this.OnPropertyChanged("IsOnAccountAuthorized");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsOnAccountAuthorized;
        partial void OnIsOnAccountAuthorizedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsOnAccountAuthorizedChanged();
        /// <summary>
        /// There are no comments for Property PostedAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal PostedAmount
        {
            get
            {
                return this._PostedAmount;
            }
            set
            {
                this.OnPostedAmountChanging(value);
                this._PostedAmount = value;
                this.OnPostedAmountChanged();
                this.OnPropertyChanged("PostedAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PostedAmount;
        partial void OnPostedAmountChanging(decimal value);
        partial void OnPostedAmountChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRCustPaymStatus> Status
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
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRCustPaymStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRCustPaymStatus> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property RetailStoreTenderTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RetailStoreTenderTypeId
        {
            get
            {
                return this._RetailStoreTenderTypeId;
            }
            set
            {
                this.OnRetailStoreTenderTypeIdChanging(value);
                this._RetailStoreTenderTypeId = value;
                this.OnRetailStoreTenderTypeIdChanged();
                this.OnPropertyChanged("RetailStoreTenderTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RetailStoreTenderTypeId;
        partial void OnRetailStoreTenderTypeIdChanging(string value);
        partial void OnRetailStoreTenderTypeIdChanged();
        /// <summary>
        /// There are no comments for Property CustomerPaymentType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRCustPaymType> CustomerPaymentType
        {
            get
            {
                return this._CustomerPaymentType;
            }
            set
            {
                this.OnCustomerPaymentTypeChanging(value);
                this._CustomerPaymentType = value;
                this.OnCustomerPaymentTypeChanged();
                this.OnPropertyChanged("CustomerPaymentType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRCustPaymType> _CustomerPaymentType;
        partial void OnCustomerPaymentTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRCustPaymType> value);
        partial void OnCustomerPaymentTypeChanged();
        /// <summary>
        /// There are no comments for Property RetailStoreCardTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RetailStoreCardTypeId
        {
            get
            {
                return this._RetailStoreCardTypeId;
            }
            set
            {
                this.OnRetailStoreCardTypeIdChanging(value);
                this._RetailStoreCardTypeId = value;
                this.OnRetailStoreCardTypeIdChanged();
                this.OnPropertyChanged("RetailStoreCardTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RetailStoreCardTypeId;
        partial void OnRetailStoreCardTypeIdChanging(string value);
        partial void OnRetailStoreCardTypeIdChanged();
        /// <summary>
        /// There are no comments for Property PaymentSchedId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PaymentSchedId
        {
            get
            {
                return this._PaymentSchedId;
            }
            set
            {
                this.OnPaymentSchedIdChanging(value);
                this._PaymentSchedId = value;
                this.OnPaymentSchedIdChanged();
                this.OnPropertyChanged("PaymentSchedId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PaymentSchedId;
        partial void OnPaymentSchedIdChanging(string value);
        partial void OnPaymentSchedIdChanged();
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
