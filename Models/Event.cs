using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Volunteering.Models
{
    public class Event
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EventID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string EventLength { get; set; }
        public DateTime EventDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}