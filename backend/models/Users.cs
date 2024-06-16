using System;
using System.Collections.Generic;

namespace backend.Models
{
    public class User
    {
        public int UserID { get; set; }
        public required string Username { get; set; }
        public required string PasswordHash { get; set; }
        public required string UserType { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<Session>? Sessions { get; set; }
        public ICollection<Task>? Tasks { get; set; }
    }
}
