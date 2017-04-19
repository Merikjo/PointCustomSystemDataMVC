﻿using PointCustomSystemDataMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PointCustomSystemDataMVC.ViewModels
{
    public class ReservationViewModel
    {
        public ReservationViewModel()
        {
            this.TreatmentReport = new HashSet<ReservationViewModel>();
        }
        public int? Reservation_id { get; set; }

        //public string Customer { get; set; }

        public int? Customer_id { get; set; }
        public string Identity { get; set; }
        [Display(Name = "Sähköposti")]
        public string Email { get; set; }
        [Display(Name = "Tiedot")]
        public string Note { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hoito maksettu pvm")]
        public DateTime? TreatmentPaidDate { get; set; }

        [Display(Name = "Maksettu")]
        public bool? TreatmentPaid { get; set; }

        //Lisätty yhdistävät nimikentät

        [Display(Name = "Asiakas Etunimi")]
        public string FirstNameA { get; set; }
        [Display(Name = "Asiakas Sukunimi")]
        public string LastNameA { get; set; }

        [Display(Name = "Asiakas")]
        public string FullNameA
        {
            get { return FirstNameA + " " + LastNameA; }
        }

        [Display(Name = "Hoitaja Etunimi")]
        public string FirstNameH { get; set; }
        [Display(Name = "Hoitaja Sukunimi")]
        public string LastNameH { get; set; }
        [Display(Name = "Hoitaja")]
        public string FullNameH2 { get; set; }
        [Display(Name = "Hoitaja")]
        public string FullNameH
        {
            get { return FirstNameH + " " + LastNameH; }
            set { FullNameH2 = value; }
        }

        [Display(Name = "Henkilökunta Etunimi")]
        public string FirstNameP { get; set; }

        [Display(Name = "Henkilökunta Sukunimi")]
        public string LastNameP { get; set; }

        [Display(Name = "Henkilökunta")]
        public string FullNameP
        {
            get { return FirstNameP + " " + LastNameP; }
        }

   
        public string CalendarTitle2 { get; set; }

        [Display(Name = "Varauskalenteri")]
        public string CalendarTitle
        {
            get { return TreatmentName + "; Hoitaja: " + FullNameH + "; Paikka: " + TreatmentPlaceName + ";"  + FullNameA ; }
            set { CalendarTitle2 = value; }
        }

        //Lisätty päivämäärämääritykset reservation.cs

        [Display(Name = "Alkaen klo")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH\\:mm}", ApplyFormatInEditMode = true)]
        public DateTime? Start { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH\\:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Loppuu klo")]
        public DateTime? End { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy\\-MM\\-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "PalveluPvm")]
        public DateTime? Date { get; set; }

        [Display(Name = "Palvelupaikka")]
        public string TreatmentPlaceName { get; set; }

        public int? User_id { get; set; }
        //public string User { get; set; }

      
        [Display(Name = "Käyttäjätunnus")]
        public string UserIdentity { get; set; }


        //public string UserIdentity
        //{
        //    get { return FirstNameA + "; " + LastNameA; }
        //    set { UserIdentity2 = value; }
        //}

        public string Password { get; set; }

        //public string Treatment { get; set; }
        public int? Treatment_id { get; set; }

        [Display(Name = "Palveluaika")]
        public string TreatmentTime { get; set; }

        [Display(Name = "Palvelu")]
        public string TreatmentName { get; set; }
        [Display(Name = "Palvelun hinta")]
        public string TreatmentPrice { get; set; }

        [Display(Name = "Osoite")]
        public string Address { get; set; }
 
        //public string TreatmentOffice { get; set; }
        public int? TreatmentOffice_id { get; set; }
        [Display(Name = "Toimipiste")]
        public string TreatmentOfficeName { get; set; }

        //public string TreatmentPlace { get; set; }
        public int? TreatmentPlace_id { get; set; }
        [Display(Name = "Palvelupaikan nro")]
        public string TreatmentPlaceNumber { get; set; }
        [Display(Name = "Palveluraportti")]
        public string TreatmentReportTexts { get; set; }
        
        public string Phone { get; set; }
        public int? Phone_id { get; set; }
        [Display(Name = "PuhNro")]
        public string PhoneNum_1 { get; set; }

        public string PostOffices { get; set; }
        public int? Post_id { get; set; }
        [Display(Name = "PostiNro")]
        public string PostalCode { get; set; }
        [Display(Name = "Postiosoite")]
        public string PostOffice { get; set; }

        [Display(Name = "Hoitaja")]
        //public string Studentx { get; set; }
        public int? Student_id { get; set; }

        [Display(Name = "Tiedot")]
        public string Notes{get; set;}
       
        public string DataDateField { get; set; }

        public string EventManager { get; set; }

        public string Reservations { get; set; }

        [Display(Name = "Palvelu suoritettu")]
        public bool? TreatmentCompleted { get; set; }


        public virtual Customer Customer { get; set; }
        public virtual Personnel Personnel { get; set; }
        public virtual Studentx Studentx { get; set; }
        public virtual TreatmentPlace TreatmentPlace { get; set; }
        public virtual Treatment Treatment { get; set; }
        public virtual User User { get; set; }
        public virtual TreatmentOffice TreatmentOffice { get; set; }
      
        public virtual ICollection<ReservationViewModel> TreatmentReport { get; set; }

    }
}