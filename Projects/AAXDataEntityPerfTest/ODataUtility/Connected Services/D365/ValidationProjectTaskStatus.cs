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
        /// There are no comments for ValidationProjectTaskStatusSingle in the schema.
        /// </summary>
    public partial class ValidationProjectTaskStatusSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ValidationProjectTaskStatus>
    {
        /// <summary>
        /// Initialize a new ValidationProjectTaskStatusSingle object.
        /// </summary>
        public ValidationProjectTaskStatusSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ValidationProjectTaskStatusSingle object.
        /// </summary>
        public ValidationProjectTaskStatusSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ValidationProjectTaskStatusSingle object.
        /// </summary>
        public ValidationProjectTaskStatusSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ValidationProjectTaskStatus> query)
            : base(query) {}

    }
        /// <summary>
        /// There are no comments for ValidationProjectTaskStatus in the schema.
        /// </summary>
    /// <KeyProperties>
    /// DataValidationProject_Name
    /// DataValidationProjectTask_LineNumber
    /// LegalEntity
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("DataValidationProject_Name", "DataValidationProjectTask_LineNumber", "LegalEntity")]
    [global::Microsoft.OData.Client.EntitySet("ValidationProjectTaskStatus")]
    public partial class ValidationProjectTaskStatus : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ValidationProjectTaskStatus object.
        /// </summary>
        /// <param name="dataValidationProject_Name">Initial value of DataValidationProject_Name.</param>
        /// <param name="dataValidationProjectTask_LineNumber">Initial value of DataValidationProjectTask_LineNumber.</param>
        /// <param name="legalEntity">Initial value of LegalEntity.</param>
        /// <param name="completedDateTime">Initial value of CompletedDateTime.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ValidationProjectTaskStatus CreateValidationProjectTaskStatus(string dataValidationProject_Name, decimal dataValidationProjectTask_LineNumber, string legalEntity, global::System.DateTimeOffset completedDateTime)
        {
            ValidationProjectTaskStatus validationProjectTaskStatus = new ValidationProjectTaskStatus();
            validationProjectTaskStatus.DataValidationProject_Name = dataValidationProject_Name;
            validationProjectTaskStatus.DataValidationProjectTask_LineNumber = dataValidationProjectTask_LineNumber;
            validationProjectTaskStatus.LegalEntity = legalEntity;
            validationProjectTaskStatus.CompletedDateTime = completedDateTime;
            return validationProjectTaskStatus;
        }
        /// <summary>
        /// There are no comments for Property DataValidationProject_Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DataValidationProject_Name
        {
            get
            {
                return this._DataValidationProject_Name;
            }
            set
            {
                this.OnDataValidationProject_NameChanging(value);
                this._DataValidationProject_Name = value;
                this.OnDataValidationProject_NameChanged();
                this.OnPropertyChanged("DataValidationProject_Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DataValidationProject_Name;
        partial void OnDataValidationProject_NameChanging(string value);
        partial void OnDataValidationProject_NameChanged();
        /// <summary>
        /// There are no comments for Property DataValidationProjectTask_LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal DataValidationProjectTask_LineNumber
        {
            get
            {
                return this._DataValidationProjectTask_LineNumber;
            }
            set
            {
                this.OnDataValidationProjectTask_LineNumberChanging(value);
                this._DataValidationProjectTask_LineNumber = value;
                this.OnDataValidationProjectTask_LineNumberChanged();
                this.OnPropertyChanged("DataValidationProjectTask_LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DataValidationProjectTask_LineNumber;
        partial void OnDataValidationProjectTask_LineNumberChanging(decimal value);
        partial void OnDataValidationProjectTask_LineNumberChanged();
        /// <summary>
        /// There are no comments for Property LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LegalEntity
        {
            get
            {
                return this._LegalEntity;
            }
            set
            {
                this.OnLegalEntityChanging(value);
                this._LegalEntity = value;
                this.OnLegalEntityChanged();
                this.OnPropertyChanged("LegalEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalEntity;
        partial void OnLegalEntityChanging(string value);
        partial void OnLegalEntityChanged();
        /// <summary>
        /// There are no comments for Property CompletedByWorker_PersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CompletedByWorker_PersonnelNumber
        {
            get
            {
                return this._CompletedByWorker_PersonnelNumber;
            }
            set
            {
                this.OnCompletedByWorker_PersonnelNumberChanging(value);
                this._CompletedByWorker_PersonnelNumber = value;
                this.OnCompletedByWorker_PersonnelNumberChanged();
                this.OnPropertyChanged("CompletedByWorker_PersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CompletedByWorker_PersonnelNumber;
        partial void OnCompletedByWorker_PersonnelNumberChanging(string value);
        partial void OnCompletedByWorker_PersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DataValidationTaskStatus> Status
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
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DataValidationTaskStatus> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DataValidationTaskStatus> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property CompletedDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset CompletedDateTime
        {
            get
            {
                return this._CompletedDateTime;
            }
            set
            {
                this.OnCompletedDateTimeChanging(value);
                this._CompletedDateTime = value;
                this.OnCompletedDateTimeChanged();
                this.OnPropertyChanged("CompletedDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _CompletedDateTime;
        partial void OnCompletedDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnCompletedDateTimeChanged();
        /// <summary>
        /// There are no comments for Property DataValidationProjectTask_Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DataValidationProjectTask_Name
        {
            get
            {
                return this._DataValidationProjectTask_Name;
            }
            set
            {
                this.OnDataValidationProjectTask_NameChanging(value);
                this._DataValidationProjectTask_Name = value;
                this.OnDataValidationProjectTask_NameChanged();
                this.OnPropertyChanged("DataValidationProjectTask_Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DataValidationProjectTask_Name;
        partial void OnDataValidationProjectTask_NameChanging(string value);
        partial void OnDataValidationProjectTask_NameChanged();
        /// <summary>
        /// There are no comments for Property ResponsibleWorker_PersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ResponsibleWorker_PersonnelNumber
        {
            get
            {
                return this._ResponsibleWorker_PersonnelNumber;
            }
            set
            {
                this.OnResponsibleWorker_PersonnelNumberChanging(value);
                this._ResponsibleWorker_PersonnelNumber = value;
                this.OnResponsibleWorker_PersonnelNumberChanged();
                this.OnPropertyChanged("ResponsibleWorker_PersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ResponsibleWorker_PersonnelNumber;
        partial void OnResponsibleWorker_PersonnelNumberChanging(string value);
        partial void OnResponsibleWorker_PersonnelNumberChanged();
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
