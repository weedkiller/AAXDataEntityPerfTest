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
    /// There are no comments for RDeferralsBookTableSingle in the schema.
    /// </summary>
    public partial class RDeferralsBookTableSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RDeferralsBookTable>
    {
        /// <summary>
        /// Initialize a new RDeferralsBookTableSingle object.
        /// </summary>
        public RDeferralsBookTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RDeferralsBookTableSingle object.
        /// </summary>
        public RDeferralsBookTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RDeferralsBookTableSingle object.
        /// </summary>
        public RDeferralsBookTableSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RDeferralsBookTable> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for RDeferralsBookTable in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ModelNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ModelNumber")]
    [global::Microsoft.OData.Client.EntitySet("RDeferralsBookTables")]
    public partial class RDeferralsBookTable : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RDeferralsBookTable object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="modelNumber">Initial value of ModelNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RDeferralsBookTable CreateRDeferralsBookTable(string dataAreaId, string modelNumber)
        {
            RDeferralsBookTable rDeferralsBookTable = new RDeferralsBookTable();
            rDeferralsBookTable.dataAreaId = dataAreaId;
            rDeferralsBookTable.ModelNumber = modelNumber;
            return rDeferralsBookTable;
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
        /// There are no comments for Property ModelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ModelNumber
        {
            get
            {
                return this._ModelNumber;
            }
            set
            {
                this.OnModelNumberChanging(value);
                this._ModelNumber = value;
                this.OnModelNumberChanged();
                this.OnPropertyChanged("ModelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ModelNumber;
        partial void OnModelNumberChanging(string value);
        partial void OnModelNumberChanged();
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
        /// There are no comments for Property PostingLayer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrentOperationsTax> PostingLayer
        {
            get
            {
                return this._PostingLayer;
            }
            set
            {
                this.OnPostingLayerChanging(value);
                this._PostingLayer = value;
                this.OnPostingLayerChanged();
                this.OnPropertyChanged("PostingLayer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrentOperationsTax> _PostingLayer;
        partial void OnPostingLayerChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.CurrentOperationsTax> value);
        partial void OnPostingLayerChanged();
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