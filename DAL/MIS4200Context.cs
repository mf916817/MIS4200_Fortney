using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MIS4200_Fortney.Models;

namespace MIS4200_Fortney.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {

        }
        public DbSet<Appointments> Appointment { get; set; }
        public DbSet<Patients> Patient { get; set; }
        public DbSet<Services> Service { get; set; }
        public DbSet<LineItems> LineItem { get; set; }



    }
}