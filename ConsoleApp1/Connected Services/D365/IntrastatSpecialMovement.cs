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
    /// There are no comments for IntrastatSpecialMovementSingle in the schema.
    /// </summary>
    public partial class IntrastatSpecialMovementSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<IntrastatSpecialMovement>
    {
        /// <summary>
        /// Initialize a new IntrastatSpecialMovementSingle object.
        /// </summary>
        public IntrastatSpecialMovementSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new IntrastatSpecialMovementSingle object.
        /// </summary>
        public IntrastatSpecialMovementSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new IntrastatSpecialMovementSingle object.
        /// </summary>
        public IntrastatSpecialMovementSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<IntrastatSpecialMovement> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for IntrastatSpecialMovement in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// SpecialMovement
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "SpecialMovement")]
    [global::Microsoft.OData.Client.EntitySet("IntrastatSpecialMovements")]
    public partial class IntrastatSpecialMovement : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new IntrastatSpecialMovement object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="specialMovement">Initial value of SpecialMovement.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static IntrastatSpecialMovement CreateIntrastatSpecialMovement(string dataAreaId, string specialMovement)
        {
            IntrastatSpecialMovement intrastatSpecialMovement = new IntrastatSpecialMovement();
            intrastatSpecialMovement.dataAreaId = dataAreaId;
            intrastatSpecialMovement.SpecialMovement = specialMovement;
            return intrastatSpecialMovement;
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
        /// There are no comments for Property SpecialMovement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SpecialMovement
        {
            get
            {
                return this._SpecialMovement;
            }
            set
            {
                this.OnSpecialMovementChanging(value);
                this._SpecialMovement = value;
                this.OnSpecialMovementChanged();
                this.OnPropertyChanged("SpecialMovement");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SpecialMovement;
        partial void OnSpecialMovementChanging(string value);
        partial void OnSpecialMovementChanged();
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
