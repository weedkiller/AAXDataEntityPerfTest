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
    /// There are no comments for TaxItemGroupSingle in the schema.
    /// </summary>
    public partial class TaxItemGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TaxItemGroup>
    {
        /// <summary>
        /// Initialize a new TaxItemGroupSingle object.
        /// </summary>
        public TaxItemGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TaxItemGroupSingle object.
        /// </summary>
        public TaxItemGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TaxItemGroupSingle object.
        /// </summary>
        public TaxItemGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TaxItemGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for FreeTextInvoiceLineTaxItemGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceLine> FreeTextInvoiceLineTaxItemGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FreeTextInvoiceLineTaxItemGroup == null))
                {
                    this._FreeTextInvoiceLineTaxItemGroup = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceLine>(GetPath("FreeTextInvoiceLineTaxItemGroup"));
                }
                return this._FreeTextInvoiceLineTaxItemGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceLine> _FreeTextInvoiceLineTaxItemGroup;
        /// <summary>
        /// There are no comments for PurchaseOrderHeaderCharges in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PurchaseOrderHeaderCharge> PurchaseOrderHeaderCharges
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PurchaseOrderHeaderCharges == null))
                {
                    this._PurchaseOrderHeaderCharges = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PurchaseOrderHeaderCharge>(GetPath("PurchaseOrderHeaderCharges"));
                }
                return this._PurchaseOrderHeaderCharges;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PurchaseOrderHeaderCharge> _PurchaseOrderHeaderCharges;
        /// <summary>
        /// There are no comments for CustomerPaymentJournalFee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalFee> CustomerPaymentJournalFee
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CustomerPaymentJournalFee == null))
                {
                    this._CustomerPaymentJournalFee = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalFee>(GetPath("CustomerPaymentJournalFee"));
                }
                return this._CustomerPaymentJournalFee;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalFee> _CustomerPaymentJournalFee;
        /// <summary>
        /// There are no comments for CustomerPaymentJournalLineTaxItemGroupEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine> CustomerPaymentJournalLineTaxItemGroupEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CustomerPaymentJournalLineTaxItemGroupEntity == null))
                {
                    this._CustomerPaymentJournalLineTaxItemGroupEntity = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine>(GetPath("CustomerPaymentJournalLineTaxItemGroupEntity"));
                }
                return this._CustomerPaymentJournalLineTaxItemGroupEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine> _CustomerPaymentJournalLineTaxItemGroupEntity;
        /// <summary>
        /// There are no comments for VendorPaymentJournalFee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalFee> VendorPaymentJournalFee
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VendorPaymentJournalFee == null))
                {
                    this._VendorPaymentJournalFee = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalFee>(GetPath("VendorPaymentJournalFee"));
                }
                return this._VendorPaymentJournalFee;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalFee> _VendorPaymentJournalFee;
        /// <summary>
        /// There are no comments for TaxCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TaxCodeSingle TaxCode
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TaxCode == null))
                {
                    this._TaxCode = new global::Microsoft.Dynamics.DataEntities.TaxCodeSingle(this.Context, GetPath("TaxCode"));
                }
                return this._TaxCode;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TaxCodeSingle _TaxCode;
        /// <summary>
        /// There are no comments for LedgerJournalLineCDSItemSalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LedgerJournalCDSLine> LedgerJournalLineCDSItemSalesTaxGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerJournalLineCDSItemSalesTaxGroup == null))
                {
                    this._LedgerJournalLineCDSItemSalesTaxGroup = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.LedgerJournalCDSLine>(GetPath("LedgerJournalLineCDSItemSalesTaxGroup"));
                }
                return this._LedgerJournalLineCDSItemSalesTaxGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LedgerJournalCDSLine> _LedgerJournalLineCDSItemSalesTaxGroup;
        /// <summary>
        /// There are no comments for LedgerJournalLineItemSalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LedgerJournalLine> LedgerJournalLineItemSalesTaxGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LedgerJournalLineItemSalesTaxGroup == null))
                {
                    this._LedgerJournalLineItemSalesTaxGroup = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.LedgerJournalLine>(GetPath("LedgerJournalLineItemSalesTaxGroup"));
                }
                return this._LedgerJournalLineItemSalesTaxGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.LedgerJournalLine> _LedgerJournalLineItemSalesTaxGroup;
        /// <summary>
        /// There are no comments for PurchaseOrderLineCharges in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PurchaseOrderLineCharge> PurchaseOrderLineCharges
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PurchaseOrderLineCharges == null))
                {
                    this._PurchaseOrderLineCharges = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PurchaseOrderLineCharge>(GetPath("PurchaseOrderLineCharges"));
                }
                return this._PurchaseOrderLineCharges;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PurchaseOrderLineCharge> _PurchaseOrderLineCharges;
    }
    /// <summary>
    /// There are no comments for TaxItemGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// TaxItemGroupCode
    /// TaxCodeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TaxItemGroupCode", "TaxCodeId")]
    [global::Microsoft.OData.Client.EntitySet("TaxItemGroups")]
    public partial class TaxItemGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TaxItemGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="taxItemGroupCode">Initial value of TaxItemGroupCode.</param>
        /// <param name="taxCodeId">Initial value of TaxCodeId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TaxItemGroup CreateTaxItemGroup(string dataAreaId, string taxItemGroupCode, string taxCodeId)
        {
            TaxItemGroup taxItemGroup = new TaxItemGroup();
            taxItemGroup.dataAreaId = dataAreaId;
            taxItemGroup.TaxItemGroupCode = taxItemGroupCode;
            taxItemGroup.TaxCodeId = taxCodeId;
            return taxItemGroup;
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
        /// There are no comments for Property TaxItemGroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxItemGroupCode
        {
            get
            {
                return this._TaxItemGroupCode;
            }
            set
            {
                this.OnTaxItemGroupCodeChanging(value);
                this._TaxItemGroupCode = value;
                this.OnTaxItemGroupCodeChanged();
                this.OnPropertyChanged("TaxItemGroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxItemGroupCode;
        partial void OnTaxItemGroupCodeChanging(string value);
        partial void OnTaxItemGroupCodeChanged();
        /// <summary>
        /// There are no comments for Property TaxCodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxCodeId
        {
            get
            {
                return this._TaxCodeId;
            }
            set
            {
                this.OnTaxCodeIdChanging(value);
                this._TaxCodeId = value;
                this.OnTaxCodeIdChanged();
                this.OnPropertyChanged("TaxCodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxCodeId;
        partial void OnTaxCodeIdChanging(string value);
        partial void OnTaxCodeIdChanged();
        /// <summary>
        /// There are no comments for Property TaxationCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxationCode
        {
            get
            {
                return this._TaxationCode;
            }
            set
            {
                this.OnTaxationCodeChanging(value);
                this._TaxationCode = value;
                this.OnTaxationCodeChanged();
                this.OnPropertyChanged("TaxationCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxationCode;
        partial void OnTaxationCodeChanging(string value);
        partial void OnTaxationCodeChanged();
        /// <summary>
        /// There are no comments for Property EUSalesListType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EUSalesListType> EUSalesListType
        {
            get
            {
                return this._EUSalesListType;
            }
            set
            {
                this.OnEUSalesListTypeChanging(value);
                this._EUSalesListType = value;
                this.OnEUSalesListTypeChanged();
                this.OnPropertyChanged("EUSalesListType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EUSalesListType> _EUSalesListType;
        partial void OnEUSalesListTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EUSalesListType> value);
        partial void OnEUSalesListTypeChanged();
        /// <summary>
        /// There are no comments for Property TaxExemptCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxExemptCode
        {
            get
            {
                return this._TaxExemptCode;
            }
            set
            {
                this.OnTaxExemptCodeChanging(value);
                this._TaxExemptCode = value;
                this.OnTaxExemptCodeChanged();
                this.OnPropertyChanged("TaxExemptCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxExemptCode;
        partial void OnTaxExemptCodeChanging(string value);
        partial void OnTaxExemptCodeChanged();
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
        /// There are no comments for Property WithoutTaxCredit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WithoutTaxCredit
        {
            get
            {
                return this._WithoutTaxCredit;
            }
            set
            {
                this.OnWithoutTaxCreditChanging(value);
                this._WithoutTaxCredit = value;
                this.OnWithoutTaxCreditChanged();
                this.OnPropertyChanged("WithoutTaxCredit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WithoutTaxCredit;
        partial void OnWithoutTaxCreditChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWithoutTaxCreditChanged();
        /// <summary>
        /// There are no comments for Property ExemptTax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ExemptTax
        {
            get
            {
                return this._ExemptTax;
            }
            set
            {
                this.OnExemptTaxChanging(value);
                this._ExemptTax = value;
                this.OnExemptTaxChanged();
                this.OnPropertyChanged("ExemptTax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ExemptTax;
        partial void OnExemptTaxChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnExemptTaxChanged();
        /// <summary>
        /// There are no comments for Property FreeTextInvoiceLineTaxItemGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceLine> FreeTextInvoiceLineTaxItemGroup
        {
            get
            {
                return this._FreeTextInvoiceLineTaxItemGroup;
            }
            set
            {
                this.OnFreeTextInvoiceLineTaxItemGroupChanging(value);
                this._FreeTextInvoiceLineTaxItemGroup = value;
                this.OnFreeTextInvoiceLineTaxItemGroupChanged();
                this.OnPropertyChanged("FreeTextInvoiceLineTaxItemGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceLine> _FreeTextInvoiceLineTaxItemGroup = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnFreeTextInvoiceLineTaxItemGroupChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.FreeTextInvoiceLine> value);
        partial void OnFreeTextInvoiceLineTaxItemGroupChanged();
        /// <summary>
        /// There are no comments for Property PurchaseOrderHeaderCharges in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PurchaseOrderHeaderCharge> PurchaseOrderHeaderCharges
        {
            get
            {
                return this._PurchaseOrderHeaderCharges;
            }
            set
            {
                this.OnPurchaseOrderHeaderChargesChanging(value);
                this._PurchaseOrderHeaderCharges = value;
                this.OnPurchaseOrderHeaderChargesChanged();
                this.OnPropertyChanged("PurchaseOrderHeaderCharges");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PurchaseOrderHeaderCharge> _PurchaseOrderHeaderCharges = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PurchaseOrderHeaderCharge>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPurchaseOrderHeaderChargesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PurchaseOrderHeaderCharge> value);
        partial void OnPurchaseOrderHeaderChargesChanged();
        /// <summary>
        /// There are no comments for Property CustomerPaymentJournalFee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalFee> CustomerPaymentJournalFee
        {
            get
            {
                return this._CustomerPaymentJournalFee;
            }
            set
            {
                this.OnCustomerPaymentJournalFeeChanging(value);
                this._CustomerPaymentJournalFee = value;
                this.OnCustomerPaymentJournalFeeChanged();
                this.OnPropertyChanged("CustomerPaymentJournalFee");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalFee> _CustomerPaymentJournalFee = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalFee>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCustomerPaymentJournalFeeChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalFee> value);
        partial void OnCustomerPaymentJournalFeeChanged();
        /// <summary>
        /// There are no comments for Property CustomerPaymentJournalLineTaxItemGroupEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine> CustomerPaymentJournalLineTaxItemGroupEntity
        {
            get
            {
                return this._CustomerPaymentJournalLineTaxItemGroupEntity;
            }
            set
            {
                this.OnCustomerPaymentJournalLineTaxItemGroupEntityChanging(value);
                this._CustomerPaymentJournalLineTaxItemGroupEntity = value;
                this.OnCustomerPaymentJournalLineTaxItemGroupEntityChanged();
                this.OnPropertyChanged("CustomerPaymentJournalLineTaxItemGroupEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine> _CustomerPaymentJournalLineTaxItemGroupEntity = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCustomerPaymentJournalLineTaxItemGroupEntityChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerPaymentJournalLine> value);
        partial void OnCustomerPaymentJournalLineTaxItemGroupEntityChanged();
        /// <summary>
        /// There are no comments for Property VendorPaymentJournalFee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalFee> VendorPaymentJournalFee
        {
            get
            {
                return this._VendorPaymentJournalFee;
            }
            set
            {
                this.OnVendorPaymentJournalFeeChanging(value);
                this._VendorPaymentJournalFee = value;
                this.OnVendorPaymentJournalFeeChanged();
                this.OnPropertyChanged("VendorPaymentJournalFee");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalFee> _VendorPaymentJournalFee = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalFee>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnVendorPaymentJournalFeeChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorPaymentJournalFee> value);
        partial void OnVendorPaymentJournalFeeChanged();
        /// <summary>
        /// There are no comments for Property TaxCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TaxCode TaxCode
        {
            get
            {
                return this._TaxCode;
            }
            set
            {
                this.OnTaxCodeChanging(value);
                this._TaxCode = value;
                this.OnTaxCodeChanged();
                this.OnPropertyChanged("TaxCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TaxCode _TaxCode;
        partial void OnTaxCodeChanging(global::Microsoft.Dynamics.DataEntities.TaxCode value);
        partial void OnTaxCodeChanged();
        /// <summary>
        /// There are no comments for Property LedgerJournalLineCDSItemSalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerJournalCDSLine> LedgerJournalLineCDSItemSalesTaxGroup
        {
            get
            {
                return this._LedgerJournalLineCDSItemSalesTaxGroup;
            }
            set
            {
                this.OnLedgerJournalLineCDSItemSalesTaxGroupChanging(value);
                this._LedgerJournalLineCDSItemSalesTaxGroup = value;
                this.OnLedgerJournalLineCDSItemSalesTaxGroupChanged();
                this.OnPropertyChanged("LedgerJournalLineCDSItemSalesTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerJournalCDSLine> _LedgerJournalLineCDSItemSalesTaxGroup = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerJournalCDSLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnLedgerJournalLineCDSItemSalesTaxGroupChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerJournalCDSLine> value);
        partial void OnLedgerJournalLineCDSItemSalesTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property LedgerJournalLineItemSalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerJournalLine> LedgerJournalLineItemSalesTaxGroup
        {
            get
            {
                return this._LedgerJournalLineItemSalesTaxGroup;
            }
            set
            {
                this.OnLedgerJournalLineItemSalesTaxGroupChanging(value);
                this._LedgerJournalLineItemSalesTaxGroup = value;
                this.OnLedgerJournalLineItemSalesTaxGroupChanged();
                this.OnPropertyChanged("LedgerJournalLineItemSalesTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerJournalLine> _LedgerJournalLineItemSalesTaxGroup = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerJournalLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnLedgerJournalLineItemSalesTaxGroupChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.LedgerJournalLine> value);
        partial void OnLedgerJournalLineItemSalesTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property PurchaseOrderLineCharges in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PurchaseOrderLineCharge> PurchaseOrderLineCharges
        {
            get
            {
                return this._PurchaseOrderLineCharges;
            }
            set
            {
                this.OnPurchaseOrderLineChargesChanging(value);
                this._PurchaseOrderLineCharges = value;
                this.OnPurchaseOrderLineChargesChanged();
                this.OnPropertyChanged("PurchaseOrderLineCharges");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PurchaseOrderLineCharge> _PurchaseOrderLineCharges = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PurchaseOrderLineCharge>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPurchaseOrderLineChargesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PurchaseOrderLineCharge> value);
        partial void OnPurchaseOrderLineChargesChanged();
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
