﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 10/4/2020 2:24:13 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for CourseHotelSingle in the schema.
    /// </summary>
    public partial class CourseHotelSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CourseHotel>
    {
        /// <summary>
        /// Initialize a new CourseHotelSingle object.
        /// </summary>
        public CourseHotelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CourseHotelSingle object.
        /// </summary>
        public CourseHotelSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CourseHotelSingle object.
        /// </summary>
        public CourseHotelSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CourseHotel> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CourseLocationHotel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CourseLocationHotel> CourseLocationHotel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CourseLocationHotel == null))
                {
                    this._CourseLocationHotel = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CourseLocationHotel>(GetPath("CourseLocationHotel"));
                }
                return this._CourseLocationHotel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CourseLocationHotel> _CourseLocationHotel;
        /// <summary>
        /// There are no comments for CourseLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CourseLocationSingle CourseLocation
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CourseLocation == null))
                {
                    this._CourseLocation = new global::Microsoft.Dynamics.DataEntities.CourseLocationSingle(this.Context, GetPath("CourseLocation"));
                }
                return this._CourseLocation;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CourseLocationSingle _CourseLocation;
    }
    /// <summary>
    /// There are no comments for CourseHotel in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// CourseLocationId
    /// HotelId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CourseLocationId", "HotelId")]
    [global::Microsoft.OData.Client.EntitySet("CourseHotels")]
    public partial class CourseHotel : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CourseHotel object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="courseLocationId">Initial value of CourseLocationId.</param>
        /// <param name="hotelId">Initial value of HotelId.</param>
        /// <param name="courseLocation">Initial value of CourseLocation.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CourseHotel CreateCourseHotel(string dataAreaId, string courseLocationId, string hotelId, global::Microsoft.Dynamics.DataEntities.CourseLocation courseLocation)
        {
            CourseHotel courseHotel = new CourseHotel();
            courseHotel.dataAreaId = dataAreaId;
            courseHotel.CourseLocationId = courseLocationId;
            courseHotel.HotelId = hotelId;
            if ((courseLocation == null))
            {
                throw new global::System.ArgumentNullException("courseLocation");
            }
            courseHotel.CourseLocation = courseLocation;
            return courseHotel;
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
        /// There are no comments for Property CourseLocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CourseLocationId
        {
            get
            {
                return this._CourseLocationId;
            }
            set
            {
                this.OnCourseLocationIdChanging(value);
                this._CourseLocationId = value;
                this.OnCourseLocationIdChanged();
                this.OnPropertyChanged("CourseLocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CourseLocationId;
        partial void OnCourseLocationIdChanging(string value);
        partial void OnCourseLocationIdChanged();
        /// <summary>
        /// There are no comments for Property HotelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string HotelId
        {
            get
            {
                return this._HotelId;
            }
            set
            {
                this.OnHotelIdChanging(value);
                this._HotelId = value;
                this.OnHotelIdChanged();
                this.OnPropertyChanged("HotelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _HotelId;
        partial void OnHotelIdChanging(string value);
        partial void OnHotelIdChanged();
        /// <summary>
        /// There are no comments for Property URL in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string URL
        {
            get
            {
                return this._URL;
            }
            set
            {
                this.OnURLChanging(value);
                this._URL = value;
                this.OnURLChanged();
                this.OnPropertyChanged("URL");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _URL;
        partial void OnURLChanging(string value);
        partial void OnURLChanged();
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
        /// There are no comments for Property MobilePhone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MobilePhone
        {
            get
            {
                return this._MobilePhone;
            }
            set
            {
                this.OnMobilePhoneChanging(value);
                this._MobilePhone = value;
                this.OnMobilePhoneChanged();
                this.OnPropertyChanged("MobilePhone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MobilePhone;
        partial void OnMobilePhoneChanging(string value);
        partial void OnMobilePhoneChanged();
        /// <summary>
        /// There are no comments for Property Email in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Email
        {
            get
            {
                return this._Email;
            }
            set
            {
                this.OnEmailChanging(value);
                this._Email = value;
                this.OnEmailChanged();
                this.OnPropertyChanged("Email");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Email;
        partial void OnEmailChanging(string value);
        partial void OnEmailChanged();
        /// <summary>
        /// There are no comments for Property TelexNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TelexNumber
        {
            get
            {
                return this._TelexNumber;
            }
            set
            {
                this.OnTelexNumberChanging(value);
                this._TelexNumber = value;
                this.OnTelexNumberChanged();
                this.OnPropertyChanged("TelexNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TelexNumber;
        partial void OnTelexNumberChanging(string value);
        partial void OnTelexNumberChanged();
        /// <summary>
        /// There are no comments for Property PhoneExtension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PhoneExtension
        {
            get
            {
                return this._PhoneExtension;
            }
            set
            {
                this.OnPhoneExtensionChanging(value);
                this._PhoneExtension = value;
                this.OnPhoneExtensionChanged();
                this.OnPropertyChanged("PhoneExtension");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PhoneExtension;
        partial void OnPhoneExtensionChanging(string value);
        partial void OnPhoneExtensionChanged();
        /// <summary>
        /// There are no comments for Property LocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LocationId
        {
            get
            {
                return this._LocationId;
            }
            set
            {
                this.OnLocationIdChanging(value);
                this._LocationId = value;
                this.OnLocationIdChanged();
                this.OnPropertyChanged("LocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LocationId;
        partial void OnLocationIdChanging(string value);
        partial void OnLocationIdChanged();
        /// <summary>
        /// There are no comments for Property Notes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Notes
        {
            get
            {
                return this._Notes;
            }
            set
            {
                this.OnNotesChanging(value);
                this._Notes = value;
                this.OnNotesChanged();
                this.OnPropertyChanged("Notes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Notes;
        partial void OnNotesChanging(string value);
        partial void OnNotesChanged();
        /// <summary>
        /// There are no comments for Property Phone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Phone
        {
            get
            {
                return this._Phone;
            }
            set
            {
                this.OnPhoneChanging(value);
                this._Phone = value;
                this.OnPhoneChanged();
                this.OnPropertyChanged("Phone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Phone;
        partial void OnPhoneChanging(string value);
        partial void OnPhoneChanged();
        /// <summary>
        /// There are no comments for Property Fax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Fax
        {
            get
            {
                return this._Fax;
            }
            set
            {
                this.OnFaxChanging(value);
                this._Fax = value;
                this.OnFaxChanged();
                this.OnPropertyChanged("Fax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Fax;
        partial void OnFaxChanging(string value);
        partial void OnFaxChanged();
        /// <summary>
        /// There are no comments for Property CourseLocationHotel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseLocationHotel> CourseLocationHotel
        {
            get
            {
                return this._CourseLocationHotel;
            }
            set
            {
                this.OnCourseLocationHotelChanging(value);
                this._CourseLocationHotel = value;
                this.OnCourseLocationHotelChanged();
                this.OnPropertyChanged("CourseLocationHotel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseLocationHotel> _CourseLocationHotel = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseLocationHotel>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCourseLocationHotelChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CourseLocationHotel> value);
        partial void OnCourseLocationHotelChanged();
        /// <summary>
        /// There are no comments for Property CourseLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CourseLocation CourseLocation
        {
            get
            {
                return this._CourseLocation;
            }
            set
            {
                this.OnCourseLocationChanging(value);
                this._CourseLocation = value;
                this.OnCourseLocationChanged();
                this.OnPropertyChanged("CourseLocation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CourseLocation _CourseLocation;
        partial void OnCourseLocationChanging(global::Microsoft.Dynamics.DataEntities.CourseLocation value);
        partial void OnCourseLocationChanged();
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
