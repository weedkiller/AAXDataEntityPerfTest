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
        /// There are no comments for RetailTillLayoutSingle in the schema.
        /// </summary>
    public partial class RetailTillLayoutSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTillLayout>
    {
        /// <summary>
        /// Initialize a new RetailTillLayoutSingle object.
        /// </summary>
        public RetailTillLayoutSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailTillLayoutSingle object.
        /// </summary>
        public RetailTillLayoutSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailTillLayoutSingle object.
        /// </summary>
        public RetailTillLayoutSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTillLayout> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailStaff in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailStaffSingle RetailStaff
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailStaff == null))
                {
                    this._RetailStaff = new global::Microsoft.Dynamics.DataEntities.RetailStaffSingle(this.Context, GetPath("RetailStaff"));
                }
                return this._RetailStaff;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailStaffSingle _RetailStaff;
        /// <summary>
        /// There are no comments for TillLayoutConfiguration in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TillLayoutConfiguration> TillLayoutConfiguration
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TillLayoutConfiguration == null))
                {
                    this._TillLayoutConfiguration = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.TillLayoutConfiguration>(GetPath("TillLayoutConfiguration"));
                }
                return this._TillLayoutConfiguration;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TillLayoutConfiguration> _TillLayoutConfiguration;
        /// <summary>
        /// There are no comments for RetailTillLayoutImageZone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutImageZone> RetailTillLayoutImageZone
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailTillLayoutImageZone == null))
                {
                    this._RetailTillLayoutImageZone = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutImageZone>(GetPath("RetailTillLayoutImageZone"));
                }
                return this._RetailTillLayoutImageZone;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutImageZone> _RetailTillLayoutImageZone;
        /// <summary>
        /// There are no comments for RetailTillLayoutStaff in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutStaff> RetailTillLayoutStaff
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailTillLayoutStaff == null))
                {
                    this._RetailTillLayoutStaff = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutStaff>(GetPath("RetailTillLayoutStaff"));
                }
                return this._RetailTillLayoutStaff;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutStaff> _RetailTillLayoutStaff;
        /// <summary>
        /// There are no comments for RetailStore in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailStoreSingle RetailStore
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailStore == null))
                {
                    this._RetailStore = new global::Microsoft.Dynamics.DataEntities.RetailStoreSingle(this.Context, GetPath("RetailStore"));
                }
                return this._RetailStore;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailStoreSingle _RetailStore;
        /// <summary>
        /// There are no comments for RetailTillLayoutButtonGridZone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutButtonGridZone> RetailTillLayoutButtonGridZone
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailTillLayoutButtonGridZone == null))
                {
                    this._RetailTillLayoutButtonGridZone = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutButtonGridZone>(GetPath("RetailTillLayoutButtonGridZone"));
                }
                return this._RetailTillLayoutButtonGridZone;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutButtonGridZone> _RetailTillLayoutButtonGridZone;
        /// <summary>
        /// There are no comments for RetailTillLayoutReportZone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutReportZone> RetailTillLayoutReportZone
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailTillLayoutReportZone == null))
                {
                    this._RetailTillLayoutReportZone = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutReportZone>(GetPath("RetailTillLayoutReportZone"));
                }
                return this._RetailTillLayoutReportZone;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutReportZone> _RetailTillLayoutReportZone;
    }
        /// <summary>
        /// There are no comments for RetailTillLayout in the schema.
        /// </summary>
    /// <KeyProperties>
    /// LayoutId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("LayoutId")]
    [global::Microsoft.OData.Client.EntitySet("RetailTillLayouts")]
    public partial class RetailTillLayout : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailTillLayout object.
        /// </summary>
        /// <param name="layoutId">Initial value of LayoutId.</param>
        /// <param name="retailDeviceTypes_Type">Initial value of RetailDeviceTypes_Type.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailTillLayout CreateRetailTillLayout(string layoutId, int retailDeviceTypes_Type)
        {
            RetailTillLayout retailTillLayout = new RetailTillLayout();
            retailTillLayout.LayoutId = layoutId;
            retailTillLayout.RetailDeviceTypes_Type = retailDeviceTypes_Type;
            return retailTillLayout;
        }
        /// <summary>
        /// There are no comments for Property LayoutId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LayoutId
        {
            get
            {
                return this._LayoutId;
            }
            set
            {
                this.OnLayoutIdChanging(value);
                this._LayoutId = value;
                this.OnLayoutIdChanged();
                this.OnPropertyChanged("LayoutId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LayoutId;
        partial void OnLayoutIdChanging(string value);
        partial void OnLayoutIdChanged();
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
        /// There are no comments for Property StartScreen in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailStartScreen> StartScreen
        {
            get
            {
                return this._StartScreen;
            }
            set
            {
                this.OnStartScreenChanging(value);
                this._StartScreen = value;
                this.OnStartScreenChanged();
                this.OnPropertyChanged("StartScreen");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailStartScreen> _StartScreen;
        partial void OnStartScreenChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailStartScreen> value);
        partial void OnStartScreenChanged();
        /// <summary>
        /// There are no comments for Property RetailDeviceTypes_Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int RetailDeviceTypes_Type
        {
            get
            {
                return this._RetailDeviceTypes_Type;
            }
            set
            {
                this.OnRetailDeviceTypes_TypeChanging(value);
                this._RetailDeviceTypes_Type = value;
                this.OnRetailDeviceTypes_TypeChanged();
                this.OnPropertyChanged("RetailDeviceTypes_Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _RetailDeviceTypes_Type;
        partial void OnRetailDeviceTypes_TypeChanging(int value);
        partial void OnRetailDeviceTypes_TypeChanged();
        /// <summary>
        /// There are no comments for Property RetailStaff in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailStaff RetailStaff
        {
            get
            {
                return this._RetailStaff;
            }
            set
            {
                this.OnRetailStaffChanging(value);
                this._RetailStaff = value;
                this.OnRetailStaffChanged();
                this.OnPropertyChanged("RetailStaff");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailStaff _RetailStaff;
        partial void OnRetailStaffChanging(global::Microsoft.Dynamics.DataEntities.RetailStaff value);
        partial void OnRetailStaffChanged();
        /// <summary>
        /// There are no comments for Property TillLayoutConfiguration in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TillLayoutConfiguration> TillLayoutConfiguration
        {
            get
            {
                return this._TillLayoutConfiguration;
            }
            set
            {
                this.OnTillLayoutConfigurationChanging(value);
                this._TillLayoutConfiguration = value;
                this.OnTillLayoutConfigurationChanged();
                this.OnPropertyChanged("TillLayoutConfiguration");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TillLayoutConfiguration> _TillLayoutConfiguration = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TillLayoutConfiguration>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnTillLayoutConfigurationChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TillLayoutConfiguration> value);
        partial void OnTillLayoutConfigurationChanged();
        /// <summary>
        /// There are no comments for Property RetailTillLayoutImageZone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutImageZone> RetailTillLayoutImageZone
        {
            get
            {
                return this._RetailTillLayoutImageZone;
            }
            set
            {
                this.OnRetailTillLayoutImageZoneChanging(value);
                this._RetailTillLayoutImageZone = value;
                this.OnRetailTillLayoutImageZoneChanged();
                this.OnPropertyChanged("RetailTillLayoutImageZone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutImageZone> _RetailTillLayoutImageZone = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutImageZone>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailTillLayoutImageZoneChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutImageZone> value);
        partial void OnRetailTillLayoutImageZoneChanged();
        /// <summary>
        /// There are no comments for Property RetailTillLayoutStaff in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutStaff> RetailTillLayoutStaff
        {
            get
            {
                return this._RetailTillLayoutStaff;
            }
            set
            {
                this.OnRetailTillLayoutStaffChanging(value);
                this._RetailTillLayoutStaff = value;
                this.OnRetailTillLayoutStaffChanged();
                this.OnPropertyChanged("RetailTillLayoutStaff");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutStaff> _RetailTillLayoutStaff = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutStaff>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailTillLayoutStaffChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutStaff> value);
        partial void OnRetailTillLayoutStaffChanged();
        /// <summary>
        /// There are no comments for Property RetailStore in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailStore RetailStore
        {
            get
            {
                return this._RetailStore;
            }
            set
            {
                this.OnRetailStoreChanging(value);
                this._RetailStore = value;
                this.OnRetailStoreChanged();
                this.OnPropertyChanged("RetailStore");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailStore _RetailStore;
        partial void OnRetailStoreChanging(global::Microsoft.Dynamics.DataEntities.RetailStore value);
        partial void OnRetailStoreChanged();
        /// <summary>
        /// There are no comments for Property RetailTillLayoutButtonGridZone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutButtonGridZone> RetailTillLayoutButtonGridZone
        {
            get
            {
                return this._RetailTillLayoutButtonGridZone;
            }
            set
            {
                this.OnRetailTillLayoutButtonGridZoneChanging(value);
                this._RetailTillLayoutButtonGridZone = value;
                this.OnRetailTillLayoutButtonGridZoneChanged();
                this.OnPropertyChanged("RetailTillLayoutButtonGridZone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutButtonGridZone> _RetailTillLayoutButtonGridZone = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutButtonGridZone>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailTillLayoutButtonGridZoneChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutButtonGridZone> value);
        partial void OnRetailTillLayoutButtonGridZoneChanged();
        /// <summary>
        /// There are no comments for Property RetailTillLayoutReportZone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutReportZone> RetailTillLayoutReportZone
        {
            get
            {
                return this._RetailTillLayoutReportZone;
            }
            set
            {
                this.OnRetailTillLayoutReportZoneChanging(value);
                this._RetailTillLayoutReportZone = value;
                this.OnRetailTillLayoutReportZoneChanged();
                this.OnPropertyChanged("RetailTillLayoutReportZone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutReportZone> _RetailTillLayoutReportZone = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutReportZone>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailTillLayoutReportZoneChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailTillLayoutReportZone> value);
        partial void OnRetailTillLayoutReportZoneChanged();
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
