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
        /// There are no comments for TeamMembershipCriterionSingle in the schema.
        /// </summary>
    public partial class TeamMembershipCriterionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TeamMembershipCriterion>
    {
        /// <summary>
        /// Initialize a new TeamMembershipCriterionSingle object.
        /// </summary>
        public TeamMembershipCriterionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TeamMembershipCriterionSingle object.
        /// </summary>
        public TeamMembershipCriterionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TeamMembershipCriterionSingle object.
        /// </summary>
        public TeamMembershipCriterionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TeamMembershipCriterion> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for TeamV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TeamV2> TeamV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TeamV2 == null))
                {
                    this._TeamV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.TeamV2>(GetPath("TeamV2"));
                }
                return this._TeamV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TeamV2> _TeamV2;
        /// <summary>
        /// There are no comments for Team in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Team> Team
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Team == null))
                {
                    this._Team = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Team>(GetPath("Team"));
                }
                return this._Team;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Team> _Team;
    }
        /// <summary>
        /// There are no comments for TeamMembershipCriterion in the schema.
        /// </summary>
    /// <KeyProperties>
    /// Name
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Name")]
    [global::Microsoft.OData.Client.EntitySet("TeamMembershipCriterions")]
    public partial class TeamMembershipCriterion : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TeamMembershipCriterion object.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TeamMembershipCriterion CreateTeamMembershipCriterion(string name)
        {
            TeamMembershipCriterion teamMembershipCriterion = new TeamMembershipCriterion();
            teamMembershipCriterion.Name = name;
            return teamMembershipCriterion;
        }
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
        /// There are no comments for Property AllowVendor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AllowVendor
        {
            get
            {
                return this._AllowVendor;
            }
            set
            {
                this.OnAllowVendorChanging(value);
                this._AllowVendor = value;
                this.OnAllowVendorChanged();
                this.OnPropertyChanged("AllowVendor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AllowVendor;
        partial void OnAllowVendorChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAllowVendorChanged();
        /// <summary>
        /// There are no comments for Property RequiresAXUser in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> RequiresAXUser
        {
            get
            {
                return this._RequiresAXUser;
            }
            set
            {
                this.OnRequiresAXUserChanging(value);
                this._RequiresAXUser = value;
                this.OnRequiresAXUserChanged();
                this.OnPropertyChanged("RequiresAXUser");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _RequiresAXUser;
        partial void OnRequiresAXUserChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnRequiresAXUserChanged();
        /// <summary>
        /// There are no comments for Property AllowContact in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AllowContact
        {
            get
            {
                return this._AllowContact;
            }
            set
            {
                this.OnAllowContactChanging(value);
                this._AllowContact = value;
                this.OnAllowContactChanged();
                this.OnPropertyChanged("AllowContact");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AllowContact;
        partial void OnAllowContactChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAllowContactChanged();
        /// <summary>
        /// There are no comments for Property IsSystemCriterion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsSystemCriterion
        {
            get
            {
                return this._IsSystemCriterion;
            }
            set
            {
                this.OnIsSystemCriterionChanging(value);
                this._IsSystemCriterion = value;
                this.OnIsSystemCriterionChanged();
                this.OnPropertyChanged("IsSystemCriterion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsSystemCriterion;
        partial void OnIsSystemCriterionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsSystemCriterionChanged();
        /// <summary>
        /// There are no comments for Property AllowContractor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AllowContractor
        {
            get
            {
                return this._AllowContractor;
            }
            set
            {
                this.OnAllowContractorChanging(value);
                this._AllowContractor = value;
                this.OnAllowContractorChanged();
                this.OnPropertyChanged("AllowContractor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AllowContractor;
        partial void OnAllowContractorChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAllowContractorChanged();
        /// <summary>
        /// There are no comments for Property AllowEmployee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AllowEmployee
        {
            get
            {
                return this._AllowEmployee;
            }
            set
            {
                this.OnAllowEmployeeChanging(value);
                this._AllowEmployee = value;
                this.OnAllowEmployeeChanged();
                this.OnPropertyChanged("AllowEmployee");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AllowEmployee;
        partial void OnAllowEmployeeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAllowEmployeeChanged();
        /// <summary>
        /// There are no comments for Property AllowCustomer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AllowCustomer
        {
            get
            {
                return this._AllowCustomer;
            }
            set
            {
                this.OnAllowCustomerChanging(value);
                this._AllowCustomer = value;
                this.OnAllowCustomerChanged();
                this.OnPropertyChanged("AllowCustomer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AllowCustomer;
        partial void OnAllowCustomerChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAllowCustomerChanged();
        /// <summary>
        /// There are no comments for Property TeamV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TeamV2> TeamV2
        {
            get
            {
                return this._TeamV2;
            }
            set
            {
                this.OnTeamV2Changing(value);
                this._TeamV2 = value;
                this.OnTeamV2Changed();
                this.OnPropertyChanged("TeamV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TeamV2> _TeamV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TeamV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnTeamV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TeamV2> value);
        partial void OnTeamV2Changed();
        /// <summary>
        /// There are no comments for Property Team in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Team> Team
        {
            get
            {
                return this._Team;
            }
            set
            {
                this.OnTeamChanging(value);
                this._Team = value;
                this.OnTeamChanged();
                this.OnPropertyChanged("Team");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Team> _Team = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Team>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnTeamChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Team> value);
        partial void OnTeamChanged();
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
