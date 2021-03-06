﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 2/4/2021 7:24:30 AM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for BudgetControlGroupOverBudgetPermissionSingle in the schema.
        /// </summary>
    public partial class BudgetControlGroupOverBudgetPermissionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetControlGroupOverBudgetPermission>
    {
        /// <summary>
        /// Initialize a new BudgetControlGroupOverBudgetPermissionSingle object.
        /// </summary>
        public BudgetControlGroupOverBudgetPermissionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BudgetControlGroupOverBudgetPermissionSingle object.
        /// </summary>
        public BudgetControlGroupOverBudgetPermissionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BudgetControlGroupOverBudgetPermissionSingle object.
        /// </summary>
        public BudgetControlGroupOverBudgetPermissionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetControlGroupOverBudgetPermission> query)
            : base(query) {}

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
        /// <summary>
        /// There are no comments for BudgetControlGroups in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetControlGroupSingle BudgetControlGroups
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetControlGroups == null))
                {
                    this._BudgetControlGroups = new global::Microsoft.Dynamics.DataEntities.BudgetControlGroupSingle(this.Context, GetPath("BudgetControlGroups"));
                }
                return this._BudgetControlGroups;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetControlGroupSingle _BudgetControlGroups;
    }
        /// <summary>
        /// There are no comments for BudgetControlGroupOverBudgetPermission in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// LegalEntityId
    /// Status
    /// BudgetGroupName
    /// UserGroupId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LegalEntityId", "Status", "BudgetGroupName", "UserGroupId")]
    [global::Microsoft.OData.Client.EntitySet("BudgetControlGroupOverBudgetPermissions")]
    public partial class BudgetControlGroupOverBudgetPermission : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BudgetControlGroupOverBudgetPermission object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        /// <param name="budgetGroupName">Initial value of BudgetGroupName.</param>
        /// <param name="userGroupId">Initial value of UserGroupId.</param>
        /// <param name="systemUserGroups">Initial value of SystemUserGroups.</param>
        /// <param name="budgetControlGroups">Initial value of BudgetControlGroups.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BudgetControlGroupOverBudgetPermission CreateBudgetControlGroupOverBudgetPermission(string dataAreaId, 
                    string legalEntityId, 
                    string budgetGroupName, 
                    string userGroupId, 
                    global::Microsoft.Dynamics.DataEntities.UserGroup systemUserGroups, 
                    global::Microsoft.Dynamics.DataEntities.BudgetControlGroup budgetControlGroups)
        {
            BudgetControlGroupOverBudgetPermission budgetControlGroupOverBudgetPermission = new BudgetControlGroupOverBudgetPermission();
            budgetControlGroupOverBudgetPermission.dataAreaId = dataAreaId;
            budgetControlGroupOverBudgetPermission.LegalEntityId = legalEntityId;
            budgetControlGroupOverBudgetPermission.BudgetGroupName = budgetGroupName;
            budgetControlGroupOverBudgetPermission.UserGroupId = userGroupId;
            if ((systemUserGroups == null))
            {
                throw new global::System.ArgumentNullException("systemUserGroups");
            }
            budgetControlGroupOverBudgetPermission.SystemUserGroups = systemUserGroups;
            if ((budgetControlGroups == null))
            {
                throw new global::System.ArgumentNullException("budgetControlGroups");
            }
            budgetControlGroupOverBudgetPermission.BudgetControlGroups = budgetControlGroups;
            return budgetControlGroupOverBudgetPermission;
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
        /// There are no comments for Property BudgetGroupName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BudgetGroupName
        {
            get
            {
                return this._BudgetGroupName;
            }
            set
            {
                this.OnBudgetGroupNameChanging(value);
                this._BudgetGroupName = value;
                this.OnBudgetGroupNameChanged();
                this.OnPropertyChanged("BudgetGroupName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BudgetGroupName;
        partial void OnBudgetGroupNameChanging(string value);
        partial void OnBudgetGroupNameChanged();
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
        /// There are no comments for Property BudgetControlGroups in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BudgetControlGroup BudgetControlGroups
        {
            get
            {
                return this._BudgetControlGroups;
            }
            set
            {
                this.OnBudgetControlGroupsChanging(value);
                this._BudgetControlGroups = value;
                this.OnBudgetControlGroupsChanged();
                this.OnPropertyChanged("BudgetControlGroups");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BudgetControlGroup _BudgetControlGroups;
        partial void OnBudgetControlGroupsChanging(global::Microsoft.Dynamics.DataEntities.BudgetControlGroup value);
        partial void OnBudgetControlGroupsChanged();
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
