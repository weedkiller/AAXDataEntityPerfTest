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
        /// There are no comments for WithholdCertificateSingle in the schema.
        /// </summary>
    public partial class WithholdCertificateSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WithholdCertificate>
    {
        /// <summary>
        /// Initialize a new WithholdCertificateSingle object.
        /// </summary>
        public WithholdCertificateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WithholdCertificateSingle object.
        /// </summary>
        public WithholdCertificateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WithholdCertificateSingle object.
        /// </summary>
        public WithholdCertificateSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WithholdCertificate> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle DimensionCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionCombination == null))
                {
                    this._DimensionCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("DimensionCombination"));
                }
                return this._DimensionCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _DimensionCombination;
    }
        /// <summary>
        /// There are no comments for WithholdCertificate in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// CertificateNumber
    /// AccountType
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CertificateNumber", "AccountType")]
    [global::Microsoft.OData.Client.EntitySet("WithholdCertificates")]
    public partial class WithholdCertificate : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WithholdCertificate object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="certificateNumber">Initial value of CertificateNumber.</param>
        /// <param name="date">Initial value of Date.</param>
        /// <param name="certificateAmount">Initial value of CertificateAmount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WithholdCertificate CreateWithholdCertificate(string dataAreaId, string certificateNumber, global::System.DateTimeOffset date, decimal certificateAmount)
        {
            WithholdCertificate withholdCertificate = new WithholdCertificate();
            withholdCertificate.dataAreaId = dataAreaId;
            withholdCertificate.CertificateNumber = certificateNumber;
            withholdCertificate.Date = date;
            withholdCertificate.CertificateAmount = certificateAmount;
            return withholdCertificate;
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
        /// There are no comments for Property CertificateNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CertificateNumber
        {
            get
            {
                return this._CertificateNumber;
            }
            set
            {
                this.OnCertificateNumberChanging(value);
                this._CertificateNumber = value;
                this.OnCertificateNumberChanged();
                this.OnPropertyChanged("CertificateNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CertificateNumber;
        partial void OnCertificateNumberChanging(string value);
        partial void OnCertificateNumberChanged();
        /// <summary>
        /// There are no comments for Property AccountType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxWithholdACType_IN> AccountType
        {
            get
            {
                return this._AccountType;
            }
            set
            {
                this.OnAccountTypeChanging(value);
                this._AccountType = value;
                this.OnAccountTypeChanged();
                this.OnPropertyChanged("AccountType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxWithholdACType_IN> _AccountType;
        partial void OnAccountTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxWithholdACType_IN> value);
        partial void OnAccountTypeChanged();
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
        /// There are no comments for Property Closed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Closed
        {
            get
            {
                return this._Closed;
            }
            set
            {
                this.OnClosedChanging(value);
                this._Closed = value;
                this.OnClosedChanged();
                this.OnPropertyChanged("Closed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Closed;
        partial void OnClosedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnClosedChanged();
        /// <summary>
        /// There are no comments for Property TaxType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxWithholdType_IN> TaxType
        {
            get
            {
                return this._TaxType;
            }
            set
            {
                this.OnTaxTypeChanging(value);
                this._TaxType = value;
                this.OnTaxTypeChanged();
                this.OnPropertyChanged("TaxType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxWithholdType_IN> _TaxType;
        partial void OnTaxTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TaxWithholdType_IN> value);
        partial void OnTaxTypeChanged();
        /// <summary>
        /// There are no comments for Property Date in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset Date
        {
            get
            {
                return this._Date;
            }
            set
            {
                this.OnDateChanging(value);
                this._Date = value;
                this.OnDateChanged();
                this.OnPropertyChanged("Date");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _Date;
        partial void OnDateChanging(global::System.DateTimeOffset value);
        partial void OnDateChanged();
        /// <summary>
        /// There are no comments for Property CertificateAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal CertificateAmount
        {
            get
            {
                return this._CertificateAmount;
            }
            set
            {
                this.OnCertificateAmountChanging(value);
                this._CertificateAmount = value;
                this.OnCertificateAmountChanged();
                this.OnPropertyChanged("CertificateAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CertificateAmount;
        partial void OnCertificateAmountChanging(decimal value);
        partial void OnCertificateAmountChanged();
        /// <summary>
        /// There are no comments for Property AccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AccountDisplayValue
        {
            get
            {
                return this._AccountDisplayValue;
            }
            set
            {
                this.OnAccountDisplayValueChanging(value);
                this._AccountDisplayValue = value;
                this.OnAccountDisplayValueChanged();
                this.OnPropertyChanged("AccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountDisplayValue;
        partial void OnAccountDisplayValueChanging(string value);
        partial void OnAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination DimensionCombination
        {
            get
            {
                return this._DimensionCombination;
            }
            set
            {
                this.OnDimensionCombinationChanging(value);
                this._DimensionCombination = value;
                this.OnDimensionCombinationChanged();
                this.OnPropertyChanged("DimensionCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _DimensionCombination;
        partial void OnDimensionCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnDimensionCombinationChanged();
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
