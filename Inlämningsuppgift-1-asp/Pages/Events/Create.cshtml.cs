using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Inlämningsuppgift_1_asp.Data;
using Inlämningsuppgift_1_asp.Models;

namespace Inlämningsuppgift_1_asp.Pages.Events
{
    public class CreateModel : PageModel
    {
        private readonly Inlämningsuppgift_1_asp.Data.Inlämningsuppgift_1_aspContext _context;

        public CreateModel(Inlämningsuppgift_1_asp.Data.Inlämningsuppgift_1_aspContext context)
        {
            _context = context;
        }
        public Event Event { get; set; }
        public Attendee Attendee { get; set; }

        public async Task<RedirectToPageResult> OnGetAsync(int? id)
        {

            Attendee = await _context.Attendee.Where(a => a.ID == 1).FirstOrDefaultAsync();
            Event = await _context.Event.FirstOrDefaultAsync(m => m.ID == id);

            _context.AttendeeEvent.Add(new AttendeeEvent { Event = Event, Attendee = Attendee });
            _context.SaveChanges();

            return RedirectToPage("./Details", new { id = id });
        }
    }
}
