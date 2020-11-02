﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 9/11/2020 3:24:26 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for WorkCycleSingle in the schema.
    /// </summary>
    public partial class WorkCycleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WorkCycle>
    {
        /// <summary>
        /// Initialize a new WorkCycleSingle object.
        /// </summary>
        public WorkCycleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WorkCycleSingle object.
        /// </summary>
        public WorkCycleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WorkCycleSingle object.
        /// </summary>
        public WorkCycleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WorkCycle> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for WorkCycle in the schema.
    /// </summary>
    /// <KeyProperties>
    /// WorkCycleId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("WorkCycleId")]
    [global::Microsoft.OData.Client.EntitySet("WorkCycles")]
    public partial class WorkCycle : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WorkCycle object.
        /// </summary>
        /// <param name="workCycleId">Initial value of WorkCycleId.</param>
        /// <param name="daysPerPeriod">Initial value of DaysPerPeriod.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WorkCycle CreateWorkCycle(string workCycleId, int daysPerPeriod)
        {
            WorkCycle workCycle = new WorkCycle();
            workCycle.WorkCycleId = workCycleId;
            workCycle.DaysPerPeriod = daysPerPeriod;
            return workCycle;
        }
        /// <summary>
        /// There are no comments for Property WorkCycleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WorkCycleId
        {
            get
            {
                return this._WorkCycleId;
            }
            set
            {
                this.OnWorkCycleIdChanging(value);
                this._WorkCycleId = value;
                this.OnWorkCycleIdChanged();
                this.OnPropertyChanged("WorkCycleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WorkCycleId;
        partial void OnWorkCycleIdChanging(string value);
        partial void OnWorkCycleIdChanged();
        /// <summary>
        /// There are no comments for Property DaysPerPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int DaysPerPeriod
        {
            get
            {
                return this._DaysPerPeriod;
            }
            set
            {
                this.OnDaysPerPeriodChanging(value);
                this._DaysPerPeriod = value;
                this.OnDaysPerPeriodChanged();
                this.OnPropertyChanged("DaysPerPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _DaysPerPeriod;
        partial void OnDaysPerPeriodChanging(int value);
        partial void OnDaysPerPeriodChanged();
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
