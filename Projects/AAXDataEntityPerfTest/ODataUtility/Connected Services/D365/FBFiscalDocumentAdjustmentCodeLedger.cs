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
        /// There are no comments for FBFiscalDocumentAdjustmentCodeLedgerSingle in the schema.
        /// </summary>
    public partial class FBFiscalDocumentAdjustmentCodeLedgerSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<FBFiscalDocumentAdjustmentCodeLedger>
    {
        /// <summary>
        /// Initialize a new FBFiscalDocumentAdjustmentCodeLedgerSingle object.
        /// </summary>
        public FBFiscalDocumentAdjustmentCodeLedgerSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FBFiscalDocumentAdjustmentCodeLedgerSingle object.
        /// </summary>
        public FBFiscalDocumentAdjustmentCodeLedgerSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FBFiscalDocumentAdjustmentCodeLedgerSingle object.
        /// </summary>
        public FBFiscalDocumentAdjustmentCodeLedgerSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<FBFiscalDocumentAdjustmentCodeLedger> query)
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
        /// There are no comments for FBFiscalDocumentAdjustmentCodeLedger in the schema.
        /// </summary>
    /// <KeyProperties>
    /// FBFiscalDocumentAdjustmentCodeIdentification
    /// Company
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("FBFiscalDocumentAdjustmentCodeIdentification", "Company")]
    [global::Microsoft.OData.Client.EntitySet("FBFiscalDocumentAdjustmentCodeLedgers")]
    public partial class FBFiscalDocumentAdjustmentCodeLedger : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FBFiscalDocumentAdjustmentCodeLedger object.
        /// </summary>
        /// <param name="fBFiscalDocumentAdjustmentCodeIdentification">Initial value of FBFiscalDocumentAdjustmentCodeIdentification.</param>
        /// <param name="company">Initial value of Company.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static FBFiscalDocumentAdjustmentCodeLedger CreateFBFiscalDocumentAdjustmentCodeLedger(string fBFiscalDocumentAdjustmentCodeIdentification, string company)
        {
            FBFiscalDocumentAdjustmentCodeLedger fBFiscalDocumentAdjustmentCodeLedger = new FBFiscalDocumentAdjustmentCodeLedger();
            fBFiscalDocumentAdjustmentCodeLedger.FBFiscalDocumentAdjustmentCodeIdentification = fBFiscalDocumentAdjustmentCodeIdentification;
            fBFiscalDocumentAdjustmentCodeLedger.Company = company;
            return fBFiscalDocumentAdjustmentCodeLedger;
        }
        /// <summary>
        /// There are no comments for Property FBFiscalDocumentAdjustmentCodeIdentification in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FBFiscalDocumentAdjustmentCodeIdentification
        {
            get
            {
                return this._FBFiscalDocumentAdjustmentCodeIdentification;
            }
            set
            {
                this.OnFBFiscalDocumentAdjustmentCodeIdentificationChanging(value);
                this._FBFiscalDocumentAdjustmentCodeIdentification = value;
                this.OnFBFiscalDocumentAdjustmentCodeIdentificationChanged();
                this.OnPropertyChanged("FBFiscalDocumentAdjustmentCodeIdentification");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FBFiscalDocumentAdjustmentCodeIdentification;
        partial void OnFBFiscalDocumentAdjustmentCodeIdentificationChanging(string value);
        partial void OnFBFiscalDocumentAdjustmentCodeIdentificationChanged();
        /// <summary>
        /// There are no comments for Property Company in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Company
        {
            get
            {
                return this._Company;
            }
            set
            {
                this.OnCompanyChanging(value);
                this._Company = value;
                this.OnCompanyChanged();
                this.OnPropertyChanged("Company");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Company;
        partial void OnCompanyChanging(string value);
        partial void OnCompanyChanged();
        /// <summary>
        /// There are no comments for Property LedgerDimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LedgerDimensionDisplayValue
        {
            get
            {
                return this._LedgerDimensionDisplayValue;
            }
            set
            {
                this.OnLedgerDimensionDisplayValueChanging(value);
                this._LedgerDimensionDisplayValue = value;
                this.OnLedgerDimensionDisplayValueChanged();
                this.OnPropertyChanged("LedgerDimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LedgerDimensionDisplayValue;
        partial void OnLedgerDimensionDisplayValueChanging(string value);
        partial void OnLedgerDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property TaxCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TaxCode
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
        private string _TaxCode;
        partial void OnTaxCodeChanging(string value);
        partial void OnTaxCodeChanged();
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
