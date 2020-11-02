﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 9/11/2020 3:24:26 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for LedgerReportIndexZakatEntitySingle in the schema.
    /// </summary>
    public partial class LedgerReportIndexZakatEntitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LedgerReportIndexZakatEntity>
    {
        /// <summary>
        /// Initialize a new LedgerReportIndexZakatEntitySingle object.
        /// </summary>
        public LedgerReportIndexZakatEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LedgerReportIndexZakatEntitySingle object.
        /// </summary>
        public LedgerReportIndexZakatEntitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LedgerReportIndexZakatEntitySingle object.
        /// </summary>
        public LedgerReportIndexZakatEntitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LedgerReportIndexZakatEntity> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for LedgerReportIndexZakatEntity in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ReportType
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ReportType")]
    [global::Microsoft.OData.Client.EntitySet("LedgerReportIndexZakatEntities")]
    public partial class LedgerReportIndexZakatEntity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LedgerReportIndexZakatEntity object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LedgerReportIndexZakatEntity CreateLedgerReportIndexZakatEntity(string dataAreaId)
        {
            LedgerReportIndexZakatEntity ledgerReportIndexZakatEntity = new LedgerReportIndexZakatEntity();
            ledgerReportIndexZakatEntity.dataAreaId = dataAreaId;
            return ledgerReportIndexZakatEntity;
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
        /// There are no comments for Property ReportType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerReportTypeZakat_SA> ReportType
        {
            get
            {
                return this._ReportType;
            }
            set
            {
                this.OnReportTypeChanging(value);
                this._ReportType = value;
                this.OnReportTypeChanged();
                this.OnPropertyChanged("ReportType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerReportTypeZakat_SA> _ReportType;
        partial void OnReportTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.LedgerReportTypeZakat_SA> value);
        partial void OnReportTypeChanged();
        /// <summary>
        /// There are no comments for Property ReportActive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> ReportActive
        {
            get
            {
                return this._ReportActive;
            }
            set
            {
                this.OnReportActiveChanging(value);
                this._ReportActive = value;
                this.OnReportActiveChanged();
                this.OnPropertyChanged("ReportActive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _ReportActive;
        partial void OnReportActiveChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnReportActiveChanged();
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
