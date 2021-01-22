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
        /// There are no comments for AAXSalesOrderHeaderV2EntityOnlySalesOrderNumberSingle in the schema.
        /// </summary>
    public partial class AAXSalesOrderHeaderV2EntityOnlySalesOrderNumberSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AAXSalesOrderHeaderV2EntityOnlySalesOrderNumber>
    {
        /// <summary>
        /// Initialize a new AAXSalesOrderHeaderV2EntityOnlySalesOrderNumberSingle object.
        /// </summary>
        public AAXSalesOrderHeaderV2EntityOnlySalesOrderNumberSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AAXSalesOrderHeaderV2EntityOnlySalesOrderNumberSingle object.
        /// </summary>
        public AAXSalesOrderHeaderV2EntityOnlySalesOrderNumberSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AAXSalesOrderHeaderV2EntityOnlySalesOrderNumberSingle object.
        /// </summary>
        public AAXSalesOrderHeaderV2EntityOnlySalesOrderNumberSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AAXSalesOrderHeaderV2EntityOnlySalesOrderNumber> query)
            : base(query) {}

    }
        /// <summary>
        /// There are no comments for AAXSalesOrderHeaderV2EntityOnlySalesOrderNumber in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// SalesOrderNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "SalesOrderNumber")]
    [global::Microsoft.OData.Client.EntitySet("AAXSalesOrderHeaderV2EntityOnlySalesOrderNumbers")]
    public partial class AAXSalesOrderHeaderV2EntityOnlySalesOrderNumber : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AAXSalesOrderHeaderV2EntityOnlySalesOrderNumber object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="salesOrderNumber">Initial value of SalesOrderNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AAXSalesOrderHeaderV2EntityOnlySalesOrderNumber CreateAAXSalesOrderHeaderV2EntityOnlySalesOrderNumber(string dataAreaId, string salesOrderNumber)
        {
            AAXSalesOrderHeaderV2EntityOnlySalesOrderNumber aAXSalesOrderHeaderV2EntityOnlySalesOrderNumber = new AAXSalesOrderHeaderV2EntityOnlySalesOrderNumber();
            aAXSalesOrderHeaderV2EntityOnlySalesOrderNumber.dataAreaId = dataAreaId;
            aAXSalesOrderHeaderV2EntityOnlySalesOrderNumber.SalesOrderNumber = salesOrderNumber;
            return aAXSalesOrderHeaderV2EntityOnlySalesOrderNumber;
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
        /// There are no comments for Property SalesOrderNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SalesOrderNumber
        {
            get
            {
                return this._SalesOrderNumber;
            }
            set
            {
                this.OnSalesOrderNumberChanging(value);
                this._SalesOrderNumber = value;
                this.OnSalesOrderNumberChanged();
                this.OnPropertyChanged("SalesOrderNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SalesOrderNumber;
        partial void OnSalesOrderNumberChanging(string value);
        partial void OnSalesOrderNumberChanged();
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
