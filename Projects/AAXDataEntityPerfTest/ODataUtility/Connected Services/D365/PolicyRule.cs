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
    /// There are no comments for PolicyRuleSingle in the schema.
    /// </summary>
    public partial class PolicyRuleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PolicyRule>
    {
        /// <summary>
        /// Initialize a new PolicyRuleSingle object.
        /// </summary>
        public PolicyRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PolicyRuleSingle object.
        /// </summary>
        public PolicyRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PolicyRuleSingle object.
        /// </summary>
        public PolicyRuleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PolicyRule> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for PolicyRule in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PolicyName
    /// PolicyType
    /// PolicyRuleName
    /// ValidFrom
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PolicyName", "PolicyType", "PolicyRuleName", "ValidFrom")]
    [global::Microsoft.OData.Client.EntitySet("PolicyRules")]
    public partial class PolicyRule : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PolicyRule object.
        /// </summary>
        /// <param name="policyName">Initial value of PolicyName.</param>
        /// <param name="policyRuleName">Initial value of PolicyRuleName.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="expressionId">Initial value of ExpressionId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PolicyRule CreatePolicyRule(string policyName, string policyRuleName, global::System.DateTimeOffset validFrom, global::System.DateTimeOffset validTo, global::System.Guid expressionId)
        {
            PolicyRule policyRule = new PolicyRule();
            policyRule.PolicyName = policyName;
            policyRule.PolicyRuleName = policyRuleName;
            policyRule.ValidFrom = validFrom;
            policyRule.ValidTo = validTo;
            policyRule.ExpressionId = expressionId;
            return policyRule;
        }
        /// <summary>
        /// There are no comments for Property PolicyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PolicyName
        {
            get
            {
                return this._PolicyName;
            }
            set
            {
                this.OnPolicyNameChanging(value);
                this._PolicyName = value;
                this.OnPolicyNameChanged();
                this.OnPropertyChanged("PolicyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PolicyName;
        partial void OnPolicyNameChanging(string value);
        partial void OnPolicyNameChanged();
        /// <summary>
        /// There are no comments for Property PolicyType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SysPolicyTypeEnum> PolicyType
        {
            get
            {
                return this._PolicyType;
            }
            set
            {
                this.OnPolicyTypeChanging(value);
                this._PolicyType = value;
                this.OnPolicyTypeChanged();
                this.OnPropertyChanged("PolicyType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SysPolicyTypeEnum> _PolicyType;
        partial void OnPolicyTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SysPolicyTypeEnum> value);
        partial void OnPolicyTypeChanged();
        /// <summary>
        /// There are no comments for Property PolicyRuleName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PolicyRuleName
        {
            get
            {
                return this._PolicyRuleName;
            }
            set
            {
                this.OnPolicyRuleNameChanging(value);
                this._PolicyRuleName = value;
                this.OnPolicyRuleNameChanged();
                this.OnPropertyChanged("PolicyRuleName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PolicyRuleName;
        partial void OnPolicyRuleNameChanging(string value);
        partial void OnPolicyRuleNameChanged();
        /// <summary>
        /// There are no comments for Property ValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ValidFrom
        {
            get
            {
                return this._ValidFrom;
            }
            set
            {
                this.OnValidFromChanging(value);
                this._ValidFrom = value;
                this.OnValidFromChanged();
                this.OnPropertyChanged("ValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidFrom;
        partial void OnValidFromChanging(global::System.DateTimeOffset value);
        partial void OnValidFromChanged();
        /// <summary>
        /// There are no comments for Property IncludeParentRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IncludeParentRule
        {
            get
            {
                return this._IncludeParentRule;
            }
            set
            {
                this.OnIncludeParentRuleChanging(value);
                this._IncludeParentRule = value;
                this.OnIncludeParentRuleChanged();
                this.OnPropertyChanged("IncludeParentRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IncludeParentRule;
        partial void OnIncludeParentRuleChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIncludeParentRuleChanged();
        /// <summary>
        /// There are no comments for Property Action in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvPolicyViolationLevel> Action
        {
            get
            {
                return this._Action;
            }
            set
            {
                this.OnActionChanging(value);
                this._Action = value;
                this.OnActionChanged();
                this.OnPropertyChanged("Action");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvPolicyViolationLevel> _Action;
        partial void OnActionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvPolicyViolationLevel> value);
        partial void OnActionChanged();
        /// <summary>
        /// There are no comments for Property ValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ValidTo
        {
            get
            {
                return this._ValidTo;
            }
            set
            {
                this.OnValidToChanging(value);
                this._ValidTo = value;
                this.OnValidToChanged();
                this.OnPropertyChanged("ValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidTo;
        partial void OnValidToChanging(global::System.DateTimeOffset value);
        partial void OnValidToChanged();
        /// <summary>
        /// There are no comments for Property ExpressionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Guid ExpressionId
        {
            get
            {
                return this._ExpressionId;
            }
            set
            {
                this.OnExpressionIdChanging(value);
                this._ExpressionId = value;
                this.OnExpressionIdChanged();
                this.OnPropertyChanged("ExpressionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _ExpressionId;
        partial void OnExpressionIdChanging(global::System.Guid value);
        partial void OnExpressionIdChanged();
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
