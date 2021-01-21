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
        /// There are no comments for ApplicationSingle in the schema.
        /// </summary>
    public partial class ApplicationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Application>
    {
        /// <summary>
        /// Initialize a new ApplicationSingle object.
        /// </summary>
        public ApplicationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ApplicationSingle object.
        /// </summary>
        public ApplicationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ApplicationSingle object.
        /// </summary>
        public ApplicationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Application> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for HcmApplicant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ApplicantSingle HcmApplicant
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._HcmApplicant == null))
                {
                    this._HcmApplicant = new global::Microsoft.Dynamics.DataEntities.ApplicantSingle(this.Context, GetPath("HcmApplicant"));
                }
                return this._HcmApplicant;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ApplicantSingle _HcmApplicant;
        /// <summary>
        /// There are no comments for Job in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.JobSingle Job
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Job == null))
                {
                    this._Job = new global::Microsoft.Dynamics.DataEntities.JobSingle(this.Context, GetPath("Job"));
                }
                return this._Job;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JobSingle _Job;
        /// <summary>
        /// There are no comments for Department in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DepartmentSingle Department
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Department == null))
                {
                    this._Department = new global::Microsoft.Dynamics.DataEntities.DepartmentSingle(this.Context, GetPath("Department"));
                }
                return this._Department;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DepartmentSingle _Department;
        /// <summary>
        /// There are no comments for ReasonCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReasonCodeSingle ReasonCode
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReasonCode == null))
                {
                    this._ReasonCode = new global::Microsoft.Dynamics.DataEntities.ReasonCodeSingle(this.Context, GetPath("ReasonCode"));
                }
                return this._ReasonCode;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReasonCodeSingle _ReasonCode;
        /// <summary>
        /// There are no comments for SourceMedia in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.MediaSingle SourceMedia
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SourceMedia == null))
                {
                    this._SourceMedia = new global::Microsoft.Dynamics.DataEntities.MediaSingle(this.Context, GetPath("SourceMedia"));
                }
                return this._SourceMedia;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.MediaSingle _SourceMedia;
        /// <summary>
        /// There are no comments for HiringManager in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle HiringManager
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._HiringManager == null))
                {
                    this._HiringManager = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("HiringManager"));
                }
                return this._HiringManager;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _HiringManager;
    }
        /// <summary>
        /// There are no comments for Application in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// Application
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "Application")]
    [global::Microsoft.OData.Client.EntitySet("Applications")]
    public partial class Application : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Application object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="application1">Initial value of Application1.</param>
        /// <param name="travelCost">Initial value of TravelCost.</param>
        /// <param name="otherCost">Initial value of OtherCost.</param>
        /// <param name="expireDate">Initial value of ExpireDate.</param>
        /// <param name="dateOfReceipt">Initial value of DateOfReceipt.</param>
        /// <param name="lodgingCost">Initial value of LodgingCost.</param>
        /// <param name="startDateAndTime">Initial value of StartDateAndTime.</param>
        /// <param name="hcmApplicant">Initial value of HcmApplicant.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Application CreateApplication(string dataAreaId, 
                    string application1, 
                    decimal travelCost, 
                    decimal otherCost, 
                    global::System.DateTimeOffset expireDate, 
                    global::System.DateTimeOffset dateOfReceipt, 
                    decimal lodgingCost, 
                    global::System.DateTimeOffset startDateAndTime, 
                    global::Microsoft.Dynamics.DataEntities.Applicant hcmApplicant)
        {
            Application application = new Application();
            application.dataAreaId = dataAreaId;
            application.Application1 = application1;
            application.TravelCost = travelCost;
            application.OtherCost = otherCost;
            application.ExpireDate = expireDate;
            application.DateOfReceipt = dateOfReceipt;
            application.LodgingCost = lodgingCost;
            application.StartDateAndTime = startDateAndTime;
            if ((hcmApplicant == null))
            {
                throw new global::System.ArgumentNullException("hcmApplicant");
            }
            application.HcmApplicant = hcmApplicant;
            return application;
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
        /// There are no comments for Property Application1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Application")]
        public virtual string Application1
        {
            get
            {
                return this._Application1;
            }
            set
            {
                this.OnApplication1Changing(value);
                this._Application1 = value;
                this.OnApplication1Changed();
                this.OnPropertyChanged("Application");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Application1;
        partial void OnApplication1Changing(string value);
        partial void OnApplication1Changed();
        /// <summary>
        /// There are no comments for Property TravelCost in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal TravelCost
        {
            get
            {
                return this._TravelCost;
            }
            set
            {
                this.OnTravelCostChanging(value);
                this._TravelCost = value;
                this.OnTravelCostChanged();
                this.OnPropertyChanged("TravelCost");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _TravelCost;
        partial void OnTravelCostChanging(decimal value);
        partial void OnTravelCostChanged();
        /// <summary>
        /// There are no comments for Property OtherCost in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal OtherCost
        {
            get
            {
                return this._OtherCost;
            }
            set
            {
                this.OnOtherCostChanging(value);
                this._OtherCost = value;
                this.OnOtherCostChanged();
                this.OnPropertyChanged("OtherCost");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _OtherCost;
        partial void OnOtherCostChanging(decimal value);
        partial void OnOtherCostChanged();
        /// <summary>
        /// There are no comments for Property CorrespondenceAction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmApplicationCorrespondanceAction> CorrespondenceAction
        {
            get
            {
                return this._CorrespondenceAction;
            }
            set
            {
                this.OnCorrespondenceActionChanging(value);
                this._CorrespondenceAction = value;
                this.OnCorrespondenceActionChanged();
                this.OnPropertyChanged("CorrespondenceAction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmApplicationCorrespondanceAction> _CorrespondenceAction;
        partial void OnCorrespondenceActionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmApplicationCorrespondanceAction> value);
        partial void OnCorrespondenceActionChanged();
        /// <summary>
        /// There are no comments for Property ExpireDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ExpireDate
        {
            get
            {
                return this._ExpireDate;
            }
            set
            {
                this.OnExpireDateChanging(value);
                this._ExpireDate = value;
                this.OnExpireDateChanged();
                this.OnPropertyChanged("ExpireDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ExpireDate;
        partial void OnExpireDateChanging(global::System.DateTimeOffset value);
        partial void OnExpireDateChanged();
        /// <summary>
        /// There are no comments for Property RecruitmentProject in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RecruitmentProject
        {
            get
            {
                return this._RecruitmentProject;
            }
            set
            {
                this.OnRecruitmentProjectChanging(value);
                this._RecruitmentProject = value;
                this.OnRecruitmentProjectChanged();
                this.OnPropertyChanged("RecruitmentProject");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RecruitmentProject;
        partial void OnRecruitmentProjectChanging(string value);
        partial void OnRecruitmentProjectChanged();
        /// <summary>
        /// There are no comments for Property JobId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JobId
        {
            get
            {
                return this._JobId;
            }
            set
            {
                this.OnJobIdChanging(value);
                this._JobId = value;
                this.OnJobIdChanged();
                this.OnPropertyChanged("JobId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JobId;
        partial void OnJobIdChanging(string value);
        partial void OnJobIdChanged();
        /// <summary>
        /// There are no comments for Property DateOfReceipt in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset DateOfReceipt
        {
            get
            {
                return this._DateOfReceipt;
            }
            set
            {
                this.OnDateOfReceiptChanging(value);
                this._DateOfReceipt = value;
                this.OnDateOfReceiptChanged();
                this.OnPropertyChanged("DateOfReceipt");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DateOfReceipt;
        partial void OnDateOfReceiptChanging(global::System.DateTimeOffset value);
        partial void OnDateOfReceiptChanged();
        /// <summary>
        /// There are no comments for Property LodgingCost in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal LodgingCost
        {
            get
            {
                return this._LodgingCost;
            }
            set
            {
                this.OnLodgingCostChanging(value);
                this._LodgingCost = value;
                this.OnLodgingCostChanged();
                this.OnPropertyChanged("LodgingCost");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LodgingCost;
        partial void OnLodgingCostChanging(decimal value);
        partial void OnLodgingCostChanged();
        /// <summary>
        /// There are no comments for Property StartDateAndTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset StartDateAndTime
        {
            get
            {
                return this._StartDateAndTime;
            }
            set
            {
                this.OnStartDateAndTimeChanging(value);
                this._StartDateAndTime = value;
                this.OnStartDateAndTimeChanged();
                this.OnPropertyChanged("StartDateAndTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _StartDateAndTime;
        partial void OnStartDateAndTimeChanging(global::System.DateTimeOffset value);
        partial void OnStartDateAndTimeChanged();
        /// <summary>
        /// There are no comments for Property Rating in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmApplicantRating> Rating
        {
            get
            {
                return this._Rating;
            }
            set
            {
                this.OnRatingChanging(value);
                this._Rating = value;
                this.OnRatingChanged();
                this.OnPropertyChanged("Rating");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmApplicantRating> _Rating;
        partial void OnRatingChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmApplicantRating> value);
        partial void OnRatingChanged();
        /// <summary>
        /// There are no comments for Property DepartmentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DepartmentId
        {
            get
            {
                return this._DepartmentId;
            }
            set
            {
                this.OnDepartmentIdChanging(value);
                this._DepartmentId = value;
                this.OnDepartmentIdChanged();
                this.OnPropertyChanged("DepartmentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DepartmentId;
        partial void OnDepartmentIdChanging(string value);
        partial void OnDepartmentIdChanged();
        /// <summary>
        /// There are no comments for Property Media in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Media
        {
            get
            {
                return this._Media;
            }
            set
            {
                this.OnMediaChanging(value);
                this._Media = value;
                this.OnMediaChanged();
                this.OnPropertyChanged("Media");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Media;
        partial void OnMediaChanging(string value);
        partial void OnMediaChanged();
        /// <summary>
        /// There are no comments for Property ReasonCodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ReasonCodeId
        {
            get
            {
                return this._ReasonCodeId;
            }
            set
            {
                this.OnReasonCodeIdChanging(value);
                this._ReasonCodeId = value;
                this.OnReasonCodeIdChanged();
                this.OnPropertyChanged("ReasonCodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReasonCodeId;
        partial void OnReasonCodeIdChanging(string value);
        partial void OnReasonCodeIdChanged();
        /// <summary>
        /// There are no comments for Property CreatedSource in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmApplicationBasketCreatedSource> CreatedSource
        {
            get
            {
                return this._CreatedSource;
            }
            set
            {
                this.OnCreatedSourceChanging(value);
                this._CreatedSource = value;
                this.OnCreatedSourceChanged();
                this.OnPropertyChanged("CreatedSource");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmApplicationBasketCreatedSource> _CreatedSource;
        partial void OnCreatedSourceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmApplicationBasketCreatedSource> value);
        partial void OnCreatedSourceChanged();
        /// <summary>
        /// There are no comments for Property ContactId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ContactId
        {
            get
            {
                return this._ContactId;
            }
            set
            {
                this.OnContactIdChanging(value);
                this._ContactId = value;
                this.OnContactIdChanged();
                this.OnPropertyChanged("ContactId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ContactId;
        partial void OnContactIdChanging(string value);
        partial void OnContactIdChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmApplicationStatus> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmApplicationStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HrmApplicationStatus> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property ApplicantId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ApplicantId
        {
            get
            {
                return this._ApplicantId;
            }
            set
            {
                this.OnApplicantIdChanging(value);
                this._ApplicantId = value;
                this.OnApplicantIdChanged();
                this.OnPropertyChanged("ApplicantId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ApplicantId;
        partial void OnApplicantIdChanging(string value);
        partial void OnApplicantIdChanged();
        /// <summary>
        /// There are no comments for Property HcmApplicant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Applicant HcmApplicant
        {
            get
            {
                return this._HcmApplicant;
            }
            set
            {
                this.OnHcmApplicantChanging(value);
                this._HcmApplicant = value;
                this.OnHcmApplicantChanged();
                this.OnPropertyChanged("HcmApplicant");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Applicant _HcmApplicant;
        partial void OnHcmApplicantChanging(global::Microsoft.Dynamics.DataEntities.Applicant value);
        partial void OnHcmApplicantChanged();
        /// <summary>
        /// There are no comments for Property Job in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Job Job
        {
            get
            {
                return this._Job;
            }
            set
            {
                this.OnJobChanging(value);
                this._Job = value;
                this.OnJobChanged();
                this.OnPropertyChanged("Job");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Job _Job;
        partial void OnJobChanging(global::Microsoft.Dynamics.DataEntities.Job value);
        partial void OnJobChanged();
        /// <summary>
        /// There are no comments for Property Department in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Department Department
        {
            get
            {
                return this._Department;
            }
            set
            {
                this.OnDepartmentChanging(value);
                this._Department = value;
                this.OnDepartmentChanged();
                this.OnPropertyChanged("Department");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Department _Department;
        partial void OnDepartmentChanging(global::Microsoft.Dynamics.DataEntities.Department value);
        partial void OnDepartmentChanged();
        /// <summary>
        /// There are no comments for Property ReasonCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReasonCode ReasonCode
        {
            get
            {
                return this._ReasonCode;
            }
            set
            {
                this.OnReasonCodeChanging(value);
                this._ReasonCode = value;
                this.OnReasonCodeChanged();
                this.OnPropertyChanged("ReasonCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReasonCode _ReasonCode;
        partial void OnReasonCodeChanging(global::Microsoft.Dynamics.DataEntities.ReasonCode value);
        partial void OnReasonCodeChanged();
        /// <summary>
        /// There are no comments for Property SourceMedia in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Media SourceMedia
        {
            get
            {
                return this._SourceMedia;
            }
            set
            {
                this.OnSourceMediaChanging(value);
                this._SourceMedia = value;
                this.OnSourceMediaChanged();
                this.OnPropertyChanged("SourceMedia");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Media _SourceMedia;
        partial void OnSourceMediaChanging(global::Microsoft.Dynamics.DataEntities.Media value);
        partial void OnSourceMediaChanged();
        /// <summary>
        /// There are no comments for Property HiringManager in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Worker HiringManager
        {
            get
            {
                return this._HiringManager;
            }
            set
            {
                this.OnHiringManagerChanging(value);
                this._HiringManager = value;
                this.OnHiringManagerChanged();
                this.OnPropertyChanged("HiringManager");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _HiringManager;
        partial void OnHiringManagerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnHiringManagerChanged();
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
