using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using NAiME.Models;
using NAiME.Models.Character;
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
            var currentUser = User.Identity.GetUserId();
            var user = _context.Users.SingleOrDefault(u => u.Id == currentUser);
            
            //var characters = _context.Characters.ToList()
            //    .Where(c => user != null && c.PlayerToken == user.UserToken);

            return View(user);
        }

        public ActionResult New()
        {
            var viewModel = new Character
            {
                CharacterMainStats = new CharacterMainStats
                {
                    Charisma = 8,
                    Constitution = 8,
                    Dexterity = 8,
                    Intelligence = 8,
                    Shadow = 8,
                    Strength = 8,
                    Wisdom = 8
                },
                CharacterSkills = new CharacterSkills(),
                CharacterSavingThrows = new CharacterSavingThrows(),
                CharacterLevel = new CharacterLevel(),
                CharacterTraits = new CharacterTraits()
            };
            return View("Save", viewModel);
        }

        public ActionResult Edit(string query)
        {
            var characterInDb = _context.Characters.Single(c => c.CharacterToken == query);

            if (characterInDb == null)
                return HttpNotFound();

            var viewData = new Character();
            viewData = characterInDb;

            return View("Save", viewData);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Save(Character character)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new Character
                {
                    CharacterLevel = character.CharacterLevel,
                    CharacterMainStats = character.CharacterMainStats,
                    CharacterSavingThrows = character.CharacterSavingThrows,
                    CharacterSkills = character.CharacterSkills,
                    CharacterToken = character.CharacterToken,
                    ExperiencePoints = character.ExperiencePoints,
                    GroupToken = character.GroupToken,
                    Id = character.Id,
                    Inspiration = character.Inspiration,
                    Name = character.Name
                };
                return View("Save", viewModel);
            }

            if (character.Id == 0)
            {
                var currentUser = User.Identity?.GetUserId();

                var user = _context.Users.Single(u => u.Id == currentUser);

                character.PlayerToken = user.UserToken;
                character.Inspiration = false;

                var characterInDb = _context.Characters.Add(character);
                _context.SaveChanges();

                characterInDb.CharacterToken = characterInDb.Id.ToString().HashThis(SHA512.Create());
            }
            else
            {
                var characterInDb = _context.Characters.Single(c => c.Id == character.Id);

                characterInDb.Name = character.Name;
                characterInDb.ExperiencePoints = character.ExperiencePoints;
                characterInDb.Inspiration = character.Inspiration;
                characterInDb.CharacterMainStats = character.CharacterMainStats;
                characterInDb.CharacterSavingThrows = character.CharacterSavingThrows;
                characterInDb.CharacterSkills = character.CharacterSkills;
                characterInDb.CharacterLevel = character.CharacterLevel;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Characters");
        }
    }
}