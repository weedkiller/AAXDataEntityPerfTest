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
    /// There are no comments for RetailTenderDiscountSingle in the schema.
    /// </summary>
    public partial class RetailTenderDiscountSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTenderDiscount>
    {
        /// <summary>
        /// Initialize a new RetailTenderDiscountSingle object.
        /// </summary>
        public RetailTenderDiscountSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailTenderDiscountSingle object.
        /// </summary>
        public RetailTenderDiscountSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailTenderDiscountSingle object.
        /// </summary>
        public RetailTenderDiscountSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTenderDiscount> query)
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
    }
    /// <summary>
    /// There are no comments for RetailTenderDiscount in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// OfferId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "OfferId")]
    [global::Microsoft.OData.Client.EntitySet("RetailTenderDiscounts")]
    public partial class RetailTenderDiscount : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailTenderDiscount object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="offerId">Initial value of OfferId.</param>
        /// <param name="maxDiscountAmount">Initial value of MaxDiscountAmount.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailTenderDiscount CreateRetailTenderDiscount(string dataAreaId, string offerId, decimal maxDiscountAmount, global::System.DateTimeOffset validTo, global::System.DateTimeOffset validFrom)
        {
            RetailTenderDiscount retailTenderDiscount = new RetailTenderDiscount();
            retailTenderDiscount.dataAreaId = dataAreaId;
            retailTenderDiscount.OfferId = offerId;
            retailTenderDiscount.MaxDiscountAmount = maxDiscountAmount;
            retailTenderDiscount.ValidTo = validTo;
            retailTenderDiscount.ValidFrom = validFrom;
            return retailTenderDiscount;
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
        /// There are no comments for Property OfferId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OfferId
        {
            get
            {
                return this._OfferId;
            }
            set
            {
                this.OnOfferIdChanging(value);
                this._OfferId = value;
                this.OnOfferIdChanged();
                this.OnPropertyChanged("OfferId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OfferId;
        partial void OnOfferIdChanging(string value);
        partial void OnOfferIdChanged();
        /// <summary>
        /// There are no comments for Property TenderTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TenderTypeId
        {
            get
            {
                return this._TenderTypeId;
            }
            set
            {
                this.OnTenderTypeIdChanging(value);
                this._TenderTypeId = value;
                this.OnTenderTypeIdChanged();
                this.OnPropertyChanged("TenderTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TenderTypeId;
        partial void OnTenderTypeIdChanging(string value);
        partial void OnTenderTypeIdChanged();
        /// <summary>
        /// There are no comments for Property MaxDiscountAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal MaxDiscountAmount
        {
            get
            {
                return this._MaxDiscountAmount;
            }
            set
            {
                this.OnMaxDiscountAmountChanging(value);
                this._MaxDiscountAmount = value;
                this.OnMaxDiscountAmountChanged();
                this.OnPropertyChanged("MaxDiscountAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MaxDiscountAmount;
        partial void OnMaxDiscountAmountChanging(decimal value);
        partial void OnMaxDiscountAmountChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailDisabledEnabled> Status
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
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailDisabledEnabled> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailDisabledEnabled> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property DateValidationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailDateValidationTypeBase> DateValidationType
        {
            get
            {
                return this._DateValidationType;
            }
            set
            {
                this.OnDateValidationTypeChanging(value);
                this._DateValidationType = value;
                this.OnDateValidationTypeChanged();
                this.OnPropertyChanged("DateValidationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailDateValidationTypeBase> _DateValidationType;
        partial void OnDateValidationTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailDateValidationTypeBase> value);
        partial void OnDateValidationTypeChanged();
        /// <summary>
        /// There are no comments for Property ValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ValidTo
        {
            get
            {
                return this._ValidTo;
            }
            set
            {
                this.OnValidToChanging(value);
                this._ValidTo = value;
                this.OnValidToChanged();
                this.OnPropertyChanged("ValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidTo;
        partial void OnValidToChanging(global::System.DateTimeOffset value);
        partial void OnValidToChanged();
        /// <summary>
        /// There are no comments for Property DiscountLedgerDimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DiscountLedgerDimensionDisplayValue
        {
            get
            {
                return this._DiscountLedgerDimensionDisplayValue;
            }
            set
            {
                this.OnDiscountLedgerDimensionDisplayValueChanging(value);
                this._DiscountLedgerDimensionDisplayValue = value;
                this.OnDiscountLedgerDimensionDisplayValueChanged();
                this.OnPropertyChanged("DiscountLedgerDimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DiscountLedgerDimensionDisplayValue;
        partial void OnDiscountLedgerDimensionDisplayValueChanging(string value);
        partial void OnDiscountLedgerDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property CardTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CardTypeId
        {
            get
            {
                return this._CardTypeId;
            }
            set
            {
                this.OnCardTypeIdChanging(value);
                this._CardTypeId = value;
                this.OnCardTypeIdChanged();
                this.OnPropertyChanged("CardTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CardTypeId;
        partial void OnCardTypeIdChanging(string value);
        partial void OnCardTypeIdChanged();
        /// <summary>
        /// There are no comments for Property ValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ValidFrom
        {
            get
            {
                return this._ValidFrom;
            }
            set
            {
                this.OnValidFromChanging(value);
                this._ValidFrom = value;
                this.OnValidFromChanged();
                this.OnPropertyChanged("ValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidFrom;
        partial void OnValidFromChanging(global::System.DateTimeOffset value);
        partial void OnValidFromChanged();
        /// <summary>
        /// There are no comments for Property ValidationPeriodId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ValidationPeriodId
        {
            get
            {
                return this._ValidationPeriodId;
            }
            set
            {
                this.OnValidationPeriodIdChanging(value);
                this._ValidationPeriodId = value;
                this.OnValidationPeriodIdChanged();
                this.OnPropertyChanged("ValidationPeriodId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ValidationPeriodId;
        partial void OnValidationPeriodIdChanging(string value);
        partial void OnValidationPeriodIdChanged();
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
