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
    /// There are no comments for CompensationPerformancePlanSingle in the schema.
    /// </summary>
    public partial class CompensationPerformancePlanSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CompensationPerformancePlan>
    {
        /// <summary>
        /// Initialize a new CompensationPerformancePlanSingle object.
        /// </summary>
        public CompensationPerformancePlanSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CompensationPerformancePlanSingle object.
        /// </summary>
        public CompensationPerformancePlanSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CompensationPerformancePlanSingle object.
        /// </summary>
        public CompensationPerformancePlanSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CompensationPerformancePlan> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CompensationPayPerformanceAllocations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocation> CompensationPayPerformanceAllocations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompensationPayPerformanceAllocations == null))
                {
                    this._CompensationPayPerformanceAllocations = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocation>(GetPath("CompensationPayPerformanceAllocations"));
                }
                return this._CompensationPayPerformanceAllocations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocation> _CompensationPayPerformanceAllocations;
    }
    /// <summary>
    /// There are no comments for CompensationPerformancePlan in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// Plan
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Plan")]
    [global::Microsoft.OData.Client.EntitySet("CompensationPerformancePlans")]
    public partial class CompensationPerformancePlan : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CompensationPerformancePlan object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="plan">Initial value of Plan.</param>
        /// <param name="expiration">Initial value of Expiration.</param>
        /// <param name="effective">Initial value of Effective.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CompensationPerformancePlan CreateCompensationPerformancePlan(string dataAreaId, string plan, global::System.DateTimeOffset expiration, global::System.DateTimeOffset effective)
        {
            CompensationPerformancePlan compensationPerformancePlan = new CompensationPerformancePlan();
            compensationPerformancePlan.dataAreaId = dataAreaId;
            compensationPerformancePlan.Plan = plan;
            compensationPerformancePlan.Expiration = expiration;
            compensationPerformancePlan.Effective = effective;
            return compensationPerformancePlan;
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
        /// There are no comments for Property Plan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Plan
        {
            get
            {
                return this._Plan;
            }
            set
            {
                this.OnPlanChanging(value);
                this._Plan = value;
                this.OnPlanChanged();
                this.OnPropertyChanged("Plan");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Plan;
        partial void OnPlanChanging(string value);
        partial void OnPlanChanged();
        /// <summary>
        /// There are no comments for Property Expiration in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset Expiration
        {
            get
            {
                return this._Expiration;
            }
            set
            {
                this.OnExpirationChanging(value);
                this._Expiration = value;
                this.OnExpirationChanged();
                this.OnPropertyChanged("Expiration");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _Expiration;
        partial void OnExpirationChanging(global::System.DateTimeOffset value);
        partial void OnExpirationChanged();
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
        /// There are no comments for Property Effective in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset Effective
        {
            get
            {
                return this._Effective;
            }
            set
            {
                this.OnEffectiveChanging(value);
                this._Effective = value;
                this.OnEffectiveChanged();
                this.OnPropertyChanged("Effective");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _Effective;
        partial void OnEffectiveChanging(global::System.DateTimeOffset value);
        partial void OnEffectiveChanged();
        /// <summary>
        /// There are no comments for Property CompensationPayPerformanceAllocations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocation> CompensationPayPerformanceAllocations
        {
            get
            {
                return this._CompensationPayPerformanceAllocations;
            }
            set
            {
                this.OnCompensationPayPerformanceAllocationsChanging(value);
                this._CompensationPayPerformanceAllocations = value;
                this.OnCompensationPayPerformanceAllocationsChanged();
                this.OnPropertyChanged("CompensationPayPerformanceAllocations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocation> _CompensationPayPerformanceAllocations = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCompensationPayPerformanceAllocationsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocation> value);
        partial void OnCompensationPayPerformanceAllocationsChanged();
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
