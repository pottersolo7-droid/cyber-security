using System;

namespace CybersecurityBotGUI
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReminderDate { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public TaskItem()
        {
            Title = "";
            Description = "";
            Status = "pending";
            ReminderDate = DateTime.MinValue;
        }
    }
}