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
    
    public partial class TreatmentReport
    {
        public int TreatmentReport_id { get; set; }
        public string TreatmentReportName { get; set; }
        public string TreatmentReportText { get; set; }
        public Nullable<System.DateTime> TreatmentDate { get; set; }
        public Nullable<System.DateTime> TreatmentTime { get; set; }
        public Nullable<int> User_id { get; set; }
        public Nullable<int> Customer_id { get; set; }
        public Nullable<int> Student_id { get; set; }
        public Nullable<int> Personnel_id { get; set; }
        public Nullable<int> Reservation_id { get; set; }
    
        public virtual User User { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Personnel Personnel { get; set; }
        public virtual Studentx Studentx { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}
