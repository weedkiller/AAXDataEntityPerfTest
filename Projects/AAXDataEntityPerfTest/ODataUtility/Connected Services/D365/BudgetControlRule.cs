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
        /// There are no comments for BudgetControlRuleSingle in the schema.
        /// </summary>
    public partial class BudgetControlRuleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetControlRule>
    {
        /// <summary>
        /// Initialize a new BudgetControlRuleSingle object.
        /// </summary>
        public BudgetControlRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BudgetControlRuleSingle object.
        /// </summary>
        public BudgetControlRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BudgetControlRuleSingle object.
        /// </summary>
        public BudgetControlRuleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetControlRule> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BudgetManagers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.SystemUserSingle BudgetManagers
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetManagers == null))
                {
                    this._BudgetManagers = new global::Microsoft.Dynamics.DataEntities.SystemUserSingle(this.Context, GetPath("BudgetManagers"));
                }
                return this._BudgetManagers;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.SystemUserSingle _BudgetManagers;
        /// <summary>
        /// There are no comments for BudgetControlConfigurations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationSingle BudgetControlConfigurations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetControlConfigurations == null))
                {
                    this._BudgetControlConfigurations = new global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationSingle(this.Context, GetPath("BudgetControlConfigurations"));
                }
                return this._BudgetControlConfigurations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationSingle _BudgetControlConfigurations;
        /// <summary>
        /// There are no comments for BudgetCycleTimeSpans in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetCycleTimeSpanSingle BudgetCycleTimeSpans
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetCycleTimeSpans == null))
                {
                    this._BudgetCycleTimeSpans = new global::Microsoft.Dynamics.DataEntities.BudgetCycleTimeSpanSingle(this.Context, GetPath("BudgetCycleTimeSpans"));
                }
                return this._BudgetCycleTimeSpans;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetCycleTimeSpanSingle _BudgetCycleTimeSpans;
        /// <summary>
        /// There are no comments for BudgetControlRuleOverBudgetPermissionsBudgetControlRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlRuleOverBudgetPermission> BudgetControlRuleOverBudgetPermissionsBudgetControlRule
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetControlRuleOverBudgetPermissionsBudgetControlRule == null))
                {
                    this._BudgetControlRuleOverBudgetPermissionsBudgetControlRule = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlRuleOverBudgetPermission>(GetPath("BudgetControlRuleOverBudgetPermissionsBudgetControlRule"));
                }
                return this._BudgetControlRuleOverBudgetPermissionsBudgetControlRule;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlRuleOverBudgetPermission> _BudgetControlRuleOverBudgetPermissionsBudgetControlRule;
        /// <summary>
        /// There are no comments for BudgetControlRuleCriterionRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlRuleCriterion> BudgetControlRuleCriterionRule
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetControlRuleCriterionRule == null))
                {
                    this._BudgetControlRuleCriterionRule = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlRuleCriterion>(GetPath("BudgetControlRuleCriterionRule"));
                }
                return this._BudgetControlRuleCriterionRule;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetControlRuleCriterion> _BudgetControlRuleCriterionRule;
    }
        /// <summary>
        /// There are no comments for BudgetControlRule in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// LegalEntityId
    /// Status
    /// Name
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LegalEntityId", "Status", "Name")]
    [global::Microsoft.OData.Client.EntitySet("BudgetControlRules")]
    public partial class BudgetControlRule : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BudgetControlRule object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="budgetThresholdPercent">Initial value of BudgetThresholdPercent.</param>
        /// <param name="budgetControlConfigurations">Initial value of BudgetControlConfigurations.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BudgetControlRule CreateBudgetControlRule(string dataAreaId, string legalEntityId, string name, decimal budgetThresholdPercent, global::Microsoft.Dynamics.DataEntities.BudgetControlConfiguration budgetControlConfigurations)
        {
            BudgetControlRule budgetControlRule = new BudgetControlRule();
            budgetControlRule.dataAreaId = dataAreaId;
            budgetControlRule.LegalEntityId = legalEntityId;
            budgetControlRule.Name = name;
            budgetControlRule.BudgetThresholdPercent = budgetThresholdPercent;
            if ((budgetControlConfigurations == null))
            {
                throw new global::System.ArgumentNullException("budgetControlConfigurations");
            }
            budgetControlRule.BudgetControlConfigurations = budgetControlConfigurations;
            return budgetControlRule;
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
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationStatus> Status
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
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetControlConfigurationStatus> value);
        partial void OnStatusChanged();
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
        /// There are no comments for Property BudgetControlInterval in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetInterval> BudgetControlInterval
        {
            get
            {
                return this._BudgetControlInterval;
            }
            set
            {
                this.OnBudgetControlIntervalChanging(value);
                this._BudgetControlInterval = value;
                this.OnBudgetControlIntervalChanged();
                this.OnPropertyChanged("BudgetControlInterval");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetInterval> _BudgetControlInterval;
        partial void OnBudgetControlIntervalChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetInterval> value);
        partial void OnBudgetControlIntervalChanged();
        /// <summary>
        /// There are no comments for Property BudgetManager in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BudgetManager
        {
            get
            {
                return this._BudgetManager;
            }
            set
            {
                this.OnBudgetManagerChanging(value);
                this._BudgetManager = value;
                this.OnBudgetManagerChanged();
                this.OnPropertyChanged("BudgetManager");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BudgetManager;
        partial void OnBudgetManagerChanging(string value);
        partial void OnBudgetManagerChanged();
        /// <summary>
        /// There are no comments for Property BudgetCycleTimeSpanName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BudgetCycleTimeSpanName
        {
            get
            {
                return this._BudgetCycleTimeSpanName;
            }
            set
            {
                this.OnBudgetCycleTimeSpanNameChanging(value);
                this._BudgetCycleTimeSpanName = value;
                this.OnBudgetCycleTimeSpanNameChanged();
                this.OnPropertyChanged("BudgetCycleTimeSpanName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BudgetCycleTimeSpanName;
        partial void OnBudgetCycleTimeSpanNameChanging(string value);
        partial void OnBudgetCycleTimeSpanNameChanged();
        /// <summary>
        /// There are no comments for Property BudgetCycleTimeSpanFiscalCalendarId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BudgetCycleTimeSpanFiscalCalendarId
        {
            get
            {
                return this._BudgetCycleTimeSpanFiscalCalendarId;
            }
            set
            {
                this.OnBudgetCycleTimeSpanFiscalCalendarIdChanging(value);
                this._BudgetCycleTimeSpanFiscalCalendarId = value;
                this.OnBudgetCycleTimeSpanFiscalCalendarIdChanged();
                this.OnPropertyChanged("BudgetCycleTimeSpanFiscalCalendarId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BudgetCycleTimeSpanFiscalCalendarId;
        partial void OnBudgetCycleTimeSpanFiscalCalendarIdChanging(string value);
        partial void OnBudgetCycleTimeSpanFiscalCalendarIdChanged();
        /// <summary>
        /// There are no comments for Property BudgetThresholdPercent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal BudgetThresholdPercent
        {
            get
            {
                return this._BudgetThresholdPercent;
            }
            set
            {
                this.OnBudgetThresholdPercentChanging(value);
                this._BudgetThresholdPercent = value;
                this.OnBudgetThresholdPercentChanged();
                this.OnPropertyChanged("BudgetThresholdPercent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _BudgetThresholdPercent;
        partial void OnBudgetThresholdPercentChanging(decimal value);
        partial void OnBudgetThresholdPercentChanged();
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
        /// There are no comments for Property InUseBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InUseBy
        {
            get
            {
                return this._InUseBy;
            }
            set
            {
                this.OnInUseByChanging(value);
                this._InUseBy = value;
                this.OnInUseByChanged();
                this.OnPropertyChanged("InUseBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InUseBy;
        partial void OnInUseByChanging(string value);
        partial void OnInUseByChanged();
        /// <summary>
        /// There are no comments for Property BudgetManagers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.SystemUser BudgetManagers
        {
            get
            {
                return this._BudgetManagers;
            }
            set
            {
                this.OnBudgetManagersChanging(value);
                this._BudgetManagers = value;
                this.OnBudgetManagersChanged();
                this.OnPropertyChanged("BudgetManagers");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.SystemUser _BudgetManagers;
        partial void OnBudgetManagersChanging(global::Microsoft.Dynamics.DataEntities.SystemUser value);
        partial void OnBudgetManagersChanged();
        /// <summary>
        /// There are no comments for Property BudgetControlConfigurations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetControlConfiguration BudgetControlConfigurations
        {
            get
            {
                return this._BudgetControlConfigurations;
            }
            set
            {
                this.OnBudgetControlConfigurationsChanging(value);
                this._BudgetControlConfigurations = value;
                this.OnBudgetControlConfigurationsChanged();
                this.OnPropertyChanged("BudgetControlConfigurations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetControlConfiguration _BudgetControlConfigurations;
        partial void OnBudgetControlConfigurationsChanging(global::Microsoft.Dynamics.DataEntities.BudgetControlConfiguration value);
        partial void OnBudgetControlConfigurationsChanged();
        /// <summary>
        /// There are no comments for Property BudgetCycleTimeSpans in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetCycleTimeSpan BudgetCycleTimeSpans
        {
            get
            {
                return this._BudgetCycleTimeSpans;
            }
            set
            {
                this.OnBudgetCycleTimeSpansChanging(value);
                this._BudgetCycleTimeSpans = value;
                this.OnBudgetCycleTimeSpansChanged();
                this.OnPropertyChanged("BudgetCycleTimeSpans");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetCycleTimeSpan _BudgetCycleTimeSpans;
        partial void OnBudgetCycleTimeSpansChanging(global::Microsoft.Dynamics.DataEntities.BudgetCycleTimeSpan value);
        partial void OnBudgetCycleTimeSpansChanged();
        /// <summary>
        /// There are no comments for Property BudgetControlRuleOverBudgetPermissionsBudgetControlRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlRuleOverBudgetPermission> BudgetControlRuleOverBudgetPermissionsBudgetControlRule
        {
            get
            {
                return this._BudgetControlRuleOverBudgetPermissionsBudgetControlRule;
            }
            set
            {
                this.OnBudgetControlRuleOverBudgetPermissionsBudgetControlRuleChanging(value);
                this._BudgetControlRuleOverBudgetPermissionsBudgetControlRule = value;
                this.OnBudgetControlRuleOverBudgetPermissionsBudgetControlRuleChanged();
                this.OnPropertyChanged("BudgetControlRuleOverBudgetPermissionsBudgetControlRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlRuleOverBudgetPermission> _BudgetControlRuleOverBudgetPermissionsBudgetControlRule = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlRuleOverBudgetPermission>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBudgetControlRuleOverBudgetPermissionsBudgetControlRuleChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlRuleOverBudgetPermission> value);
        partial void OnBudgetControlRuleOverBudgetPermissionsBudgetControlRuleChanged();
        /// <summary>
        /// There are no comments for Property BudgetControlRuleCriterionRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlRuleCriterion> BudgetControlRuleCriterionRule
        {
            get
            {
                return this._BudgetControlRuleCriterionRule;
            }
            set
            {
                this.OnBudgetControlRuleCriterionRuleChanging(value);
                this._BudgetControlRuleCriterionRule = value;
                this.OnBudgetControlRuleCriterionRuleChanged();
                this.OnPropertyChanged("BudgetControlRuleCriterionRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlRuleCriterion> _BudgetControlRuleCriterionRule = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlRuleCriterion>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBudgetControlRuleCriterionRuleChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetControlRuleCriterion> value);
        partial void OnBudgetControlRuleCriterionRuleChanged();
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
