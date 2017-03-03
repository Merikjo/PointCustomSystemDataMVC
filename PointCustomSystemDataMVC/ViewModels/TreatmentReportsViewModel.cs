﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PointCustomSystemDataMVC.ViewModels
{
    public class TreatmentReportsViewModel
    {
        
        public int TreatmentReport_id { get; set; }

        [Display(Name = "Hoito")]
        public string TreatmentReportName { get; set; }

        [Display(Name = "Hoitokertomus")]
        public string TreatmentReportText { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "HoitoPvm")]
        public DateTime TreatmentDate { get; set; }

        [Display(Name = "Hoitoaika")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime TreatmentTime { get; set; }

        public int? User_id { get; set; }
        public int? Customer_id { get; set; }
        public int? Student_id { get; set; }
        public int? Personnel_id { get; set; }
        public int? Reservation_id { get; set; }

        public string UserIdentity { get; set; }
        public string Customer { get; set; }

        public string Studentx { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Display(Name = "Hoitaja")]
        public string FullNameH
        {
            get { return FirstName + ", " + LastName; }
        }

        [Display(Name = "Asiakas")]
        public string FullNameA
        {
            get { return FirstName + ", " + LastName; }
        }
        public virtual ICollection<TreatmentReportsViewModel> TreatmentReservations { get; set; }
    }
}