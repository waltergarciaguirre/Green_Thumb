using System;
using System.ComponentModel.DataAnnotations;

namespace Green_Thumb_Web_App.Models
{
    public class Reminder
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public DateTime ReminderTime { get; set; }  
        public bool IsCompleted { get; set; }
    }
}
