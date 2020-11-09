﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 11/8/2020 8:07:52 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for SADDocumentLineLedgerJournalSingle in the schema.
        /// </summary>
    public partial class SADDocumentLineLedgerJournalSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SADDocumentLineLedgerJournal>
    {
        /// <summary>
        /// Initialize a new SADDocumentLineLedgerJournalSingle object.
        /// </summary>
        public SADDocumentLineLedgerJournalSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SADDocumentLineLedgerJournalSingle object.
        /// </summary>
        public SADDocumentLineLedgerJournalSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SADDocumentLineLedgerJournalSingle object.
        /// </summary>
        public SADDocumentLineLedgerJournalSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SADDocumentLineLedgerJournal> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for SADDocumentLedgerJournal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.SADDocumentLedgerJournalSingle SADDocumentLedgerJournal
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SADDocumentLedgerJournal == null))
                {
                    this._SADDocumentLedgerJournal = new global::Microsoft.Dynamics.DataEntities.SADDocumentLedgerJournalSingle(this.Context, GetPath("SADDocumentLedgerJournal"));
                }
                return this._SADDocumentLedgerJournal;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.SADDocumentLedgerJournalSingle _SADDocumentLedgerJournal;
        /// <summary>
        /// There are no comments for SADDocumentInvoiceLineLedgerJournal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLineLedgerJournal> SADDocumentInvoiceLineLedgerJournal
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SADDocumentInvoiceLineLedgerJournal == null))
                {
                    this._SADDocumentInvoiceLineLedgerJournal = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLineLedgerJournal>(GetPath("SADDocumentInvoiceLineLedgerJournal"));
                }
                return this._SADDocumentInvoiceLineLedgerJournal;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLineLedgerJournal> _SADDocumentInvoiceLineLedgerJournal;
    }
        /// <summary>
        /// There are no comments for SADDocumentLineLedgerJournal in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// SADDate
    /// SADNumber
    /// Position
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "SADDate", "SADNumber", "Position")]
    [global::Microsoft.OData.Client.EntitySet("SADDocumentLineLedgerJournals")]
    public partial class SADDocumentLineLedgerJournal : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SADDocumentLineLedgerJournal object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="sADDate">Initial value of SADDate.</param>
        /// <param name="sADNumber">Initial value of SADNumber.</param>
        /// <param name="position">Initial value of Position.</param>
        /// <param name="duty">Initial value of Duty.</param>
        /// <param name="baseForSAD">Initial value of BaseForSAD.</param>
        /// <param name="excise">Initial value of Excise.</param>
        /// <param name="salesTaxAmount">Initial value of SalesTaxAmount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SADDocumentLineLedgerJournal CreateSADDocumentLineLedgerJournal(string dataAreaId, 
                    global::System.DateTimeOffset sADDate, 
                    string sADNumber, 
                    int position, 
                    decimal duty, 
                    decimal baseForSAD, 
                    decimal excise, 
                    decimal salesTaxAmount)
        {
            SADDocumentLineLedgerJournal sADDocumentLineLedgerJournal = new SADDocumentLineLedgerJournal();
            sADDocumentLineLedgerJournal.dataAreaId = dataAreaId;
            sADDocumentLineLedgerJournal.SADDate = sADDate;
            sADDocumentLineLedgerJournal.SADNumber = sADNumber;
            sADDocumentLineLedgerJournal.Position = position;
            sADDocumentLineLedgerJournal.Duty = duty;
            sADDocumentLineLedgerJournal.BaseForSAD = baseForSAD;
            sADDocumentLineLedgerJournal.Excise = excise;
            sADDocumentLineLedgerJournal.SalesTaxAmount = salesTaxAmount;
            return sADDocumentLineLedgerJournal;
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
        /// There are no comments for Property SADDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset SADDate
        {
            get
            {
                return this._SADDate;
            }
            set
            {
                this.OnSADDateChanging(value);
                this._SADDate = value;
                this.OnSADDateChanged();
                this.OnPropertyChanged("SADDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _SADDate;
        partial void OnSADDateChanging(global::System.DateTimeOffset value);
        partial void OnSADDateChanged();
        /// <summary>
        /// There are no comments for Property SADNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SADNumber
        {
            get
            {
                return this._SADNumber;
            }
            set
            {
                this.OnSADNumberChanging(value);
                this._SADNumber = value;
                this.OnSADNumberChanged();
                this.OnPropertyChanged("SADNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SADNumber;
        partial void OnSADNumberChanging(string value);
        partial void OnSADNumberChanged();
        /// <summary>
        /// There are no comments for Property Position in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int Position
        {
            get
            {
                return this._Position;
            }
            set
            {
                this.OnPositionChanging(value);
                this._Position = value;
                this.OnPositionChanged();
                this.OnPropertyChanged("Position");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Position;
        partial void OnPositionChanging(int value);
        partial void OnPositionChanged();
        /// <summary>
        /// There are no comments for Property Duty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Duty
        {
            get
            {
                return this._Duty;
            }
            set
            {
                this.OnDutyChanging(value);
                this._Duty = value;
                this.OnDutyChanged();
                this.OnPropertyChanged("Duty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Duty;
        partial void OnDutyChanging(decimal value);
        partial void OnDutyChanged();
        /// <summary>
        /// There are no comments for Property SalesTaxCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SalesTaxCode
        {
            get
            {
                return this._SalesTaxCode;
            }
            set
            {
                this.OnSalesTaxCodeChanging(value);
                this._SalesTaxCode = value;
                this.OnSalesTaxCodeChanged();
                this.OnPropertyChanged("SalesTaxCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesTaxCode;
        partial void OnSalesTaxCodeChanging(string value);
        partial void OnSalesTaxCodeChanged();
        /// <summary>
        /// There are no comments for Property BaseForSAD in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal BaseForSAD
        {
            get
            {
                return this._BaseForSAD;
            }
            set
            {
                this.OnBaseForSADChanging(value);
                this._BaseForSAD = value;
                this.OnBaseForSADChanged();
                this.OnPropertyChanged("BaseForSAD");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _BaseForSAD;
        partial void OnBaseForSADChanging(decimal value);
        partial void OnBaseForSADChanged();
        /// <summary>
        /// There are no comments for Property Excise in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Excise
        {
            get
            {
                return this._Excise;
            }
            set
            {
                this.OnExciseChanging(value);
                this._Excise = value;
                this.OnExciseChanged();
                this.OnPropertyChanged("Excise");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Excise;
        partial void OnExciseChanging(decimal value);
        partial void OnExciseChanged();
        /// <summary>
        /// There are no comments for Property SalesTaxAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal SalesTaxAmount
        {
            get
            {
                return this._SalesTaxAmount;
            }
            set
            {
                this.OnSalesTaxAmountChanging(value);
                this._SalesTaxAmount = value;
                this.OnSalesTaxAmountChanged();
                this.OnPropertyChanged("SalesTaxAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SalesTaxAmount;
        partial void OnSalesTaxAmountChanging(decimal value);
        partial void OnSalesTaxAmountChanged();
        /// <summary>
        /// There are no comments for Property SADDocumentLedgerJournal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.SADDocumentLedgerJournal SADDocumentLedgerJournal
        {
            get
            {
                return this._SADDocumentLedgerJournal;
            }
            set
            {
                this.OnSADDocumentLedgerJournalChanging(value);
                this._SADDocumentLedgerJournal = value;
                this.OnSADDocumentLedgerJournalChanged();
                this.OnPropertyChanged("SADDocumentLedgerJournal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.SADDocumentLedgerJournal _SADDocumentLedgerJournal;
        partial void OnSADDocumentLedgerJournalChanging(global::Microsoft.Dynamics.DataEntities.SADDocumentLedgerJournal value);
        partial void OnSADDocumentLedgerJournalChanged();
        /// <summary>
        /// There are no comments for Property SADDocumentInvoiceLineLedgerJournal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLineLedgerJournal> SADDocumentInvoiceLineLedgerJournal
        {
            get
            {
                return this._SADDocumentInvoiceLineLedgerJournal;
            }
            set
            {
                this.OnSADDocumentInvoiceLineLedgerJournalChanging(value);
                this._SADDocumentInvoiceLineLedgerJournal = value;
                this.OnSADDocumentInvoiceLineLedgerJournalChanged();
                this.OnPropertyChanged("SADDocumentInvoiceLineLedgerJournal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLineLedgerJournal> _SADDocumentInvoiceLineLedgerJournal = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLineLedgerJournal>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnSADDocumentInvoiceLineLedgerJournalChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SADDocumentInvoiceLineLedgerJournal> value);
        partial void OnSADDocumentInvoiceLineLedgerJournalChanged();
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
