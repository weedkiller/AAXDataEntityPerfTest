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
        /// There are no comments for TotalDiscountCustomerGroupSingle in the schema.
        /// </summary>
    public partial class TotalDiscountCustomerGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TotalDiscountCustomerGroup>
    {
        /// <summary>
        /// Initialize a new TotalDiscountCustomerGroupSingle object.
        /// </summary>
        public TotalDiscountCustomerGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TotalDiscountCustomerGroupSingle object.
        /// </summary>
        public TotalDiscountCustomerGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TotalDiscountCustomerGroupSingle object.
        /// </summary>
        public TotalDiscountCustomerGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TotalDiscountCustomerGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for OpenSalesTotalDiscountJournalLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.OpenSalesTotalDiscountJournalLine> OpenSalesTotalDiscountJournalLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._OpenSalesTotalDiscountJournalLine == null))
                {
                    this._OpenSalesTotalDiscountJournalLine = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.OpenSalesTotalDiscountJournalLine>(GetPath("OpenSalesTotalDiscountJournalLine"));
                }
                return this._OpenSalesTotalDiscountJournalLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.OpenSalesTotalDiscountJournalLine> _OpenSalesTotalDiscountJournalLine;
    }
        /// <summary>
        /// There are no comments for TotalDiscountCustomerGroup in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// GroupCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "GroupCode")]
    [global::Microsoft.OData.Client.EntitySet("TotalDiscountCustomerGroups")]
    public partial class TotalDiscountCustomerGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TotalDiscountCustomerGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="groupCode">Initial value of GroupCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TotalDiscountCustomerGroup CreateTotalDiscountCustomerGroup(string dataAreaId, string groupCode)
        {
            TotalDiscountCustomerGroup totalDiscountCustomerGroup = new TotalDiscountCustomerGroup();
            totalDiscountCustomerGroup.dataAreaId = dataAreaId;
            totalDiscountCustomerGroup.GroupCode = groupCode;
            return totalDiscountCustomerGroup;
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
        /// There are no comments for Property OpenSalesTotalDiscountJournalLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OpenSalesTotalDiscountJournalLine> OpenSalesTotalDiscountJournalLine
        {
            get
            {
                return this._OpenSalesTotalDiscountJournalLine;
            }
            set
            {
                this.OnOpenSalesTotalDiscountJournalLineChanging(value);
                this._OpenSalesTotalDiscountJournalLine = value;
                this.OnOpenSalesTotalDiscountJournalLineChanged();
                this.OnPropertyChanged("OpenSalesTotalDiscountJournalLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OpenSalesTotalDiscountJournalLine> _OpenSalesTotalDiscountJournalLine = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OpenSalesTotalDiscountJournalLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnOpenSalesTotalDiscountJournalLineChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OpenSalesTotalDiscountJournalLine> value);
        partial void OnOpenSalesTotalDiscountJournalLineChanged();
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
