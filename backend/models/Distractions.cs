using System;

namespace backend.Models
{
    public class Distraction
    {
        public int DistractionID { get; set; }
        public int UserID { get; set; }
        public required string Description { get; set; }
        public bool Handled { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public required User User { get; set; }
    }
}
