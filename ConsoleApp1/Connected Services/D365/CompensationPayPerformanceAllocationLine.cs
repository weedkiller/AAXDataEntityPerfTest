﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 10/4/2020 2:55:10 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for CompensationPayPerformanceAllocationLineSingle in the schema.
    /// </summary>
    public partial class CompensationPayPerformanceAllocationLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CompensationPayPerformanceAllocationLine>
    {
        /// <summary>
        /// Initialize a new CompensationPayPerformanceAllocationLineSingle object.
        /// </summary>
        public CompensationPayPerformanceAllocationLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CompensationPayPerformanceAllocationLineSingle object.
        /// </summary>
        public CompensationPayPerformanceAllocationLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CompensationPayPerformanceAllocationLineSingle object.
        /// </summary>
        public CompensationPayPerformanceAllocationLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CompensationPayPerformanceAllocationLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CompensationPerformanceRating in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CompensationPerformanceRatingSingle CompensationPerformanceRating
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompensationPerformanceRating == null))
                {
                    this._CompensationPerformanceRating = new global::Microsoft.Dynamics.DataEntities.CompensationPerformanceRatingSingle(this.Context, GetPath("CompensationPerformanceRating"));
                }
                return this._CompensationPerformanceRating;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CompensationPerformanceRatingSingle _CompensationPerformanceRating;
        /// <summary>
        /// There are no comments for RatingLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RatingLevelSingle RatingLevel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RatingLevel == null))
                {
                    this._RatingLevel = new global::Microsoft.Dynamics.DataEntities.RatingLevelSingle(this.Context, GetPath("RatingLevel"));
                }
                return this._RatingLevel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RatingLevelSingle _RatingLevel;
        /// <summary>
        /// There are no comments for CompensationPayPerformanceAllocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocationSingle CompensationPayPerformanceAllocation
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompensationPayPerformanceAllocation == null))
                {
                    this._CompensationPayPerformanceAllocation = new global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocationSingle(this.Context, GetPath("CompensationPayPerformanceAllocation"));
                }
                return this._CompensationPayPerformanceAllocation;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocationSingle _CompensationPayPerformanceAllocation;
    }
    /// <summary>
    /// There are no comments for CompensationPayPerformanceAllocationLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// RatingLevelId
    /// AllocationId
    /// PlanType
    /// RatingModelType
    /// CompPerfRatingId
    /// RatingModelId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RatingLevelId", "AllocationId", "PlanType", "RatingModelType", "CompPerfRatingId", "RatingModelId")]
    [global::Microsoft.OData.Client.EntitySet("CompensationPayPerformanceAllocationLines")]
    public partial class CompensationPayPerformanceAllocationLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CompensationPayPerformanceAllocationLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="ratingLevelId">Initial value of RatingLevelId.</param>
        /// <param name="allocationId">Initial value of AllocationId.</param>
        /// <param name="compPerfRatingId">Initial value of CompPerfRatingId.</param>
        /// <param name="ratingModelId">Initial value of RatingModelId.</param>
        /// <param name="perfFactorPercent">Initial value of PerfFactorPercent.</param>
        /// <param name="compensationPayPerformanceAllocation">Initial value of CompensationPayPerformanceAllocation.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CompensationPayPerformanceAllocationLine CreateCompensationPayPerformanceAllocationLine(string dataAreaId, 
                    string ratingLevelId, 
                    string allocationId, 
                    string compPerfRatingId, 
                    string ratingModelId, 
                    decimal perfFactorPercent, 
                    global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocation compensationPayPerformanceAllocation)
        {
            CompensationPayPerformanceAllocationLine compensationPayPerformanceAllocationLine = new CompensationPayPerformanceAllocationLine();
            compensationPayPerformanceAllocationLine.dataAreaId = dataAreaId;
            compensationPayPerformanceAllocationLine.RatingLevelId = ratingLevelId;
            compensationPayPerformanceAllocationLine.AllocationId = allocationId;
            compensationPayPerformanceAllocationLine.CompPerfRatingId = compPerfRatingId;
            compensationPayPerformanceAllocationLine.RatingModelId = ratingModelId;
            compensationPayPerformanceAllocationLine.PerfFactorPercent = perfFactorPercent;
            if ((compensationPayPerformanceAllocation == null))
            {
                throw new global::System.ArgumentNullException("compensationPayPerformanceAllocation");
            }
            compensationPayPerformanceAllocationLine.CompensationPayPerformanceAllocation = compensationPayPerformanceAllocation;
            return compensationPayPerformanceAllocationLine;
        }
        /// <summary>
        /// There are no comments for Property dataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string dataAreaId
        {
            get
            {
                return this._dataAreaId;
            }
            set
            {
                this.OndataAreaIdChanging(value);
                this._dataAreaId = value;
                this.OndataAreaIdChanged();
                this.OnPropertyChanged("dataAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _dataAreaId;
        partial void OndataAreaIdChanging(string value);
        partial void OndataAreaIdChanged();
        /// <summary>
        /// There are no comments for Property RatingLevelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RatingLevelId
        {
            get
            {
                return this._RatingLevelId;
            }
            set
            {
                this.OnRatingLevelIdChanging(value);
                this._RatingLevelId = value;
                this.OnRatingLevelIdChanged();
                this.OnPropertyChanged("RatingLevelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RatingLevelId;
        partial void OnRatingLevelIdChanging(string value);
        partial void OnRatingLevelIdChanged();
        /// <summary>
        /// There are no comments for Property AllocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AllocationId
        {
            get
            {
                return this._AllocationId;
            }
            set
            {
                this.OnAllocationIdChanging(value);
                this._AllocationId = value;
                this.OnAllocationIdChanged();
                this.OnPropertyChanged("AllocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AllocationId;
        partial void OnAllocationIdChanging(string value);
        partial void OnAllocationIdChanged();
        /// <summary>
        /// There are no comments for Property PlanType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompPlanType> PlanType
        {
            get
            {
                return this._PlanType;
            }
            set
            {
                this.OnPlanTypeChanging(value);
                this._PlanType = value;
                this.OnPlanTypeChanged();
                this.OnPropertyChanged("PlanType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompPlanType> _PlanType;
        partial void OnPlanTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompPlanType> value);
        partial void OnPlanTypeChanged();
        /// <summary>
        /// There are no comments for Property RatingModelType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompRatingModel> RatingModelType
        {
            get
            {
                return this._RatingModelType;
            }
            set
            {
                this.OnRatingModelTypeChanging(value);
                this._RatingModelType = value;
                this.OnRatingModelTypeChanged();
                this.OnPropertyChanged("RatingModelType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompRatingModel> _RatingModelType;
        partial void OnRatingModelTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmCompRatingModel> value);
        partial void OnRatingModelTypeChanged();
        /// <summary>
        /// There are no comments for Property CompPerfRatingId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CompPerfRatingId
        {
            get
            {
                return this._CompPerfRatingId;
            }
            set
            {
                this.OnCompPerfRatingIdChanging(value);
                this._CompPerfRatingId = value;
                this.OnCompPerfRatingIdChanged();
                this.OnPropertyChanged("CompPerfRatingId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CompPerfRatingId;
        partial void OnCompPerfRatingIdChanging(string value);
        partial void OnCompPerfRatingIdChanged();
        /// <summary>
        /// There are no comments for Property RatingModelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RatingModelId
        {
            get
            {
                return this._RatingModelId;
            }
            set
            {
                this.OnRatingModelIdChanging(value);
                this._RatingModelId = value;
                this.OnRatingModelIdChanged();
                this.OnPropertyChanged("RatingModelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RatingModelId;
        partial void OnRatingModelIdChanging(string value);
        partial void OnRatingModelIdChanged();
        /// <summary>
        /// There are no comments for Property PerfFactorPercent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal PerfFactorPercent
        {
            get
            {
                return this._PerfFactorPercent;
            }
            set
            {
                this.OnPerfFactorPercentChanging(value);
                this._PerfFactorPercent = value;
                this.OnPerfFactorPercentChanged();
                this.OnPropertyChanged("PerfFactorPercent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _PerfFactorPercent;
        partial void OnPerfFactorPercentChanging(decimal value);
        partial void OnPerfFactorPercentChanged();
        /// <summary>
        /// There are no comments for Property CompensationPerformanceRating in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CompensationPerformanceRating CompensationPerformanceRating
        {
            get
            {
                return this._CompensationPerformanceRating;
            }
            set
            {
                this.OnCompensationPerformanceRatingChanging(value);
                this._CompensationPerformanceRating = value;
                this.OnCompensationPerformanceRatingChanged();
                this.OnPropertyChanged("CompensationPerformanceRating");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CompensationPerformanceRating _CompensationPerformanceRating;
        partial void OnCompensationPerformanceRatingChanging(global::Microsoft.Dynamics.DataEntities.CompensationPerformanceRating value);
        partial void OnCompensationPerformanceRatingChanged();
        /// <summary>
        /// There are no comments for Property RatingLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RatingLevel RatingLevel
        {
            get
            {
                return this._RatingLevel;
            }
            set
            {
                this.OnRatingLevelChanging(value);
                this._RatingLevel = value;
                this.OnRatingLevelChanged();
                this.OnPropertyChanged("RatingLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RatingLevel _RatingLevel;
        partial void OnRatingLevelChanging(global::Microsoft.Dynamics.DataEntities.RatingLevel value);
        partial void OnRatingLevelChanged();
        /// <summary>
        /// There are no comments for Property CompensationPayPerformanceAllocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocation CompensationPayPerformanceAllocation
        {
            get
            {
                return this._CompensationPayPerformanceAllocation;
            }
            set
            {
                this.OnCompensationPayPerformanceAllocationChanging(value);
                this._CompensationPayPerformanceAllocation = value;
                this.OnCompensationPayPerformanceAllocationChanged();
                this.OnPropertyChanged("CompensationPayPerformanceAllocation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocation _CompensationPayPerformanceAllocation;
        partial void OnCompensationPayPerformanceAllocationChanging(global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocation value);
        partial void OnCompensationPayPerformanceAllocationChanged();
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
