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
    /// There are no comments for BudgetAllowTransferRuleSingle in the schema.
    /// </summary>
    public partial class BudgetAllowTransferRuleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetAllowTransferRule>
    {
        /// <summary>
        /// Initialize a new BudgetAllowTransferRuleSingle object.
        /// </summary>
        public BudgetAllowTransferRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BudgetAllowTransferRuleSingle object.
        /// </summary>
        public BudgetAllowTransferRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BudgetAllowTransferRuleSingle object.
        /// </summary>
        public BudgetAllowTransferRuleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetAllowTransferRule> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AccountStructures in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AccountStructureSingle AccountStructures
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AccountStructures == null))
                {
                    this._AccountStructures = new global::Microsoft.Dynamics.DataEntities.AccountStructureSingle(this.Context, GetPath("AccountStructures"));
                }
                return this._AccountStructures;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AccountStructureSingle _AccountStructures;
        /// <summary>
        /// There are no comments for LegalEntities in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.LedgerSingle LegalEntities
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LegalEntities == null))
                {
                    this._LegalEntities = new global::Microsoft.Dynamics.DataEntities.LedgerSingle(this.Context, GetPath("LegalEntities"));
                }
                return this._LegalEntities;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LedgerSingle _LegalEntities;
        /// <summary>
        /// There are no comments for BudgetDimensions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetDimensionSingle BudgetDimensions
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetDimensions == null))
                {
                    this._BudgetDimensions = new global::Microsoft.Dynamics.DataEntities.BudgetDimensionSingle(this.Context, GetPath("BudgetDimensions"));
                }
                return this._BudgetDimensions;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetDimensionSingle _BudgetDimensions;
    }
    /// <summary>
    /// There are no comments for BudgetAllowTransferRule in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// LegalEntityId
    /// BudgetTransferRule
    /// RuleMember
    /// DimensionAttributeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LegalEntityId", "BudgetTransferRule", "RuleMember", "DimensionAttributeId")]
    [global::Microsoft.OData.Client.EntitySet("BudgetAllowTransferRules")]
    public partial class BudgetAllowTransferRule : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BudgetAllowTransferRule object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        /// <param name="budgetTransferRule">Initial value of BudgetTransferRule.</param>
        /// <param name="ruleMember">Initial value of RuleMember.</param>
        /// <param name="dimensionAttributeId">Initial value of DimensionAttributeId.</param>
        /// <param name="accountStructures">Initial value of AccountStructures.</param>
        /// <param name="legalEntities">Initial value of LegalEntities.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BudgetAllowTransferRule CreateBudgetAllowTransferRule(string dataAreaId, 
                    string legalEntityId, 
                    string budgetTransferRule, 
                    string ruleMember, 
                    string dimensionAttributeId, 
                    global::Microsoft.Dynamics.DataEntities.AccountStructure accountStructures, 
                    global::Microsoft.Dynamics.DataEntities.Ledger legalEntities)
        {
            BudgetAllowTransferRule budgetAllowTransferRule = new BudgetAllowTransferRule();
            budgetAllowTransferRule.dataAreaId = dataAreaId;
            budgetAllowTransferRule.LegalEntityId = legalEntityId;
            budgetAllowTransferRule.BudgetTransferRule = budgetTransferRule;
            budgetAllowTransferRule.RuleMember = ruleMember;
            budgetAllowTransferRule.DimensionAttributeId = dimensionAttributeId;
            if ((accountStructures == null))
            {
                throw new global::System.ArgumentNullException("accountStructures");
            }
            budgetAllowTransferRule.AccountStructures = accountStructures;
            if ((legalEntities == null))
            {
                throw new global::System.ArgumentNullException("legalEntities");
            }
            budgetAllowTransferRule.LegalEntities = legalEntities;
            return budgetAllowTransferRule;
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
        /// There are no comments for Property LegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LegalEntityId
        {
            get
            {
                return this._LegalEntityId;
            }
            set
            {
                this.OnLegalEntityIdChanging(value);
                this._LegalEntityId = value;
                this.OnLegalEntityIdChanged();
                this.OnPropertyChanged("LegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalEntityId;
        partial void OnLegalEntityIdChanging(string value);
        partial void OnLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property BudgetTransferRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BudgetTransferRule
        {
            get
            {
                return this._BudgetTransferRule;
            }
            set
            {
                this.OnBudgetTransferRuleChanging(value);
                this._BudgetTransferRule = value;
                this.OnBudgetTransferRuleChanged();
                this.OnPropertyChanged("BudgetTransferRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BudgetTransferRule;
        partial void OnBudgetTransferRuleChanging(string value);
        partial void OnBudgetTransferRuleChanged();
        /// <summary>
        /// There are no comments for Property RuleMember in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RuleMember
        {
            get
            {
                return this._RuleMember;
            }
            set
            {
                this.OnRuleMemberChanging(value);
                this._RuleMember = value;
                this.OnRuleMemberChanged();
                this.OnPropertyChanged("RuleMember");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RuleMember;
        partial void OnRuleMemberChanging(string value);
        partial void OnRuleMemberChanged();
        /// <summary>
        /// There are no comments for Property DimensionAttributeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DimensionAttributeId
        {
            get
            {
                return this._DimensionAttributeId;
            }
            set
            {
                this.OnDimensionAttributeIdChanging(value);
                this._DimensionAttributeId = value;
                this.OnDimensionAttributeIdChanged();
                this.OnPropertyChanged("DimensionAttributeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DimensionAttributeId;
        partial void OnDimensionAttributeIdChanging(string value);
        partial void OnDimensionAttributeIdChanged();
        /// <summary>
        /// There are no comments for Property AccountStructureId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AccountStructureId
        {
            get
            {
                return this._AccountStructureId;
            }
            set
            {
                this.OnAccountStructureIdChanging(value);
                this._AccountStructureId = value;
                this.OnAccountStructureIdChanged();
                this.OnPropertyChanged("AccountStructureId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountStructureId;
        partial void OnAccountStructureIdChanging(string value);
        partial void OnAccountStructureIdChanged();
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
        /// There are no comments for Property Criterion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Criterion
        {
            get
            {
                return this._Criterion;
            }
            set
            {
                this.OnCriterionChanging(value);
                this._Criterion = value;
                this.OnCriterionChanged();
                this.OnPropertyChanged("Criterion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Criterion;
        partial void OnCriterionChanging(string value);
        partial void OnCriterionChanged();
        /// <summary>
        /// There are no comments for Property AccountStructures in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AccountStructure AccountStructures
        {
            get
            {
                return this._AccountStructures;
            }
            set
            {
                this.OnAccountStructuresChanging(value);
                this._AccountStructures = value;
                this.OnAccountStructuresChanged();
                this.OnPropertyChanged("AccountStructures");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AccountStructure _AccountStructures;
        partial void OnAccountStructuresChanging(global::Microsoft.Dynamics.DataEntities.AccountStructure value);
        partial void OnAccountStructuresChanged();
        /// <summary>
        /// There are no comments for Property LegalEntities in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Ledger LegalEntities
        {
            get
            {
                return this._LegalEntities;
            }
            set
            {
                this.OnLegalEntitiesChanging(value);
                this._LegalEntities = value;
                this.OnLegalEntitiesChanged();
                this.OnPropertyChanged("LegalEntities");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Ledger _LegalEntities;
        partial void OnLegalEntitiesChanging(global::Microsoft.Dynamics.DataEntities.Ledger value);
        partial void OnLegalEntitiesChanged();
        /// <summary>
        /// There are no comments for Property BudgetDimensions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetDimension BudgetDimensions
        {
            get
            {
                return this._BudgetDimensions;
            }
            set
            {
                this.OnBudgetDimensionsChanging(value);
                this._BudgetDimensions = value;
                this.OnBudgetDimensionsChanged();
                this.OnPropertyChanged("BudgetDimensions");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetDimension _BudgetDimensions;
        partial void OnBudgetDimensionsChanging(global::Microsoft.Dynamics.DataEntities.BudgetDimension value);
        partial void OnBudgetDimensionsChanged();
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
