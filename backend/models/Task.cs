using System;
using System.Collections.Generic;

namespace backend.Models
{
    public class Task
    {
        public int TaskID { get; set; }
        public int UserID { get; set; }
        public required string Description { get; set; }
        public bool IsCompleted { get; set; }
        public int Priority { get; set; }
        public string? Tags { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public required User User { get; set; }
        public ICollection<SessionTask>? SessionTasks { get; set; }
    }
}
