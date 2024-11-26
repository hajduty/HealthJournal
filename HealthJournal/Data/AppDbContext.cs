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

            for (int i = 1; i <= 100; i++)
            {
                modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        Id = $"user{i}",
                        UserName = $"user{i}@example.com",
                        Email = $"user{i}@example.com"
                    }
                );

                modelBuilder.Entity<Message>().HasData(
                    new Message
                    {
                        Id = i,
                        ReceiverId = $"user{i % 3 + 1}", // Cycling through user1, user2, user3
                        SenderId = $"user{(i + 1) % 3 + 1}", // Cycling through user1, user2, user3
                        Info = $"Message {i} info",
                        Date = DateTime.Now.AddDays(-i) // Adjust date based on index
                    }
                );

                modelBuilder.Entity<Patient>().HasData(
                    new Patient
                    {
                        Id = i,
                        FirstName = $"FirstName{i}",
                        LastName = $"LastName{i}",
                        Age = 20 + (i % 50), // Random age between 20 and 69
                        UserId = $"user{i % 100 + 1}"
                    }
                );

                modelBuilder.Entity<Condition>().HasData(
                    new Condition
                    {
                        Id = i,
                        ConditionName = $"Condition {i}",
                        PatientId = i
                    }
                );

                modelBuilder.Entity<Encounter>().HasData(
                    new Encounter
                    {
                        Id = i,
                        Date = DateTime.Now.AddMonths(-i),
                        PatientId = i
                    }
                );

                modelBuilder.Entity<Observation>().HasData(
                    new Observation
                    {
                        Id = i,
                        Type = $"Observation Type {i}",
                        Value = 50 + (i % 100), // Some random value
                        PatientId = i,
                        EncounterId = i
                    }
                );
            }
        }
    }
}