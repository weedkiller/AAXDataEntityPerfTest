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
        /// There are no comments for InjuryFilingAgencySingle in the schema.
        /// </summary>
    public partial class InjuryFilingAgencySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<InjuryFilingAgency>
    {
        /// <summary>
        /// Initialize a new InjuryFilingAgencySingle object.
        /// </summary>
        public InjuryFilingAgencySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new InjuryFilingAgencySingle object.
        /// </summary>
        public InjuryFilingAgencySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new InjuryFilingAgencySingle object.
        /// </summary>
        public InjuryFilingAgencySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<InjuryFilingAgency> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for InjuryIncidentFilingAgency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.InjuryIncidentFilingAgencySingle InjuryIncidentFilingAgency
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._InjuryIncidentFilingAgency == null))
                {
                    this._InjuryIncidentFilingAgency = new global::Microsoft.Dynamics.DataEntities.InjuryIncidentFilingAgencySingle(this.Context, GetPath("InjuryIncidentFilingAgency"));
                }
                return this._InjuryIncidentFilingAgency;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.InjuryIncidentFilingAgencySingle _InjuryIncidentFilingAgency;
    }
        /// <summary>
        /// There are no comments for InjuryFilingAgency in the schema.
        /// </summary>
    /// <KeyProperties>
    /// FilingAgencyId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("FilingAgencyId")]
    [global::Microsoft.OData.Client.EntitySet("InjuryFilingAgencies")]
    public partial class InjuryFilingAgency : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new InjuryFilingAgency object.
        /// </summary>
        /// <param name="filingAgencyId">Initial value of FilingAgencyId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static InjuryFilingAgency CreateInjuryFilingAgency(string filingAgencyId)
        {
            InjuryFilingAgency injuryFilingAgency = new InjuryFilingAgency();
            injuryFilingAgency.FilingAgencyId = filingAgencyId;
            return injuryFilingAgency;
        }
        /// <summary>
        /// There are no comments for Property FilingAgencyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FilingAgencyId
        {
            get
            {
                return this._FilingAgencyId;
            }
            set
            {
                this.OnFilingAgencyIdChanging(value);
                this._FilingAgencyId = value;
                this.OnFilingAgencyIdChanged();
                this.OnPropertyChanged("FilingAgencyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FilingAgencyId;
        partial void OnFilingAgencyIdChanging(string value);
        partial void OnFilingAgencyIdChanged();
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
        /// There are no comments for Property Default in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Default
        {
            get
            {
                return this._Default;
            }
            set
            {
                this.OnDefaultChanging(value);
                this._Default = value;
                this.OnDefaultChanged();
                this.OnPropertyChanged("Default");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Default;
        partial void OnDefaultChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnDefaultChanged();
        /// <summary>
        /// There are no comments for Property InjuryIncidentFilingAgency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.InjuryIncidentFilingAgency InjuryIncidentFilingAgency
        {
            get
            {
                return this._InjuryIncidentFilingAgency;
            }
            set
            {
                this.OnInjuryIncidentFilingAgencyChanging(value);
                this._InjuryIncidentFilingAgency = value;
                this.OnInjuryIncidentFilingAgencyChanged();
                this.OnPropertyChanged("InjuryIncidentFilingAgency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.InjuryIncidentFilingAgency _InjuryIncidentFilingAgency;
        partial void OnInjuryIncidentFilingAgencyChanging(global::Microsoft.Dynamics.DataEntities.InjuryIncidentFilingAgency value);
        partial void OnInjuryIncidentFilingAgencyChanged();
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
