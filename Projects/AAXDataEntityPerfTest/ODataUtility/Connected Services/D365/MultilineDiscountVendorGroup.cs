﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 2/4/2021 7:24:30 AM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for MultilineDiscountVendorGroupSingle in the schema.
        /// </summary>
    public partial class MultilineDiscountVendorGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<MultilineDiscountVendorGroup>
    {
        /// <summary>
        /// Initialize a new MultilineDiscountVendorGroupSingle object.
        /// </summary>
        public MultilineDiscountVendorGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new MultilineDiscountVendorGroupSingle object.
        /// </summary>
        public MultilineDiscountVendorGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new MultilineDiscountVendorGroupSingle object.
        /// </summary>
        public MultilineDiscountVendorGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<MultilineDiscountVendorGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for OpenPurchaseMultiLineDiscountJournalLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.OpenPurchaseMultiLineDiscountJournalLine> OpenPurchaseMultiLineDiscountJournalLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._OpenPurchaseMultiLineDiscountJournalLine == null))
                {
                    this._OpenPurchaseMultiLineDiscountJournalLine = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.OpenPurchaseMultiLineDiscountJournalLine>(GetPath("OpenPurchaseMultiLineDiscountJournalLine"));
                }
                return this._OpenPurchaseMultiLineDiscountJournalLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.OpenPurchaseMultiLineDiscountJournalLine> _OpenPurchaseMultiLineDiscountJournalLine;
    }
        /// <summary>
        /// There are no comments for MultilineDiscountVendorGroup in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// GroupCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "GroupCode")]
    [global::Microsoft.OData.Client.EntitySet("MultilineDiscountVendorGroups")]
    public partial class MultilineDiscountVendorGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new MultilineDiscountVendorGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="groupCode">Initial value of GroupCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static MultilineDiscountVendorGroup CreateMultilineDiscountVendorGroup(string dataAreaId, string groupCode)
        {
            MultilineDiscountVendorGroup multilineDiscountVendorGroup = new MultilineDiscountVendorGroup();
            multilineDiscountVendorGroup.dataAreaId = dataAreaId;
            multilineDiscountVendorGroup.GroupCode = groupCode;
            return multilineDiscountVendorGroup;
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
        /// There are no comments for Property GroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string GroupCode
        {
            get
            {
                return this._GroupCode;
            }
            set
            {
                this.OnGroupCodeChanging(value);
                this._GroupCode = value;
                this.OnGroupCodeChanged();
                this.OnPropertyChanged("GroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupCode;
        partial void OnGroupCodeChanging(string value);
        partial void OnGroupCodeChanged();
        /// <summary>
        /// There are no comments for Property GroupName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string GroupName
        {
            get
            {
                return this._GroupName;
            }
            set
            {
                this.OnGroupNameChanging(value);
                this._GroupName = value;
                this.OnGroupNameChanged();
                this.OnPropertyChanged("GroupName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupName;
        partial void OnGroupNameChanging(string value);
        partial void OnGroupNameChanged();
        /// <summary>
        /// There are no comments for Property OpenPurchaseMultiLineDiscountJournalLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OpenPurchaseMultiLineDiscountJournalLine> OpenPurchaseMultiLineDiscountJournalLine
        {
            get
            {
                return this._OpenPurchaseMultiLineDiscountJournalLine;
            }
            set
            {
                this.OnOpenPurchaseMultiLineDiscountJournalLineChanging(value);
                this._OpenPurchaseMultiLineDiscountJournalLine = value;
                this.OnOpenPurchaseMultiLineDiscountJournalLineChanged();
                this.OnPropertyChanged("OpenPurchaseMultiLineDiscountJournalLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OpenPurchaseMultiLineDiscountJournalLine> _OpenPurchaseMultiLineDiscountJournalLine = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OpenPurchaseMultiLineDiscountJournalLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnOpenPurchaseMultiLineDiscountJournalLineChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OpenPurchaseMultiLineDiscountJournalLine> value);
        partial void OnOpenPurchaseMultiLineDiscountJournalLineChanged();
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
