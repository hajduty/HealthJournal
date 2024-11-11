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
        }
    }
}