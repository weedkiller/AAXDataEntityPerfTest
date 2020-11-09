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
        /// There are no comments for EducationDisciplineGroupSingle in the schema.
        /// </summary>
    public partial class EducationDisciplineGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EducationDisciplineGroup>
    {
        /// <summary>
        /// Initialize a new EducationDisciplineGroupSingle object.
        /// </summary>
        public EducationDisciplineGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EducationDisciplineGroupSingle object.
        /// </summary>
        public EducationDisciplineGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EducationDisciplineGroupSingle object.
        /// </summary>
        public EducationDisciplineGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EducationDisciplineGroup> query)
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
        /// There are no comments for EducationDisciplineCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EducationDisciplineCategorySingle EducationDisciplineCategory
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EducationDisciplineCategory == null))
                {
                    this._EducationDisciplineCategory = new global::Microsoft.Dynamics.DataEntities.EducationDisciplineCategorySingle(this.Context, GetPath("EducationDisciplineCategory"));
                }
                return this._EducationDisciplineCategory;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EducationDisciplineCategorySingle _EducationDisciplineCategory;
    }
        /// <summary>
        /// There are no comments for EducationDisciplineGroup in the schema.
        /// </summary>
    /// <KeyProperties>
    /// EducationId
    /// EducationDisciplineCategoryId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("EducationId", "EducationDisciplineCategoryId")]
    [global::Microsoft.OData.Client.EntitySet("EducationDisciplineGroups")]
    public partial class EducationDisciplineGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EducationDisciplineGroup object.
        /// </summary>
        /// <param name="educationId">Initial value of EducationId.</param>
        /// <param name="educationDisciplineCategoryId">Initial value of EducationDisciplineCategoryId.</param>
        /// <param name="educationDiscipline">Initial value of EducationDiscipline.</param>
        /// <param name="educationDisciplineCategory">Initial value of EducationDisciplineCategory.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EducationDisciplineGroup CreateEducationDisciplineGroup(string educationId, string educationDisciplineCategoryId, global::Microsoft.Dynamics.DataEntities.EducationDiscipline educationDiscipline, global::Microsoft.Dynamics.DataEntities.EducationDisciplineCategory educationDisciplineCategory)
        {
            EducationDisciplineGroup educationDisciplineGroup = new EducationDisciplineGroup();
            educationDisciplineGroup.EducationId = educationId;
            educationDisciplineGroup.EducationDisciplineCategoryId = educationDisciplineCategoryId;
            if ((educationDiscipline == null))
            {
                throw new global::System.ArgumentNullException("educationDiscipline");
            }
            educationDisciplineGroup.EducationDiscipline = educationDiscipline;
            if ((educationDisciplineCategory == null))
            {
                throw new global::System.ArgumentNullException("educationDisciplineCategory");
            }
            educationDisciplineGroup.EducationDisciplineCategory = educationDisciplineCategory;
            return educationDisciplineGroup;
        }
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
        /// There are no comments for Property EducationDisciplineCategoryId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EducationDisciplineCategoryId
        {
            get
            {
                return this._EducationDisciplineCategoryId;
            }
            set
            {
                this.OnEducationDisciplineCategoryIdChanging(value);
                this._EducationDisciplineCategoryId = value;
                this.OnEducationDisciplineCategoryIdChanged();
                this.OnPropertyChanged("EducationDisciplineCategoryId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EducationDisciplineCategoryId;
        partial void OnEducationDisciplineCategoryIdChanging(string value);
        partial void OnEducationDisciplineCategoryIdChanged();
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
        /// There are no comments for Property EducationDisciplineCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EducationDisciplineCategory EducationDisciplineCategory
        {
            get
            {
                return this._EducationDisciplineCategory;
            }
            set
            {
                this.OnEducationDisciplineCategoryChanging(value);
                this._EducationDisciplineCategory = value;
                this.OnEducationDisciplineCategoryChanged();
                this.OnPropertyChanged("EducationDisciplineCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EducationDisciplineCategory _EducationDisciplineCategory;
        partial void OnEducationDisciplineCategoryChanging(global::Microsoft.Dynamics.DataEntities.EducationDisciplineCategory value);
        partial void OnEducationDisciplineCategoryChanged();
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
