using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200_Fortney.Models
{
    public class LineItems
    {
        [Key]
        public int appointmentDetailID { get; set; }
        public decimal price { get; set; }
        public int serviceID { get; set; }
        public int appointmentID { get; set; }
        public virtual Appointments Appointment { get; set; }
        public virtual Services Service  { get; set; }


    }
}