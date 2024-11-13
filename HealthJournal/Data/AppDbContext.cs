using HealthJournal.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HealthJournal.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<Encounter> Encounters { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Observation> Observations { get; set; }
        public DbSet<Patient> Patients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            List<IdentityRole> identityRoles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name = "Patient",
                    NormalizedName = "PATIENT"
                }
            };
            modelBuilder.Entity<IdentityRole>().HasData(identityRoles);

            modelBuilder.Entity<Condition>()
                .HasOne(c => c.Patient)
                .WithMany(p => p.Conditions)
                .HasForeignKey(c => c.PatientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Encounter>()
                .HasOne(e => e.Patient)
                .WithMany(p => p.Encounters)
                .HasForeignKey(e => e.PatientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Observation>()
                .HasOne(o => o.Patient)
                .WithMany(p => p.Observations)
                .HasForeignKey(o => o.PatientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Observation>()
                .HasOne(o => o.Encounter)
                .WithMany(e => e.Observations)
                .HasForeignKey(o => o.EncounterId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Sender)
                .WithMany()
                .HasForeignKey(m => m.SenderId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Receiver)
                .WithMany()
                .HasForeignKey(m => m.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Patient>()
                .HasOne(p => p.User)
                .WithMany()
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>().HasData(
                new User { Id = "user1", UserName = "user1@example.com", Email = "user1@example.com" },
                new User { Id = "user2", UserName = "user2@example.com", Email = "user2@example.com" },
                new User { Id = "user3", UserName = "user3@example.com", Email = "user3@example.com" }
            );

            modelBuilder.Entity<Message>().HasData(
                new { Id = 1, ReceiverId = "user1", SenderId = "user2", Info = "Follow-up appointment scheduled.", Date = DateTime.Now.AddDays(-3) },
                new { Id = 2, ReceiverId = "user2", SenderId = "user1", Info = "Please bring medical reports.", Date = DateTime.Now.AddDays(-2) },
                new { Id = 3, ReceiverId = "user3", SenderId = "user1", Info = "Lab results ready.", Date = DateTime.Now.AddDays(-1) }
            );

            modelBuilder.Entity<Patient>().HasData(
                new { Id = 1, FirstName = "John", LastName = "Doe", Age = 45, UserId = "user1" },
                new { Id = 2, FirstName = "Jane", LastName = "Smith", Age = 32, UserId = "user2" },
                new { Id = 3, FirstName = "Tom", LastName = "Brown", Age = 28, UserId = "user3" }
            );

            // Seed for Conditions
            modelBuilder.Entity<Condition>().HasData(
                new { Id = 1, ConditionName = "Hypertension", PatientId = 1 },
                new { Id = 2, ConditionName = "Diabetes", PatientId = 2 },
                new { Id = 3, ConditionName = "Asthma", PatientId = 3 }
            );

            // Seed for Encounters
            modelBuilder.Entity<Encounter>().HasData(
                new { Id = 1, Date = DateTime.Now.AddMonths(-1), PatientId = 1 },
                new { Id = 2, Date = DateTime.Now.AddMonths(-2), PatientId = 2 },
                new { Id = 3, Date = DateTime.Now.AddMonths(-1).AddDays(5), PatientId = 3 }
            );

            // Seed for Observations
            modelBuilder.Entity<Observation>().HasData(
                new { Id = 1, Type = "Blood Pressure", Value = 130.5, PatientId = 1, EncounterId = 1 },
                new { Id = 2, Type = "Blood Sugar", Value = 7.5, PatientId = 2, EncounterId = 2 },
                new { Id = 3, Type = "Peak Flow", Value = 350.0, PatientId = 3, EncounterId = 3 }
            );
        }
    }
}