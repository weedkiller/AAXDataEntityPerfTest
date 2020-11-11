﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 11/8/2020 8:07:52 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for JobTemplateEducationDisciplineSingle in the schema.
        /// </summary>
    public partial class JobTemplateEducationDisciplineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<JobTemplateEducationDiscipline>
    {
        /// <summary>
        /// Initialize a new JobTemplateEducationDisciplineSingle object.
        /// </summary>
        public JobTemplateEducationDisciplineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new JobTemplateEducationDisciplineSingle object.
        /// </summary>
        public JobTemplateEducationDisciplineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new JobTemplateEducationDisciplineSingle object.
        /// </summary>
        public JobTemplateEducationDisciplineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<JobTemplateEducationDiscipline> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EducationDiscipline in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EducationDisciplineSingle EducationDiscipline
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EducationDiscipline == null))
                {
                    this._EducationDiscipline = new global::Microsoft.Dynamics.DataEntities.EducationDisciplineSingle(this.Context, GetPath("EducationDiscipline"));
                }
                return this._EducationDiscipline;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EducationDisciplineSingle _EducationDiscipline;
        /// <summary>
        /// There are no comments for JobTemplate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.JobTemplateSingle JobTemplate
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JobTemplate == null))
                {
                    this._JobTemplate = new global::Microsoft.Dynamics.DataEntities.JobTemplateSingle(this.Context, GetPath("JobTemplate"));
                }
                return this._JobTemplate;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JobTemplateSingle _JobTemplate;
    }
        /// <summary>
        /// There are no comments for JobTemplateEducationDiscipline in the schema.
        /// </summary>
    /// <KeyProperties>
    /// JobTemplateId
    /// EducationId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("JobTemplateId", "EducationId")]
    [global::Microsoft.OData.Client.EntitySet("JobTemplateEducationDisciplines")]
    public partial class JobTemplateEducationDiscipline : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new JobTemplateEducationDiscipline object.
        /// </summary>
        /// <param name="jobTemplateId">Initial value of JobTemplateId.</param>
        /// <param name="educationId">Initial value of EducationId.</param>
        /// <param name="educationDiscipline">Initial value of EducationDiscipline.</param>
        /// <param name="jobTemplate">Initial value of JobTemplate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static JobTemplateEducationDiscipline CreateJobTemplateEducationDiscipline(string jobTemplateId, string educationId, global::Microsoft.Dynamics.DataEntities.EducationDiscipline educationDiscipline, global::Microsoft.Dynamics.DataEntities.JobTemplate jobTemplate)
        {
            JobTemplateEducationDiscipline jobTemplateEducationDiscipline = new JobTemplateEducationDiscipline();
            jobTemplateEducationDiscipline.JobTemplateId = jobTemplateId;
            jobTemplateEducationDiscipline.EducationId = educationId;
            if ((educationDiscipline == null))
            {
                throw new global::System.ArgumentNullException("educationDiscipline");
            }
            jobTemplateEducationDiscipline.EducationDiscipline = educationDiscipline;
            if ((jobTemplate == null))
            {
                throw new global::System.ArgumentNullException("jobTemplate");
            }
            jobTemplateEducationDiscipline.JobTemplate = jobTemplate;
            return jobTemplateEducationDiscipline;
        }
        /// <summary>
        /// There are no comments for Property JobTemplateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JobTemplateId
        {
            get
            {
                return this._JobTemplateId;
            }
            set
            {
                this.OnJobTemplateIdChanging(value);
                this._JobTemplateId = value;
                this.OnJobTemplateIdChanged();
                this.OnPropertyChanged("JobTemplateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobTemplateId;
        partial void OnJobTemplateIdChanging(string value);
        partial void OnJobTemplateIdChanged();
        /// <summary>
        /// There are no comments for Property EducationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EducationId
        {
            get
            {
                return this._EducationId;
            }
            set
            {
                this.OnEducationIdChanging(value);
                this._EducationId = value;
                this.OnEducationIdChanged();
                this.OnPropertyChanged("EducationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EducationId;
        partial void OnEducationIdChanging(string value);
        partial void OnEducationIdChanged();
        /// <summary>
        /// There are no comments for Property Importance in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmSkillImportance> Importance
        {
            get
            {
                return this._Importance;
            }
            set
            {
                this.OnImportanceChanging(value);
                this._Importance = value;
                this.OnImportanceChanged();
                this.OnPropertyChanged("Importance");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmSkillImportance> _Importance;
        partial void OnImportanceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmSkillImportance> value);
        partial void OnImportanceChanged();
        /// <summary>
        /// There are no comments for Property EducationDiscipline in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EducationDiscipline EducationDiscipline
        {
            get
            {
                return this._EducationDiscipline;
            }
            set
            {
                this.OnEducationDisciplineChanging(value);
                this._EducationDiscipline = value;
                this.OnEducationDisciplineChanged();
                this.OnPropertyChanged("EducationDiscipline");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EducationDiscipline _EducationDiscipline;
        partial void OnEducationDisciplineChanging(global::Microsoft.Dynamics.DataEntities.EducationDiscipline value);
        partial void OnEducationDisciplineChanged();
        /// <summary>
        /// There are no comments for Property JobTemplate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.JobTemplate JobTemplate
        {
            get
            {
                return this._JobTemplate;
            }
            set
            {
                this.OnJobTemplateChanging(value);
                this._JobTemplate = value;
                this.OnJobTemplateChanged();
                this.OnPropertyChanged("JobTemplate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JobTemplate _JobTemplate;
        partial void OnJobTemplateChanging(global::Microsoft.Dynamics.DataEntities.JobTemplate value);
        partial void OnJobTemplateChanged();
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