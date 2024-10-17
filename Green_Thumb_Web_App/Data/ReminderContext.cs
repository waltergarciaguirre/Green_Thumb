using Microsoft.EntityFrameworkCore;
using Green_Thumb_Web_App.Models;

namespace Green_Thumb_Web_App.Data
{
    public class ReminderContext : DbContext
    {
        public ReminderContext(DbContextOptions<ReminderContext> options) : base(options) 
        { 
        }

        public DbSet<Reminder> Reminders { get; set; }
    }
}
