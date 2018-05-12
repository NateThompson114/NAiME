using System.ComponentModel.DataAnnotations;

namespace NAiME.Models.Character
{
    public class Character
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [StringLength(200)]
        public string CharacterToken { get; set; }

        [StringLength(200)]
        public string PlayerToken { get; set; }

        [StringLength(200)]
        public string GroupToken { get; set; }

        [Required]
        public int ExperiencePoints { get; set; }

        [Required]
        public bool Inspiration { get; set; }

        //Main Stats
        public CharacterMainStats CharacterMainStats { get; set; }

        //Saving Throws
        public CharacterSavingThrows CharacterSavingThrows { get; set; }

        //Skills
        public CharacterSkills CharacterSkills { get; set; }

        //Level
        public CharacterLevel CharacterLevel { get; set; }

        //Traits
        public CharacterTraits CharacterTraits { get; set; }
    }
}