using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Green_Thumb_Web_App.Data;
using Green_Thumb_Web_App.Models;

namespace Green_Thumb_Web_App.Pages.Reminders
{
    public class CreateModel : PageModel
    {
        private readonly Green_Thumb_Web_App.Data.ReminderContext _context;

        public CreateModel(Green_Thumb_Web_App.Data.ReminderContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Reminder Reminder { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Setting Inital Trigger Time
            Reminder.NextTriggerTime = Reminder.ReminderTime;

            _context.Reminders.Add(Reminder);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
