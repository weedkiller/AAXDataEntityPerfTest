﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 10/4/2020 2:24:13 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for JournalTableSingle in the schema.
    /// </summary>
    public partial class JournalTableSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<JournalTable>
    {
        /// <summary>
        /// Initialize a new JournalTableSingle object.
        /// </summary>
        public JournalTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new JournalTableSingle object.
        /// </summary>
        public JournalTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new JournalTableSingle object.
        /// </summary>
        public JournalTableSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<JournalTable> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for JournalLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BeginningBalanceFeeTransaction> JournalLines
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JournalLines == null))
                {
                    this._JournalLines = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BeginningBalanceFeeTransaction>(GetPath("JournalLines"));
                }
                return this._JournalLines;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BeginningBalanceFeeTransaction> _JournalLines;
        /// <summary>
        /// There are no comments for JournalTrans in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JournalTrans> JournalTrans
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JournalTrans == null))
                {
                    this._JournalTrans = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.JournalTrans>(GetPath("JournalTrans"));
                }
                return this._JournalTrans;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JournalTrans> _JournalTrans;
    }
    /// <summary>
    /// There are no comments for JournalTable in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// JournalBatchNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "JournalBatchNumber")]
    [global::Microsoft.OData.Client.EntitySet("JournalTables")]
    public partial class JournalTable : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new JournalTable object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="journalBatchNumber">Initial value of JournalBatchNumber.</param>
        /// <param name="projectDate">Initial value of ProjectDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static JournalTable CreateJournalTable(string dataAreaId, string journalBatchNumber, global::System.DateTimeOffset projectDate)
        {
            JournalTable journalTable = new JournalTable();
            journalTable.dataAreaId = dataAreaId;
            journalTable.JournalBatchNumber = journalBatchNumber;
            journalTable.ProjectDate = projectDate;
            return journalTable;
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
        /// There are no comments for Property JournalBatchNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JournalBatchNumber
        {
            get
            {
                return this._JournalBatchNumber;
            }
            set
            {
                this.OnJournalBatchNumberChanging(value);
                this._JournalBatchNumber = value;
                this.OnJournalBatchNumberChanged();
                this.OnPropertyChanged("JournalBatchNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalBatchNumber;
        partial void OnJournalBatchNumberChanging(string value);
        partial void OnJournalBatchNumberChanged();
        /// <summary>
        /// There are no comments for Property Txt in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Txt
        {
            get
            {
                return this._Txt;
            }
            set
            {
                this.OnTxtChanging(value);
                this._Txt = value;
                this.OnTxtChanged();
                this.OnPropertyChanged("Txt");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Txt;
        partial void OnTxtChanging(string value);
        partial void OnTxtChanged();
        /// <summary>
        /// There are no comments for Property SetVoucherDateTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjJournalVoucherDateChange> SetVoucherDateTo
        {
            get
            {
                return this._SetVoucherDateTo;
            }
            set
            {
                this.OnSetVoucherDateToChanging(value);
                this._SetVoucherDateTo = value;
                this.OnSetVoucherDateToChanged();
                this.OnPropertyChanged("SetVoucherDateTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjJournalVoucherDateChange> _SetVoucherDateTo;
        partial void OnSetVoucherDateToChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjJournalVoucherDateChange> value);
        partial void OnSetVoucherDateToChanged();
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
        /// There are no comments for Property JournalName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JournalName
        {
            get
            {
                return this._JournalName;
            }
            set
            {
                this.OnJournalNameChanging(value);
                this._JournalName = value;
                this.OnJournalNameChanged();
                this.OnPropertyChanged("JournalName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalName;
        partial void OnJournalNameChanging(string value);
        partial void OnJournalNameChanged();
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
        /// There are no comments for Property ResourceId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ResourceId
        {
            get
            {
                return this._ResourceId;
            }
            set
            {
                this.OnResourceIdChanging(value);
                this._ResourceId = value;
                this.OnResourceIdChanged();
                this.OnPropertyChanged("ResourceId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ResourceId;
        partial void OnResourceIdChanging(string value);
        partial void OnResourceIdChanged();
        /// <summary>
        /// There are no comments for Property DetailSummary in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DetailSummary> DetailSummary
        {
            get
            {
                return this._DetailSummary;
            }
            set
            {
                this.OnDetailSummaryChanging(value);
                this._DetailSummary = value;
                this.OnDetailSummaryChanged();
                this.OnPropertyChanged("DetailSummary");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DetailSummary> _DetailSummary;
        partial void OnDetailSummaryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DetailSummary> value);
        partial void OnDetailSummaryChanged();
        /// <summary>
        /// There are no comments for Property JournalType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjJournalType> JournalType
        {
            get
            {
                return this._JournalType;
            }
            set
            {
                this.OnJournalTypeChanging(value);
                this._JournalType = value;
                this.OnJournalTypeChanged();
                this.OnPropertyChanged("JournalType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjJournalType> _JournalType;
        partial void OnJournalTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjJournalType> value);
        partial void OnJournalTypeChanged();
        /// <summary>
        /// There are no comments for Property NewVoucherBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjJournalVoucherChange> NewVoucherBy
        {
            get
            {
                return this._NewVoucherBy;
            }
            set
            {
                this.OnNewVoucherByChanging(value);
                this._NewVoucherBy = value;
                this.OnNewVoucherByChanged();
                this.OnPropertyChanged("NewVoucherBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjJournalVoucherChange> _NewVoucherBy;
        partial void OnNewVoucherByChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ProjJournalVoucherChange> value);
        partial void OnNewVoucherByChanged();
        /// <summary>
        /// There are no comments for Property ProjCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProjCategory
        {
            get
            {
                return this._ProjCategory;
            }
            set
            {
                this.OnProjCategoryChanging(value);
                this._ProjCategory = value;
                this.OnProjCategoryChanged();
                this.OnPropertyChanged("ProjCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjCategory;
        partial void OnProjCategoryChanging(string value);
        partial void OnProjCategoryChanged();
        /// <summary>
        /// There are no comments for Property ProjectDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ProjectDate
        {
            get
            {
                return this._ProjectDate;
            }
            set
            {
                this.OnProjectDateChanging(value);
                this._ProjectDate = value;
                this.OnProjectDateChanged();
                this.OnPropertyChanged("ProjectDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ProjectDate;
        partial void OnProjectDateChanging(global::System.DateTimeOffset value);
        partial void OnProjectDateChanged();
        /// <summary>
        /// There are no comments for Property DeleteLinesAfterPosting in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> DeleteLinesAfterPosting
        {
            get
            {
                return this._DeleteLinesAfterPosting;
            }
            set
            {
                this.OnDeleteLinesAfterPostingChanging(value);
                this._DeleteLinesAfterPosting = value;
                this.OnDeleteLinesAfterPostingChanged();
                this.OnPropertyChanged("DeleteLinesAfterPosting");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _DeleteLinesAfterPosting;
        partial void OnDeleteLinesAfterPostingChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnDeleteLinesAfterPostingChanged();
        /// <summary>
        /// There are no comments for Property SelectionBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.JournalVoucherDraw> SelectionBy
        {
            get
            {
                return this._SelectionBy;
            }
            set
            {
                this.OnSelectionByChanging(value);
                this._SelectionBy = value;
                this.OnSelectionByChanged();
                this.OnPropertyChanged("SelectionBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.JournalVoucherDraw> _SelectionBy;
        partial void OnSelectionByChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.JournalVoucherDraw> value);
        partial void OnSelectionByChanged();
        /// <summary>
        /// There are no comments for Property ProjLineProperty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProjLineProperty
        {
            get
            {
                return this._ProjLineProperty;
            }
            set
            {
                this.OnProjLinePropertyChanging(value);
                this._ProjLineProperty = value;
                this.OnProjLinePropertyChanged();
                this.OnPropertyChanged("ProjLineProperty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProjLineProperty;
        partial void OnProjLinePropertyChanging(string value);
        partial void OnProjLinePropertyChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Status
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
        private string _Status;
        partial void OnStatusChanging(string value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property PostedUserId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PostedUserId
        {
            get
            {
                return this._PostedUserId;
            }
            set
            {
                this.OnPostedUserIdChanging(value);
                this._PostedUserId = value;
                this.OnPostedUserIdChanged();
                this.OnPropertyChanged("PostedUserId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PostedUserId;
        partial void OnPostedUserIdChanging(string value);
        partial void OnPostedUserIdChanged();
        /// <summary>
        /// There are no comments for Property ResourceCompanyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ResourceCompanyId
        {
            get
            {
                return this._ResourceCompanyId;
            }
            set
            {
                this.OnResourceCompanyIdChanging(value);
                this._ResourceCompanyId = value;
                this.OnResourceCompanyIdChanged();
                this.OnPropertyChanged("ResourceCompanyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ResourceCompanyId;
        partial void OnResourceCompanyIdChanging(string value);
        partial void OnResourceCompanyIdChanged();
        /// <summary>
        /// There are no comments for Property Approve in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Approve
        {
            get
            {
                return this._Approve;
            }
            set
            {
                this.OnApproveChanging(value);
                this._Approve = value;
                this.OnApproveChanged();
                this.OnPropertyChanged("Approve");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Approve;
        partial void OnApproveChanging(string value);
        partial void OnApproveChanged();
        /// <summary>
        /// There are no comments for Property Posted in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Posted
        {
            get
            {
                return this._Posted;
            }
            set
            {
                this.OnPostedChanging(value);
                this._Posted = value;
                this.OnPostedChanged();
                this.OnPropertyChanged("Posted");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Posted;
        partial void OnPostedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPostedChanged();
        /// <summary>
        /// There are no comments for Property NumberSequenceCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string NumberSequenceCode
        {
            get
            {
                return this._NumberSequenceCode;
            }
            set
            {
                this.OnNumberSequenceCodeChanging(value);
                this._NumberSequenceCode = value;
                this.OnNumberSequenceCodeChanged();
                this.OnPropertyChanged("NumberSequenceCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NumberSequenceCode;
        partial void OnNumberSequenceCodeChanging(string value);
        partial void OnNumberSequenceCodeChanged();
        /// <summary>
        /// There are no comments for Property JournalLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BeginningBalanceFeeTransaction> JournalLines
        {
            get
            {
                return this._JournalLines;
            }
            set
            {
                this.OnJournalLinesChanging(value);
                this._JournalLines = value;
                this.OnJournalLinesChanged();
                this.OnPropertyChanged("JournalLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BeginningBalanceFeeTransaction> _JournalLines = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BeginningBalanceFeeTransaction>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnJournalLinesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BeginningBalanceFeeTransaction> value);
        partial void OnJournalLinesChanged();
        /// <summary>
        /// There are no comments for Property JournalTrans in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JournalTrans> JournalTrans
        {
            get
            {
                return this._JournalTrans;
            }
            set
            {
                this.OnJournalTransChanging(value);
                this._JournalTrans = value;
                this.OnJournalTransChanged();
                this.OnPropertyChanged("JournalTrans");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JournalTrans> _JournalTrans = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JournalTrans>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnJournalTransChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JournalTrans> value);
        partial void OnJournalTransChanged();
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