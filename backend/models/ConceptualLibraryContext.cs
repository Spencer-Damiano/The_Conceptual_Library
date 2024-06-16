using Microsoft.EntityFrameworkCore;

namespace backend.Models
{
    public class ConceptualLibraryContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<TimerType> TimerTypes { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<SessionTask> SessionTasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=conceptuallibrary.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SessionTask>()
                .HasKey(st => new { st.SessionID, st.TaskID, st.TimerTypeID });

            modelBuilder.Entity<SessionTask>()
                .HasOne(st => st.Session)
                .WithMany(s => s.SessionTasks)
                .HasForeignKey(st => st.SessionID);

            modelBuilder.Entity<SessionTask>()
                .HasOne(st => st.Task)
                .WithMany(t => t.SessionTasks)
                .HasForeignKey(st => st.TaskID);

            modelBuilder.Entity<SessionTask>()
                .HasOne(st => st.TimerType)
                .WithMany(tt => tt.SessionTasks)
                .HasForeignKey(st => st.TimerTypeID);
        }
    }
}
