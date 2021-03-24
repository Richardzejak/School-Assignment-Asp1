using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlämningsuppgift_1_asp.Models
{
    public class Attendee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone_number { get; set; }
        public ICollection<AttendeeEvent> AttendeeEvents { get; set; }
    }
}
