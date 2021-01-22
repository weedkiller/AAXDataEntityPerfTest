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
        /// There are no comments for CoveredDependentRelationshipSingle in the schema.
        /// </summary>
    public partial class CoveredDependentRelationshipSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CoveredDependentRelationship>
    {
        /// <summary>
        /// Initialize a new CoveredDependentRelationshipSingle object.
        /// </summary>
        public CoveredDependentRelationshipSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CoveredDependentRelationshipSingle object.
        /// </summary>
        public CoveredDependentRelationshipSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CoveredDependentRelationshipSingle object.
        /// </summary>
        public CoveredDependentRelationshipSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CoveredDependentRelationship> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for WorkerEnrolledBenefit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefitSingle WorkerEnrolledBenefit
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WorkerEnrolledBenefit == null))
                {
                    this._WorkerEnrolledBenefit = new global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefitSingle(this.Context, GetPath("WorkerEnrolledBenefit"));
                }
                return this._WorkerEnrolledBenefit;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefitSingle _WorkerEnrolledBenefit;
    }
        /// <summary>
        /// There are no comments for CoveredDependentRelationship in the schema.
        /// </summary>
    /// <KeyProperties>
    /// BenefitId
    /// PersonnelNumber
    /// EnrollmentStart
    /// EnrollmentEnd
    /// RelationshipTypeId
    /// ChildPartyId
    /// PartyRelationshipDataAreaId
    /// PartyRelationshipValidTo
    /// PartyRelationshipValidFrom
    /// ValidFrom
    /// ValidTo
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("BenefitId", "PersonnelNumber", "EnrollmentStart", "EnrollmentEnd", "RelationshipTypeId", "ChildPartyId", "PartyRelationshipDataAreaId", "PartyRelationshipValidTo", "PartyRelationshipValidFrom", "ValidFrom", "ValidTo")]
    [global::Microsoft.OData.Client.EntitySet("CoveredDependentRelationships")]
    public partial class CoveredDependentRelationship : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CoveredDependentRelationship object.
        /// </summary>
        /// <param name="benefitId">Initial value of BenefitId.</param>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="enrollmentStart">Initial value of EnrollmentStart.</param>
        /// <param name="enrollmentEnd">Initial value of EnrollmentEnd.</param>
        /// <param name="relationshipTypeId">Initial value of RelationshipTypeId.</param>
        /// <param name="childPartyId">Initial value of ChildPartyId.</param>
        /// <param name="partyRelationshipDataAreaId">Initial value of PartyRelationshipDataAreaId.</param>
        /// <param name="partyRelationshipValidTo">Initial value of PartyRelationshipValidTo.</param>
        /// <param name="partyRelationshipValidFrom">Initial value of PartyRelationshipValidFrom.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="workerEnrolledBenefit">Initial value of WorkerEnrolledBenefit.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CoveredDependentRelationship CreateCoveredDependentRelationship(string benefitId, 
                    string personnelNumber, 
                    global::System.DateTimeOffset enrollmentStart, 
                    global::System.DateTimeOffset enrollmentEnd, 
                    string relationshipTypeId, 
                    string childPartyId, 
                    string partyRelationshipDataAreaId, 
                    global::System.DateTimeOffset partyRelationshipValidTo, 
                    global::System.DateTimeOffset partyRelationshipValidFrom, 
                    global::System.DateTimeOffset validFrom, 
                    global::System.DateTimeOffset validTo, 
                    global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefit workerEnrolledBenefit)
        {
            CoveredDependentRelationship coveredDependentRelationship = new CoveredDependentRelationship();
            coveredDependentRelationship.BenefitId = benefitId;
            coveredDependentRelationship.PersonnelNumber = personnelNumber;
            coveredDependentRelationship.EnrollmentStart = enrollmentStart;
            coveredDependentRelationship.EnrollmentEnd = enrollmentEnd;
            coveredDependentRelationship.RelationshipTypeId = relationshipTypeId;
            coveredDependentRelationship.ChildPartyId = childPartyId;
            coveredDependentRelationship.PartyRelationshipDataAreaId = partyRelationshipDataAreaId;
            coveredDependentRelationship.PartyRelationshipValidTo = partyRelationshipValidTo;
            coveredDependentRelationship.PartyRelationshipValidFrom = partyRelationshipValidFrom;
            coveredDependentRelationship.ValidFrom = validFrom;
            coveredDependentRelationship.ValidTo = validTo;
            if ((workerEnrolledBenefit == null))
            {
                throw new global::System.ArgumentNullException("workerEnrolledBenefit");
            }
            coveredDependentRelationship.WorkerEnrolledBenefit = workerEnrolledBenefit;
            return coveredDependentRelationship;
        }
        /// <summary>
        /// There are no comments for Property BenefitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BenefitId
        {
            get
            {
                return this._BenefitId;
            }
            set
            {
                this.OnBenefitIdChanging(value);
                this._BenefitId = value;
                this.OnBenefitIdChanged();
                this.OnPropertyChanged("BenefitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BenefitId;
        partial void OnBenefitIdChanging(string value);
        partial void OnBenefitIdChanged();
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
        /// There are no comments for Property EnrollmentStart in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset EnrollmentStart
        {
            get
            {
                return this._EnrollmentStart;
            }
            set
            {
                this.OnEnrollmentStartChanging(value);
                this._EnrollmentStart = value;
                this.OnEnrollmentStartChanged();
                this.OnPropertyChanged("EnrollmentStart");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EnrollmentStart;
        partial void OnEnrollmentStartChanging(global::System.DateTimeOffset value);
        partial void OnEnrollmentStartChanged();
        /// <summary>
        /// There are no comments for Property EnrollmentEnd in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset EnrollmentEnd
        {
            get
            {
                return this._EnrollmentEnd;
            }
            set
            {
                this.OnEnrollmentEndChanging(value);
                this._EnrollmentEnd = value;
                this.OnEnrollmentEndChanged();
                this.OnPropertyChanged("EnrollmentEnd");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _EnrollmentEnd;
        partial void OnEnrollmentEndChanging(global::System.DateTimeOffset value);
        partial void OnEnrollmentEndChanged();
        /// <summary>
        /// There are no comments for Property RelationshipTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RelationshipTypeId
        {
            get
            {
                return this._RelationshipTypeId;
            }
            set
            {
                this.OnRelationshipTypeIdChanging(value);
                this._RelationshipTypeId = value;
                this.OnRelationshipTypeIdChanged();
                this.OnPropertyChanged("RelationshipTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RelationshipTypeId;
        partial void OnRelationshipTypeIdChanging(string value);
        partial void OnRelationshipTypeIdChanged();
        /// <summary>
        /// There are no comments for Property ChildPartyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ChildPartyId
        {
            get
            {
                return this._ChildPartyId;
            }
            set
            {
                this.OnChildPartyIdChanging(value);
                this._ChildPartyId = value;
                this.OnChildPartyIdChanged();
                this.OnPropertyChanged("ChildPartyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ChildPartyId;
        partial void OnChildPartyIdChanging(string value);
        partial void OnChildPartyIdChanged();
        /// <summary>
        /// There are no comments for Property PartyRelationshipDataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PartyRelationshipDataAreaId
        {
            get
            {
                return this._PartyRelationshipDataAreaId;
            }
            set
            {
                this.OnPartyRelationshipDataAreaIdChanging(value);
                this._PartyRelationshipDataAreaId = value;
                this.OnPartyRelationshipDataAreaIdChanged();
                this.OnPropertyChanged("PartyRelationshipDataAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PartyRelationshipDataAreaId;
        partial void OnPartyRelationshipDataAreaIdChanging(string value);
        partial void OnPartyRelationshipDataAreaIdChanged();
        /// <summary>
        /// There are no comments for Property PartyRelationshipValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset PartyRelationshipValidTo
        {
            get
            {
                return this._PartyRelationshipValidTo;
            }
            set
            {
                this.OnPartyRelationshipValidToChanging(value);
                this._PartyRelationshipValidTo = value;
                this.OnPartyRelationshipValidToChanged();
                this.OnPropertyChanged("PartyRelationshipValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PartyRelationshipValidTo;
        partial void OnPartyRelationshipValidToChanging(global::System.DateTimeOffset value);
        partial void OnPartyRelationshipValidToChanged();
        /// <summary>
        /// There are no comments for Property PartyRelationshipValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset PartyRelationshipValidFrom
        {
            get
            {
                return this._PartyRelationshipValidFrom;
            }
            set
            {
                this.OnPartyRelationshipValidFromChanging(value);
                this._PartyRelationshipValidFrom = value;
                this.OnPartyRelationshipValidFromChanged();
                this.OnPropertyChanged("PartyRelationshipValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _PartyRelationshipValidFrom;
        partial void OnPartyRelationshipValidFromChanging(global::System.DateTimeOffset value);
        partial void OnPartyRelationshipValidFromChanged();
        /// <summary>
        /// There are no comments for Property ValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ValidFrom
        {
            get
            {
                return this._ValidFrom;
            }
            set
            {
                this.OnValidFromChanging(value);
                this._ValidFrom = value;
                this.OnValidFromChanged();
                this.OnPropertyChanged("ValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidFrom;
        partial void OnValidFromChanging(global::System.DateTimeOffset value);
        partial void OnValidFromChanged();
        /// <summary>
        /// There are no comments for Property ValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ValidTo
        {
            get
            {
                return this._ValidTo;
            }
            set
            {
                this.OnValidToChanging(value);
                this._ValidTo = value;
                this.OnValidToChanged();
                this.OnPropertyChanged("ValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidTo;
        partial void OnValidToChanging(global::System.DateTimeOffset value);
        partial void OnValidToChanged();
        /// <summary>
        /// There are no comments for Property WorkerEnrolledBenefit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefit WorkerEnrolledBenefit
        {
            get
            {
                return this._WorkerEnrolledBenefit;
            }
            set
            {
                this.OnWorkerEnrolledBenefitChanging(value);
                this._WorkerEnrolledBenefit = value;
                this.OnWorkerEnrolledBenefitChanged();
                this.OnPropertyChanged("WorkerEnrolledBenefit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefit _WorkerEnrolledBenefit;
        partial void OnWorkerEnrolledBenefitChanging(global::Microsoft.Dynamics.DataEntities.WorkerEnrolledBenefit value);
        partial void OnWorkerEnrolledBenefitChanged();
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
