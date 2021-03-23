using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Inlämningsuppgift_1_asp.Data;
using Inlämningsuppgift_1_asp.Models;
using System.Diagnostics;

namespace Inlämningsuppgift_1_asp.Pages.Events
{
    public class DetailsModel : PageModel
    {
        private readonly Inlämningsuppgift_1_asp.Data.Inlämningsuppgift_1_aspContext _context;

        public DetailsModel(Inlämningsuppgift_1_asp.Data.Inlämningsuppgift_1_aspContext context)
        {
            _context = context;
        }

        public Event Event { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Event.Include(e=>e.Organizer).FirstOrDefaultAsync(m => m.ID == id);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPost(int? id)
        {
            Event = await _context.Event.Include(e => e.Organizer).FirstOrDefaultAsync(m => m.ID == id);
            Console.Beep();
            return Page();

           // new Attendee {Name = "User1", Email = "User1@hotmail.com", Phone_number = 15129512 };
        }
    }
}
