using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using NAiME.Models.Character;

namespace NAiME.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Character.Character> Characters { get; set; }
        public DbSet<ChangeLog> ChangeLogs { get; set; }
        
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