﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 1/20/2021 5:35:39 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for TradeAllowanceAgreementMerchandisingEventSingle in the schema.
        /// </summary>
    public partial class TradeAllowanceAgreementMerchandisingEventSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TradeAllowanceAgreementMerchandisingEvent>
    {
        /// <summary>
        /// Initialize a new TradeAllowanceAgreementMerchandisingEventSingle object.
        /// </summary>
        public TradeAllowanceAgreementMerchandisingEventSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TradeAllowanceAgreementMerchandisingEventSingle object.
        /// </summary>
        public TradeAllowanceAgreementMerchandisingEventSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TradeAllowanceAgreementMerchandisingEventSingle object.
        /// </summary>
        public TradeAllowanceAgreementMerchandisingEventSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TradeAllowanceAgreementMerchandisingEvent> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for TradeAllowanceAgreementMerchandisingEventBillBack in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventBillBackSingle TradeAllowanceAgreementMerchandisingEventBillBack
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TradeAllowanceAgreementMerchandisingEventBillBack == null))
                {
                    this._TradeAllowanceAgreementMerchandisingEventBillBack = new global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventBillBackSingle(this.Context, GetPath("TradeAllowanceAgreementMerchandisingEventBillBack"));
                }
                return this._TradeAllowanceAgreementMerchandisingEventBillBack;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventBillBackSingle _TradeAllowanceAgreementMerchandisingEventBillBack;
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
        /// <summary>
        /// There are no comments for TradeAllowanceAgreementMerchandisingEventFunds in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventFund> TradeAllowanceAgreementMerchandisingEventFunds
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TradeAllowanceAgreementMerchandisingEventFunds == null))
                {
                    this._TradeAllowanceAgreementMerchandisingEventFunds = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventFund>(GetPath("TradeAllowanceAgreementMerchandisingEventFunds"));
                }
                return this._TradeAllowanceAgreementMerchandisingEventFunds;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventFund> _TradeAllowanceAgreementMerchandisingEventFunds;
        /// <summary>
        /// There are no comments for TradeAllowanceAgreementMerchandisingEventLumpSums in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventLumpSum> TradeAllowanceAgreementMerchandisingEventLumpSums
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TradeAllowanceAgreementMerchandisingEventLumpSums == null))
                {
                    this._TradeAllowanceAgreementMerchandisingEventLumpSums = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventLumpSum>(GetPath("TradeAllowanceAgreementMerchandisingEventLumpSums"));
                }
                return this._TradeAllowanceAgreementMerchandisingEventLumpSums;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventLumpSum> _TradeAllowanceAgreementMerchandisingEventLumpSums;
        /// <summary>
        /// There are no comments for TradeAllowanceAgreementMerchandisingEventProducts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventProduct> TradeAllowanceAgreementMerchandisingEventProducts
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TradeAllowanceAgreementMerchandisingEventProducts == null))
                {
                    this._TradeAllowanceAgreementMerchandisingEventProducts = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventProduct>(GetPath("TradeAllowanceAgreementMerchandisingEventProducts"));
                }
                return this._TradeAllowanceAgreementMerchandisingEventProducts;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventProduct> _TradeAllowanceAgreementMerchandisingEventProducts;
        /// <summary>
        /// There are no comments for TradeAllowanceAgreementMerchandisingEventDiscounts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventDiscount> TradeAllowanceAgreementMerchandisingEventDiscounts
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TradeAllowanceAgreementMerchandisingEventDiscounts == null))
                {
                    this._TradeAllowanceAgreementMerchandisingEventDiscounts = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventDiscount>(GetPath("TradeAllowanceAgreementMerchandisingEventDiscounts"));
                }
                return this._TradeAllowanceAgreementMerchandisingEventDiscounts;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventDiscount> _TradeAllowanceAgreementMerchandisingEventDiscounts;
        /// <summary>
        /// There are no comments for TradeAllowanceAgreementMerchandisingEventProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventProductV2> TradeAllowanceAgreementMerchandisingEventProductsV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TradeAllowanceAgreementMerchandisingEventProductsV2 == null))
                {
                    this._TradeAllowanceAgreementMerchandisingEventProductsV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventProductV2>(GetPath("TradeAllowanceAgreementMerchandisingEventProductsV2"));
                }
                return this._TradeAllowanceAgreementMerchandisingEventProductsV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventProductV2> _TradeAllowanceAgreementMerchandisingEventProductsV2;
    }
        /// <summary>
        /// There are no comments for TradeAllowanceAgreementMerchandisingEvent in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// TradeAllowanceAgreementId
    /// CustomerAccountNumber
    /// EventId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TradeAllowanceAgreementId", "CustomerAccountNumber", "EventId")]
    [global::Microsoft.OData.Client.EntitySet("TradeAllowanceAgreementMerchandisingEvents")]
    public partial class TradeAllowanceAgreementMerchandisingEvent : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TradeAllowanceAgreementMerchandisingEvent object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="tradeAllowanceAgreementId">Initial value of TradeAllowanceAgreementId.</param>
        /// <param name="customerAccountNumber">Initial value of CustomerAccountNumber.</param>
        /// <param name="eventId">Initial value of EventId.</param>
        /// <param name="eventCostAmount">Initial value of EventCostAmount.</param>
        /// <param name="tradeAllowanceAgreementHeader">Initial value of TradeAllowanceAgreementHeader.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TradeAllowanceAgreementMerchandisingEvent CreateTradeAllowanceAgreementMerchandisingEvent(string dataAreaId, 
                    string tradeAllowanceAgreementId, 
                    string customerAccountNumber, 
                    string eventId, 
                    decimal eventCostAmount, 
                    global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementHeader tradeAllowanceAgreementHeader)
        {
            TradeAllowanceAgreementMerchandisingEvent tradeAllowanceAgreementMerchandisingEvent = new TradeAllowanceAgreementMerchandisingEvent();
            tradeAllowanceAgreementMerchandisingEvent.dataAreaId = dataAreaId;
            tradeAllowanceAgreementMerchandisingEvent.TradeAllowanceAgreementId = tradeAllowanceAgreementId;
            tradeAllowanceAgreementMerchandisingEvent.CustomerAccountNumber = customerAccountNumber;
            tradeAllowanceAgreementMerchandisingEvent.EventId = eventId;
            tradeAllowanceAgreementMerchandisingEvent.EventCostAmount = eventCostAmount;
            if ((tradeAllowanceAgreementHeader == null))
            {
                throw new global::System.ArgumentNullException("tradeAllowanceAgreementHeader");
            }
            tradeAllowanceAgreementMerchandisingEvent.TradeAllowanceAgreementHeader = tradeAllowanceAgreementHeader;
            return tradeAllowanceAgreementMerchandisingEvent;
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
        /// There are no comments for Property EventId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EventId
        {
            get
            {
                return this._EventId;
            }
            set
            {
                this.OnEventIdChanging(value);
                this._EventId = value;
                this.OnEventIdChanged();
                this.OnPropertyChanged("EventId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EventId;
        partial void OnEventIdChanging(string value);
        partial void OnEventIdChanged();
        /// <summary>
        /// There are no comments for Property StandardMerchandisingEventCategoryType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRMerchandisingEventCategory> StandardMerchandisingEventCategoryType
        {
            get
            {
                return this._StandardMerchandisingEventCategoryType;
            }
            set
            {
                this.OnStandardMerchandisingEventCategoryTypeChanging(value);
                this._StandardMerchandisingEventCategoryType = value;
                this.OnStandardMerchandisingEventCategoryTypeChanged();
                this.OnPropertyChanged("StandardMerchandisingEventCategoryType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRMerchandisingEventCategory> _StandardMerchandisingEventCategoryType;
        partial void OnStandardMerchandisingEventCategoryTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.MCRMerchandisingEventCategory> value);
        partial void OnStandardMerchandisingEventCategoryTypeChanged();
        /// <summary>
        /// There are no comments for Property MerchandisingEventCategoryName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MerchandisingEventCategoryName
        {
            get
            {
                return this._MerchandisingEventCategoryName;
            }
            set
            {
                this.OnMerchandisingEventCategoryNameChanging(value);
                this._MerchandisingEventCategoryName = value;
                this.OnMerchandisingEventCategoryNameChanged();
                this.OnPropertyChanged("MerchandisingEventCategoryName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MerchandisingEventCategoryName;
        partial void OnMerchandisingEventCategoryNameChanging(string value);
        partial void OnMerchandisingEventCategoryNameChanged();
        /// <summary>
        /// There are no comments for Property EventDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EventDescription
        {
            get
            {
                return this._EventDescription;
            }
            set
            {
                this.OnEventDescriptionChanging(value);
                this._EventDescription = value;
                this.OnEventDescriptionChanged();
                this.OnPropertyChanged("EventDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EventDescription;
        partial void OnEventDescriptionChanging(string value);
        partial void OnEventDescriptionChanged();
        /// <summary>
        /// There are no comments for Property EventCostAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal EventCostAmount
        {
            get
            {
                return this._EventCostAmount;
            }
            set
            {
                this.OnEventCostAmountChanging(value);
                this._EventCostAmount = value;
                this.OnEventCostAmountChanged();
                this.OnPropertyChanged("EventCostAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _EventCostAmount;
        partial void OnEventCostAmountChanging(decimal value);
        partial void OnEventCostAmountChanged();
        /// <summary>
        /// There are no comments for Property TradeAllowanceAgreementMerchandisingEventBillBack in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventBillBack TradeAllowanceAgreementMerchandisingEventBillBack
        {
            get
            {
                return this._TradeAllowanceAgreementMerchandisingEventBillBack;
            }
            set
            {
                this.OnTradeAllowanceAgreementMerchandisingEventBillBackChanging(value);
                this._TradeAllowanceAgreementMerchandisingEventBillBack = value;
                this.OnTradeAllowanceAgreementMerchandisingEventBillBackChanged();
                this.OnPropertyChanged("TradeAllowanceAgreementMerchandisingEventBillBack");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventBillBack _TradeAllowanceAgreementMerchandisingEventBillBack;
        partial void OnTradeAllowanceAgreementMerchandisingEventBillBackChanging(global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventBillBack value);
        partial void OnTradeAllowanceAgreementMerchandisingEventBillBackChanged();
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
        /// There are no comments for Property TradeAllowanceAgreementMerchandisingEventFunds in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventFund> TradeAllowanceAgreementMerchandisingEventFunds
        {
            get
            {
                return this._TradeAllowanceAgreementMerchandisingEventFunds;
            }
            set
            {
                this.OnTradeAllowanceAgreementMerchandisingEventFundsChanging(value);
                this._TradeAllowanceAgreementMerchandisingEventFunds = value;
                this.OnTradeAllowanceAgreementMerchandisingEventFundsChanged();
                this.OnPropertyChanged("TradeAllowanceAgreementMerchandisingEventFunds");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventFund> _TradeAllowanceAgreementMerchandisingEventFunds = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventFund>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnTradeAllowanceAgreementMerchandisingEventFundsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventFund> value);
        partial void OnTradeAllowanceAgreementMerchandisingEventFundsChanged();
        /// <summary>
        /// There are no comments for Property TradeAllowanceAgreementMerchandisingEventLumpSums in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventLumpSum> TradeAllowanceAgreementMerchandisingEventLumpSums
        {
            get
            {
                return this._TradeAllowanceAgreementMerchandisingEventLumpSums;
            }
            set
            {
                this.OnTradeAllowanceAgreementMerchandisingEventLumpSumsChanging(value);
                this._TradeAllowanceAgreementMerchandisingEventLumpSums = value;
                this.OnTradeAllowanceAgreementMerchandisingEventLumpSumsChanged();
                this.OnPropertyChanged("TradeAllowanceAgreementMerchandisingEventLumpSums");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventLumpSum> _TradeAllowanceAgreementMerchandisingEventLumpSums = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventLumpSum>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnTradeAllowanceAgreementMerchandisingEventLumpSumsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventLumpSum> value);
        partial void OnTradeAllowanceAgreementMerchandisingEventLumpSumsChanged();
        /// <summary>
        /// There are no comments for Property TradeAllowanceAgreementMerchandisingEventProducts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventProduct> TradeAllowanceAgreementMerchandisingEventProducts
        {
            get
            {
                return this._TradeAllowanceAgreementMerchandisingEventProducts;
            }
            set
            {
                this.OnTradeAllowanceAgreementMerchandisingEventProductsChanging(value);
                this._TradeAllowanceAgreementMerchandisingEventProducts = value;
                this.OnTradeAllowanceAgreementMerchandisingEventProductsChanged();
                this.OnPropertyChanged("TradeAllowanceAgreementMerchandisingEventProducts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventProduct> _TradeAllowanceAgreementMerchandisingEventProducts = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventProduct>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnTradeAllowanceAgreementMerchandisingEventProductsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventProduct> value);
        partial void OnTradeAllowanceAgreementMerchandisingEventProductsChanged();
        /// <summary>
        /// There are no comments for Property TradeAllowanceAgreementMerchandisingEventDiscounts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventDiscount> TradeAllowanceAgreementMerchandisingEventDiscounts
        {
            get
            {
                return this._TradeAllowanceAgreementMerchandisingEventDiscounts;
            }
            set
            {
                this.OnTradeAllowanceAgreementMerchandisingEventDiscountsChanging(value);
                this._TradeAllowanceAgreementMerchandisingEventDiscounts = value;
                this.OnTradeAllowanceAgreementMerchandisingEventDiscountsChanged();
                this.OnPropertyChanged("TradeAllowanceAgreementMerchandisingEventDiscounts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventDiscount> _TradeAllowanceAgreementMerchandisingEventDiscounts = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventDiscount>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnTradeAllowanceAgreementMerchandisingEventDiscountsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventDiscount> value);
        partial void OnTradeAllowanceAgreementMerchandisingEventDiscountsChanged();
        /// <summary>
        /// There are no comments for Property TradeAllowanceAgreementMerchandisingEventProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventProductV2> TradeAllowanceAgreementMerchandisingEventProductsV2
        {
            get
            {
                return this._TradeAllowanceAgreementMerchandisingEventProductsV2;
            }
            set
            {
                this.OnTradeAllowanceAgreementMerchandisingEventProductsV2Changing(value);
                this._TradeAllowanceAgreementMerchandisingEventProductsV2 = value;
                this.OnTradeAllowanceAgreementMerchandisingEventProductsV2Changed();
                this.OnPropertyChanged("TradeAllowanceAgreementMerchandisingEventProductsV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventProductV2> _TradeAllowanceAgreementMerchandisingEventProductsV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventProductV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnTradeAllowanceAgreementMerchandisingEventProductsV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TradeAllowanceAgreementMerchandisingEventProductV2> value);
        partial void OnTradeAllowanceAgreementMerchandisingEventProductsV2Changed();
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
