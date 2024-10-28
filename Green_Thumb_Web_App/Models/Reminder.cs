using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;

namespace Green_Thumb_Web_App.Models
{
    public class Reminder
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public DateTime ReminderTime { get; set; }  
        public DateTime NextTriggerTime { get; set; }
        public bool IsRecurring { get; set; }
        public TimeSpan? RecurrenceInterval { get; set; }
        public bool IsCompleted { get; set; }
    }
}
