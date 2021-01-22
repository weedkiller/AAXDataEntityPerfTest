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
        /// There are no comments for VendorPaymentJournalHeaderSingle in the schema.
        /// </summary>
    public partial class VendorPaymentJournalHeaderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VendorPaymentJournalHeader>
    {
        /// <summary>
        /// Initialize a new VendorPaymentJournalHeaderSingle object.
        /// </summary>
        public VendorPaymentJournalHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VendorPaymentJournalHeaderSingle object.
        /// </summary>
        public VendorPaymentJournalHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VendorPaymentJournalHeaderSingle object.
        /// </summary>
        public VendorPaymentJournalHeaderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VendorPaymentJournalHeader> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for VendorPaymentJournalLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLine> VendorPaymentJournalLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VendorPaymentJournalLine == null))
                {
                    this._VendorPaymentJournalLine = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLine>(GetPath("VendorPaymentJournalLine"));
                }
                return this._VendorPaymentJournalLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLine> _VendorPaymentJournalLine;
        /// <summary>
        /// There are no comments for VendorPaymentJournalHeaderEntityRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLineSettledInvoice> VendorPaymentJournalHeaderEntityRole
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VendorPaymentJournalHeaderEntityRole == null))
                {
                    this._VendorPaymentJournalHeaderEntityRole = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLineSettledInvoice>(GetPath("VendorPaymentJournalHeaderEntityRole"));
                }
                return this._VendorPaymentJournalHeaderEntityRole;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLineSettledInvoice> _VendorPaymentJournalHeaderEntityRole;
    }
        /// <summary>
        /// There are no comments for VendorPaymentJournalHeader in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// JournalBatchNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "JournalBatchNumber")]
    [global::Microsoft.OData.Client.EntitySet("VendorPaymentJournalHeaders")]
    public partial class VendorPaymentJournalHeader : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VendorPaymentJournalHeader object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="journalBatchNumber">Initial value of JournalBatchNumber.</param>
        /// <param name="chargeBearer">Initial value of ChargeBearer.</param>
        /// <param name="categoryPurpose">Initial value of CategoryPurpose.</param>
        /// <param name="localInstrument">Initial value of LocalInstrument.</param>
        /// <param name="serviceLevel">Initial value of ServiceLevel.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VendorPaymentJournalHeader CreateVendorPaymentJournalHeader(string dataAreaId, 
                    string journalBatchNumber, 
                    long chargeBearer, 
                    long categoryPurpose, 
                    long localInstrument, 
                    long serviceLevel)
        {
            VendorPaymentJournalHeader vendorPaymentJournalHeader = new VendorPaymentJournalHeader();
            vendorPaymentJournalHeader.dataAreaId = dataAreaId;
            vendorPaymentJournalHeader.JournalBatchNumber = journalBatchNumber;
            vendorPaymentJournalHeader.ChargeBearer = chargeBearer;
            vendorPaymentJournalHeader.CategoryPurpose = categoryPurpose;
            vendorPaymentJournalHeader.LocalInstrument = localInstrument;
            vendorPaymentJournalHeader.ServiceLevel = serviceLevel;
            return vendorPaymentJournalHeader;
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
        /// There are no comments for Property JournalBatchNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JournalBatchNumber
        {
            get
            {
                return this._JournalBatchNumber;
            }
            set
            {
                this.OnJournalBatchNumberChanging(value);
                this._JournalBatchNumber = value;
                this.OnJournalBatchNumberChanged();
                this.OnPropertyChanged("JournalBatchNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalBatchNumber;
        partial void OnJournalBatchNumberChanging(string value);
        partial void OnJournalBatchNumberChanged();
        /// <summary>
        /// There are no comments for Property JournalName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JournalName
        {
            get
            {
                return this._JournalName;
            }
            set
            {
                this.OnJournalNameChanging(value);
                this._JournalName = value;
                this.OnJournalNameChanged();
                this.OnPropertyChanged("JournalName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalName;
        partial void OnJournalNameChanging(string value);
        partial void OnJournalNameChanged();
        /// <summary>
        /// There are no comments for Property ChargeBearer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long ChargeBearer
        {
            get
            {
                return this._ChargeBearer;
            }
            set
            {
                this.OnChargeBearerChanging(value);
                this._ChargeBearer = value;
                this.OnChargeBearerChanged();
                this.OnPropertyChanged("ChargeBearer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _ChargeBearer;
        partial void OnChargeBearerChanging(long value);
        partial void OnChargeBearerChanged();
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
        /// There are no comments for Property CategoryPurpose in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long CategoryPurpose
        {
            get
            {
                return this._CategoryPurpose;
            }
            set
            {
                this.OnCategoryPurposeChanging(value);
                this._CategoryPurpose = value;
                this.OnCategoryPurposeChanged();
                this.OnPropertyChanged("CategoryPurpose");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _CategoryPurpose;
        partial void OnCategoryPurposeChanging(long value);
        partial void OnCategoryPurposeChanged();
        /// <summary>
        /// There are no comments for Property IsPosted in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsPosted
        {
            get
            {
                return this._IsPosted;
            }
            set
            {
                this.OnIsPostedChanging(value);
                this._IsPosted = value;
                this.OnIsPostedChanged();
                this.OnPropertyChanged("IsPosted");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsPosted;
        partial void OnIsPostedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsPostedChanged();
        /// <summary>
        /// There are no comments for Property LocalInstrument in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long LocalInstrument
        {
            get
            {
                return this._LocalInstrument;
            }
            set
            {
                this.OnLocalInstrumentChanging(value);
                this._LocalInstrument = value;
                this.OnLocalInstrumentChanged();
                this.OnPropertyChanged("LocalInstrument");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _LocalInstrument;
        partial void OnLocalInstrumentChanging(long value);
        partial void OnLocalInstrumentChanged();
        /// <summary>
        /// There are no comments for Property ServiceLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long ServiceLevel
        {
            get
            {
                return this._ServiceLevel;
            }
            set
            {
                this.OnServiceLevelChanging(value);
                this._ServiceLevel = value;
                this.OnServiceLevelChanged();
                this.OnPropertyChanged("ServiceLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _ServiceLevel;
        partial void OnServiceLevelChanging(long value);
        partial void OnServiceLevelChanged();
        /// <summary>
        /// There are no comments for Property VendorPaymentJournalLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLine> VendorPaymentJournalLine
        {
            get
            {
                return this._VendorPaymentJournalLine;
            }
            set
            {
                this.OnVendorPaymentJournalLineChanging(value);
                this._VendorPaymentJournalLine = value;
                this.OnVendorPaymentJournalLineChanged();
                this.OnPropertyChanged("VendorPaymentJournalLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLine> _VendorPaymentJournalLine = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnVendorPaymentJournalLineChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLine> value);
        partial void OnVendorPaymentJournalLineChanged();
        /// <summary>
        /// There are no comments for Property VendorPaymentJournalHeaderEntityRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLineSettledInvoice> VendorPaymentJournalHeaderEntityRole
        {
            get
            {
                return this._VendorPaymentJournalHeaderEntityRole;
            }
            set
            {
                this.OnVendorPaymentJournalHeaderEntityRoleChanging(value);
                this._VendorPaymentJournalHeaderEntityRole = value;
                this.OnVendorPaymentJournalHeaderEntityRoleChanged();
                this.OnPropertyChanged("VendorPaymentJournalHeaderEntityRole");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLineSettledInvoice> _VendorPaymentJournalHeaderEntityRole = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLineSettledInvoice>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnVendorPaymentJournalHeaderEntityRoleChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalLineSettledInvoice> value);
        partial void OnVendorPaymentJournalHeaderEntityRoleChanged();
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
