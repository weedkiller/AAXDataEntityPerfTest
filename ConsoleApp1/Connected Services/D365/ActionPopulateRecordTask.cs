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
    /// There are no comments for ActionPopulateRecordTaskSingle in the schema.
    /// </summary>
    public partial class ActionPopulateRecordTaskSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ActionPopulateRecordTask>
    {
        /// <summary>
        /// Initialize a new ActionPopulateRecordTaskSingle object.
        /// </summary>
        public ActionPopulateRecordTaskSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ActionPopulateRecordTaskSingle object.
        /// </summary>
        public ActionPopulateRecordTaskSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ActionPopulateRecordTaskSingle object.
        /// </summary>
        public ActionPopulateRecordTaskSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ActionPopulateRecordTask> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ActionPopulateRecordTask in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ActionName
    /// Name
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ActionName", "Name")]
    [global::Microsoft.OData.Client.EntitySet("ActionPopulateRecordTasks")]
    public partial class ActionPopulateRecordTask : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ActionPopulateRecordTask object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="actionName">Initial value of ActionName.</param>
        /// <param name="name">Initial value of Name.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ActionPopulateRecordTask CreateActionPopulateRecordTask(string dataAreaId, string actionName, string name)
        {
            ActionPopulateRecordTask actionPopulateRecordTask = new ActionPopulateRecordTask();
            actionPopulateRecordTask.dataAreaId = dataAreaId;
            actionPopulateRecordTask.ActionName = actionName;
            actionPopulateRecordTask.Name = name;
            return actionPopulateRecordTask;
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
        /// There are no comments for Property ActionName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ActionName
        {
            get
            {
                return this._ActionName;
            }
            set
            {
                this.OnActionNameChanging(value);
                this._ActionName = value;
                this.OnActionNameChanged();
                this.OnPropertyChanged("ActionName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ActionName;
        partial void OnActionNameChanging(string value);
        partial void OnActionNameChanged();
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
        /// There are no comments for Property QueryDataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string QueryDataAreaId
        {
            get
            {
                return this._QueryDataAreaId;
            }
            set
            {
                this.OnQueryDataAreaIdChanging(value);
                this._QueryDataAreaId = value;
                this.OnQueryDataAreaIdChanged();
                this.OnPropertyChanged("QueryDataAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _QueryDataAreaId;
        partial void OnQueryDataAreaIdChanging(string value);
        partial void OnQueryDataAreaIdChanged();
        /// <summary>
        /// There are no comments for Property PackQuery in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PackQuery
        {
            get
            {
                return this._PackQuery;
            }
            set
            {
                this.OnPackQueryChanging(value);
                this._PackQuery = value;
                this.OnPackQueryChanged();
                this.OnPropertyChanged("PackQuery");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PackQuery;
        partial void OnPackQueryChanging(string value);
        partial void OnPackQueryChanged();
        /// <summary>
        /// There are no comments for Property MessageItemType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MessageItemType
        {
            get
            {
                return this._MessageItemType;
            }
            set
            {
                this.OnMessageItemTypeChanging(value);
                this._MessageItemType = value;
                this.OnMessageItemTypeChanged();
                this.OnPropertyChanged("MessageItemType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MessageItemType;
        partial void OnMessageItemTypeChanging(string value);
        partial void OnMessageItemTypeChanged();
        /// <summary>
        /// There are no comments for Property ItemDateFieldName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ItemDateFieldName
        {
            get
            {
                return this._ItemDateFieldName;
            }
            set
            {
                this.OnItemDateFieldNameChanging(value);
                this._ItemDateFieldName = value;
                this.OnItemDateFieldNameChanged();
                this.OnPropertyChanged("ItemDateFieldName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemDateFieldName;
        partial void OnItemDateFieldNameChanging(string value);
        partial void OnItemDateFieldNameChanged();
        /// <summary>
        /// There are no comments for Property MasterTableName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MasterTableName
        {
            get
            {
                return this._MasterTableName;
            }
            set
            {
                this.OnMasterTableNameChanging(value);
                this._MasterTableName = value;
                this.OnMasterTableNameChanged();
                this.OnPropertyChanged("MasterTableName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MasterTableName;
        partial void OnMasterTableNameChanging(string value);
        partial void OnMasterTableNameChanged();
        /// <summary>
        /// There are no comments for Property ItemNumberFieldName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ItemNumberFieldName
        {
            get
            {
                return this._ItemNumberFieldName;
            }
            set
            {
                this.OnItemNumberFieldNameChanging(value);
                this._ItemNumberFieldName = value;
                this.OnItemNumberFieldNameChanged();
                this.OnPropertyChanged("ItemNumberFieldName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemNumberFieldName;
        partial void OnItemNumberFieldNameChanging(string value);
        partial void OnItemNumberFieldNameChanged();
        /// <summary>
        /// There are no comments for Property PackedQuery in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual byte[] PackedQuery
        {
            get
            {
                return this._PackedQuery;
            }
            set
            {
                this.OnPackedQueryChanging(value);
                this._PackedQuery = value;
                this.OnPackedQueryChanged();
                this.OnPropertyChanged("PackedQuery");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private byte[] _PackedQuery;
        partial void OnPackedQueryChanging(byte[] value);
        partial void OnPackedQueryChanged();
        /// <summary>
        /// There are no comments for Property AccountType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EMAccountType> AccountType
        {
            get
            {
                return this._AccountType;
            }
            set
            {
                this.OnAccountTypeChanging(value);
                this._AccountType = value;
                this.OnAccountTypeChanged();
                this.OnPropertyChanged("AccountType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EMAccountType> _AccountType;
        partial void OnAccountTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EMAccountType> value);
        partial void OnAccountTypeChanged();
        /// <summary>
        /// There are no comments for Property ItemAccountFieldName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ItemAccountFieldName
        {
            get
            {
                return this._ItemAccountFieldName;
            }
            set
            {
                this.OnItemAccountFieldNameChanging(value);
                this._ItemAccountFieldName = value;
                this.OnItemAccountFieldNameChanged();
                this.OnPropertyChanged("ItemAccountFieldName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemAccountFieldName;
        partial void OnItemAccountFieldNameChanging(string value);
        partial void OnItemAccountFieldNameChanged();
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
