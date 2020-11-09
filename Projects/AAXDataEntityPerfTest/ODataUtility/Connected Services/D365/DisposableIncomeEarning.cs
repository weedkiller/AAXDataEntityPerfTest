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
        /// There are no comments for DisposableIncomeEarningSingle in the schema.
        /// </summary>
    public partial class DisposableIncomeEarningSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DisposableIncomeEarning>
    {
        /// <summary>
        /// Initialize a new DisposableIncomeEarningSingle object.
        /// </summary>
        public DisposableIncomeEarningSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DisposableIncomeEarningSingle object.
        /// </summary>
        public DisposableIncomeEarningSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DisposableIncomeEarningSingle object.
        /// </summary>
        public DisposableIncomeEarningSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DisposableIncomeEarning> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DisposableIncome in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DisposableIncomeSingle DisposableIncome
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DisposableIncome == null))
                {
                    this._DisposableIncome = new global::Microsoft.Dynamics.DataEntities.DisposableIncomeSingle(this.Context, GetPath("DisposableIncome"));
                }
                return this._DisposableIncome;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DisposableIncomeSingle _DisposableIncome;
    }
        /// <summary>
        /// There are no comments for DisposableIncomeEarning in the schema.
        /// </summary>
    /// <KeyProperties>
    /// EarningCodeId
    /// Name
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("EarningCodeId", "Name")]
    [global::Microsoft.OData.Client.EntitySet("DisposableIncomeEarnings")]
    public partial class DisposableIncomeEarning : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DisposableIncomeEarning object.
        /// </summary>
        /// <param name="earningCodeId">Initial value of EarningCodeId.</param>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="disposableIncome">Initial value of DisposableIncome.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DisposableIncomeEarning CreateDisposableIncomeEarning(string earningCodeId, string name, global::Microsoft.Dynamics.DataEntities.DisposableIncome disposableIncome)
        {
            DisposableIncomeEarning disposableIncomeEarning = new DisposableIncomeEarning();
            disposableIncomeEarning.EarningCodeId = earningCodeId;
            disposableIncomeEarning.Name = name;
            if ((disposableIncome == null))
            {
                throw new global::System.ArgumentNullException("disposableIncome");
            }
            disposableIncomeEarning.DisposableIncome = disposableIncome;
            return disposableIncomeEarning;
        }
        /// <summary>
        /// There are no comments for Property EarningCodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EarningCodeId
        {
            get
            {
                return this._EarningCodeId;
            }
            set
            {
                this.OnEarningCodeIdChanging(value);
                this._EarningCodeId = value;
                this.OnEarningCodeIdChanged();
                this.OnPropertyChanged("EarningCodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EarningCodeId;
        partial void OnEarningCodeIdChanging(string value);
        partial void OnEarningCodeIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property DisposableIncome in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DisposableIncome DisposableIncome
        {
            get
            {
                return this._DisposableIncome;
            }
            set
            {
                this.OnDisposableIncomeChanging(value);
                this._DisposableIncome = value;
                this.OnDisposableIncomeChanged();
                this.OnPropertyChanged("DisposableIncome");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DisposableIncome _DisposableIncome;
        partial void OnDisposableIncomeChanging(global::Microsoft.Dynamics.DataEntities.DisposableIncome value);
        partial void OnDisposableIncomeChanged();
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
