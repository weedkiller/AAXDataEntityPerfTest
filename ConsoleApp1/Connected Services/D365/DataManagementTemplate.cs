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
    /// There are no comments for DataManagementTemplateSingle in the schema.
    /// </summary>
    public partial class DataManagementTemplateSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DataManagementTemplate>
    {
        /// <summary>
        /// Initialize a new DataManagementTemplateSingle object.
        /// </summary>
        public DataManagementTemplateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DataManagementTemplateSingle object.
        /// </summary>
        public DataManagementTemplateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DataManagementTemplateSingle object.
        /// </summary>
        public DataManagementTemplateSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DataManagementTemplate> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Details in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DataManagementTemplateDetail> Details
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Details == null))
                {
                    this._Details = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.DataManagementTemplateDetail>(GetPath("Details"));
                }
                return this._Details;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DataManagementTemplateDetail> _Details;
        /// <summary>
        /// There are no comments for Sources in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSource> Sources
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Sources == null))
                {
                    this._Sources = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSource>(GetPath("Sources"));
                }
                return this._Sources;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSource> _Sources;
    }
    /// <summary>
    /// There are no comments for DataManagementTemplate in the schema.
    /// </summary>
    /// <KeyProperties>
    /// TemplateId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("TemplateId")]
    [global::Microsoft.OData.Client.EntitySet("DataManagementTemplates")]
    public partial class DataManagementTemplate : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DataManagementTemplate object.
        /// </summary>
        /// <param name="templateId">Initial value of TemplateId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DataManagementTemplate CreateDataManagementTemplate(string templateId)
        {
            DataManagementTemplate dataManagementTemplate = new DataManagementTemplate();
            dataManagementTemplate.TemplateId = templateId;
            return dataManagementTemplate;
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
        /// There are no comments for Property Details in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DataManagementTemplateDetail> Details
        {
            get
            {
                return this._Details;
            }
            set
            {
                this.OnDetailsChanging(value);
                this._Details = value;
                this.OnDetailsChanged();
                this.OnPropertyChanged("Details");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DataManagementTemplateDetail> _Details = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DataManagementTemplateDetail>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnDetailsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DataManagementTemplateDetail> value);
        partial void OnDetailsChanged();
        /// <summary>
        /// There are no comments for Property Sources in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSource> Sources
        {
            get
            {
                return this._Sources;
            }
            set
            {
                this.OnSourcesChanging(value);
                this._Sources = value;
                this.OnSourcesChanged();
                this.OnPropertyChanged("Sources");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSource> _Sources = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSource>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnSourcesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DataManagementTemplateSource> value);
        partial void OnSourcesChanged();
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
