﻿namespace HealthJournal.Dto.Account
{
    public class NewUserDto
    {
        public string Email { get; set; }
        public string Token { get; set; }
        public string? Role { get; set; }
    }
}
