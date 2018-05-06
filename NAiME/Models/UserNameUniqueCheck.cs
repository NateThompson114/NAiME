using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using NAiME.ViewModel.Account;

namespace NAiME.Models
{
    public class UserNameUniqueCheck : ValidationAttribute
    {
        private ApplicationDbContext _context;

        public UserNameUniqueCheck()
        {
            _context = new ApplicationDbContext();
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var user = (RegisterViewModel)validationContext.ObjectInstance;

            var userNameCheck = _context.Users.Any(u => u.UserName == user.UserName);

            return userNameCheck ? new ValidationResult($"{user.UserName} is already taken!") : ValidationResult.Success;
        }
    }
}