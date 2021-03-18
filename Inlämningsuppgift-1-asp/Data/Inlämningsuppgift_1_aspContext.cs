using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Inlämningsuppgift_1_asp.Models;

namespace Inlämningsuppgift_1_asp.Data
{
    public class Inlämningsuppgift_1_aspContext : DbContext
    {
        public Inlämningsuppgift_1_aspContext (DbContextOptions<Inlämningsuppgift_1_aspContext> options)
            : base(options)
        {
        }

        public DbSet<Inlämningsuppgift_1_asp.Models.Event> Event { get; set; }
        public DbSet<Inlämningsuppgift_1_asp.Models.Attendee> Attendee { get; set; }
        public DbSet<Inlämningsuppgift_1_asp.Models.Organizer> Organizer { get; set; }
    }
}
