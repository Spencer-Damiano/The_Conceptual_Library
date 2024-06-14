using System;

namespace backend.Models
{
    public class User
    {
        public int UserID { get; set; }
        public required string Username { get; set; }
        public string? PasswordHash { get; set; } // Once the database is better set up make this required
        public string? UserType { get; set; } // Once the database is better set up make this required
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
