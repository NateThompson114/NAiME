using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using NAiME.Models;
using NAiME.ViewModel;
using NAiME.ViewModel.Account;

namespace NAiME.Controllers
{
    [Authorize(Roles = RoleName.Admin)]
    public class MembersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MembersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Members
        public ActionResult Index()
        {
            var usersWithRoles = (from user in _context.Users
                select new
                {
                    UserId = user.Id,
                    Username = user.UserName,
                    user.Email,
                    user.LastLogin,
                    RoleNames = (from userRole in user.Roles
                        join role in _context.Roles on userRole.RoleId
                            equals role.Id
                        select role.Name).ToList()
                }).ToList().Select(p => new UsersInRoleViewModel()
                {
                    UserId = p.UserId,
                    UserName = p.Username,
                    Email = p.Email,
                    Role = string.Join(",", p.RoleNames),
                    LastLogin = p.LastLogin.Year == 1900 ? 
                        "No Information" : 
                        p.LastLogin.ToLocalTime().ToLongDateString() + " " + p.LastLogin.ToLocalTime().ToLongTimeString()
                });


            return View(usersWithRoles);
        }

        public ActionResult New()
        {
            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(_context));
            //var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(_context));

            //const string roleName = "Admin";

            //if (!roleManager.RoleExists(roleName))
            //{
            //    var role = new IdentityRole {Name = roleName};
            //    roleManager.Create(role);
            //}

            //userManager.AddToRole(User.Identity.GetUserId(), roleName);


            //if (User.IsInRole(roleName))
            //{
            //    return Content($"{User.Identity.Name} is in the role of {roleName}");
            //}

            return Content("Failed");
        }
    }
}