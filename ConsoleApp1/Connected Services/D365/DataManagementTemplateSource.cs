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
    /// There are no comments for DataManagementTemplateSourceSingle in the schema.
    /// </summary>
    public partial class DataManagementTemplateSourceSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DataManagementTemplateSource>
    {
        /// <summary>
        /// Initialize a new DataManagementTemplateSourceSingle object.
        /// </summary>
        public DataManagementTemplateSourceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DataManagementTemplateSourceSingle object.
        /// </summary>
        public DataManagementTemplateSourceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DataManagementTemplateSourceSingle object.
        /// </summary>
        public DataManagementTemplateSourceSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DataManagementTemplateSource> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DefinitionGroupTemplate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSingle DefinitionGroupTemplate
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DefinitionGroupTemplate == null))
                {
                    this._DefinitionGroupTemplate = new global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSingle(this.Context, GetPath("DefinitionGroupTemplate"));
                }
                return this._DefinitionGroupTemplate;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSingle _DefinitionGroupTemplate;
        /// <summary>
        /// There are no comments for Dependencies in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSourceDependency> Dependencies
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Dependencies == null))
                {
                    this._Dependencies = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSourceDependency>(GetPath("Dependencies"));
                }
                return this._Dependencies;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSourceDependency> _Dependencies;
    }
    /// <summary>
    /// There are no comments for DataManagementTemplateSource in the schema.
    /// </summary>
    /// <KeyProperties>
    /// TemplateId
    /// SourceEntity
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("TemplateId", "SourceEntity")]
    [global::Microsoft.OData.Client.EntitySet("DataManagementTemplateSources")]
    public partial class DataManagementTemplateSource : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DataManagementTemplateSource object.
        /// </summary>
        /// <param name="templateId">Initial value of TemplateId.</param>
        /// <param name="sourceEntity">Initial value of SourceEntity.</param>
        /// <param name="definitionGroupTemplate">Initial value of DefinitionGroupTemplate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DataManagementTemplateSource CreateDataManagementTemplateSource(string templateId, string sourceEntity, global::Microsoft.Dynamics.DataEntities.DataManagementTemplate definitionGroupTemplate)
        {
            DataManagementTemplateSource dataManagementTemplateSource = new DataManagementTemplateSource();
            dataManagementTemplateSource.TemplateId = templateId;
            dataManagementTemplateSource.SourceEntity = sourceEntity;
            if ((definitionGroupTemplate == null))
            {
                throw new global::System.ArgumentNullException("definitionGroupTemplate");
            }
            dataManagementTemplateSource.DefinitionGroupTemplate = definitionGroupTemplate;
            return dataManagementTemplateSource;
        }
        /// <summary>
        /// There are no comments for Property TemplateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TemplateId
        {
            get
            {
                return this._TemplateId;
            }
            set
            {
                this.OnTemplateIdChanging(value);
                this._TemplateId = value;
                this.OnTemplateIdChanged();
                this.OnPropertyChanged("TemplateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TemplateId;
        partial void OnTemplateIdChanging(string value);
        partial void OnTemplateIdChanged();
        /// <summary>
        /// There are no comments for Property SourceEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SourceEntity
        {
            get
            {
                return this._SourceEntity;
            }
            set
            {
                this.OnSourceEntityChanging(value);
                this._SourceEntity = value;
                this.OnSourceEntityChanged();
                this.OnPropertyChanged("SourceEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SourceEntity;
        partial void OnSourceEntityChanging(string value);
        partial void OnSourceEntityChanged();
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
        /// There are no comments for Property DefinitionGroupTemplate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DataManagementTemplate DefinitionGroupTemplate
        {
            get
            {
                return this._DefinitionGroupTemplate;
            }
            set
            {
                this.OnDefinitionGroupTemplateChanging(value);
                this._DefinitionGroupTemplate = value;
                this.OnDefinitionGroupTemplateChanged();
                this.OnPropertyChanged("DefinitionGroupTemplate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DataManagementTemplate _DefinitionGroupTemplate;
        partial void OnDefinitionGroupTemplateChanging(global::Microsoft.Dynamics.DataEntities.DataManagementTemplate value);
        partial void OnDefinitionGroupTemplateChanged();
        /// <summary>
        /// There are no comments for Property Dependencies in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSourceDependency> Dependencies
        {
            get
            {
                return this._Dependencies;
            }
            set
            {
                this.OnDependenciesChanging(value);
                this._Dependencies = value;
                this.OnDependenciesChanged();
                this.OnPropertyChanged("Dependencies");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSourceDependency> _Dependencies = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSourceDependency>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnDependenciesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSourceDependency> value);
        partial void OnDependenciesChanged();
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
