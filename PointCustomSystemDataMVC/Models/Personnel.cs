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
    using System.ComponentModel.DataAnnotations;

    public partial class Personnel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personnel()
        {
            this.Customer = new HashSet<Customer>();
            this.Personnel1 = new HashSet<Personnel>();
            this.Phone1 = new HashSet<Phone>();
            this.PostOffices1 = new HashSet<PostOffices>();
            this.Reservation1 = new HashSet<Reservation>();
            this.Treatment1 = new HashSet<Treatment>();
            this.TreatmentPlace1 = new HashSet<TreatmentPlace>();
            this.Studentx1 = new HashSet<Studentx>();
            this.TreatmentOffice1 = new HashSet<TreatmentOffice>();
            this.User1 = new HashSet<User>();
        }
    
        public int Personnel_id { get; set; }
        [Display(Name = "Etunimi")]
        public string FirstName { get; set; }
        [Display(Name = "Sukunimi")]
        public string LastName { get; set; }
        public string Identity { get; set; }
        [Display(Name = "Huomiot")]
        public string Notes { get; set; }
        [Display(Name = "S�hk�posti")]
        public string Email { get; set; }
        public Nullable<int> User_id { get; set; }
        public Nullable<int> Customer_id { get; set; }
        public Nullable<int> Phone_id { get; set; }
        public Nullable<int> Post_id { get; set; }
        public Nullable<int> Reservation_id { get; set; }
        public Nullable<int> Student_id { get; set; }
        public Nullable<int> Treatment_id { get; set; }
        public Nullable<int> TreatmentOffice_id { get; set; }
        public Nullable<int> TreatmentPlace_id { get; set; }

        //Lis�tty Personnels.cs

            public string UserIdentity { get; set; }

        //Lis�tty yhdist�v�t nimikent�t

        [Display(Name = "Henkil�kunta")]
        public string FullNameH
        {
            get { return FirstName + " " + LastName; }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personnel> Personnel1 { get; set; }
        public virtual Personnel Personnel2 { get; set; }
        public virtual Phone Phone { get; set; }
        public virtual PostOffices PostOffices { get; set; }
        public virtual Reservation Reservation { get; set; }
        public virtual Treatment Treatment { get; set; }
        public virtual TreatmentPlace TreatmentPlace { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phone> Phone1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostOffices> PostOffices1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservation1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Treatment> Treatment1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TreatmentPlace> TreatmentPlace1 { get; set; }
        public virtual Studentx Studentx { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Studentx> Studentx1 { get; set; }
        public virtual TreatmentOffice TreatmentOffice { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TreatmentOffice> TreatmentOffice1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> User1 { get; set; }
    }
}
