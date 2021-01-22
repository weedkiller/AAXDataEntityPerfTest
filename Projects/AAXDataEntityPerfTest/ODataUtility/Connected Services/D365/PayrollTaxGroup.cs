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
        /// There are no comments for PayrollTaxGroupSingle in the schema.
        /// </summary>
    public partial class PayrollTaxGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PayrollTaxGroup>
    {
        /// <summary>
        /// Initialize a new PayrollTaxGroupSingle object.
        /// </summary>
        public PayrollTaxGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PayrollTaxGroupSingle object.
        /// </summary>
        public PayrollTaxGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PayrollTaxGroupSingle object.
        /// </summary>
        public PayrollTaxGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PayrollTaxGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for TaxGroupCodes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PayrollTaxGroupCode> TaxGroupCodes
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TaxGroupCodes == null))
                {
                    this._TaxGroupCodes = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PayrollTaxGroupCode>(GetPath("TaxGroupCodes"));
                }
                return this._TaxGroupCodes;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PayrollTaxGroupCode> _TaxGroupCodes;
        /// <summary>
        /// There are no comments for BenefitTaxRuleUS in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BenefitTaxRuleUS> BenefitTaxRuleUS
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BenefitTaxRuleUS == null))
                {
                    this._BenefitTaxRuleUS = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BenefitTaxRuleUS>(GetPath("BenefitTaxRuleUS"));
                }
                return this._BenefitTaxRuleUS;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BenefitTaxRuleUS> _BenefitTaxRuleUS;
    }
        /// <summary>
        /// There are no comments for PayrollTaxGroup in the schema.
        /// </summary>
    /// <KeyProperties>
    /// GroupId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("GroupId")]
    [global::Microsoft.OData.Client.EntitySet("PayrollTaxGroups")]
    public partial class PayrollTaxGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PayrollTaxGroup object.
        /// </summary>
        /// <param name="groupId">Initial value of GroupId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PayrollTaxGroup CreatePayrollTaxGroup(string groupId)
        {
            PayrollTaxGroup payrollTaxGroup = new PayrollTaxGroup();
            payrollTaxGroup.GroupId = groupId;
            return payrollTaxGroup;
        }
        /// <summary>
        /// There are no comments for Property GroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string GroupId
        {
            get
            {
                return this._GroupId;
            }
            set
            {
                this.OnGroupIdChanging(value);
                this._GroupId = value;
                this.OnGroupIdChanged();
                this.OnPropertyChanged("GroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupId;
        partial void OnGroupIdChanging(string value);
        partial void OnGroupIdChanged();
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
        /// There are no comments for Property TaxGroupCodes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PayrollTaxGroupCode> TaxGroupCodes
        {
            get
            {
                return this._TaxGroupCodes;
            }
            set
            {
                this.OnTaxGroupCodesChanging(value);
                this._TaxGroupCodes = value;
                this.OnTaxGroupCodesChanged();
                this.OnPropertyChanged("TaxGroupCodes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PayrollTaxGroupCode> _TaxGroupCodes = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PayrollTaxGroupCode>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnTaxGroupCodesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PayrollTaxGroupCode> value);
        partial void OnTaxGroupCodesChanged();
        /// <summary>
        /// There are no comments for Property BenefitTaxRuleUS in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitTaxRuleUS> BenefitTaxRuleUS
        {
            get
            {
                return this._BenefitTaxRuleUS;
            }
            set
            {
                this.OnBenefitTaxRuleUSChanging(value);
                this._BenefitTaxRuleUS = value;
                this.OnBenefitTaxRuleUSChanged();
                this.OnPropertyChanged("BenefitTaxRuleUS");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitTaxRuleUS> _BenefitTaxRuleUS = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitTaxRuleUS>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBenefitTaxRuleUSChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BenefitTaxRuleUS> value);
        partial void OnBenefitTaxRuleUSChanged();
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
