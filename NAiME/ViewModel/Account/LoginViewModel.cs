﻿using System.ComponentModel.DataAnnotations;

namespace NAiME.ViewModel.Account
{
    public class LoginViewModel
    {
        [Required, Display(Name = "Username or Email")]
        public string UserName { get; set; }

        //[Required, Display(Name = "Email"), EmailAddress]
        //public string Email { get; set; }

        [Required, DataType(DataType.Password), Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}