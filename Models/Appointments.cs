using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200_Fortney.Models
{
    public class Appointments
    {
        [Key]
        public int appointmentID { get; set; }
        public string description { get; set; }
        public DateTime appointmentDate { get; set; }
        public int patientID { get; set; }
        public virtual Patients patients { get; set; }
        public ICollection<LineItems> LineItems { get; set; }

    }
}