using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Green_Thumb_Web_App.Data;
using Green_Thumb_Web_App.Models;

namespace Green_Thumb_Web_App.Pages.Reminders
{
    public class DeleteModel : PageModel
    {
        private readonly Green_Thumb_Web_App.Data.ReminderContext _context;

        public DeleteModel(Green_Thumb_Web_App.Data.ReminderContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Reminder Reminder { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reminder = await _context.Reminders.FirstOrDefaultAsync(m => m.Id == id);

            if (reminder == null)
            {
                return NotFound();
            }
            else
            {
                Reminder = reminder;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reminder = await _context.Reminders.FindAsync(id);
            if (reminder != null)
            {
                Reminder = reminder;
                _context.Reminders.Remove(Reminder);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
