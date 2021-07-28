﻿using System.ComponentModel.DataAnnotations;

namespace ItransitionTask4.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }
         
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        
        public string ReturnUrl { get; set; }
    }
}