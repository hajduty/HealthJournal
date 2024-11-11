using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace HealthJournal.Models
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
