﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 10/4/2020 2:55:10 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for TradeAllowanceAgreementMerchandisingEventLumpSumSingle in the schema.
    /// </summary>
    public partial class TradeAllowanceAgreementMerchandisingEventLumpSumSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TradeAllowanceAgreementMerchandisingEventLumpSum>
    {
        /// <summary>
        /// Initialize a new TradeAllowanceAgreementMerchandisingEventLumpSumSingle object.
        /// </summary>
        public TradeAllowanceAgreementMerchandisingEventLumpSumSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TradeAllowanceAgreementMerchandisingEventLumpSumSingle object.
        /// </summary>
        public TradeAllowanceAgreementMerchandisingEventLumpSumSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TradeAllowanceAgreementMerchandisingEventLumpSumSingle object.
        /// </summary>
        public TradeAllowanceAgreementMerchandisingEventLumpSumSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TradeAllowanceAgreementMerchandisingEventLumpSum> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ClaimPaymentRecipientVendor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.VendorV2Single ClaimPaymentRecipientVendor
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ClaimPaymentRecipientVendor == null))
                {
                    this._ClaimPaymentRecipientVendor = new global::Microsoft.Dynamics.DataEntities.VendorV2Single(this.Context, GetPath("ClaimPaymentRecipientVendor"));
                }
                return this._ClaimPaymentRecipientVendor;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.VendorV2Single _ClaimPaymentRecipientVendor;
        /// <summary>
        /// There are no comments for ClaimPaymentRecipientCustomer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CustomerV3Single ClaimPaymentRecipientCustomer
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ClaimPaymentRecipientCustomer == null))
                {
                    this._ClaimPaymentRecipientCustomer = new global::Microsoft.Dynamics.DataEntities.CustomerV3Single(this.Context, GetPath("ClaimPaymentRecipientCustomer"));
                }
                return this._ClaimPaymentRecipientCustomer;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CustomerV3Single _ClaimPaymentRecipientCustomer;
        /// <summary>
        /// There are no comments for TradeAllowanceAgreementMerchandisingEvent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventSingle TradeAllowanceAgreementMerchandisingEvent
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TradeAllowanceAgreementMerchandisingEvent == null))
                {
                    this._TradeAllowanceAgreementMerchandisingEvent = new global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventSingle(this.Context, GetPath("TradeAllowanceAgreementMerchandisingEvent"));
                }
                return this._TradeAllowanceAgreementMerchandisingEvent;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventSingle _TradeAllowanceAgreementMerchandisingEvent;
        /// <summary>
        /// There are no comments for TradeAllowanceAgreementHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementHeaderSingle TradeAllowanceAgreementHeader
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TradeAllowanceAgreementHeader == null))
                {
                    this._TradeAllowanceAgreementHeader = new global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementHeaderSingle(this.Context, GetPath("TradeAllowanceAgreementHeader"));
                }
                return this._TradeAllowanceAgreementHeader;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementHeaderSingle _TradeAllowanceAgreementHeader;
    }
    /// <summary>
    /// There are no comments for TradeAllowanceAgreementMerchandisingEventLumpSum in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// TradeAllowanceAgreementId
    /// CustomerAccountNumber
    /// TradeAllowanceAgreementMerchandisingEventId
    /// LumpSumId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TradeAllowanceAgreementId", "CustomerAccountNumber", "TradeAllowanceAgreementMerchandisingEventId", "LumpSumId")]
    [global::Microsoft.OData.Client.EntitySet("TradeAllowanceAgreementMerchandisingEventLumpSums")]
    public partial class TradeAllowanceAgreementMerchandisingEventLumpSum : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TradeAllowanceAgreementMerchandisingEventLumpSum object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="tradeAllowanceAgreementId">Initial value of TradeAllowanceAgreementId.</param>
        /// <param name="customerAccountNumber">Initial value of CustomerAccountNumber.</param>
        /// <param name="tradeAllowanceAgreementMerchandisingEventId">Initial value of TradeAllowanceAgreementMerchandisingEventId.</param>
        /// <param name="lumpSumId">Initial value of LumpSumId.</param>
        /// <param name="suggestedLumpSumAmount">Initial value of SuggestedLumpSumAmount.</param>
        /// <param name="approvedLumpSumAmount">Initial value of ApprovedLumpSumAmount.</param>
        /// <param name="tradeAllowanceAgreementMerchandisingEvent">Initial value of TradeAllowanceAgreementMerchandisingEvent.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TradeAllowanceAgreementMerchandisingEventLumpSum CreateTradeAllowanceAgreementMerchandisingEventLumpSum(string dataAreaId, 
                    string tradeAllowanceAgreementId, 
                    string customerAccountNumber, 
                    string tradeAllowanceAgreementMerchandisingEventId, 
                    long lumpSumId, 
                    decimal suggestedLumpSumAmount, 
                    decimal approvedLumpSumAmount, 
                    global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEvent tradeAllowanceAgreementMerchandisingEvent)
        {
            TradeAllowanceAgreementMerchandisingEventLumpSum tradeAllowanceAgreementMerchandisingEventLumpSum = new TradeAllowanceAgreementMerchandisingEventLumpSum();
            tradeAllowanceAgreementMerchandisingEventLumpSum.dataAreaId = dataAreaId;
            tradeAllowanceAgreementMerchandisingEventLumpSum.TradeAllowanceAgreementId = tradeAllowanceAgreementId;
            tradeAllowanceAgreementMerchandisingEventLumpSum.CustomerAccountNumber = customerAccountNumber;
            tradeAllowanceAgreementMerchandisingEventLumpSum.TradeAllowanceAgreementMerchandisingEventId = tradeAllowanceAgreementMerchandisingEventId;
            tradeAllowanceAgreementMerchandisingEventLumpSum.LumpSumId = lumpSumId;
            tradeAllowanceAgreementMerchandisingEventLumpSum.SuggestedLumpSumAmount = suggestedLumpSumAmount;
            tradeAllowanceAgreementMerchandisingEventLumpSum.ApprovedLumpSumAmount = approvedLumpSumAmount;
            if ((tradeAllowanceAgreementMerchandisingEvent == null))
            {
                throw new global::System.ArgumentNullException("tradeAllowanceAgreementMerchandisingEvent");
            }
            tradeAllowanceAgreementMerchandisingEventLumpSum.TradeAllowanceAgreementMerchandisingEvent = tradeAllowanceAgreementMerchandisingEvent;
            return tradeAllowanceAgreementMerchandisingEventLumpSum;
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
        /// There are no comments for Property TradeAllowanceAgreementId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TradeAllowanceAgreementId
        {
            get
            {
                return this._TradeAllowanceAgreementId;
            }
            set
            {
                this.OnTradeAllowanceAgreementIdChanging(value);
                this._TradeAllowanceAgreementId = value;
                this.OnTradeAllowanceAgreementIdChanged();
                this.OnPropertyChanged("TradeAllowanceAgreementId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TradeAllowanceAgreementId;
        partial void OnTradeAllowanceAgreementIdChanging(string value);
        partial void OnTradeAllowanceAgreementIdChanged();
        /// <summary>
        /// There are no comments for Property CustomerAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CustomerAccountNumber
        {
            get
            {
                return this._CustomerAccountNumber;
            }
            set
            {
                this.OnCustomerAccountNumberChanging(value);
                this._CustomerAccountNumber = value;
                this.OnCustomerAccountNumberChanged();
                this.OnPropertyChanged("CustomerAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerAccountNumber;
        partial void OnCustomerAccountNumberChanging(string value);
        partial void OnCustomerAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property TradeAllowanceAgreementMerchandisingEventId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TradeAllowanceAgreementMerchandisingEventId
        {
            get
            {
                return this._TradeAllowanceAgreementMerchandisingEventId;
            }
            set
            {
                this.OnTradeAllowanceAgreementMerchandisingEventIdChanging(value);
                this._TradeAllowanceAgreementMerchandisingEventId = value;
                this.OnTradeAllowanceAgreementMerchandisingEventIdChanged();
                this.OnPropertyChanged("TradeAllowanceAgreementMerchandisingEventId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TradeAllowanceAgreementMerchandisingEventId;
        partial void OnTradeAllowanceAgreementMerchandisingEventIdChanging(string value);
        partial void OnTradeAllowanceAgreementMerchandisingEventIdChanged();
        /// <summary>
        /// There are no comments for Property LumpSumId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long LumpSumId
        {
            get
            {
                return this._LumpSumId;
            }
            set
            {
                this.OnLumpSumIdChanging(value);
                this._LumpSumId = value;
                this.OnLumpSumIdChanged();
                this.OnPropertyChanged("LumpSumId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _LumpSumId;
        partial void OnLumpSumIdChanging(long value);
        partial void OnLumpSumIdChanged();
        /// <summary>
        /// There are no comments for Property SuggestedLumpSumAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal SuggestedLumpSumAmount
        {
            get
            {
                return this._SuggestedLumpSumAmount;
            }
            set
            {
                this.OnSuggestedLumpSumAmountChanging(value);
                this._SuggestedLumpSumAmount = value;
                this.OnSuggestedLumpSumAmountChanged();
                this.OnPropertyChanged("SuggestedLumpSumAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SuggestedLumpSumAmount;
        partial void OnSuggestedLumpSumAmountChanging(decimal value);
        partial void OnSuggestedLumpSumAmountChanged();
        /// <summary>
        /// There are no comments for Property LumpSumApprovalStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRLumpSumStatus> LumpSumApprovalStatus
        {
            get
            {
                return this._LumpSumApprovalStatus;
            }
            set
            {
                this.OnLumpSumApprovalStatusChanging(value);
                this._LumpSumApprovalStatus = value;
                this.OnLumpSumApprovalStatusChanged();
                this.OnPropertyChanged("LumpSumApprovalStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRLumpSumStatus> _LumpSumApprovalStatus;
        partial void OnLumpSumApprovalStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRLumpSumStatus> value);
        partial void OnLumpSumApprovalStatusChanged();
        /// <summary>
        /// There are no comments for Property ApprovedLumpSumAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ApprovedLumpSumAmount
        {
            get
            {
                return this._ApprovedLumpSumAmount;
            }
            set
            {
                this.OnApprovedLumpSumAmountChanging(value);
                this._ApprovedLumpSumAmount = value;
                this.OnApprovedLumpSumAmountChanged();
                this.OnPropertyChanged("ApprovedLumpSumAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ApprovedLumpSumAmount;
        partial void OnApprovedLumpSumAmountChanging(decimal value);
        partial void OnApprovedLumpSumAmountChanged();
        /// <summary>
        /// There are no comments for Property ClaimPaymentRecipientCustomerAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ClaimPaymentRecipientCustomerAccountNumber
        {
            get
            {
                return this._ClaimPaymentRecipientCustomerAccountNumber;
            }
            set
            {
                this.OnClaimPaymentRecipientCustomerAccountNumberChanging(value);
                this._ClaimPaymentRecipientCustomerAccountNumber = value;
                this.OnClaimPaymentRecipientCustomerAccountNumberChanged();
                this.OnPropertyChanged("ClaimPaymentRecipientCustomerAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ClaimPaymentRecipientCustomerAccountNumber;
        partial void OnClaimPaymentRecipientCustomerAccountNumberChanging(string value);
        partial void OnClaimPaymentRecipientCustomerAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property ClaimPaymentMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMPaymentType> ClaimPaymentMethod
        {
            get
            {
                return this._ClaimPaymentMethod;
            }
            set
            {
                this.OnClaimPaymentMethodChanging(value);
                this._ClaimPaymentMethod = value;
                this.OnClaimPaymentMethodChanged();
                this.OnPropertyChanged("ClaimPaymentMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMPaymentType> _ClaimPaymentMethod;
        partial void OnClaimPaymentMethodChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TAMPaymentType> value);
        partial void OnClaimPaymentMethodChanged();
        /// <summary>
        /// There are no comments for Property ClaimPaymentRecipientVendorAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ClaimPaymentRecipientVendorAccountNumber
        {
            get
            {
                return this._ClaimPaymentRecipientVendorAccountNumber;
            }
            set
            {
                this.OnClaimPaymentRecipientVendorAccountNumberChanging(value);
                this._ClaimPaymentRecipientVendorAccountNumber = value;
                this.OnClaimPaymentRecipientVendorAccountNumberChanged();
                this.OnPropertyChanged("ClaimPaymentRecipientVendorAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ClaimPaymentRecipientVendorAccountNumber;
        partial void OnClaimPaymentRecipientVendorAccountNumberChanging(string value);
        partial void OnClaimPaymentRecipientVendorAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property LumpSumDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LumpSumDetails
        {
            get
            {
                return this._LumpSumDetails;
            }
            set
            {
                this.OnLumpSumDetailsChanging(value);
                this._LumpSumDetails = value;
                this.OnLumpSumDetailsChanged();
                this.OnPropertyChanged("LumpSumDetails");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LumpSumDetails;
        partial void OnLumpSumDetailsChanging(string value);
        partial void OnLumpSumDetailsChanged();
        /// <summary>
        /// There are no comments for Property ClaimPaymentRecipientVendor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.VendorV2 ClaimPaymentRecipientVendor
        {
            get
            {
                return this._ClaimPaymentRecipientVendor;
            }
            set
            {
                this.OnClaimPaymentRecipientVendorChanging(value);
                this._ClaimPaymentRecipientVendor = value;
                this.OnClaimPaymentRecipientVendorChanged();
                this.OnPropertyChanged("ClaimPaymentRecipientVendor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.VendorV2 _ClaimPaymentRecipientVendor;
        partial void OnClaimPaymentRecipientVendorChanging(global::Microsoft.Dynamics.DataEntities.VendorV2 value);
        partial void OnClaimPaymentRecipientVendorChanged();
        /// <summary>
        /// There are no comments for Property ClaimPaymentRecipientCustomer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CustomerV3 ClaimPaymentRecipientCustomer
        {
            get
            {
                return this._ClaimPaymentRecipientCustomer;
            }
            set
            {
                this.OnClaimPaymentRecipientCustomerChanging(value);
                this._ClaimPaymentRecipientCustomer = value;
                this.OnClaimPaymentRecipientCustomerChanged();
                this.OnPropertyChanged("ClaimPaymentRecipientCustomer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CustomerV3 _ClaimPaymentRecipientCustomer;
        partial void OnClaimPaymentRecipientCustomerChanging(global::Microsoft.Dynamics.DataEntities.CustomerV3 value);
        partial void OnClaimPaymentRecipientCustomerChanged();
        /// <summary>
        /// There are no comments for Property TradeAllowanceAgreementMerchandisingEvent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEvent TradeAllowanceAgreementMerchandisingEvent
        {
            get
            {
                return this._TradeAllowanceAgreementMerchandisingEvent;
            }
            set
            {
                this.OnTradeAllowanceAgreementMerchandisingEventChanging(value);
                this._TradeAllowanceAgreementMerchandisingEvent = value;
                this.OnTradeAllowanceAgreementMerchandisingEventChanged();
                this.OnPropertyChanged("TradeAllowanceAgreementMerchandisingEvent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEvent _TradeAllowanceAgreementMerchandisingEvent;
        partial void OnTradeAllowanceAgreementMerchandisingEventChanging(global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEvent value);
        partial void OnTradeAllowanceAgreementMerchandisingEventChanged();
        /// <summary>
        /// There are no comments for Property TradeAllowanceAgreementHeader in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementHeader TradeAllowanceAgreementHeader
        {
            get
            {
                return this._TradeAllowanceAgreementHeader;
            }
            set
            {
                this.OnTradeAllowanceAgreementHeaderChanging(value);
                this._TradeAllowanceAgreementHeader = value;
                this.OnTradeAllowanceAgreementHeaderChanged();
                this.OnPropertyChanged("TradeAllowanceAgreementHeader");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementHeader _TradeAllowanceAgreementHeader;
        partial void OnTradeAllowanceAgreementHeaderChanging(global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementHeader value);
        partial void OnTradeAllowanceAgreementHeaderChanged();
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