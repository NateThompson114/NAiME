using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using NAiME.Models;
using NAiME.Tools;

namespace NAiME.Controllers
{
    public class CharactersController : Controller
    {
        private ApplicationDbContext _context;

        public CharactersController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Character
        public ActionResult Index()
        {
            //return Content(User.Identity.GetUserId());
            var currentUser = User.Identity.GetUserId();
            var user = _context.Users.SingleOrDefault(u => u.Id == currentUser.ToString());

            var characters = _context.Characters.ToList().Where(c => c.PlayerToken == user.UserToken);
            return View(characters);
        }

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(Character character)
        {
            var currentUser = User.Identity.GetUserId();
            var user = _context.Users.Single(u => u.Id == currentUser);
            
            character.PlayerToken = user.UserToken;
            character.Shadow = 0;
            character.PermanentShadow = 0;
            character.Inspiration = false;

            var characterInDb = _context.Characters.Add(character);
            _context.SaveChanges();

            characterInDb.CharacterToken = characterInDb.Id.ToString().HashThis(SHA512.Create());
            _context.SaveChanges();

            return RedirectToAction("Index", "Characters");
        }
    }
}