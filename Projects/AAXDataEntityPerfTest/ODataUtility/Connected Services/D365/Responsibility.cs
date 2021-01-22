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
        /// There are no comments for ResponsibilitySingle in the schema.
        /// </summary>
    public partial class ResponsibilitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Responsibility>
    {
        /// <summary>
        /// Initialize a new ResponsibilitySingle object.
        /// </summary>
        public ResponsibilitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ResponsibilitySingle object.
        /// </summary>
        public ResponsibilitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ResponsibilitySingle object.
        /// </summary>
        public ResponsibilitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Responsibility> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for JobTemplateResponsibilities in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateResponsibility> JobTemplateResponsibilities
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JobTemplateResponsibilities == null))
                {
                    this._JobTemplateResponsibilities = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateResponsibility>(GetPath("JobTemplateResponsibilities"));
                }
                return this._JobTemplateResponsibilities;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateResponsibility> _JobTemplateResponsibilities;
        /// <summary>
        /// There are no comments for JobResponsibilities in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobResponsibility> JobResponsibilities
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JobResponsibilities == null))
                {
                    this._JobResponsibilities = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.JobResponsibility>(GetPath("JobResponsibilities"));
                }
                return this._JobResponsibilities;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobResponsibility> _JobResponsibilities;
    }
        /// <summary>
        /// There are no comments for Responsibility in the schema.
        /// </summary>
    /// <KeyProperties>
    /// ResponsibilityId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ResponsibilityId")]
    [global::Microsoft.OData.Client.EntitySet("Responsibilities")]
    public partial class Responsibility : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Responsibility object.
        /// </summary>
        /// <param name="responsibilityId">Initial value of ResponsibilityId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Responsibility CreateResponsibility(string responsibilityId)
        {
            Responsibility responsibility = new Responsibility();
            responsibility.ResponsibilityId = responsibilityId;
            return responsibility;
        }
        /// <summary>
        /// There are no comments for Property ResponsibilityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ResponsibilityId
        {
            get
            {
                return this._ResponsibilityId;
            }
            set
            {
                this.OnResponsibilityIdChanging(value);
                this._ResponsibilityId = value;
                this.OnResponsibilityIdChanged();
                this.OnPropertyChanged("ResponsibilityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ResponsibilityId;
        partial void OnResponsibilityIdChanging(string value);
        partial void OnResponsibilityIdChanged();
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
        /// There are no comments for Property Note in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Note
        {
            get
            {
                return this._Note;
            }
            set
            {
                this.OnNoteChanging(value);
                this._Note = value;
                this.OnNoteChanged();
                this.OnPropertyChanged("Note");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Note;
        partial void OnNoteChanging(string value);
        partial void OnNoteChanged();
        /// <summary>
        /// There are no comments for Property JobTemplateResponsibilities in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateResponsibility> JobTemplateResponsibilities
        {
            get
            {
                return this._JobTemplateResponsibilities;
            }
            set
            {
                this.OnJobTemplateResponsibilitiesChanging(value);
                this._JobTemplateResponsibilities = value;
                this.OnJobTemplateResponsibilitiesChanged();
                this.OnPropertyChanged("JobTemplateResponsibilities");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateResponsibility> _JobTemplateResponsibilities = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateResponsibility>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnJobTemplateResponsibilitiesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateResponsibility> value);
        partial void OnJobTemplateResponsibilitiesChanged();
        /// <summary>
        /// There are no comments for Property JobResponsibilities in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobResponsibility> JobResponsibilities
        {
            get
            {
                return this._JobResponsibilities;
            }
            set
            {
                this.OnJobResponsibilitiesChanging(value);
                this._JobResponsibilities = value;
                this.OnJobResponsibilitiesChanged();
                this.OnPropertyChanged("JobResponsibilities");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobResponsibility> _JobResponsibilities = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobResponsibility>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnJobResponsibilitiesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobResponsibility> value);
        partial void OnJobResponsibilitiesChanged();
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
