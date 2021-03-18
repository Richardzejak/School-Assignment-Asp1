using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Inlämningsuppgift_1_asp.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public Organizer Organizer { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public string Address { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int Spots_available { get; set; }
        public List<Attendee> Attendees { get; set; }
    }
}
