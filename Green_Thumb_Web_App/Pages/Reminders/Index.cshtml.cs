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
    public class IndexModel : PageModel
    {
        private readonly Green_Thumb_Web_App.Data.ReminderContext _context;

        public IndexModel(Green_Thumb_Web_App.Data.ReminderContext context)
        {
            _context = context;
        }

        public IList<Reminder> Reminder { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Reminder = await _context.Reminders.ToListAsync();
        }
    }
}
