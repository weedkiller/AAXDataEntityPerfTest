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
    /// There are no comments for PublishedRequestForQuotationAmendmentSingle in the schema.
    /// </summary>
    public partial class PublishedRequestForQuotationAmendmentSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PublishedRequestForQuotationAmendment>
    {
        /// <summary>
        /// Initialize a new PublishedRequestForQuotationAmendmentSingle object.
        /// </summary>
        public PublishedRequestForQuotationAmendmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PublishedRequestForQuotationAmendmentSingle object.
        /// </summary>
        public PublishedRequestForQuotationAmendmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PublishedRequestForQuotationAmendmentSingle object.
        /// </summary>
        public PublishedRequestForQuotationAmendmentSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PublishedRequestForQuotationAmendment> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for PublishedRequestForQuotationAmendment in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// RFQCaseNumber
    /// AmendmentNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RFQCaseNumber", "AmendmentNumber")]
    [global::Microsoft.OData.Client.EntitySet("PublishedRequestForQuotationAmendments")]
    public partial class PublishedRequestForQuotationAmendment : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PublishedRequestForQuotationAmendment object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="rFQCaseNumber">Initial value of RFQCaseNumber.</param>
        /// <param name="amendmentNumber">Initial value of AmendmentNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PublishedRequestForQuotationAmendment CreatePublishedRequestForQuotationAmendment(string dataAreaId, string rFQCaseNumber, int amendmentNumber)
        {
            PublishedRequestForQuotationAmendment publishedRequestForQuotationAmendment = new PublishedRequestForQuotationAmendment();
            publishedRequestForQuotationAmendment.dataAreaId = dataAreaId;
            publishedRequestForQuotationAmendment.RFQCaseNumber = rFQCaseNumber;
            publishedRequestForQuotationAmendment.AmendmentNumber = amendmentNumber;
            return publishedRequestForQuotationAmendment;
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
        /// There are no comments for Property AmendmentNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int AmendmentNumber
        {
            get
            {
                return this._AmendmentNumber;
            }
            set
            {
                this.OnAmendmentNumberChanging(value);
                this._AmendmentNumber = value;
                this.OnAmendmentNumberChanged();
                this.OnPropertyChanged("AmendmentNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _AmendmentNumber;
        partial void OnAmendmentNumberChanging(int value);
        partial void OnAmendmentNumberChanged();
        /// <summary>
        /// There are no comments for Property AmendmentDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AmendmentDescription
        {
            get
            {
                return this._AmendmentDescription;
            }
            set
            {
                this.OnAmendmentDescriptionChanging(value);
                this._AmendmentDescription = value;
                this.OnAmendmentDescriptionChanged();
                this.OnPropertyChanged("AmendmentDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AmendmentDescription;
        partial void OnAmendmentDescriptionChanging(string value);
        partial void OnAmendmentDescriptionChanged();
        /// <summary>
        /// There are no comments for Property AmendmentRequesterName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AmendmentRequesterName
        {
            get
            {
                return this._AmendmentRequesterName;
            }
            set
            {
                this.OnAmendmentRequesterNameChanging(value);
                this._AmendmentRequesterName = value;
                this.OnAmendmentRequesterNameChanged();
                this.OnPropertyChanged("AmendmentRequesterName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AmendmentRequesterName;
        partial void OnAmendmentRequesterNameChanging(string value);
        partial void OnAmendmentRequesterNameChanged();
        /// <summary>
        /// There are no comments for Property AmendmentName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AmendmentName
        {
            get
            {
                return this._AmendmentName;
            }
            set
            {
                this.OnAmendmentNameChanging(value);
                this._AmendmentName = value;
                this.OnAmendmentNameChanged();
                this.OnPropertyChanged("AmendmentName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AmendmentName;
        partial void OnAmendmentNameChanging(string value);
        partial void OnAmendmentNameChanged();
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
