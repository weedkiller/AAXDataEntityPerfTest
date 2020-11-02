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
    /// There are no comments for WriteOffFinancialReasonsSetupSingle in the schema.
    /// </summary>
    public partial class WriteOffFinancialReasonsSetupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WriteOffFinancialReasonsSetup>
    {
        /// <summary>
        /// Initialize a new WriteOffFinancialReasonsSetupSingle object.
        /// </summary>
        public WriteOffFinancialReasonsSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WriteOffFinancialReasonsSetupSingle object.
        /// </summary>
        public WriteOffFinancialReasonsSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WriteOffFinancialReasonsSetupSingle object.
        /// </summary>
        public WriteOffFinancialReasonsSetupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WriteOffFinancialReasonsSetup> query)
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
    /// There are no comments for WriteOffFinancialReasonsSetup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Company
    /// WriteOffReason
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Company", "WriteOffReason")]
    [global::Microsoft.OData.Client.EntitySet("WriteOffFinancialReasonsSetups")]
    public partial class WriteOffFinancialReasonsSetup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WriteOffFinancialReasonsSetup object.
        /// </summary>
        /// <param name="company">Initial value of Company.</param>
        /// <param name="writeOffReason">Initial value of WriteOffReason.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WriteOffFinancialReasonsSetup CreateWriteOffFinancialReasonsSetup(string company, string writeOffReason)
        {
            WriteOffFinancialReasonsSetup writeOffFinancialReasonsSetup = new WriteOffFinancialReasonsSetup();
            writeOffFinancialReasonsSetup.Company = company;
            writeOffFinancialReasonsSetup.WriteOffReason = writeOffReason;
            return writeOffFinancialReasonsSetup;
        }
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
        /// There are no comments for Property WriteOffReason in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WriteOffReason
        {
            get
            {
                return this._WriteOffReason;
            }
            set
            {
                this.OnWriteOffReasonChanging(value);
                this._WriteOffReason = value;
                this.OnWriteOffReasonChanged();
                this.OnPropertyChanged("WriteOffReason");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WriteOffReason;
        partial void OnWriteOffReasonChanging(string value);
        partial void OnWriteOffReasonChanged();
        /// <summary>
        /// There are no comments for Property WriteOffDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WriteOffDescription
        {
            get
            {
                return this._WriteOffDescription;
            }
            set
            {
                this.OnWriteOffDescriptionChanging(value);
                this._WriteOffDescription = value;
                this.OnWriteOffDescriptionChanged();
                this.OnPropertyChanged("WriteOffDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WriteOffDescription;
        partial void OnWriteOffDescriptionChanging(string value);
        partial void OnWriteOffDescriptionChanged();
        /// <summary>
        /// There are no comments for Property WriteOffLedgerDimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WriteOffLedgerDimensionDisplayValue
        {
            get
            {
                return this._WriteOffLedgerDimensionDisplayValue;
            }
            set
            {
                this.OnWriteOffLedgerDimensionDisplayValueChanging(value);
                this._WriteOffLedgerDimensionDisplayValue = value;
                this.OnWriteOffLedgerDimensionDisplayValueChanged();
                this.OnPropertyChanged("WriteOffLedgerDimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WriteOffLedgerDimensionDisplayValue;
        partial void OnWriteOffLedgerDimensionDisplayValueChanging(string value);
        partial void OnWriteOffLedgerDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property IsDefault in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsDefault
        {
            get
            {
                return this._IsDefault;
            }
            set
            {
                this.OnIsDefaultChanging(value);
                this._IsDefault = value;
                this.OnIsDefaultChanged();
                this.OnPropertyChanged("IsDefault");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsDefault;
        partial void OnIsDefaultChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsDefaultChanged();
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
