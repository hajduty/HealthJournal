using System;
using HealthJournal.Controllers;
using HealthJournal.Data;
using HealthJournal.Dto.Account;
using HealthJournal.Interfaces;
using HealthJournal.Models;
using HealthJournal.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace HealthJournal.Tests
{
    [TestFixture]
    public class Tests
    {
        private AppDbContext _context;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase("TestDatabase")
            .Options;

            _context = new AppDbContext(options);

            _context.Database.EnsureCreated();
        }

        [TearDown]
        public void Cleanup()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }

        [Test]
        public void Test_SeededData_Exists()
        {
            var users = _context.Users.ToList();

            Assert.That(users.Count,Is.EqualTo(100));
        }
    }
}