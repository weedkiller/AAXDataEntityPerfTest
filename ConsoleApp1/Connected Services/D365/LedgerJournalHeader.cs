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
    /// There are no comments for LedgerJournalHeaderSingle in the schema.
    /// </summary>
    public partial class LedgerJournalHeaderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LedgerJournalHeader>
    {
        /// <summary>
        /// Initialize a new LedgerJournalHeaderSingle object.
        /// </summary>
        public LedgerJournalHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LedgerJournalHeaderSingle object.
        /// </summary>
        public LedgerJournalHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LedgerJournalHeaderSingle object.
        /// </summary>
        public LedgerJournalHeaderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LedgerJournalHeader> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.LegalEntitySingle LegalEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LegalEntity == null))
                {
                    this._LegalEntity = new global::Microsoft.Dynamics.DataEntities.LegalEntitySingle(this.Context, GetPath("LegalEntity"));
                }
                return this._LegalEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LegalEntitySingle _LegalEntity;
        /// <summary>
        /// There are no comments for LedgerJournalLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LedgerJournalLine> LedgerJournalLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerJournalLine == null))
                {
                    this._LedgerJournalLine = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.LedgerJournalLine>(GetPath("LedgerJournalLine"));
                }
                return this._LedgerJournalLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LedgerJournalLine> _LedgerJournalLine;
    }
    /// <summary>
    /// There are no comments for LedgerJournalHeader in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// JournalBatchNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "JournalBatchNumber")]
    [global::Microsoft.OData.Client.EntitySet("LedgerJournalHeaders")]
    public partial class LedgerJournalHeader : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LedgerJournalHeader object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="journalBatchNumber">Initial value of JournalBatchNumber.</param>
        /// <param name="journalTotalCredit">Initial value of JournalTotalCredit.</param>
        /// <param name="journalTotalDebit">Initial value of JournalTotalDebit.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LedgerJournalHeader CreateLedgerJournalHeader(string dataAreaId, string journalBatchNumber, decimal journalTotalCredit, decimal journalTotalDebit)
        {
            LedgerJournalHeader ledgerJournalHeader = new LedgerJournalHeader();
            ledgerJournalHeader.dataAreaId = dataAreaId;
            ledgerJournalHeader.JournalBatchNumber = journalBatchNumber;
            ledgerJournalHeader.JournalTotalCredit = journalTotalCredit;
            ledgerJournalHeader.JournalTotalDebit = journalTotalDebit;
            return ledgerJournalHeader;
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
        /// There are no comments for Property AccountingCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AccountingCurrency
        {
            get
            {
                return this._AccountingCurrency;
            }
            set
            {
                this.OnAccountingCurrencyChanging(value);
                this._AccountingCurrency = value;
                this.OnAccountingCurrencyChanged();
                this.OnPropertyChanged("AccountingCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountingCurrency;
        partial void OnAccountingCurrencyChanging(string value);
        partial void OnAccountingCurrencyChanged();
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
        /// There are no comments for Property IntegrationKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string IntegrationKey
        {
            get
            {
                return this._IntegrationKey;
            }
            set
            {
                this.OnIntegrationKeyChanging(value);
                this._IntegrationKey = value;
                this.OnIntegrationKeyChanged();
                this.OnPropertyChanged("IntegrationKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IntegrationKey;
        partial void OnIntegrationKeyChanging(string value);
        partial void OnIntegrationKeyChanged();
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
        /// There are no comments for Property PostingLayer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrentOperationsTax> PostingLayer
        {
            get
            {
                return this._PostingLayer;
            }
            set
            {
                this.OnPostingLayerChanging(value);
                this._PostingLayer = value;
                this.OnPostingLayerChanged();
                this.OnPropertyChanged("PostingLayer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrentOperationsTax> _PostingLayer;
        partial void OnPostingLayerChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrentOperationsTax> value);
        partial void OnPostingLayerChanged();
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
        /// There are no comments for Property JournalTotalCredit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal JournalTotalCredit
        {
            get
            {
                return this._JournalTotalCredit;
            }
            set
            {
                this.OnJournalTotalCreditChanging(value);
                this._JournalTotalCredit = value;
                this.OnJournalTotalCreditChanged();
                this.OnPropertyChanged("JournalTotalCredit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _JournalTotalCredit;
        partial void OnJournalTotalCreditChanging(decimal value);
        partial void OnJournalTotalCreditChanged();
        /// <summary>
        /// There are no comments for Property JournalTotalDebit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal JournalTotalDebit
        {
            get
            {
                return this._JournalTotalDebit;
            }
            set
            {
                this.OnJournalTotalDebitChanging(value);
                this._JournalTotalDebit = value;
                this.OnJournalTotalDebitChanged();
                this.OnPropertyChanged("JournalTotalDebit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _JournalTotalDebit;
        partial void OnJournalTotalDebitChanging(decimal value);
        partial void OnJournalTotalDebitChanged();
        /// <summary>
        /// There are no comments for Property LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.LegalEntity LegalEntity
        {
            get
            {
                return this._LegalEntity;
            }
            set
            {
                this.OnLegalEntityChanging(value);
                this._LegalEntity = value;
                this.OnLegalEntityChanged();
                this.OnPropertyChanged("LegalEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LegalEntity _LegalEntity;
        partial void OnLegalEntityChanging(global::Microsoft.Dynamics.DataEntities.LegalEntity value);
        partial void OnLegalEntityChanged();
        /// <summary>
        /// There are no comments for Property LedgerJournalLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerJournalLine> LedgerJournalLine
        {
            get
            {
                return this._LedgerJournalLine;
            }
            set
            {
                this.OnLedgerJournalLineChanging(value);
                this._LedgerJournalLine = value;
                this.OnLedgerJournalLineChanged();
                this.OnPropertyChanged("LedgerJournalLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerJournalLine> _LedgerJournalLine = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerJournalLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnLedgerJournalLineChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerJournalLine> value);
        partial void OnLedgerJournalLineChanged();
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
