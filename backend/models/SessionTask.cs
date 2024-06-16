namespace backend.Models
{
    public class SessionTask
    {
        public int SessionID { get; set; }
        public int TaskID { get; set; }
        public int TimerTypeID { get; set; }

        public required Session Session { get; set; }
        public required Task Task { get; set; }
        public required TimerType TimerType { get; set; }
    }
}
