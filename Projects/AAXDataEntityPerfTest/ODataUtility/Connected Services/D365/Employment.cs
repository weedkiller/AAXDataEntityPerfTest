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
        /// There are no comments for EmploymentSingle in the schema.
        /// </summary>
    public partial class EmploymentSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Employment>
    {
        /// <summary>
        /// Initialize a new EmploymentSingle object.
        /// </summary>
        public EmploymentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EmploymentSingle object.
        /// </summary>
        public EmploymentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EmploymentSingle object.
        /// </summary>
        public EmploymentSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Employment> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EmploymentContractor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EmploymentContractor> EmploymentContractor
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EmploymentContractor == null))
                {
                    this._EmploymentContractor = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EmploymentContractor>(GetPath("EmploymentContractor"));
                }
                return this._EmploymentContractor;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EmploymentContractor> _EmploymentContractor;
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
        /// <summary>
        /// There are no comments for EmploymentDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EmploymentDetail> EmploymentDetails
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EmploymentDetails == null))
                {
                    this._EmploymentDetails = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EmploymentDetail>(GetPath("EmploymentDetails"));
                }
                return this._EmploymentDetails;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EmploymentDetail> _EmploymentDetails;
        /// <summary>
        /// There are no comments for RegulatoryEstablishmentDetail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishmentDetailSingle RegulatoryEstablishmentDetail
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RegulatoryEstablishmentDetail == null))
                {
                    this._RegulatoryEstablishmentDetail = new global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishmentDetailSingle(this.Context, GetPath("RegulatoryEstablishmentDetail"));
                }
                return this._RegulatoryEstablishmentDetail;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishmentDetailSingle _RegulatoryEstablishmentDetail;
        /// <summary>
        /// There are no comments for Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle Worker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Worker == null))
                {
                    this._Worker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("Worker"));
                }
                return this._Worker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _Worker;
        /// <summary>
        /// There are no comments for DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSetSingle DimensionSet
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionSet == null))
                {
                    this._DimensionSet = new global::Microsoft.Dynamics.DataEntities.DimensionSetSingle(this.Context, GetPath("DimensionSet"));
                }
                return this._DimensionSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSetSingle _DimensionSet;
    }
        /// <summary>
        /// There are no comments for Employment in the schema.
        /// </summary>
    /// <KeyProperties>
    /// PersonnelNumber
    /// LegalEntityId
    /// EmploymentStartDate
    /// EmploymentEndDate
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PersonnelNumber", "LegalEntityId", "EmploymentStartDate", "EmploymentEndDate")]
    [global::Microsoft.OData.Client.EntitySet("Employments")]
    public partial class Employment : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Employment object.
        /// </summary>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        /// <param name="employmentStartDate">Initial value of EmploymentStartDate.</param>
        /// <param name="employmentEndDate">Initial value of EmploymentEndDate.</param>
        /// <param name="worker">Initial value of Worker.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Employment CreateEmployment(string personnelNumber, string legalEntityId, global::System.DateTimeOffset employmentStartDate, global::System.DateTimeOffset employmentEndDate, global::Microsoft.Dynamics.DataEntities.Worker worker)
        {
            Employment employment = new Employment();
            employment.PersonnelNumber = personnelNumber;
            employment.LegalEntityId = legalEntityId;
            employment.EmploymentStartDate = employmentStartDate;
            employment.EmploymentEndDate = employmentEndDate;
            if ((worker == null))
            {
                throw new global::System.ArgumentNullException("worker");
            }
            employment.Worker = worker;
            return employment;
        }
        /// <summary>
        /// There are no comments for Property PersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PersonnelNumber
        {
            get
            {
                return this._PersonnelNumber;
            }
            set
            {
                this.OnPersonnelNumberChanging(value);
                this._PersonnelNumber = value;
                this.OnPersonnelNumberChanged();
                this.OnPropertyChanged("PersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonnelNumber;
        partial void OnPersonnelNumberChanging(string value);
        partial void OnPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property LegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LegalEntityId
        {
            get
            {
                return this._LegalEntityId;
            }
            set
            {
                this.OnLegalEntityIdChanging(value);
                this._LegalEntityId = value;
                this.OnLegalEntityIdChanged();
                this.OnPropertyChanged("LegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalEntityId;
        partial void OnLegalEntityIdChanging(string value);
        partial void OnLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property EmploymentStartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset EmploymentStartDate
        {
            get
            {
                return this._EmploymentStartDate;
            }
            set
            {
                this.OnEmploymentStartDateChanging(value);
                this._EmploymentStartDate = value;
                this.OnEmploymentStartDateChanged();
                this.OnPropertyChanged("EmploymentStartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EmploymentStartDate;
        partial void OnEmploymentStartDateChanging(global::System.DateTimeOffset value);
        partial void OnEmploymentStartDateChanged();
        /// <summary>
        /// There are no comments for Property EmploymentEndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset EmploymentEndDate
        {
            get
            {
                return this._EmploymentEndDate;
            }
            set
            {
                this.OnEmploymentEndDateChanging(value);
                this._EmploymentEndDate = value;
                this.OnEmploymentEndDateChanged();
                this.OnPropertyChanged("EmploymentEndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EmploymentEndDate;
        partial void OnEmploymentEndDateChanging(global::System.DateTimeOffset value);
        partial void OnEmploymentEndDateChanged();
        /// <summary>
        /// There are no comments for Property DimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DimensionDisplayValue
        {
            get
            {
                return this._DimensionDisplayValue;
            }
            set
            {
                this.OnDimensionDisplayValueChanging(value);
                this._DimensionDisplayValue = value;
                this.OnDimensionDisplayValueChanged();
                this.OnPropertyChanged("DimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DimensionDisplayValue;
        partial void OnDimensionDisplayValueChanging(string value);
        partial void OnDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property RegulatoryEstablishmentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RegulatoryEstablishmentId
        {
            get
            {
                return this._RegulatoryEstablishmentId;
            }
            set
            {
                this.OnRegulatoryEstablishmentIdChanging(value);
                this._RegulatoryEstablishmentId = value;
                this.OnRegulatoryEstablishmentIdChanged();
                this.OnPropertyChanged("RegulatoryEstablishmentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RegulatoryEstablishmentId;
        partial void OnRegulatoryEstablishmentIdChanging(string value);
        partial void OnRegulatoryEstablishmentIdChanged();
        /// <summary>
        /// There are no comments for Property WorkerType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmEmploymentType> WorkerType
        {
            get
            {
                return this._WorkerType;
            }
            set
            {
                this.OnWorkerTypeChanging(value);
                this._WorkerType = value;
                this.OnWorkerTypeChanged();
                this.OnPropertyChanged("WorkerType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmEmploymentType> _WorkerType;
        partial void OnWorkerTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmEmploymentType> value);
        partial void OnWorkerTypeChanged();
        /// <summary>
        /// There are no comments for Property CalendarId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CalendarId
        {
            get
            {
                return this._CalendarId;
            }
            set
            {
                this.OnCalendarIdChanging(value);
                this._CalendarId = value;
                this.OnCalendarIdChanged();
                this.OnPropertyChanged("CalendarId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CalendarId;
        partial void OnCalendarIdChanging(string value);
        partial void OnCalendarIdChanged();
        /// <summary>
        /// There are no comments for Property EmploymentContractor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentContractor> EmploymentContractor
        {
            get
            {
                return this._EmploymentContractor;
            }
            set
            {
                this.OnEmploymentContractorChanging(value);
                this._EmploymentContractor = value;
                this.OnEmploymentContractorChanged();
                this.OnPropertyChanged("EmploymentContractor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentContractor> _EmploymentContractor = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentContractor>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEmploymentContractorChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentContractor> value);
        partial void OnEmploymentContractorChanged();
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
        /// There are no comments for Property EmploymentDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentDetail> EmploymentDetails
        {
            get
            {
                return this._EmploymentDetails;
            }
            set
            {
                this.OnEmploymentDetailsChanging(value);
                this._EmploymentDetails = value;
                this.OnEmploymentDetailsChanged();
                this.OnPropertyChanged("EmploymentDetails");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentDetail> _EmploymentDetails = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentDetail>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEmploymentDetailsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EmploymentDetail> value);
        partial void OnEmploymentDetailsChanged();
        /// <summary>
        /// There are no comments for Property RegulatoryEstablishmentDetail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishmentDetail RegulatoryEstablishmentDetail
        {
            get
            {
                return this._RegulatoryEstablishmentDetail;
            }
            set
            {
                this.OnRegulatoryEstablishmentDetailChanging(value);
                this._RegulatoryEstablishmentDetail = value;
                this.OnRegulatoryEstablishmentDetailChanged();
                this.OnPropertyChanged("RegulatoryEstablishmentDetail");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishmentDetail _RegulatoryEstablishmentDetail;
        partial void OnRegulatoryEstablishmentDetailChanging(global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishmentDetail value);
        partial void OnRegulatoryEstablishmentDetailChanged();
        /// <summary>
        /// There are no comments for Property Worker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Worker Worker
        {
            get
            {
                return this._Worker;
            }
            set
            {
                this.OnWorkerChanging(value);
                this._Worker = value;
                this.OnWorkerChanged();
                this.OnPropertyChanged("Worker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _Worker;
        partial void OnWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnWorkerChanged();
        /// <summary>
        /// There are no comments for Property DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSet DimensionSet
        {
            get
            {
                return this._DimensionSet;
            }
            set
            {
                this.OnDimensionSetChanging(value);
                this._DimensionSet = value;
                this.OnDimensionSetChanged();
                this.OnPropertyChanged("DimensionSet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSet _DimensionSet;
        partial void OnDimensionSetChanging(global::Microsoft.Dynamics.DataEntities.DimensionSet value);
        partial void OnDimensionSetChanged();
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
