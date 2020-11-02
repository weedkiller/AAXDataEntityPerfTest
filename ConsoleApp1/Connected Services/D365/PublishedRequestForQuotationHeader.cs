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
    /// There are no comments for PublishedRequestForQuotationHeaderSingle in the schema.
    /// </summary>
    public partial class PublishedRequestForQuotationHeaderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PublishedRequestForQuotationHeader>
    {
        /// <summary>
        /// Initialize a new PublishedRequestForQuotationHeaderSingle object.
        /// </summary>
        public PublishedRequestForQuotationHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PublishedRequestForQuotationHeaderSingle object.
        /// </summary>
        public PublishedRequestForQuotationHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PublishedRequestForQuotationHeaderSingle object.
        /// </summary>
        public PublishedRequestForQuotationHeaderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PublishedRequestForQuotationHeader> query)
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
    }
    /// <summary>
    /// There are no comments for PublishedRequestForQuotationHeader in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// RFQCaseNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RFQCaseNumber")]
    [global::Microsoft.OData.Client.EntitySet("PublishedRequestForQuotationHeaders")]
    public partial class PublishedRequestForQuotationHeader : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PublishedRequestForQuotationHeader object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="rFQCaseNumber">Initial value of RFQCaseNumber.</param>
        /// <param name="rFQCancellationDateTime">Initial value of RFQCancellationDateTime.</param>
        /// <param name="rFQExpirationDateTime">Initial value of RFQExpirationDateTime.</param>
        /// <param name="rFQDeliveryDate">Initial value of RFQDeliveryDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PublishedRequestForQuotationHeader CreatePublishedRequestForQuotationHeader(string dataAreaId, string rFQCaseNumber, global::System.DateTimeOffset rFQCancellationDateTime, global::System.DateTimeOffset rFQExpirationDateTime, global::System.DateTimeOffset rFQDeliveryDate)
        {
            PublishedRequestForQuotationHeader publishedRequestForQuotationHeader = new PublishedRequestForQuotationHeader();
            publishedRequestForQuotationHeader.dataAreaId = dataAreaId;
            publishedRequestForQuotationHeader.RFQCaseNumber = rFQCaseNumber;
            publishedRequestForQuotationHeader.RFQCancellationDateTime = rFQCancellationDateTime;
            publishedRequestForQuotationHeader.RFQExpirationDateTime = rFQExpirationDateTime;
            publishedRequestForQuotationHeader.RFQDeliveryDate = rFQDeliveryDate;
            return publishedRequestForQuotationHeader;
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
        /// There are no comments for Property RFQCaseNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RFQCaseNumber
        {
            get
            {
                return this._RFQCaseNumber;
            }
            set
            {
                this.OnRFQCaseNumberChanging(value);
                this._RFQCaseNumber = value;
                this.OnRFQCaseNumberChanged();
                this.OnPropertyChanged("RFQCaseNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RFQCaseNumber;
        partial void OnRFQCaseNumberChanging(string value);
        partial void OnRFQCaseNumberChanged();
        /// <summary>
        /// There are no comments for Property RFQCancellationDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset RFQCancellationDateTime
        {
            get
            {
                return this._RFQCancellationDateTime;
            }
            set
            {
                this.OnRFQCancellationDateTimeChanging(value);
                this._RFQCancellationDateTime = value;
                this.OnRFQCancellationDateTimeChanged();
                this.OnPropertyChanged("RFQCancellationDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _RFQCancellationDateTime;
        partial void OnRFQCancellationDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnRFQCancellationDateTimeChanged();
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
        /// There are no comments for Property RFQBidType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PurchRFQBidType> RFQBidType
        {
            get
            {
                return this._RFQBidType;
            }
            set
            {
                this.OnRFQBidTypeChanging(value);
                this._RFQBidType = value;
                this.OnRFQBidTypeChanged();
                this.OnPropertyChanged("RFQBidType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PurchRFQBidType> _RFQBidType;
        partial void OnRFQBidTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PurchRFQBidType> value);
        partial void OnRFQBidTypeChanged();
        /// <summary>
        /// There are no comments for Property AreAlternateProductsAllowed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AreAlternateProductsAllowed
        {
            get
            {
                return this._AreAlternateProductsAllowed;
            }
            set
            {
                this.OnAreAlternateProductsAllowedChanging(value);
                this._AreAlternateProductsAllowed = value;
                this.OnAreAlternateProductsAllowedChanged();
                this.OnPropertyChanged("AreAlternateProductsAllowed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AreAlternateProductsAllowed;
        partial void OnAreAlternateProductsAllowedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAreAlternateProductsAllowedChanged();
        /// <summary>
        /// There are no comments for Property RequestingDepartmentName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RequestingDepartmentName
        {
            get
            {
                return this._RequestingDepartmentName;
            }
            set
            {
                this.OnRequestingDepartmentNameChanging(value);
                this._RequestingDepartmentName = value;
                this.OnRequestingDepartmentNameChanged();
                this.OnPropertyChanged("RequestingDepartmentName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RequestingDepartmentName;
        partial void OnRequestingDepartmentNameChanging(string value);
        partial void OnRequestingDepartmentNameChanged();
        /// <summary>
        /// There are no comments for Property DeliveryAddressName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DeliveryAddressName
        {
            get
            {
                return this._DeliveryAddressName;
            }
            set
            {
                this.OnDeliveryAddressNameChanging(value);
                this._DeliveryAddressName = value;
                this.OnDeliveryAddressNameChanged();
                this.OnPropertyChanged("DeliveryAddressName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DeliveryAddressName;
        partial void OnDeliveryAddressNameChanging(string value);
        partial void OnDeliveryAddressNameChanged();
        /// <summary>
        /// There are no comments for Property RFQCaseTitle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RFQCaseTitle
        {
            get
            {
                return this._RFQCaseTitle;
            }
            set
            {
                this.OnRFQCaseTitleChanging(value);
                this._RFQCaseTitle = value;
                this.OnRFQCaseTitleChanged();
                this.OnPropertyChanged("RFQCaseTitle");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RFQCaseTitle;
        partial void OnRFQCaseTitleChanging(string value);
        partial void OnRFQCaseTitleChanged();
        /// <summary>
        /// There are no comments for Property RFQSolicitationTypeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RFQSolicitationTypeName
        {
            get
            {
                return this._RFQSolicitationTypeName;
            }
            set
            {
                this.OnRFQSolicitationTypeNameChanging(value);
                this._RFQSolicitationTypeName = value;
                this.OnRFQSolicitationTypeNameChanged();
                this.OnPropertyChanged("RFQSolicitationTypeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RFQSolicitationTypeName;
        partial void OnRFQSolicitationTypeNameChanging(string value);
        partial void OnRFQSolicitationTypeNameChanged();
        /// <summary>
        /// There are no comments for Property RFQExpirationDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset RFQExpirationDateTime
        {
            get
            {
                return this._RFQExpirationDateTime;
            }
            set
            {
                this.OnRFQExpirationDateTimeChanging(value);
                this._RFQExpirationDateTime = value;
                this.OnRFQExpirationDateTimeChanged();
                this.OnPropertyChanged("RFQExpirationDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _RFQExpirationDateTime;
        partial void OnRFQExpirationDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnRFQExpirationDateTimeChanged();
        /// <summary>
        /// There are no comments for Property AreOnlyInvitedVendorBidsAllowed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AreOnlyInvitedVendorBidsAllowed
        {
            get
            {
                return this._AreOnlyInvitedVendorBidsAllowed;
            }
            set
            {
                this.OnAreOnlyInvitedVendorBidsAllowedChanging(value);
                this._AreOnlyInvitedVendorBidsAllowed = value;
                this.OnAreOnlyInvitedVendorBidsAllowedChanged();
                this.OnPropertyChanged("AreOnlyInvitedVendorBidsAllowed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AreOnlyInvitedVendorBidsAllowed;
        partial void OnAreOnlyInvitedVendorBidsAllowedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAreOnlyInvitedVendorBidsAllowedChanged();
        /// <summary>
        /// There are no comments for Property RFQCancellationReasonDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RFQCancellationReasonDescription
        {
            get
            {
                return this._RFQCancellationReasonDescription;
            }
            set
            {
                this.OnRFQCancellationReasonDescriptionChanging(value);
                this._RFQCancellationReasonDescription = value;
                this.OnRFQCancellationReasonDescriptionChanged();
                this.OnPropertyChanged("RFQCancellationReasonDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RFQCancellationReasonDescription;
        partial void OnRFQCancellationReasonDescriptionChanging(string value);
        partial void OnRFQCancellationReasonDescriptionChanged();
        /// <summary>
        /// There are no comments for Property RequesterName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RequesterName
        {
            get
            {
                return this._RequesterName;
            }
            set
            {
                this.OnRequesterNameChanging(value);
                this._RequesterName = value;
                this.OnRequesterNameChanged();
                this.OnPropertyChanged("RequesterName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RequesterName;
        partial void OnRequesterNameChanging(string value);
        partial void OnRequesterNameChanged();
        /// <summary>
        /// There are no comments for Property RFQDeliveryDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset RFQDeliveryDate
        {
            get
            {
                return this._RFQDeliveryDate;
            }
            set
            {
                this.OnRFQDeliveryDateChanging(value);
                this._RFQDeliveryDate = value;
                this.OnRFQDeliveryDateChanged();
                this.OnPropertyChanged("RFQDeliveryDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _RFQDeliveryDate;
        partial void OnRFQDeliveryDateChanging(global::System.DateTimeOffset value);
        partial void OnRFQDeliveryDateChanged();
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
