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
    /// There are no comments for CustomerRetentionTermSingle in the schema.
    /// </summary>
    public partial class CustomerRetentionTermSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CustomerRetentionTerm>
    {
        /// <summary>
        /// Initialize a new CustomerRetentionTermSingle object.
        /// </summary>
        public CustomerRetentionTermSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CustomerRetentionTermSingle object.
        /// </summary>
        public CustomerRetentionTermSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CustomerRetentionTermSingle object.
        /// </summary>
        public CustomerRetentionTermSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CustomerRetentionTerm> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CustomerRetentionTermSchedule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CustomerRetentionTermSchedule> CustomerRetentionTermSchedule
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CustomerRetentionTermSchedule == null))
                {
                    this._CustomerRetentionTermSchedule = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CustomerRetentionTermSchedule>(GetPath("CustomerRetentionTermSchedule"));
                }
                return this._CustomerRetentionTermSchedule;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CustomerRetentionTermSchedule> _CustomerRetentionTermSchedule;
    }
    /// <summary>
    /// There are no comments for CustomerRetentionTerm in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// RetentionTerm
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RetentionTerm")]
    [global::Microsoft.OData.Client.EntitySet("CustomerRetentionTerms")]
    public partial class CustomerRetentionTerm : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CustomerRetentionTerm object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="retentionTerm">Initial value of RetentionTerm.</param>
        /// <param name="effectiveDate">Initial value of EffectiveDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CustomerRetentionTerm CreateCustomerRetentionTerm(string dataAreaId, string retentionTerm, global::System.DateTimeOffset effectiveDate)
        {
            CustomerRetentionTerm customerRetentionTerm = new CustomerRetentionTerm();
            customerRetentionTerm.dataAreaId = dataAreaId;
            customerRetentionTerm.RetentionTerm = retentionTerm;
            customerRetentionTerm.EffectiveDate = effectiveDate;
            return customerRetentionTerm;
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
        /// There are no comments for Property RetentionTerm in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RetentionTerm
        {
            get
            {
                return this._RetentionTerm;
            }
            set
            {
                this.OnRetentionTermChanging(value);
                this._RetentionTerm = value;
                this.OnRetentionTermChanged();
                this.OnPropertyChanged("RetentionTerm");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RetentionTerm;
        partial void OnRetentionTermChanging(string value);
        partial void OnRetentionTermChanged();
        /// <summary>
        /// There are no comments for Property CustomerAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CustomerAccount
        {
            get
            {
                return this._CustomerAccount;
            }
            set
            {
                this.OnCustomerAccountChanging(value);
                this._CustomerAccount = value;
                this.OnCustomerAccountChanged();
                this.OnPropertyChanged("CustomerAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerAccount;
        partial void OnCustomerAccountChanging(string value);
        partial void OnCustomerAccountChanged();
        /// <summary>
        /// There are no comments for Property ProjectContractID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProjectContractID
        {
            get
            {
                return this._ProjectContractID;
            }
            set
            {
                this.OnProjectContractIDChanging(value);
                this._ProjectContractID = value;
                this.OnProjectContractIDChanged();
                this.OnPropertyChanged("ProjectContractID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectContractID;
        partial void OnProjectContractIDChanging(string value);
        partial void OnProjectContractIDChanged();
        /// <summary>
        /// There are no comments for Property BillingRule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BillingRule
        {
            get
            {
                return this._BillingRule;
            }
            set
            {
                this.OnBillingRuleChanging(value);
                this._BillingRule = value;
                this.OnBillingRuleChanged();
                this.OnPropertyChanged("BillingRule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BillingRule;
        partial void OnBillingRuleChanging(string value);
        partial void OnBillingRuleChanged();
        /// <summary>
        /// There are no comments for Property ProjectID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProjectID
        {
            get
            {
                return this._ProjectID;
            }
            set
            {
                this.OnProjectIDChanging(value);
                this._ProjectID = value;
                this.OnProjectIDChanged();
                this.OnPropertyChanged("ProjectID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectID;
        partial void OnProjectIDChanging(string value);
        partial void OnProjectIDChanged();
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
        /// There are no comments for Property EffectiveDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset EffectiveDate
        {
            get
            {
                return this._EffectiveDate;
            }
            set
            {
                this.OnEffectiveDateChanging(value);
                this._EffectiveDate = value;
                this.OnEffectiveDateChanged();
                this.OnPropertyChanged("EffectiveDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EffectiveDate;
        partial void OnEffectiveDateChanging(global::System.DateTimeOffset value);
        partial void OnEffectiveDateChanged();
        /// <summary>
        /// There are no comments for Property CustomerRetentionTermSchedule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerRetentionTermSchedule> CustomerRetentionTermSchedule
        {
            get
            {
                return this._CustomerRetentionTermSchedule;
            }
            set
            {
                this.OnCustomerRetentionTermScheduleChanging(value);
                this._CustomerRetentionTermSchedule = value;
                this.OnCustomerRetentionTermScheduleChanged();
                this.OnPropertyChanged("CustomerRetentionTermSchedule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerRetentionTermSchedule> _CustomerRetentionTermSchedule = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerRetentionTermSchedule>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCustomerRetentionTermScheduleChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CustomerRetentionTermSchedule> value);
        partial void OnCustomerRetentionTermScheduleChanged();
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
