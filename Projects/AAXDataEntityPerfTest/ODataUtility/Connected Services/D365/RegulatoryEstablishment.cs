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
        /// There are no comments for RegulatoryEstablishmentSingle in the schema.
        /// </summary>
    public partial class RegulatoryEstablishmentSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RegulatoryEstablishment>
    {
        /// <summary>
        /// Initialize a new RegulatoryEstablishmentSingle object.
        /// </summary>
        public RegulatoryEstablishmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RegulatoryEstablishmentSingle object.
        /// </summary>
        public RegulatoryEstablishmentSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RegulatoryEstablishmentSingle object.
        /// </summary>
        public RegulatoryEstablishmentSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RegulatoryEstablishment> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EstablishmentDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishmentDetail> EstablishmentDetails
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EstablishmentDetails == null))
                {
                    this._EstablishmentDetails = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishmentDetail>(GetPath("EstablishmentDetails"));
                }
                return this._EstablishmentDetails;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishmentDetail> _EstablishmentDetails;
    }
        /// <summary>
        /// There are no comments for RegulatoryEstablishment in the schema.
        /// </summary>
    /// <KeyProperties>
    /// RegulatoryEstablishmentId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("RegulatoryEstablishmentId")]
    [global::Microsoft.OData.Client.EntitySet("RegulatoryEstablishments")]
    public partial class RegulatoryEstablishment : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RegulatoryEstablishment object.
        /// </summary>
        /// <param name="regulatoryEstablishmentId">Initial value of RegulatoryEstablishmentId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RegulatoryEstablishment CreateRegulatoryEstablishment(string regulatoryEstablishmentId)
        {
            RegulatoryEstablishment regulatoryEstablishment = new RegulatoryEstablishment();
            regulatoryEstablishment.RegulatoryEstablishmentId = regulatoryEstablishmentId;
            return regulatoryEstablishment;
        }
        /// <summary>
        /// There are no comments for Property RegulatoryEstablishmentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RegulatoryEstablishmentId
        {
            get
            {
                return this._RegulatoryEstablishmentId;
            }
            set
            {
                this.OnRegulatoryEstablishmentIdChanging(value);
                this._RegulatoryEstablishmentId = value;
                this.OnRegulatoryEstablishmentIdChanged();
                this.OnPropertyChanged("RegulatoryEstablishmentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RegulatoryEstablishmentId;
        partial void OnRegulatoryEstablishmentIdChanging(string value);
        partial void OnRegulatoryEstablishmentIdChanged();
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
        /// There are no comments for Property EstablishmentDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishmentDetail> EstablishmentDetails
        {
            get
            {
                return this._EstablishmentDetails;
            }
            set
            {
                this.OnEstablishmentDetailsChanging(value);
                this._EstablishmentDetails = value;
                this.OnEstablishmentDetailsChanged();
                this.OnPropertyChanged("EstablishmentDetails");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishmentDetail> _EstablishmentDetails = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishmentDetail>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEstablishmentDetailsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishmentDetail> value);
        partial void OnEstablishmentDetailsChanged();
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
