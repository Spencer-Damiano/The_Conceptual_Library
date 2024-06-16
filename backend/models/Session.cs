using System;
using System.Collections.Generic;

namespace backend.Models
{
    public class Session
    {
        public int SessionID { get; set; }
        public int UserID { get; set; }
        public int TimerTypeID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int WorkDuration { get; set; }
        public int BreakDuration { get; set; }

        public required User User { get; set; }
        public required TimerType TimerType { get; set; }
        public ICollection<SessionTask>? SessionTasks { get; set; }
    }
}
