using System;
using Microsoft.AspNetCore.Identity;

namespace ItransitionTask4.Models
{
    public class User : IdentityUser
    {
        
        public DateTime RegistrationDate { get; set; }

        public DateTime LastLoginDate { get; set; }

        public User()
        {
        }
    }
}