using System;

namespace backend.Models
{
    public class Session
    {
        public int SessionID { get; set; }
        public int UserID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
         // public string SessionType { get; set; } 
         // I need to think about how I want to use the SessionType, I would like this to messure the number of times
         // the timer changes from break to study. Maybe I should have a TimeInStudy and a TimeInBreak on top of StateChange.
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public required User User { get; set; }
    }
}
