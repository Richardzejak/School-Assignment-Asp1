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
        public int organizer_id { get; set; }
        public string description { get; set; }
        public string place { get; set; }
        public string address { get; set; }
        [DataType(DataType.Date)]
        public DateTime date { get; set; }
        public int spots_available { get; set; }
    }
}
