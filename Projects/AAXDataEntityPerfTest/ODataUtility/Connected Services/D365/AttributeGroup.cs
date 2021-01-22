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
        /// There are no comments for AttributeGroupSingle in the schema.
        /// </summary>
    public partial class AttributeGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AttributeGroup>
    {
        /// <summary>
        /// Initialize a new AttributeGroupSingle object.
        /// </summary>
        public AttributeGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AttributeGroupSingle object.
        /// </summary>
        public AttributeGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AttributeGroupSingle object.
        /// </summary>
        public AttributeGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AttributeGroup> query)
            : base(query) {}

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
    }
        /// <summary>
        /// There are no comments for AttributeGroup in the schema.
        /// </summary>
    /// <KeyProperties>
    /// GroupName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("GroupName")]
    [global::Microsoft.OData.Client.EntitySet("AttributeGroups")]
    public partial class AttributeGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AttributeGroup object.
        /// </summary>
        /// <param name="groupName">Initial value of GroupName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AttributeGroup CreateAttributeGroup(string groupName)
        {
            AttributeGroup attributeGroup = new AttributeGroup();
            attributeGroup.GroupName = groupName;
            return attributeGroup;
        }
        /// <summary>
        /// There are no comments for Property GroupName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string GroupName
        {
            get
            {
                return this._GroupName;
            }
            set
            {
                this.OnGroupNameChanging(value);
                this._GroupName = value;
                this.OnGroupNameChanged();
                this.OnPropertyChanged("GroupName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupName;
        partial void OnGroupNameChanging(string value);
        partial void OnGroupNameChanged();
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
