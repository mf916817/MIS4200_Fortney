using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200_Fortney.Models
{
    public class Patients
    {
        [Key]
        public int patientID { get; set;  }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime patientSince { get; set; }
        public ICollection<Appointments> Appointments { get; set; }

    }
}