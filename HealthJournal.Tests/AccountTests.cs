using HealthJournal.Controllers;
using HealthJournal.Data;
using HealthJournal.Dto.Account;
using HealthJournal.Interfaces;
using HealthJournal.Models;
using HealthJournal.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthJournal.Tests
{
    [TestFixture]
    public class AccountTests
    {
        private AppDbContext _context;
        private Mock<UserManager<User>> _mockUserManager;
        private Mock<SignInManager<User>> _mockSignInManager;
        private Mock<ITokenService> _mockTokenService;
        private AccountController _controller;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase("TestDatabase")
            .Options;

            _context = new AppDbContext(options);

            _context.Database.EnsureCreated();

            var userStore = new Mock<IUserStore<User>>();
            _mockUserManager = new Mock<UserManager<User>>(
                userStore.Object,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null);

            var contextAccessor = new Mock<Microsoft.AspNetCore.Http.IHttpContextAccessor>();
            var claimsFactory = new Mock<IUserClaimsPrincipalFactory<User>>();

            _mockSignInManager = new Mock<SignInManager<User>>(
                _mockUserManager.Object,
                contextAccessor.Object,
                claimsFactory.Object,
                null,
                null,
                null,
                null);

            _mockTokenService = new Mock<ITokenService>();

            _controller = new AccountController(
                _mockUserManager.Object,
                _mockTokenService.Object,
                _mockSignInManager.Object);
        }

        [Test]
        public void Test_Register()
        {
            var registerDto = new RegisterDto
            {
                Email = "TestEmail@gmail.com",
                Password = "TestPassword1234!"
            };

            _mockUserManager
                .Setup(manager => manager.CreateAsync(It.IsAny<User>(), It.IsAny<string>()))
                .ReturnsAsync(IdentityResult.Success);

            _mockSignInManager
                .Setup(manager => manager.SignInAsync(It.IsAny<User>(), It.IsAny<bool>(), null))
                .Returns(Task.CompletedTask);

            var result = _controller.Register(registerDto);

            Console.WriteLine(result);

            Assert.That(result.IsCompleted, Is.True);
        }
    }
}
