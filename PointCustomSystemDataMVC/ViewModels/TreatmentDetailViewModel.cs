﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PointCustomSystemDataMVC.ViewModels
{
    public class TreatmentDetailViewModel
    {
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH\\:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Alkaen klo")]
        public DateTime? Start { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH\\:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Loppuu klo")]
        public DateTime? End { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy\\-MM\\-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "PalveluPvm")]
        public DateTime? Date { get; set; }

        [Display(Name = "Palvelu")]
        public string TreatmentName { get; set; }
        [Display(Name = "Palveluaika min.")]
        public string TreatmentTime { get; set; }

        [Display(Name = "Hoitaja Etunimi")]
        public string FirstNameH { get; set; }
        [Display(Name = "Hoitaja Sukunimi")]
        public string LastNameH { get; set; }
        [Display(Name = "Hoitaja")]
        public string FullNameH
        {
            get { return FirstNameH + " " + LastNameH; }
        }

        [Display(Name = "Tiedot")]
        public string Notes { get; set; }

        [Display(Name = "Palvelun hinta")]
        public string TreatmentPrice { get; set; }

        [Display(Name = "Palveluraportti")]
        public string TreatmentReportTexts { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH\\:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Palvelu maksettu pvm")]
        public DateTime? TreatmentPaidDate { get; set; }

        [Display(Name = "Palvelu suoritettu")]
        public bool? TreatmentCompleted { get; set; }

        [Display(Name = "Maksettu")]
        public bool? TreatmentPaid { get; set; }


    }
}