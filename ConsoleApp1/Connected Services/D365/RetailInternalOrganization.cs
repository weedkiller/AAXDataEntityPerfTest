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
    /// There are no comments for RetailInternalOrganizationSingle in the schema.
    /// </summary>
    public partial class RetailInternalOrganizationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailInternalOrganization>
    {
        /// <summary>
        /// Initialize a new RetailInternalOrganizationSingle object.
        /// </summary>
        public RetailInternalOrganizationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailInternalOrganizationSingle object.
        /// </summary>
        public RetailInternalOrganizationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailInternalOrganizationSingle object.
        /// </summary>
        public RetailInternalOrganizationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailInternalOrganization> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailCatalogInternalOrganizationProductAttributeValue2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue2> RetailCatalogInternalOrganizationProductAttributeValue2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailCatalogInternalOrganizationProductAttributeValue2 == null))
                {
                    this._RetailCatalogInternalOrganizationProductAttributeValue2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue2>(GetPath("RetailCatalogInternalOrganizationProductAttributeValue2"));
                }
                return this._RetailCatalogInternalOrganizationProductAttributeValue2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue2> _RetailCatalogInternalOrganizationProductAttributeValue2;
        /// <summary>
        /// There are no comments for RetailInternalOrganizationAttributeGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationAttributeGroup> RetailInternalOrganizationAttributeGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailInternalOrganizationAttributeGroup == null))
                {
                    this._RetailInternalOrganizationAttributeGroup = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationAttributeGroup>(GetPath("RetailInternalOrganizationAttributeGroup"));
                }
                return this._RetailInternalOrganizationAttributeGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationAttributeGroup> _RetailInternalOrganizationAttributeGroup;
        /// <summary>
        /// There are no comments for RetailInternalOrganizationProductAttributeValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationProductAttributeValue> RetailInternalOrganizationProductAttributeValue
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailInternalOrganizationProductAttributeValue == null))
                {
                    this._RetailInternalOrganizationProductAttributeValue = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationProductAttributeValue>(GetPath("RetailInternalOrganizationProductAttributeValue"));
                }
                return this._RetailInternalOrganizationProductAttributeValue;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationProductAttributeValue> _RetailInternalOrganizationProductAttributeValue;
        /// <summary>
        /// There are no comments for RetailInternalOrganizationProductAttributeValue2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationProductAttributeValue2> RetailInternalOrganizationProductAttributeValue2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailInternalOrganizationProductAttributeValue2 == null))
                {
                    this._RetailInternalOrganizationProductAttributeValue2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationProductAttributeValue2>(GetPath("RetailInternalOrganizationProductAttributeValue2"));
                }
                return this._RetailInternalOrganizationProductAttributeValue2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationProductAttributeValue2> _RetailInternalOrganizationProductAttributeValue2;
    }
    /// <summary>
    /// There are no comments for RetailInternalOrganization in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PartyNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PartyNumber")]
    [global::Microsoft.OData.Client.EntitySet("RetailInternalOrganizations")]
    public partial class RetailInternalOrganization : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailInternalOrganization object.
        /// </summary>
        /// <param name="partyNumber">Initial value of PartyNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailInternalOrganization CreateRetailInternalOrganization(string partyNumber)
        {
            RetailInternalOrganization retailInternalOrganization = new RetailInternalOrganization();
            retailInternalOrganization.PartyNumber = partyNumber;
            return retailInternalOrganization;
        }
        /// <summary>
        /// There are no comments for Property PartyNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PartyNumber
        {
            get
            {
                return this._PartyNumber;
            }
            set
            {
                this.OnPartyNumberChanging(value);
                this._PartyNumber = value;
                this.OnPartyNumberChanged();
                this.OnPropertyChanged("PartyNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PartyNumber;
        partial void OnPartyNumberChanging(string value);
        partial void OnPartyNumberChanged();
        /// <summary>
        /// There are no comments for Property InheritEnabled in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> InheritEnabled
        {
            get
            {
                return this._InheritEnabled;
            }
            set
            {
                this.OnInheritEnabledChanging(value);
                this._InheritEnabled = value;
                this.OnInheritEnabledChanged();
                this.OnPropertyChanged("InheritEnabled");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _InheritEnabled;
        partial void OnInheritEnabledChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnInheritEnabledChanged();
        /// <summary>
        /// There are no comments for Property OrganizationName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OrganizationName
        {
            get
            {
                return this._OrganizationName;
            }
            set
            {
                this.OnOrganizationNameChanging(value);
                this._OrganizationName = value;
                this.OnOrganizationNameChanged();
                this.OnPropertyChanged("OrganizationName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OrganizationName;
        partial void OnOrganizationNameChanging(string value);
        partial void OnOrganizationNameChanged();
        /// <summary>
        /// There are no comments for Property CategoryHierarchyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CategoryHierarchyName
        {
            get
            {
                return this._CategoryHierarchyName;
            }
            set
            {
                this.OnCategoryHierarchyNameChanging(value);
                this._CategoryHierarchyName = value;
                this.OnCategoryHierarchyNameChanged();
                this.OnPropertyChanged("CategoryHierarchyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CategoryHierarchyName;
        partial void OnCategoryHierarchyNameChanging(string value);
        partial void OnCategoryHierarchyNameChanged();
        /// <summary>
        /// There are no comments for Property RetailCatalogInternalOrganizationProductAttributeValue2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue2> RetailCatalogInternalOrganizationProductAttributeValue2
        {
            get
            {
                return this._RetailCatalogInternalOrganizationProductAttributeValue2;
            }
            set
            {
                this.OnRetailCatalogInternalOrganizationProductAttributeValue2Changing(value);
                this._RetailCatalogInternalOrganizationProductAttributeValue2 = value;
                this.OnRetailCatalogInternalOrganizationProductAttributeValue2Changed();
                this.OnPropertyChanged("RetailCatalogInternalOrganizationProductAttributeValue2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue2> _RetailCatalogInternalOrganizationProductAttributeValue2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailCatalogInternalOrganizationProductAttributeValue2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCatalogInternalOrganizationProductAttributeValue2> value);
        partial void OnRetailCatalogInternalOrganizationProductAttributeValue2Changed();
        /// <summary>
        /// There are no comments for Property RetailInternalOrganizationAttributeGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationAttributeGroup> RetailInternalOrganizationAttributeGroup
        {
            get
            {
                return this._RetailInternalOrganizationAttributeGroup;
            }
            set
            {
                this.OnRetailInternalOrganizationAttributeGroupChanging(value);
                this._RetailInternalOrganizationAttributeGroup = value;
                this.OnRetailInternalOrganizationAttributeGroupChanged();
                this.OnPropertyChanged("RetailInternalOrganizationAttributeGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationAttributeGroup> _RetailInternalOrganizationAttributeGroup = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationAttributeGroup>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailInternalOrganizationAttributeGroupChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationAttributeGroup> value);
        partial void OnRetailInternalOrganizationAttributeGroupChanged();
        /// <summary>
        /// There are no comments for Property RetailInternalOrganizationProductAttributeValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationProductAttributeValue> RetailInternalOrganizationProductAttributeValue
        {
            get
            {
                return this._RetailInternalOrganizationProductAttributeValue;
            }
            set
            {
                this.OnRetailInternalOrganizationProductAttributeValueChanging(value);
                this._RetailInternalOrganizationProductAttributeValue = value;
                this.OnRetailInternalOrganizationProductAttributeValueChanged();
                this.OnPropertyChanged("RetailInternalOrganizationProductAttributeValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationProductAttributeValue> _RetailInternalOrganizationProductAttributeValue = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationProductAttributeValue>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailInternalOrganizationProductAttributeValueChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationProductAttributeValue> value);
        partial void OnRetailInternalOrganizationProductAttributeValueChanged();
        /// <summary>
        /// There are no comments for Property RetailInternalOrganizationProductAttributeValue2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationProductAttributeValue2> RetailInternalOrganizationProductAttributeValue2
        {
            get
            {
                return this._RetailInternalOrganizationProductAttributeValue2;
            }
            set
            {
                this.OnRetailInternalOrganizationProductAttributeValue2Changing(value);
                this._RetailInternalOrganizationProductAttributeValue2 = value;
                this.OnRetailInternalOrganizationProductAttributeValue2Changed();
                this.OnPropertyChanged("RetailInternalOrganizationProductAttributeValue2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationProductAttributeValue2> _RetailInternalOrganizationProductAttributeValue2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationProductAttributeValue2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailInternalOrganizationProductAttributeValue2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailInternalOrganizationProductAttributeValue2> value);
        partial void OnRetailInternalOrganizationProductAttributeValue2Changed();
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
