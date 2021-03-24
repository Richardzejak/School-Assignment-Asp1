using Inlämningsuppgift_1_asp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlämningsuppgift_1_asp.Data
{
    public class DbSeed
    {
        public static void Initialize(Inlämningsuppgift_1_aspContext context)
        {
            context.Database.EnsureCreated();

            context.AttendeeEvent.RemoveRange(context.AttendeeEvent);
            context.SaveChanges();

            context.Event.RemoveRange(context.Event);
            context.SaveChanges();

            context.Organizer.RemoveRange(context.Organizer);
            context.SaveChanges();

            var organizers = new Organizer[]
            {
                new Organizer{Name="Ricky-Conserts", Email="Ricky-conserts@gmail.com", Phone_number="580027173"},
                new Organizer{Name="The Organizers", Email="organizers_@gmail.com", Phone_number="340582131"},
                new Organizer{Name="Music Camp", Email="John_Doe@mc.com", Phone_number="412905919"},
                new Organizer{Name="Dance From Nightfall", Email="DFN@hotmail.com", Phone_number="11231519"},
                new Organizer{Name="Lord of the Events", Email="Lote@hotmail.com", Phone_number="131223123"},
                new Organizer{Name="Valencia Events", Email="Valencia@events.com", Phone_number="698123133"}
            };
            context.Organizer.AddRange(organizers);
            context.SaveChanges();

            var events = new Event[]
            {
               new Event{Title="Neil Young In Toronto", Organizer = organizers[3], Description="Live Consert", Address="Toronto 2645",
                   Place="Canada", Date=DateTime.Parse("2021-04-13"), Spots_available=320},

               new Event{Title="Summer Camp",Organizer = organizers[2], Description="Music Summer Camp", Address="Götgatan 24, Linköping",
                   Place="Sweden", Date=DateTime.Parse("2021-07-15"), Spots_available=50},

               new Event{Title="X-2000",Organizer = organizers[1], Description="E-Sport Tournament", Address="cavas equados 141,Valencia",
                   Place="Spain", Date=DateTime.Parse("2021-08-24"), Spots_available=169},

               new Event{Title="Grand Movie Festival 2021",Organizer = organizers[5],Description="Movie Festival", Address="152 Gordon Street, New York",
                   Place="United States", Date=DateTime.Parse("2021-09-21"), Spots_available=1640},
            };
            context.Event.AddRange(events);
            context.SaveChanges();

            if(context.Attendee.Any())
            {
                return;
            }

            var attendees = new Attendee[]
{
                new Attendee{Name="User3", Email="User1@hotmail.com", Phone_number="0148124012"},
                new Attendee{Name="User2", Email="User2@hotmail.com", Phone_number="1024012412"},
                new Attendee{Name="User1", Email="User3@hotmail.com", Phone_number="1240124050"}
};
            context.Attendee.AddRange(attendees);
            context.SaveChanges();
        }
    }
}
