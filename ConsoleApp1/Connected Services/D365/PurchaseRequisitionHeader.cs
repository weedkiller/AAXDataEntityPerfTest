﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 10/4/2020 2:55:10 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for PurchaseRequisitionHeaderSingle in the schema.
    /// </summary>
    public partial class PurchaseRequisitionHeaderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PurchaseRequisitionHeader>
    {
        /// <summary>
        /// Initialize a new PurchaseRequisitionHeaderSingle object.
        /// </summary>
        public PurchaseRequisitionHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PurchaseRequisitionHeaderSingle object.
        /// </summary>
        public PurchaseRequisitionHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PurchaseRequisitionHeaderSingle object.
        /// </summary>
        public PurchaseRequisitionHeaderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PurchaseRequisitionHeader> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PurchaseRequisitionLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PurchaseRequisitionLine> PurchaseRequisitionLines
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PurchaseRequisitionLines == null))
                {
                    this._PurchaseRequisitionLines = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PurchaseRequisitionLine>(GetPath("PurchaseRequisitionLines"));
                }
                return this._PurchaseRequisitionLines;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PurchaseRequisitionLine> _PurchaseRequisitionLines;
    }
    /// <summary>
    /// There are no comments for PurchaseRequisitionHeader in the schema.
    /// </summary>
    /// <KeyProperties>
    /// RequisitionNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("RequisitionNumber")]
    [global::Microsoft.OData.Client.EntitySet("PurchaseRequisitionHeaders")]
    public partial class PurchaseRequisitionHeader : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PurchaseRequisitionHeader object.
        /// </summary>
        /// <param name="requisitionNumber">Initial value of RequisitionNumber.</param>
        /// <param name="defaultAccountingDate">Initial value of DefaultAccountingDate.</param>
        /// <param name="defaultRequestedDate">Initial value of DefaultRequestedDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PurchaseRequisitionHeader CreatePurchaseRequisitionHeader(string requisitionNumber, global::System.DateTimeOffset defaultAccountingDate, global::System.DateTimeOffset defaultRequestedDate)
        {
            PurchaseRequisitionHeader purchaseRequisitionHeader = new PurchaseRequisitionHeader();
            purchaseRequisitionHeader.RequisitionNumber = requisitionNumber;
            purchaseRequisitionHeader.DefaultAccountingDate = defaultAccountingDate;
            purchaseRequisitionHeader.DefaultRequestedDate = defaultRequestedDate;
            return purchaseRequisitionHeader;
        }
        /// <summary>
        /// There are no comments for Property RequisitionNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RequisitionNumber
        {
            get
            {
                return this._RequisitionNumber;
            }
            set
            {
                this.OnRequisitionNumberChanging(value);
                this._RequisitionNumber = value;
                this.OnRequisitionNumberChanged();
                this.OnPropertyChanged("RequisitionNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RequisitionNumber;
        partial void OnRequisitionNumberChanging(string value);
        partial void OnRequisitionNumberChanged();
        /// <summary>
        /// There are no comments for Property RequisitionStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PurchReqRequisitionStatus> RequisitionStatus
        {
            get
            {
                return this._RequisitionStatus;
            }
            set
            {
                this.OnRequisitionStatusChanging(value);
                this._RequisitionStatus = value;
                this.OnRequisitionStatusChanged();
                this.OnPropertyChanged("RequisitionStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PurchReqRequisitionStatus> _RequisitionStatus;
        partial void OnRequisitionStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PurchReqRequisitionStatus> value);
        partial void OnRequisitionStatusChanged();
        /// <summary>
        /// There are no comments for Property DefaultAccountingDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset DefaultAccountingDate
        {
            get
            {
                return this._DefaultAccountingDate;
            }
            set
            {
                this.OnDefaultAccountingDateChanging(value);
                this._DefaultAccountingDate = value;
                this.OnDefaultAccountingDateChanged();
                this.OnPropertyChanged("DefaultAccountingDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DefaultAccountingDate;
        partial void OnDefaultAccountingDateChanging(global::System.DateTimeOffset value);
        partial void OnDefaultAccountingDateChanged();
        /// <summary>
        /// There are no comments for Property DefaultBusinessJustificationDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DefaultBusinessJustificationDetails
        {
            get
            {
                return this._DefaultBusinessJustificationDetails;
            }
            set
            {
                this.OnDefaultBusinessJustificationDetailsChanging(value);
                this._DefaultBusinessJustificationDetails = value;
                this.OnDefaultBusinessJustificationDetailsChanged();
                this.OnPropertyChanged("DefaultBusinessJustificationDetails");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultBusinessJustificationDetails;
        partial void OnDefaultBusinessJustificationDetailsChanging(string value);
        partial void OnDefaultBusinessJustificationDetailsChanged();
        /// <summary>
        /// There are no comments for Property DefaultProjectId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DefaultProjectId
        {
            get
            {
                return this._DefaultProjectId;
            }
            set
            {
                this.OnDefaultProjectIdChanging(value);
                this._DefaultProjectId = value;
                this.OnDefaultProjectIdChanged();
                this.OnPropertyChanged("DefaultProjectId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultProjectId;
        partial void OnDefaultProjectIdChanging(string value);
        partial void OnDefaultProjectIdChanged();
        /// <summary>
        /// There are no comments for Property DefaultRequestedDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset DefaultRequestedDate
        {
            get
            {
                return this._DefaultRequestedDate;
            }
            set
            {
                this.OnDefaultRequestedDateChanging(value);
                this._DefaultRequestedDate = value;
                this.OnDefaultRequestedDateChanged();
                this.OnPropertyChanged("DefaultRequestedDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DefaultRequestedDate;
        partial void OnDefaultRequestedDateChanging(global::System.DateTimeOffset value);
        partial void OnDefaultRequestedDateChanged();
        /// <summary>
        /// There are no comments for Property ProjectBuyingLegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProjectBuyingLegalEntityId
        {
            get
            {
                return this._ProjectBuyingLegalEntityId;
            }
            set
            {
                this.OnProjectBuyingLegalEntityIdChanging(value);
                this._ProjectBuyingLegalEntityId = value;
                this.OnProjectBuyingLegalEntityIdChanged();
                this.OnPropertyChanged("ProjectBuyingLegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjectBuyingLegalEntityId;
        partial void OnProjectBuyingLegalEntityIdChanging(string value);
        partial void OnProjectBuyingLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property PreparerPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PreparerPersonnelNumber
        {
            get
            {
                return this._PreparerPersonnelNumber;
            }
            set
            {
                this.OnPreparerPersonnelNumberChanging(value);
                this._PreparerPersonnelNumber = value;
                this.OnPreparerPersonnelNumberChanged();
                this.OnPropertyChanged("PreparerPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PreparerPersonnelNumber;
        partial void OnPreparerPersonnelNumberChanging(string value);
        partial void OnPreparerPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property DefaultBusinessJustificationCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DefaultBusinessJustificationCode
        {
            get
            {
                return this._DefaultBusinessJustificationCode;
            }
            set
            {
                this.OnDefaultBusinessJustificationCodeChanging(value);
                this._DefaultBusinessJustificationCode = value;
                this.OnDefaultBusinessJustificationCodeChanged();
                this.OnPropertyChanged("DefaultBusinessJustificationCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultBusinessJustificationCode;
        partial void OnDefaultBusinessJustificationCodeChanging(string value);
        partial void OnDefaultBusinessJustificationCodeChanged();
        /// <summary>
        /// There are no comments for Property RequisitionName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RequisitionName
        {
            get
            {
                return this._RequisitionName;
            }
            set
            {
                this.OnRequisitionNameChanging(value);
                this._RequisitionName = value;
                this.OnRequisitionNameChanged();
                this.OnPropertyChanged("RequisitionName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RequisitionName;
        partial void OnRequisitionNameChanging(string value);
        partial void OnRequisitionNameChanged();
        /// <summary>
        /// There are no comments for Property OnHoldExplanation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OnHoldExplanation
        {
            get
            {
                return this._OnHoldExplanation;
            }
            set
            {
                this.OnOnHoldExplanationChanging(value);
                this._OnHoldExplanation = value;
                this.OnOnHoldExplanationChanged();
                this.OnPropertyChanged("OnHoldExplanation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OnHoldExplanation;
        partial void OnOnHoldExplanationChanging(string value);
        partial void OnOnHoldExplanationChanged();
        /// <summary>
        /// There are no comments for Property IsPurchaseRequisitionOnHold in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsPurchaseRequisitionOnHold
        {
            get
            {
                return this._IsPurchaseRequisitionOnHold;
            }
            set
            {
                this.OnIsPurchaseRequisitionOnHoldChanging(value);
                this._IsPurchaseRequisitionOnHold = value;
                this.OnIsPurchaseRequisitionOnHoldChanged();
                this.OnPropertyChanged("IsPurchaseRequisitionOnHold");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsPurchaseRequisitionOnHold;
        partial void OnIsPurchaseRequisitionOnHoldChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsPurchaseRequisitionOnHoldChanged();
        /// <summary>
        /// There are no comments for Property RequisitionPurpose in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RequisitionPurpose> RequisitionPurpose
        {
            get
            {
                return this._RequisitionPurpose;
            }
            set
            {
                this.OnRequisitionPurposeChanging(value);
                this._RequisitionPurpose = value;
                this.OnRequisitionPurposeChanged();
                this.OnPropertyChanged("RequisitionPurpose");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RequisitionPurpose> _RequisitionPurpose;
        partial void OnRequisitionPurposeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RequisitionPurpose> value);
        partial void OnRequisitionPurposeChanged();
        /// <summary>
        /// There are no comments for Property PurchaseRequisitionLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PurchaseRequisitionLine> PurchaseRequisitionLines
        {
            get
            {
                return this._PurchaseRequisitionLines;
            }
            set
            {
                this.OnPurchaseRequisitionLinesChanging(value);
                this._PurchaseRequisitionLines = value;
                this.OnPurchaseRequisitionLinesChanged();
                this.OnPropertyChanged("PurchaseRequisitionLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PurchaseRequisitionLine> _PurchaseRequisitionLines = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PurchaseRequisitionLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPurchaseRequisitionLinesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PurchaseRequisitionLine> value);
        partial void OnPurchaseRequisitionLinesChanged();
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