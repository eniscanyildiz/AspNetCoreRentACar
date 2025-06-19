using System;
using System.Collections.Generic;

namespace RentACar.DataAccess.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string? Username { get; set; }
        public string? PasswordHash { get; set; }
        public string? Role { get; set; }
    }
}
