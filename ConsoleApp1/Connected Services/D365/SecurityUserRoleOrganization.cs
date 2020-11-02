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
    /// There are no comments for SecurityUserRoleOrganizationSingle in the schema.
    /// </summary>
    public partial class SecurityUserRoleOrganizationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SecurityUserRoleOrganization>
    {
        /// <summary>
        /// Initialize a new SecurityUserRoleOrganizationSingle object.
        /// </summary>
        public SecurityUserRoleOrganizationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SecurityUserRoleOrganizationSingle object.
        /// </summary>
        public SecurityUserRoleOrganizationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SecurityUserRoleOrganizationSingle object.
        /// </summary>
        public SecurityUserRoleOrganizationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SecurityUserRoleOrganization> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for SecurityUserRoleOrganization in the schema.
    /// </summary>
    /// <KeyProperties>
    /// UserId
    /// SecurityRoleIdentifier
    /// OrganizationType
    /// OrganizationId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("UserId", "SecurityRoleIdentifier", "OrganizationType", "OrganizationId")]
    [global::Microsoft.OData.Client.EntitySet("SecurityUserRoleOrganizations")]
    public partial class SecurityUserRoleOrganization : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SecurityUserRoleOrganization object.
        /// </summary>
        /// <param name="userId">Initial value of UserId.</param>
        /// <param name="securityRoleIdentifier">Initial value of SecurityRoleIdentifier.</param>
        /// <param name="organizationId">Initial value of OrganizationId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SecurityUserRoleOrganization CreateSecurityUserRoleOrganization(string userId, string securityRoleIdentifier, string organizationId)
        {
            SecurityUserRoleOrganization securityUserRoleOrganization = new SecurityUserRoleOrganization();
            securityUserRoleOrganization.UserId = userId;
            securityUserRoleOrganization.SecurityRoleIdentifier = securityRoleIdentifier;
            securityUserRoleOrganization.OrganizationId = organizationId;
            return securityUserRoleOrganization;
        }
        /// <summary>
        /// There are no comments for Property UserId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string UserId
        {
            get
            {
                return this._UserId;
            }
            set
            {
                this.OnUserIdChanging(value);
                this._UserId = value;
                this.OnUserIdChanged();
                this.OnPropertyChanged("UserId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UserId;
        partial void OnUserIdChanging(string value);
        partial void OnUserIdChanged();
        /// <summary>
        /// There are no comments for Property SecurityRoleIdentifier in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SecurityRoleIdentifier
        {
            get
            {
                return this._SecurityRoleIdentifier;
            }
            set
            {
                this.OnSecurityRoleIdentifierChanging(value);
                this._SecurityRoleIdentifier = value;
                this.OnSecurityRoleIdentifierChanged();
                this.OnPropertyChanged("SecurityRoleIdentifier");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SecurityRoleIdentifier;
        partial void OnSecurityRoleIdentifierChanging(string value);
        partial void OnSecurityRoleIdentifierChanged();
        /// <summary>
        /// There are no comments for Property OrganizationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.OMInternalOrganizationType> OrganizationType
        {
            get
            {
                return this._OrganizationType;
            }
            set
            {
                this.OnOrganizationTypeChanging(value);
                this._OrganizationType = value;
                this.OnOrganizationTypeChanged();
                this.OnPropertyChanged("OrganizationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.OMInternalOrganizationType> _OrganizationType;
        partial void OnOrganizationTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.OMInternalOrganizationType> value);
        partial void OnOrganizationTypeChanged();
        /// <summary>
        /// There are no comments for Property OrganizationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OrganizationId
        {
            get
            {
                return this._OrganizationId;
            }
            set
            {
                this.OnOrganizationIdChanging(value);
                this._OrganizationId = value;
                this.OnOrganizationIdChanged();
                this.OnPropertyChanged("OrganizationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OrganizationId;
        partial void OnOrganizationIdChanging(string value);
        partial void OnOrganizationIdChanged();
        /// <summary>
        /// There are no comments for Property OperatingUnitType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.OMOperatingUnitType> OperatingUnitType
        {
            get
            {
                return this._OperatingUnitType;
            }
            set
            {
                this.OnOperatingUnitTypeChanging(value);
                this._OperatingUnitType = value;
                this.OnOperatingUnitTypeChanged();
                this.OnPropertyChanged("OperatingUnitType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.OMOperatingUnitType> _OperatingUnitType;
        partial void OnOperatingUnitTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.OMOperatingUnitType> value);
        partial void OnOperatingUnitTypeChanged();
        /// <summary>
        /// There are no comments for Property HierarchyType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string HierarchyType
        {
            get
            {
                return this._HierarchyType;
            }
            set
            {
                this.OnHierarchyTypeChanging(value);
                this._HierarchyType = value;
                this.OnHierarchyTypeChanged();
                this.OnPropertyChanged("HierarchyType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _HierarchyType;
        partial void OnHierarchyTypeChanging(string value);
        partial void OnHierarchyTypeChanged();
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
