using System.Collections.Generic;
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
        
        public bool Inspiration { get; set; }

        [Display(Name = "Armour Class")]
        public int ArmourClass { get; set; }

        public int Speed { get; set; }

        [Display(Name = "Current Hit Points")]
        public int HitPointsCurrent { get; set; }

        [Display(Name = "Maximum Hit Points")]
        public int HitPointsMaximum { get; set; }

        [Display(Name = "Temporary Hit Points")]
        public int HitPointsTemporary { get; set; }

        public bool Miserable { get; set; }


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

        //Attacks
        public CharacterWeapon CharacterWeapon1 { get; set; }
        public CharacterWeapon CharacterWeapon2 { get; set; }
        public CharacterWeapon CharacterWeapon3 { get; set; }

        [StringLength(200)]
        public string Attacks { get; set; }

        //Features, traits, and virtues
        [StringLength(1000), Display(Name = "Features, Traits, and Virtues")]
        public string FeaturesTraitsVirtues { get; set; }

        //Equipment
        public int Gold { get; set; }
        public int Silver { get; set; }
        public int Copper { get; set; }

        [StringLength(200)]
        public string Equipment { get; set; }

        //Other Proficiencies & Languages
        [StringLength(200), Display(Name = "Other Proficiencies and Languages")]
        public string OtherProficienciesAndLangages { get; set; }

        //Standard of Living
        [StringLength(40), Display(Name = "Standard of Living")]
        public string StandardOfLiving { get; set; }

        //Character Basics
        public CharacterBasics CharacterBasics { get; set; }

        //Character Appearance
        [StringLength(500), Display(Name = "Character Appearance")]
        public string CharacterAppearance { get; set; }

        //Allies and Patrons
        [StringLength(500), Display(Name = "Allies and Patrons")]
        public string AlliesAndPatrons { get; set; }

        //Character Backstory
        [StringLength(500), Display(Name = "Character Backstory")]
        public string CharacterBackstory { get; set; }

        //Additional Features and Traits
        [StringLength(500), Display(Name = "Additional Features and Traits")]
        public string AdditionalFeaturesAndTraits { get; set; }

        //Treasure
        [StringLength(500)]
        public string Treasure { get; set; }
    }
}