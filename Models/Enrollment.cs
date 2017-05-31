using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Volunteering.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int EventID { get; set; }
        public int VolunteerID { get; set; }
 
        public virtual Event Event { get; set; }
        public virtual Volunteer Volunteer { get; set; }
    }

}