using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Volunteering.Models;

namespace Volunteering.Data_Access_Layer
{
    public class EventInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<EventContext>
    {
        protected override void Seed(EventContext context)
        {
            var volunteers = new List<Volunteer>
        {
    new Volunteer{FirstMidName="Carson",LastName="Alexander",Gender="Male",Age= 32,EnrollmentDate=DateTime.Parse("2016-09-06").Date},
    new Volunteer{FirstMidName="Meredith",LastName="Alonso",Gender="Female",Age= 55,EnrollmentDate=DateTime.Parse("2016-09-12").Date},
    new Volunteer{FirstMidName="Arturo",LastName="Anand",Gender="Male",Age= 21, EnrollmentDate=DateTime.Parse("2016-01-05").Date},
    new Volunteer{FirstMidName="Alex",LastName="Barzdukas",Gender="Male",Age= 19, EnrollmentDate=DateTime.Parse("2016-10-03").Date},
    new Volunteer{FirstMidName="Yan",LastName="Li",Gender="Female",Age= 43, EnrollmentDate=DateTime.Parse("2016-12-01").Date},
    new Volunteer{FirstMidName="Peggy",LastName="Justice",Gender="Female",Age= 44, EnrollmentDate=DateTime.Parse("2016-10-11").Date},
    new Volunteer{FirstMidName="Laura",LastName="Norman",Gender="Female",Age= 22,EnrollmentDate=DateTime.Parse("2016-04-01").Date},
    new Volunteer{FirstMidName="Nino",LastName="Olivetto",Gender="Male",Age= 33,EnrollmentDate=DateTime.Parse("2016-06-01").Date}
 };
            volunteers.ForEach(s => context.Volunteers.Add(s));
            context.SaveChanges();
            var events = new List<Event>
 {
 new Event{EventID=1050,Title="Painting a House",EventDate=DateTime.Parse("2017-06-20 03:30:00 PM"), Location="123 example st. Chicago, IL 60606", EventLength="2 Hours", Description="Volunteering opportunity to paint a community building"},
 new Event{EventID=4022,Title="Coloring with the special kids",EventDate=DateTime.Parse("2017-04-10 11:00:00 AM"),Location="123 testing st. Chicago, IL 60606", EventLength="3.5 Hours",Description="Painting and coloring with Kindergarten kids for Easter"},
 new Event{EventID=4041,Title="Thanksgiving cooking",EventDate=DateTime.Parse("2017-11-20 05:00:00 PM"),Location="123 finding st. Chicago, IL 60606", EventLength="2 Hours",Description="Cooking for nursing home residents to celebrate Thanksgiving"},
 new Event{EventID=1045,Title="Walk for Breast Cancer",EventDate=DateTime.Parse("2017-09-06 09:00:00 AM"), Location="123 unknown st. Chicago, IL 60606", EventLength="2.5 Hours",Description="Raising money and awareness for Breast Cancer"},
 new Event{EventID=3141,Title="IT Explorer",EventDate=DateTime.Parse("2017-02-08 06:00:00 PM"),Location="123 example2 st. Chicago, IL 60606", EventLength="1.5 Hours every two weeks", Description="Help High School kids learn a little more about IT"},
 new Event{EventID=2021,Title="Halloween Pumpkin Carving", EventDate=DateTime.Parse("2017-10-12 01:00:00 PM"),Location="123 example st. Chicago, IL 60606", EventLength="3 Hours",Description="Help elementary kids carve pumpkins to take home for Halloween"},
 new Event{EventID=2042,Title="Hospital Volunteering",EventDate=DateTime.Parse("2017-07-16 03:00:00 PM"),Location="123 whoKnows st. Chicago, IL 60606", EventLength="1 Hour every week", Description="Volunteer in the hospital by working with nurses"}
 };
            events.ForEach(s => context.Events.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
 {
 new Enrollment{VolunteerID=1,EventID=1050},
 new Enrollment{VolunteerID=1,EventID=4022},
 new Enrollment{VolunteerID=1,EventID=4041},
 new Enrollment{VolunteerID=2,EventID=1045},
 new Enrollment{VolunteerID=2,EventID=3141},
 new Enrollment{VolunteerID=2,EventID=2021},
 new Enrollment{VolunteerID=3,EventID=1050},
 new Enrollment{VolunteerID=4,EventID=1050},
 new Enrollment{VolunteerID=4,EventID=4022},
 new Enrollment{VolunteerID=5,EventID=4041},
 new Enrollment{VolunteerID=6,EventID=1045},
 new Enrollment{VolunteerID=7,EventID=3141},
 new Enrollment{VolunteerID=7,EventID=1050}
 };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}