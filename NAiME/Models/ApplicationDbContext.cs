﻿using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace NAiME.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Character> Characters { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {

            return new ApplicationDbContext();
        }
    }
}