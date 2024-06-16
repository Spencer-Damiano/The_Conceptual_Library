using System.Collections.Generic;

namespace backend.Models
{
    public class TimerType
    {
        public int TimerTypeID { get; set; }
        public required string TypeName { get; set; }

        public ICollection<Session>? Sessions { get; set; }
        public ICollection<SessionTask>? SessionTasks { get; set; }
    }
}
