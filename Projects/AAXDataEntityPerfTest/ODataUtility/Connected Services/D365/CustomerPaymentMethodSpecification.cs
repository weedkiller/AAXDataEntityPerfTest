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
        /// There are no comments for CustomerPaymentMethodSpecificationSingle in the schema.
        /// </summary>
    public partial class CustomerPaymentMethodSpecificationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CustomerPaymentMethodSpecification>
    {
        /// <summary>
        /// Initialize a new CustomerPaymentMethodSpecificationSingle object.
        /// </summary>
        public CustomerPaymentMethodSpecificationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CustomerPaymentMethodSpecificationSingle object.
        /// </summary>
        public CustomerPaymentMethodSpecificationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CustomerPaymentMethodSpecificationSingle object.
        /// </summary>
        public CustomerPaymentMethodSpecificationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CustomerPaymentMethodSpecification> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for SalesAgreementHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.SalesAgreement> SalesAgreementHeaders
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SalesAgreementHeaders == null))
                {
                    this._SalesAgreementHeaders = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.SalesAgreement>(GetPath("SalesAgreementHeaders"));
                }
                return this._SalesAgreementHeaders;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.SalesAgreement> _SalesAgreementHeaders;
        /// <summary>
        /// There are no comments for SalesAgreementConfirmationHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.SalesAgreementConfirmation> SalesAgreementConfirmationHeaders
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SalesAgreementConfirmationHeaders == null))
                {
                    this._SalesAgreementConfirmationHeaders = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.SalesAgreementConfirmation>(GetPath("SalesAgreementConfirmationHeaders"));
                }
                return this._SalesAgreementConfirmationHeaders;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.SalesAgreementConfirmation> _SalesAgreementConfirmationHeaders;
        /// <summary>
        /// There are no comments for CustomerPaymentMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CustomerPaymentMethodSingle CustomerPaymentMethod
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CustomerPaymentMethod == null))
                {
                    this._CustomerPaymentMethod = new global::Microsoft.Dynamics.DataEntities.CustomerPaymentMethodSingle(this.Context, GetPath("CustomerPaymentMethod"));
                }
                return this._CustomerPaymentMethod;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CustomerPaymentMethodSingle _CustomerPaymentMethod;
    }
        /// <summary>
        /// There are no comments for CustomerPaymentMethodSpecification in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// PaymentMethodName
    /// Name
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "PaymentMethodName", "Name")]
    [global::Microsoft.OData.Client.EntitySet("CustomerPaymentMethodSpecifications")]
    public partial class CustomerPaymentMethodSpecification : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CustomerPaymentMethodSpecification object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="paymentMethodName">Initial value of PaymentMethodName.</param>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="customerPaymentMethod">Initial value of CustomerPaymentMethod.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CustomerPaymentMethodSpecification CreateCustomerPaymentMethodSpecification(string dataAreaId, string paymentMethodName, string name, global::Microsoft.Dynamics.DataEntities.CustomerPaymentMethod customerPaymentMethod)
        {
            CustomerPaymentMethodSpecification customerPaymentMethodSpecification = new CustomerPaymentMethodSpecification();
            customerPaymentMethodSpecification.dataAreaId = dataAreaId;
            customerPaymentMethodSpecification.PaymentMethodName = paymentMethodName;
            customerPaymentMethodSpecification.Name = name;
            if ((customerPaymentMethod == null))
            {
                throw new global::System.ArgumentNullException("customerPaymentMethod");
            }
            customerPaymentMethodSpecification.CustomerPaymentMethod = customerPaymentMethod;
            return customerPaymentMethodSpecification;
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
        /// There are no comments for Property PaymentMethodName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PaymentMethodName
        {
            get
            {
                return this._PaymentMethodName;
            }
            set
            {
                this.OnPaymentMethodNameChanging(value);
                this._PaymentMethodName = value;
                this.OnPaymentMethodNameChanged();
                this.OnPropertyChanged("PaymentMethodName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PaymentMethodName;
        partial void OnPaymentMethodNameChanging(string value);
        partial void OnPaymentMethodNameChanged();
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
        /// There are no comments for Property SpecParameters in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SpecParameters
        {
            get
            {
                return this._SpecParameters;
            }
            set
            {
                this.OnSpecParametersChanging(value);
                this._SpecParameters = value;
                this.OnSpecParametersChanged();
                this.OnPropertyChanged("SpecParameters");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SpecParameters;
        partial void OnSpecParametersChanging(string value);
        partial void OnSpecParametersChanged();
        /// <summary>
        /// There are no comments for Property PaymentWay in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PaymentWay
        {
            get
            {
                return this._PaymentWay;
            }
            set
            {
                this.OnPaymentWayChanging(value);
                this._PaymentWay = value;
                this.OnPaymentWayChanged();
                this.OnPropertyChanged("PaymentWay");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PaymentWay;
        partial void OnPaymentWayChanging(string value);
        partial void OnPaymentWayChanged();
        /// <summary>
        /// There are no comments for Property ClassName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ClassName
        {
            get
            {
                return this._ClassName;
            }
            set
            {
                this.OnClassNameChanging(value);
                this._ClassName = value;
                this.OnClassNameChanged();
                this.OnPropertyChanged("ClassName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ClassName;
        partial void OnClassNameChanging(string value);
        partial void OnClassNameChanged();
        /// <summary>
        /// There are no comments for Property ReturnSegment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReturnSegment
        {
            get
            {
                return this._ReturnSegment;
            }
            set
            {
                this.OnReturnSegmentChanging(value);
                this._ReturnSegment = value;
                this.OnReturnSegmentChanged();
                this.OnPropertyChanged("ReturnSegment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReturnSegment;
        partial void OnReturnSegmentChanging(string value);
        partial void OnReturnSegmentChanged();
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
        /// There are no comments for Property RemittanceSegment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RemittanceSegment
        {
            get
            {
                return this._RemittanceSegment;
            }
            set
            {
                this.OnRemittanceSegmentChanging(value);
                this._RemittanceSegment = value;
                this.OnRemittanceSegmentChanged();
                this.OnPropertyChanged("RemittanceSegment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RemittanceSegment;
        partial void OnRemittanceSegmentChanging(string value);
        partial void OnRemittanceSegmentChanged();
        /// <summary>
        /// There are no comments for Property PaymentType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PaymentType
        {
            get
            {
                return this._PaymentType;
            }
            set
            {
                this.OnPaymentTypeChanging(value);
                this._PaymentType = value;
                this.OnPaymentTypeChanged();
                this.OnPropertyChanged("PaymentType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PaymentType;
        partial void OnPaymentTypeChanging(string value);
        partial void OnPaymentTypeChanged();
        /// <summary>
        /// There are no comments for Property SalesAgreementHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SalesAgreement> SalesAgreementHeaders
        {
            get
            {
                return this._SalesAgreementHeaders;
            }
            set
            {
                this.OnSalesAgreementHeadersChanging(value);
                this._SalesAgreementHeaders = value;
                this.OnSalesAgreementHeadersChanged();
                this.OnPropertyChanged("SalesAgreementHeaders");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SalesAgreement> _SalesAgreementHeaders = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SalesAgreement>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnSalesAgreementHeadersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SalesAgreement> value);
        partial void OnSalesAgreementHeadersChanged();
        /// <summary>
        /// There are no comments for Property SalesAgreementConfirmationHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SalesAgreementConfirmation> SalesAgreementConfirmationHeaders
        {
            get
            {
                return this._SalesAgreementConfirmationHeaders;
            }
            set
            {
                this.OnSalesAgreementConfirmationHeadersChanging(value);
                this._SalesAgreementConfirmationHeaders = value;
                this.OnSalesAgreementConfirmationHeadersChanged();
                this.OnPropertyChanged("SalesAgreementConfirmationHeaders");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SalesAgreementConfirmation> _SalesAgreementConfirmationHeaders = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SalesAgreementConfirmation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnSalesAgreementConfirmationHeadersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SalesAgreementConfirmation> value);
        partial void OnSalesAgreementConfirmationHeadersChanged();
        /// <summary>
        /// There are no comments for Property CustomerPaymentMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CustomerPaymentMethod CustomerPaymentMethod
        {
            get
            {
                return this._CustomerPaymentMethod;
            }
            set
            {
                this.OnCustomerPaymentMethodChanging(value);
                this._CustomerPaymentMethod = value;
                this.OnCustomerPaymentMethodChanged();
                this.OnPropertyChanged("CustomerPaymentMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CustomerPaymentMethod _CustomerPaymentMethod;
        partial void OnCustomerPaymentMethodChanging(global::Microsoft.Dynamics.DataEntities.CustomerPaymentMethod value);
        partial void OnCustomerPaymentMethodChanged();
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
