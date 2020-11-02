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
    /// There are no comments for PolicyViolationsCacheSingle in the schema.
    /// </summary>
    public partial class PolicyViolationsCacheSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PolicyViolationsCache>
    {
        /// <summary>
        /// Initialize a new PolicyViolationsCacheSingle object.
        /// </summary>
        public PolicyViolationsCacheSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PolicyViolationsCacheSingle object.
        /// </summary>
        public PolicyViolationsCacheSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PolicyViolationsCacheSingle object.
        /// </summary>
        public PolicyViolationsCacheSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PolicyViolationsCache> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for PolicyViolationsCache in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ViolationsCacheId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ViolationsCacheId")]
    [global::Microsoft.OData.Client.EntitySet("PolicyViolationsCache")]
    public partial class PolicyViolationsCache : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PolicyViolationsCache object.
        /// </summary>
        /// <param name="violationsCacheId">Initial value of ViolationsCacheId.</param>
        /// <param name="policyRuleValidFrom">Initial value of PolicyRuleValidFrom.</param>
        /// <param name="saveDateTime">Initial value of SaveDateTime.</param>
        /// <param name="violationDate">Initial value of ViolationDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PolicyViolationsCache CreatePolicyViolationsCache(global::System.Guid violationsCacheId, global::System.DateTimeOffset policyRuleValidFrom, global::System.DateTimeOffset saveDateTime, global::System.DateTimeOffset violationDate)
        {
            PolicyViolationsCache policyViolationsCache = new PolicyViolationsCache();
            policyViolationsCache.ViolationsCacheId = violationsCacheId;
            policyViolationsCache.PolicyRuleValidFrom = policyRuleValidFrom;
            policyViolationsCache.SaveDateTime = saveDateTime;
            policyViolationsCache.ViolationDate = violationDate;
            return policyViolationsCache;
        }
        /// <summary>
        /// There are no comments for Property ViolationsCacheId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Guid ViolationsCacheId
        {
            get
            {
                return this._ViolationsCacheId;
            }
            set
            {
                this.OnViolationsCacheIdChanging(value);
                this._ViolationsCacheId = value;
                this.OnViolationsCacheIdChanged();
                this.OnPropertyChanged("ViolationsCacheId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _ViolationsCacheId;
        partial void OnViolationsCacheIdChanging(global::System.Guid value);
        partial void OnViolationsCacheIdChanged();
        /// <summary>
        /// There are no comments for Property LineId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LineId
        {
            get
            {
                return this._LineId;
            }
            set
            {
                this.OnLineIdChanging(value);
                this._LineId = value;
                this.OnLineIdChanged();
                this.OnPropertyChanged("LineId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LineId;
        partial void OnLineIdChanging(string value);
        partial void OnLineIdChanged();
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
        /// There are no comments for Property PolicyRuleValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset PolicyRuleValidFrom
        {
            get
            {
                return this._PolicyRuleValidFrom;
            }
            set
            {
                this.OnPolicyRuleValidFromChanging(value);
                this._PolicyRuleValidFrom = value;
                this.OnPolicyRuleValidFromChanged();
                this.OnPropertyChanged("PolicyRuleValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PolicyRuleValidFrom;
        partial void OnPolicyRuleValidFromChanging(global::System.DateTimeOffset value);
        partial void OnPolicyRuleValidFromChanged();
        /// <summary>
        /// There are no comments for Property SaveDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset SaveDateTime
        {
            get
            {
                return this._SaveDateTime;
            }
            set
            {
                this.OnSaveDateTimeChanging(value);
                this._SaveDateTime = value;
                this.OnSaveDateTimeChanged();
                this.OnPropertyChanged("SaveDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _SaveDateTime;
        partial void OnSaveDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnSaveDateTimeChanged();
        /// <summary>
        /// There are no comments for Property PolicyViolationLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvPolicyViolationLevel> PolicyViolationLevel
        {
            get
            {
                return this._PolicyViolationLevel;
            }
            set
            {
                this.OnPolicyViolationLevelChanging(value);
                this._PolicyViolationLevel = value;
                this.OnPolicyViolationLevelChanged();
                this.OnPropertyChanged("PolicyViolationLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvPolicyViolationLevel> _PolicyViolationLevel;
        partial void OnPolicyViolationLevelChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvPolicyViolationLevel> value);
        partial void OnPolicyViolationLevelChanged();
        /// <summary>
        /// There are no comments for Property HeaderLegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string HeaderLegalEntity
        {
            get
            {
                return this._HeaderLegalEntity;
            }
            set
            {
                this.OnHeaderLegalEntityChanging(value);
                this._HeaderLegalEntity = value;
                this.OnHeaderLegalEntityChanged();
                this.OnPropertyChanged("HeaderLegalEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _HeaderLegalEntity;
        partial void OnHeaderLegalEntityChanging(string value);
        partial void OnHeaderLegalEntityChanged();
        /// <summary>
        /// There are no comments for Property PersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PersonnelNumber
        {
            get
            {
                return this._PersonnelNumber;
            }
            set
            {
                this.OnPersonnelNumberChanging(value);
                this._PersonnelNumber = value;
                this.OnPersonnelNumberChanged();
                this.OnPropertyChanged("PersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonnelNumber;
        partial void OnPersonnelNumberChanging(string value);
        partial void OnPersonnelNumberChanged();
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
        /// There are no comments for Property ParentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ParentId
        {
            get
            {
                return this._ParentId;
            }
            set
            {
                this.OnParentIdChanging(value);
                this._ParentId = value;
                this.OnParentIdChanged();
                this.OnPropertyChanged("ParentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ParentId;
        partial void OnParentIdChanging(string value);
        partial void OnParentIdChanged();
        /// <summary>
        /// There are no comments for Property HeaderId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string HeaderId
        {
            get
            {
                return this._HeaderId;
            }
            set
            {
                this.OnHeaderIdChanging(value);
                this._HeaderId = value;
                this.OnHeaderIdChanged();
                this.OnPropertyChanged("HeaderId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _HeaderId;
        partial void OnHeaderIdChanging(string value);
        partial void OnHeaderIdChanged();
        /// <summary>
        /// There are no comments for Property ViolationDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ViolationDate
        {
            get
            {
                return this._ViolationDate;
            }
            set
            {
                this.OnViolationDateChanging(value);
                this._ViolationDate = value;
                this.OnViolationDateChanged();
                this.OnPropertyChanged("ViolationDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ViolationDate;
        partial void OnViolationDateChanging(global::System.DateTimeOffset value);
        partial void OnViolationDateChanged();
        /// <summary>
        /// There are no comments for Property PolicyRuleTypeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PolicyRuleTypeName
        {
            get
            {
                return this._PolicyRuleTypeName;
            }
            set
            {
                this.OnPolicyRuleTypeNameChanging(value);
                this._PolicyRuleTypeName = value;
                this.OnPolicyRuleTypeNameChanged();
                this.OnPropertyChanged("PolicyRuleTypeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PolicyRuleTypeName;
        partial void OnPolicyRuleTypeNameChanging(string value);
        partial void OnPolicyRuleTypeNameChanged();
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