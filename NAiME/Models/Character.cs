using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NAiME.Models
{
    public class Character
    {
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string CharacterToken { get; set; }

        [Required, StringLength(200)]
        public string PlayerToken { get; set; }

        [StringLength(200)]
        public string GroupToken { get; set; }

        [Required]
        public int Strength { get; set; }

        [Required]
        public int Dexterity { get; set; }

        [Required]
        public int Constitution { get; set; }

        [Required]
        public int Intelligence { get; set; }

        [Required]
        public int Wisdom { get; set; }

        [Required]
        public int Charisma { get; set; }

        [Required]
        public int Shadow { get; set; }

        [Required]
        public int PermanentShadow { get; set; }

        [Required] public int ProficiencyBonus { get; set; }

        public bool Inspiration { get; set; }

    }
}