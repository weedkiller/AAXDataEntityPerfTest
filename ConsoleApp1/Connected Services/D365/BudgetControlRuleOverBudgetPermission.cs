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
    /// There are no comments for BudgetControlRuleOverBudgetPermissionSingle in the schema.
    /// </summary>
    public partial class BudgetControlRuleOverBudgetPermissionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetControlRuleOverBudgetPermission>
    {
        /// <summary>
        /// Initialize a new BudgetControlRuleOverBudgetPermissionSingle object.
        /// </summary>
        public BudgetControlRuleOverBudgetPermissionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BudgetControlRuleOverBudgetPermissionSingle object.
        /// </summary>
        public BudgetControlRuleOverBudgetPermissionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BudgetControlRuleOverBudgetPermissionSingle object.
        /// </summary>
        public BudgetControlRuleOverBudgetPermissionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetControlRuleOverBudgetPermission> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BudgetControlRules in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetControlRuleSingle BudgetControlRules
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetControlRules == null))
                {
                    this._BudgetControlRules = new global::Microsoft.Dynamics.DataEntities.BudgetControlRuleSingle(this.Context, GetPath("BudgetControlRules"));
                }
                return this._BudgetControlRules;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetControlRuleSingle _BudgetControlRules;
        /// <summary>
        /// There are no comments for SystemUserGroups in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UserGroupSingle SystemUserGroups
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SystemUserGroups == null))
                {
                    this._SystemUserGroups = new global::Microsoft.Dynamics.DataEntities.UserGroupSingle(this.Context, GetPath("SystemUserGroups"));
                }
                return this._SystemUserGroups;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UserGroupSingle _SystemUserGroups;
    }
    /// <summary>
    /// There are no comments for BudgetControlRuleOverBudgetPermission in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// LegalEntityId
    /// Status
    /// RuleName
    /// UserGroupId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LegalEntityId", "Status", "RuleName", "UserGroupId")]
    [global::Microsoft.OData.Client.EntitySet("BudgetControlRuleOverBudgetPermissions")]
    public partial class BudgetControlRuleOverBudgetPermission : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BudgetControlRuleOverBudgetPermission object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        /// <param name="ruleName">Initial value of RuleName.</param>
        /// <param name="userGroupId">Initial value of UserGroupId.</param>
        /// <param name="budgetControlRules">Initial value of BudgetControlRules.</param>
        /// <param name="systemUserGroups">Initial value of SystemUserGroups.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BudgetControlRuleOverBudgetPermission CreateBudgetControlRuleOverBudgetPermission(string dataAreaId, 
                    string legalEntityId, 
                    string ruleName, 
                    string userGroupId, 
                    global::Microsoft.Dynamics.DataEntities.BudgetControlRule budgetControlRules, 
                    global::Microsoft.Dynamics.DataEntities.UserGroup systemUserGroups)
        {
            BudgetControlRuleOverBudgetPermission budgetControlRuleOverBudgetPermission = new BudgetControlRuleOverBudgetPermission();
            budgetControlRuleOverBudgetPermission.dataAreaId = dataAreaId;
            budgetControlRuleOverBudgetPermission.LegalEntityId = legalEntityId;
            budgetControlRuleOverBudgetPermission.RuleName = ruleName;
            budgetControlRuleOverBudgetPermission.UserGroupId = userGroupId;
            if ((budgetControlRules == null))
            {
                throw new global::System.ArgumentNullException("budgetControlRules");
            }
            budgetControlRuleOverBudgetPermission.BudgetControlRules = budgetControlRules;
            if ((systemUserGroups == null))
            {
                throw new global::System.ArgumentNullException("systemUserGroups");
            }
            budgetControlRuleOverBudgetPermission.SystemUserGroups = systemUserGroups;
            return budgetControlRuleOverBudgetPermission;
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
        /// There are no comments for Property RuleName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RuleName
        {
            get
            {
                return this._RuleName;
            }
            set
            {
                this.OnRuleNameChanging(value);
                this._RuleName = value;
                this.OnRuleNameChanged();
                this.OnPropertyChanged("RuleName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RuleName;
        partial void OnRuleNameChanging(string value);
        partial void OnRuleNameChanged();
        /// <summary>
        /// There are no comments for Property UserGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string UserGroupId
        {
            get
            {
                return this._UserGroupId;
            }
            set
            {
                this.OnUserGroupIdChanging(value);
                this._UserGroupId = value;
                this.OnUserGroupIdChanged();
                this.OnPropertyChanged("UserGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UserGroupId;
        partial void OnUserGroupIdChanging(string value);
        partial void OnUserGroupIdChanged();
        /// <summary>
        /// There are no comments for Property OverbudgetBudgetGroupCheckOption in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetGroupCheckOverbudgetOption> OverbudgetBudgetGroupCheckOption
        {
            get
            {
                return this._OverbudgetBudgetGroupCheckOption;
            }
            set
            {
                this.OnOverbudgetBudgetGroupCheckOptionChanging(value);
                this._OverbudgetBudgetGroupCheckOption = value;
                this.OnOverbudgetBudgetGroupCheckOptionChanged();
                this.OnPropertyChanged("OverbudgetBudgetGroupCheckOption");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetGroupCheckOverbudgetOption> _OverbudgetBudgetGroupCheckOption;
        partial void OnOverbudgetBudgetGroupCheckOptionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetGroupCheckOverbudgetOption> value);
        partial void OnOverbudgetBudgetGroupCheckOptionChanged();
        /// <summary>
        /// There are no comments for Property OverrideOverbudgetOption in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetCheckOverbudgetOption> OverrideOverbudgetOption
        {
            get
            {
                return this._OverrideOverbudgetOption;
            }
            set
            {
                this.OnOverrideOverbudgetOptionChanging(value);
                this._OverrideOverbudgetOption = value;
                this.OnOverrideOverbudgetOptionChanged();
                this.OnPropertyChanged("OverrideOverbudgetOption");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetCheckOverbudgetOption> _OverrideOverbudgetOption;
        partial void OnOverrideOverbudgetOptionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetCheckOverbudgetOption> value);
        partial void OnOverrideOverbudgetOptionChanged();
        /// <summary>
        /// There are no comments for Property UserGroupName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string UserGroupName
        {
            get
            {
                return this._UserGroupName;
            }
            set
            {
                this.OnUserGroupNameChanging(value);
                this._UserGroupName = value;
                this.OnUserGroupNameChanged();
                this.OnPropertyChanged("UserGroupName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UserGroupName;
        partial void OnUserGroupNameChanging(string value);
        partial void OnUserGroupNameChanged();
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
        /// There are no comments for Property BudgetControlRules in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetControlRule BudgetControlRules
        {
            get
            {
                return this._BudgetControlRules;
            }
            set
            {
                this.OnBudgetControlRulesChanging(value);
                this._BudgetControlRules = value;
                this.OnBudgetControlRulesChanged();
                this.OnPropertyChanged("BudgetControlRules");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetControlRule _BudgetControlRules;
        partial void OnBudgetControlRulesChanging(global::Microsoft.Dynamics.DataEntities.BudgetControlRule value);
        partial void OnBudgetControlRulesChanged();
        /// <summary>
        /// There are no comments for Property SystemUserGroups in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.UserGroup SystemUserGroups
        {
            get
            {
                return this._SystemUserGroups;
            }
            set
            {
                this.OnSystemUserGroupsChanging(value);
                this._SystemUserGroups = value;
                this.OnSystemUserGroupsChanged();
                this.OnPropertyChanged("SystemUserGroups");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.UserGroup _SystemUserGroups;
        partial void OnSystemUserGroupsChanging(global::Microsoft.Dynamics.DataEntities.UserGroup value);
        partial void OnSystemUserGroupsChanged();
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
