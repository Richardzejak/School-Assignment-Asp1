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
    public class MyeventsModel : PageModel
    {
        private readonly Inlämningsuppgift_1_asp.Data.Inlämningsuppgift_1_aspContext _context;

        public MyeventsModel(Inlämningsuppgift_1_asp.Data.Inlämningsuppgift_1_aspContext context)
        {
            _context = context;
        }

        public IList<AttendeeEvent> AttendeeEvent { get;set; }

        public async Task OnGetAsync()
        {
            AttendeeEvent = await _context.AttendeeEvent.Include(e=>e.Event).ThenInclude(o=>o.Organizer).Where(ae=>ae.Attendee.ID == 1).ToListAsync();
        }
    }
}
