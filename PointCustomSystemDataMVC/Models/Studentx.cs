//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PointCustomSystemDataMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Studentx
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Studentx()
        {
            this.Personnel = new HashSet<Personnel>();
            this.Phone = new HashSet<Phone>();
            this.PostOffices = new HashSet<PostOffices>();
            this.Reservation = new HashSet<Reservation>();
            this.Treatment = new HashSet<Treatment>();
            this.TreatmentPlace = new HashSet<TreatmentPlace>();
            this.TreatmentOffice1 = new HashSet<TreatmentOffice>();
            this.User1 = new HashSet<User>();
            this.TreatmentReport = new HashSet<TreatmentReport>();
            this.Customer = new HashSet<Customer>();
        }
    
        public int Student_id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Identity { get; set; }
        public string Notes { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> EnrollmentDateIN { get; set; }
        public Nullable<System.DateTime> EnrollmentDateOUT { get; set; }
        public Nullable<int> Phone_id { get; set; }
        public Nullable<int> Post_id { get; set; }
        public Nullable<int> User_id { get; set; }
        public string Address { get; set; }
        public Nullable<int> Personnel_id { get; set; }
        public Nullable<int> Reservation_id { get; set; }
        public Nullable<int> Treatment_id { get; set; }
        public Nullable<int> Customer_id { get; set; }
        public Nullable<int> TreatmentPlace_id { get; set; }
        public Nullable<int> TreatmentOffice_id { get; set; }
        public Nullable<int> TreatmentReport_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personnel> Personnel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phone> Phone { get; set; }
        public virtual Phone Phone1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostOffices> PostOffices { get; set; }
        public virtual PostOffices PostOffices1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Treatment> Treatment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TreatmentPlace> TreatmentPlace { get; set; }
        public virtual Personnel Personnel1 { get; set; }
        public virtual Reservation Reservation1 { get; set; }
        public virtual Treatment Treatment1 { get; set; }
        public virtual TreatmentPlace TreatmentPlace1 { get; set; }
        public virtual User User { get; set; }
        public virtual TreatmentOffice TreatmentOffice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TreatmentOffice> TreatmentOffice1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> User1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TreatmentReport> TreatmentReport { get; set; }
        public virtual TreatmentReport TreatmentReport1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customer { get; set; }
        public virtual Customer Customer1 { get; set; }
    }
}
