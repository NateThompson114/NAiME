using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NAiME.Models.Character
{
    public class CharacterSavingThrows
    {
        [Required]
        public bool SavingThrowStrength { get; set; }
        [Required]
        public int SavingThrowStrengthMultiplier { get; set; }

        [Required]
        public bool SavingThrowDexterity { get; set; }
        [Required]
        public int SavingThrowDexterityMultiplier { get; set; }

        [Required]
        public bool SavingThrowConstitution { get; set; }
        [Required]
        public int SavingThrowConstitutionMultiplier { get; set; }

        [Required]
        public bool SavingThrowIntelligence { get; set; }
        [Required]
        public int SavingThrowIntelligenceMultiplier { get; set; }

        [Required]
        public bool SavingThrowWisdom { get; set; }
        [Required]
        public int SavingThrowWisdomMultiplier { get; set; }

        [Required]
        public bool SavingThrowCharisma { get; set; }
        [Required]
        public int SavingThrowCharismaMultiplier { get; set; }

        [Required]
        public bool SavingThrowCorruption { get; set; }
        [Required]
        public int SavingThrowCorruptionMultiplier { get; set; }
    }
}