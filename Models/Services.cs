using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200_Fortney.Models
{
    public class Services
    {
        [Key]
        public int serviceID { get; set; }
        public string serviceDescription { get; set; }
        public decimal unitCost { get; set; }
        public ICollection<LineItems> LineItem { get; set; }
    }
}