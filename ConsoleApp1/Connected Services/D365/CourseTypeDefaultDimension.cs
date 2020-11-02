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
    /// There are no comments for CourseTypeDefaultDimensionSingle in the schema.
    /// </summary>
    public partial class CourseTypeDefaultDimensionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CourseTypeDefaultDimension>
    {
        /// <summary>
        /// Initialize a new CourseTypeDefaultDimensionSingle object.
        /// </summary>
        public CourseTypeDefaultDimensionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CourseTypeDefaultDimensionSingle object.
        /// </summary>
        public CourseTypeDefaultDimensionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CourseTypeDefaultDimensionSingle object.
        /// </summary>
        public CourseTypeDefaultDimensionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CourseTypeDefaultDimension> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSetSingle DimensionSet
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionSet == null))
                {
                    this._DimensionSet = new global::Microsoft.Dynamics.DataEntities.DimensionSetSingle(this.Context, GetPath("DimensionSet"));
                }
                return this._DimensionSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSetSingle _DimensionSet;
        /// <summary>
        /// There are no comments for CourseTypes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CourseTypeSingle CourseTypes
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CourseTypes == null))
                {
                    this._CourseTypes = new global::Microsoft.Dynamics.DataEntities.CourseTypeSingle(this.Context, GetPath("CourseTypes"));
                }
                return this._CourseTypes;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CourseTypeSingle _CourseTypes;
    }
    /// <summary>
    /// There are no comments for CourseTypeDefaultDimension in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CourseTypeId
    /// Company
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CourseTypeId", "Company")]
    [global::Microsoft.OData.Client.EntitySet("CourseTypeDefaultDimensions")]
    public partial class CourseTypeDefaultDimension : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CourseTypeDefaultDimension object.
        /// </summary>
        /// <param name="courseTypeId">Initial value of CourseTypeId.</param>
        /// <param name="company">Initial value of Company.</param>
        /// <param name="courseTypes">Initial value of CourseTypes.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CourseTypeDefaultDimension CreateCourseTypeDefaultDimension(string courseTypeId, string company, global::Microsoft.Dynamics.DataEntities.CourseType courseTypes)
        {
            CourseTypeDefaultDimension courseTypeDefaultDimension = new CourseTypeDefaultDimension();
            courseTypeDefaultDimension.CourseTypeId = courseTypeId;
            courseTypeDefaultDimension.Company = company;
            if ((courseTypes == null))
            {
                throw new global::System.ArgumentNullException("courseTypes");
            }
            courseTypeDefaultDimension.CourseTypes = courseTypes;
            return courseTypeDefaultDimension;
        }
        /// <summary>
        /// There are no comments for Property CourseTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CourseTypeId
        {
            get
            {
                return this._CourseTypeId;
            }
            set
            {
                this.OnCourseTypeIdChanging(value);
                this._CourseTypeId = value;
                this.OnCourseTypeIdChanged();
                this.OnPropertyChanged("CourseTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CourseTypeId;
        partial void OnCourseTypeIdChanging(string value);
        partial void OnCourseTypeIdChanged();
        /// <summary>
        /// There are no comments for Property Company in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Company
        {
            get
            {
                return this._Company;
            }
            set
            {
                this.OnCompanyChanging(value);
                this._Company = value;
                this.OnCompanyChanged();
                this.OnPropertyChanged("Company");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Company;
        partial void OnCompanyChanging(string value);
        partial void OnCompanyChanged();
        /// <summary>
        /// There are no comments for Property DimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DimensionDisplayValue
        {
            get
            {
                return this._DimensionDisplayValue;
            }
            set
            {
                this.OnDimensionDisplayValueChanging(value);
                this._DimensionDisplayValue = value;
                this.OnDimensionDisplayValueChanged();
                this.OnPropertyChanged("DimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DimensionDisplayValue;
        partial void OnDimensionDisplayValueChanging(string value);
        partial void OnDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSet DimensionSet
        {
            get
            {
                return this._DimensionSet;
            }
            set
            {
                this.OnDimensionSetChanging(value);
                this._DimensionSet = value;
                this.OnDimensionSetChanged();
                this.OnPropertyChanged("DimensionSet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSet _DimensionSet;
        partial void OnDimensionSetChanging(global::Microsoft.Dynamics.DataEntities.DimensionSet value);
        partial void OnDimensionSetChanged();
        /// <summary>
        /// There are no comments for Property CourseTypes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CourseType CourseTypes
        {
            get
            {
                return this._CourseTypes;
            }
            set
            {
                this.OnCourseTypesChanging(value);
                this._CourseTypes = value;
                this.OnCourseTypesChanged();
                this.OnPropertyChanged("CourseTypes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CourseType _CourseTypes;
        partial void OnCourseTypesChanging(global::Microsoft.Dynamics.DataEntities.CourseType value);
        partial void OnCourseTypesChanged();
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
