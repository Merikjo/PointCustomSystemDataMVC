﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PointCustomSystemDataMVC.ViewModels
{
    public class TreatmentPlaceViewModel
    {
            public TreatmentPlaceViewModel()
            {
                this.Reservation = new HashSet<ReservationViewModel>();
            }

            public int TreatmentPlace_id { get; set; }
            [Display(Name = "Palvelupaikka")]
            public string TreatmentPlaceName { get; set; }
            [Display(Name = "Palvelupaikan nro")]
            public string TreatmentPlaceNumber { get; set; }


            public virtual ICollection<ReservationViewModel> Reservation { get; set; }
        }
    }
