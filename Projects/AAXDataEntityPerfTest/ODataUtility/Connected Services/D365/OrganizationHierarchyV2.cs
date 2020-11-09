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
    /// There are no comments for OrganizationHierarchyV2Single in the schema.
    /// </summary>
    public partial class OrganizationHierarchyV2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<OrganizationHierarchyV2>
    {
        /// <summary>
        /// Initialize a new OrganizationHierarchyV2Single object.
        /// </summary>
        public OrganizationHierarchyV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new OrganizationHierarchyV2Single object.
        /// </summary>
        public OrganizationHierarchyV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new OrganizationHierarchyV2Single object.
        /// </summary>
        public OrganizationHierarchyV2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<OrganizationHierarchyV2> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for OrganizationHierarchyV2 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// HierarchyType
    /// ChildOrganizationPartyNumber
    /// validFrom
    /// validTo
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("HierarchyType", "ChildOrganizationPartyNumber", "validFrom", "validTo")]
    [global::Microsoft.OData.Client.EntitySet("OrganizationHierarchiesV2")]
    public partial class OrganizationHierarchyV2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new OrganizationHierarchyV2 object.
        /// </summary>
        /// <param name="hierarchyType">Initial value of HierarchyType.</param>
        /// <param name="childOrganizationPartyNumber">Initial value of ChildOrganizationPartyNumber.</param>
        /// <param name="validFrom">Initial value of validFrom.</param>
        /// <param name="validTo">Initial value of validTo.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static OrganizationHierarchyV2 CreateOrganizationHierarchyV2(string hierarchyType, string childOrganizationPartyNumber, global::System.DateTimeOffset validFrom, global::System.DateTimeOffset validTo)
        {
            OrganizationHierarchyV2 organizationHierarchyV2 = new OrganizationHierarchyV2();
            organizationHierarchyV2.HierarchyType = hierarchyType;
            organizationHierarchyV2.ChildOrganizationPartyNumber = childOrganizationPartyNumber;
            organizationHierarchyV2.validFrom = validFrom;
            organizationHierarchyV2.validTo = validTo;
            return organizationHierarchyV2;
        }
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
        /// There are no comments for Property ChildOrganizationPartyNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ChildOrganizationPartyNumber
        {
            get
            {
                return this._ChildOrganizationPartyNumber;
            }
            set
            {
                this.OnChildOrganizationPartyNumberChanging(value);
                this._ChildOrganizationPartyNumber = value;
                this.OnChildOrganizationPartyNumberChanged();
                this.OnPropertyChanged("ChildOrganizationPartyNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ChildOrganizationPartyNumber;
        partial void OnChildOrganizationPartyNumberChanging(string value);
        partial void OnChildOrganizationPartyNumberChanged();
        /// <summary>
        /// There are no comments for Property validFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset validFrom
        {
            get
            {
                return this._validFrom;
            }
            set
            {
                this.OnvalidFromChanging(value);
                this._validFrom = value;
                this.OnvalidFromChanged();
                this.OnPropertyChanged("validFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _validFrom;
        partial void OnvalidFromChanging(global::System.DateTimeOffset value);
        partial void OnvalidFromChanged();
        /// <summary>
        /// There are no comments for Property validTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset validTo
        {
            get
            {
                return this._validTo;
            }
            set
            {
                this.OnvalidToChanging(value);
                this._validTo = value;
                this.OnvalidToChanged();
                this.OnPropertyChanged("validTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _validTo;
        partial void OnvalidToChanging(global::System.DateTimeOffset value);
        partial void OnvalidToChanged();
        /// <summary>
        /// There are no comments for Property RelationshipType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RelationshipType
        {
            get
            {
                return this._RelationshipType;
            }
            set
            {
                this.OnRelationshipTypeChanging(value);
                this._RelationshipType = value;
                this.OnRelationshipTypeChanged();
                this.OnPropertyChanged("RelationshipType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RelationshipType;
        partial void OnRelationshipTypeChanging(string value);
        partial void OnRelationshipTypeChanged();
        /// <summary>
        /// There are no comments for Property ParentOrganizationPartyNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ParentOrganizationPartyNumber
        {
            get
            {
                return this._ParentOrganizationPartyNumber;
            }
            set
            {
                this.OnParentOrganizationPartyNumberChanging(value);
                this._ParentOrganizationPartyNumber = value;
                this.OnParentOrganizationPartyNumberChanged();
                this.OnPropertyChanged("ParentOrganizationPartyNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ParentOrganizationPartyNumber;
        partial void OnParentOrganizationPartyNumberChanging(string value);
        partial void OnParentOrganizationPartyNumberChanged();
        /// <summary>
        /// There are no comments for Property ChildOrganizationName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ChildOrganizationName
        {
            get
            {
                return this._ChildOrganizationName;
            }
            set
            {
                this.OnChildOrganizationNameChanging(value);
                this._ChildOrganizationName = value;
                this.OnChildOrganizationNameChanged();
                this.OnPropertyChanged("ChildOrganizationName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ChildOrganizationName;
        partial void OnChildOrganizationNameChanging(string value);
        partial void OnChildOrganizationNameChanged();
        /// <summary>
        /// There are no comments for Property ParentOrganizationName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ParentOrganizationName
        {
            get
            {
                return this._ParentOrganizationName;
            }
            set
            {
                this.OnParentOrganizationNameChanging(value);
                this._ParentOrganizationName = value;
                this.OnParentOrganizationNameChanged();
                this.OnPropertyChanged("ParentOrganizationName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ParentOrganizationName;
        partial void OnParentOrganizationNameChanging(string value);
        partial void OnParentOrganizationNameChanged();
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
