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
        /// There are no comments for DisposableIncomeSingle in the schema.
        /// </summary>
    public partial class DisposableIncomeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DisposableIncome>
    {
        /// <summary>
        /// Initialize a new DisposableIncomeSingle object.
        /// </summary>
        public DisposableIncomeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DisposableIncomeSingle object.
        /// </summary>
        public DisposableIncomeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DisposableIncomeSingle object.
        /// </summary>
        public DisposableIncomeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DisposableIncome> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DisposableIncomeEarnings in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DisposableIncomeEarning> DisposableIncomeEarnings
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DisposableIncomeEarnings == null))
                {
                    this._DisposableIncomeEarnings = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.DisposableIncomeEarning>(GetPath("DisposableIncomeEarnings"));
                }
                return this._DisposableIncomeEarnings;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DisposableIncomeEarning> _DisposableIncomeEarnings;
        /// <summary>
        /// There are no comments for GarnishmentTaxLevyRules in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WorkerGarnishmentRule> GarnishmentTaxLevyRules
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._GarnishmentTaxLevyRules == null))
                {
                    this._GarnishmentTaxLevyRules = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WorkerGarnishmentRule>(GetPath("GarnishmentTaxLevyRules"));
                }
                return this._GarnishmentTaxLevyRules;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WorkerGarnishmentRule> _GarnishmentTaxLevyRules;
        /// <summary>
        /// There are no comments for DisposableIncomeBenefits in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DisposableIncomeBenefit> DisposableIncomeBenefits
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DisposableIncomeBenefits == null))
                {
                    this._DisposableIncomeBenefits = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.DisposableIncomeBenefit>(GetPath("DisposableIncomeBenefits"));
                }
                return this._DisposableIncomeBenefits;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.DisposableIncomeBenefit> _DisposableIncomeBenefits;
    }
        /// <summary>
        /// There are no comments for DisposableIncome in the schema.
        /// </summary>
    /// <KeyProperties>
    /// Name
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Name")]
    [global::Microsoft.OData.Client.EntitySet("DisposableIncomes")]
    public partial class DisposableIncome : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DisposableIncome object.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DisposableIncome CreateDisposableIncome(string name)
        {
            DisposableIncome disposableIncome = new DisposableIncome();
            disposableIncome.Name = name;
            return disposableIncome;
        }
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
        /// There are no comments for Property DisposableIncomeEarnings in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DisposableIncomeEarning> DisposableIncomeEarnings
        {
            get
            {
                return this._DisposableIncomeEarnings;
            }
            set
            {
                this.OnDisposableIncomeEarningsChanging(value);
                this._DisposableIncomeEarnings = value;
                this.OnDisposableIncomeEarningsChanged();
                this.OnPropertyChanged("DisposableIncomeEarnings");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DisposableIncomeEarning> _DisposableIncomeEarnings = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DisposableIncomeEarning>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnDisposableIncomeEarningsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DisposableIncomeEarning> value);
        partial void OnDisposableIncomeEarningsChanged();
        /// <summary>
        /// There are no comments for Property GarnishmentTaxLevyRules in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerGarnishmentRule> GarnishmentTaxLevyRules
        {
            get
            {
                return this._GarnishmentTaxLevyRules;
            }
            set
            {
                this.OnGarnishmentTaxLevyRulesChanging(value);
                this._GarnishmentTaxLevyRules = value;
                this.OnGarnishmentTaxLevyRulesChanged();
                this.OnPropertyChanged("GarnishmentTaxLevyRules");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerGarnishmentRule> _GarnishmentTaxLevyRules = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerGarnishmentRule>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnGarnishmentTaxLevyRulesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerGarnishmentRule> value);
        partial void OnGarnishmentTaxLevyRulesChanged();
        /// <summary>
        /// There are no comments for Property DisposableIncomeBenefits in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DisposableIncomeBenefit> DisposableIncomeBenefits
        {
            get
            {
                return this._DisposableIncomeBenefits;
            }
            set
            {
                this.OnDisposableIncomeBenefitsChanging(value);
                this._DisposableIncomeBenefits = value;
                this.OnDisposableIncomeBenefitsChanged();
                this.OnPropertyChanged("DisposableIncomeBenefits");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DisposableIncomeBenefit> _DisposableIncomeBenefits = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DisposableIncomeBenefit>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnDisposableIncomeBenefitsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.DisposableIncomeBenefit> value);
        partial void OnDisposableIncomeBenefitsChanged();
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
