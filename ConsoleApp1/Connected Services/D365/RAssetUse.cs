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
    /// There are no comments for RAssetUseSingle in the schema.
    /// </summary>
    public partial class RAssetUseSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RAssetUse>
    {
        /// <summary>
        /// Initialize a new RAssetUseSingle object.
        /// </summary>
        public RAssetUseSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RAssetUseSingle object.
        /// </summary>
        public RAssetUseSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RAssetUseSingle object.
        /// </summary>
        public RAssetUseSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RAssetUse> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RAssetUse in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// FAInventoryNumber
    /// Period
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "FAInventoryNumber", "Period")]
    [global::Microsoft.OData.Client.EntitySet("RAssetUses")]
    public partial class RAssetUse : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RAssetUse object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="fAInventoryNumber">Initial value of FAInventoryNumber.</param>
        /// <param name="period">Initial value of Period.</param>
        /// <param name="outputRunNontaxable">Initial value of OutputRunNontaxable.</param>
        /// <param name="outputRunExport">Initial value of OutputRunExport.</param>
        /// <param name="outputMileage">Initial value of OutputMileage.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RAssetUse CreateRAssetUse(string dataAreaId, 
                    string fAInventoryNumber, 
                    global::System.DateTimeOffset period, 
                    decimal outputRunNontaxable, 
                    decimal outputRunExport, 
                    decimal outputMileage)
        {
            RAssetUse rAssetUse = new RAssetUse();
            rAssetUse.dataAreaId = dataAreaId;
            rAssetUse.FAInventoryNumber = fAInventoryNumber;
            rAssetUse.Period = period;
            rAssetUse.OutputRunNontaxable = outputRunNontaxable;
            rAssetUse.OutputRunExport = outputRunExport;
            rAssetUse.OutputMileage = outputMileage;
            return rAssetUse;
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
        /// There are no comments for Property FAInventoryNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FAInventoryNumber
        {
            get
            {
                return this._FAInventoryNumber;
            }
            set
            {
                this.OnFAInventoryNumberChanging(value);
                this._FAInventoryNumber = value;
                this.OnFAInventoryNumberChanged();
                this.OnPropertyChanged("FAInventoryNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FAInventoryNumber;
        partial void OnFAInventoryNumberChanging(string value);
        partial void OnFAInventoryNumberChanged();
        /// <summary>
        /// There are no comments for Property Period in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset Period
        {
            get
            {
                return this._Period;
            }
            set
            {
                this.OnPeriodChanging(value);
                this._Period = value;
                this.OnPeriodChanged();
                this.OnPropertyChanged("Period");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _Period;
        partial void OnPeriodChanging(global::System.DateTimeOffset value);
        partial void OnPeriodChanged();
        /// <summary>
        /// There are no comments for Property OutputRunNontaxable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal OutputRunNontaxable
        {
            get
            {
                return this._OutputRunNontaxable;
            }
            set
            {
                this.OnOutputRunNontaxableChanging(value);
                this._OutputRunNontaxable = value;
                this.OnOutputRunNontaxableChanged();
                this.OnPropertyChanged("OutputRunNontaxable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _OutputRunNontaxable;
        partial void OnOutputRunNontaxableChanging(decimal value);
        partial void OnOutputRunNontaxableChanged();
        /// <summary>
        /// There are no comments for Property OutputRunExport in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal OutputRunExport
        {
            get
            {
                return this._OutputRunExport;
            }
            set
            {
                this.OnOutputRunExportChanging(value);
                this._OutputRunExport = value;
                this.OnOutputRunExportChanged();
                this.OnPropertyChanged("OutputRunExport");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _OutputRunExport;
        partial void OnOutputRunExportChanging(decimal value);
        partial void OnOutputRunExportChanged();
        /// <summary>
        /// There are no comments for Property OutputMileage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal OutputMileage
        {
            get
            {
                return this._OutputMileage;
            }
            set
            {
                this.OnOutputMileageChanging(value);
                this._OutputMileage = value;
                this.OnOutputMileageChanged();
                this.OnPropertyChanged("OutputMileage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _OutputMileage;
        partial void OnOutputMileageChanging(decimal value);
        partial void OnOutputMileageChanged();
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
