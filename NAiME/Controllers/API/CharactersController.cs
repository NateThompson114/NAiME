using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NAiME.Models;
using NAiME.Models.Character;

namespace NAiME.Controllers.API
{
    [AllowAnonymous]
    public class CharactersController : ApiController
    {
        private ApplicationDbContext _context;

        public CharactersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/characters
        public IHttpActionResult GetCharacters(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return NotFound();

            var characterQuery = _context.Characters.Where(c => c.PlayerToken.Contains(query));

            return Ok(characterQuery.ToList());

        }
    }
}
