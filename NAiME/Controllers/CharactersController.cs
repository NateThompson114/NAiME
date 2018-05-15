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
                var viewModel = new Character();
                viewModel = character;

                return View("Save", viewModel);
            }

            if (character.Id == 0)
            {
                var currentUser = User.Identity?.GetUserId();

                var user = _context.Users.Single(u => u.Id == currentUser);

                character.PlayerToken = user.UserToken;

                var characterInDb = _context.Characters.Add(character);
                _context.SaveChanges();

                characterInDb.CharacterToken = characterInDb.Id.ToString().HashThis(SHA512.Create());
            }
            else
            {
                var characterInDb = _context.Characters.Single(c => c.Id == character.Id);

                //id
                characterInDb.Name = character.Name;
                //CharacterToken
                //PlayerToken
                //GroupToken
                characterInDb.Inspiration = character.Inspiration;
                characterInDb.ArmourClass = character.ArmourClass;
                characterInDb.Speed = character.Speed;
                characterInDb.CharacterHitPoints = character.CharacterHitPoints ?? new CharacterHitPoints();
                characterInDb.Miserable = character.Miserable;
                characterInDb.Background = character.Background;
                characterInDb.PlayerName = character.PlayerName;
                characterInDb.Culture = character.Culture;
                characterInDb.ShadowWeakness = character.ShadowWeakness;
                characterInDb.CharacterHitDices = character.CharacterHitDices ?? new CharacterHitDices();
                characterInDb.CharacterDeathThrows = character.CharacterDeathThrows ?? new CharacterDeathThrows();

                characterInDb.CharacterMainStats = character.CharacterMainStats;
                characterInDb.CharacterSavingThrows = character.CharacterSavingThrows;
                characterInDb.CharacterSkills = character.CharacterSkills;
                characterInDb.CharacterLevel = character.CharacterLevel;
                characterInDb.CharacterTraits = character.CharacterTraits;

                characterInDb.CharacterWeapon1 = character.CharacterWeapon1 ?? new CharacterWeapon();
                characterInDb.CharacterWeapon2 = character.CharacterWeapon2 ?? new CharacterWeapon();
                characterInDb.CharacterWeapon3 = character.CharacterWeapon3 ?? new CharacterWeapon();
                characterInDb.Attacks = character.Attacks;

                characterInDb.FeaturesTraitsVirtues = character.FeaturesTraitsVirtues;

                characterInDb.Gold = character.Gold;
                characterInDb.Silver = character.Silver;
                characterInDb.Copper = character.Copper;

                characterInDb.Equipment = character.Equipment;

                characterInDb.OtherProficienciesAndLangages = character.OtherProficienciesAndLangages;

                characterInDb.StandardOfLiving = character.StandardOfLiving;

                characterInDb.CharacterBasics = character.CharacterBasics ?? new CharacterBasics();

                characterInDb.CharacterAppearance = character.CharacterAppearance;

                characterInDb.AlliesAndPatrons = character.AlliesAndPatrons;

                characterInDb.CharacterBackstory = character.CharacterBackstory;

                characterInDb.AdditionalFeaturesAndTraits = character.AdditionalFeaturesAndTraits;

                characterInDb.Treasure = character.Treasure;

            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Characters");
        }
    }
}