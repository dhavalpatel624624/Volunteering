using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Volunteering.Models;

namespace Volunteering.Data_Access_Layer
{
    public class EventContext : DbContext
    {
        public EventContext() : base("EventContext")
        {
        }
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Event> Events { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}