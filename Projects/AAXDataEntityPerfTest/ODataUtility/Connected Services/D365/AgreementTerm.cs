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
        /// There are no comments for AgreementTermSingle in the schema.
        /// </summary>
    public partial class AgreementTermSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AgreementTerm>
    {
        /// <summary>
        /// Initialize a new AgreementTermSingle object.
        /// </summary>
        public AgreementTermSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AgreementTermSingle object.
        /// </summary>
        public AgreementTermSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AgreementTermSingle object.
        /// </summary>
        public AgreementTermSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AgreementTerm> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EmploymentTerms in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EmploymentTerm> EmploymentTerms
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EmploymentTerms == null))
                {
                    this._EmploymentTerms = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EmploymentTerm>(GetPath("EmploymentTerms"));
                }
                return this._EmploymentTerms;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EmploymentTerm> _EmploymentTerms;
    }
        /// <summary>
        /// There are no comments for AgreementTerm in the schema.
        /// </summary>
    /// <KeyProperties>
    /// TermsOfEmployment
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("TermsOfEmployment")]
    [global::Microsoft.OData.Client.EntitySet("AgreementTerms")]
    public partial class AgreementTerm : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AgreementTerm object.
        /// </summary>
        /// <param name="termsOfEmployment">Initial value of TermsOfEmployment.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AgreementTerm CreateAgreementTerm(string termsOfEmployment)
        {
            AgreementTerm agreementTerm = new AgreementTerm();
            agreementTerm.TermsOfEmployment = termsOfEmployment;
            return agreementTerm;
        }
        /// <summary>
        /// There are no comments for Property TermsOfEmployment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TermsOfEmployment
        {
            get
            {
                return this._TermsOfEmployment;
            }
            set
            {
                this.OnTermsOfEmploymentChanging(value);
                this._TermsOfEmployment = value;
                this.OnTermsOfEmploymentChanged();
                this.OnPropertyChanged("TermsOfEmployment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TermsOfEmployment;
        partial void OnTermsOfEmploymentChanging(string value);
        partial void OnTermsOfEmploymentChanged();
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
        /// There are no comments for Property EmploymentTerms in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentTerm> EmploymentTerms
        {
            get
            {
                return this._EmploymentTerms;
            }
            set
            {
                this.OnEmploymentTermsChanging(value);
                this._EmploymentTerms = value;
                this.OnEmploymentTermsChanged();
                this.OnPropertyChanged("EmploymentTerms");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentTerm> _EmploymentTerms = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentTerm>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEmploymentTermsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentTerm> value);
        partial void OnEmploymentTermsChanged();
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
