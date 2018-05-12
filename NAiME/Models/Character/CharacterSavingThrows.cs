using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NAiME.Models.Character
{
    public class CharacterSavingThrows
    {
        [Required, Range(0,2)]
        public int SavingThrowStrengthMultiplier { get; set; }

        [Required, Range(0, 2)]
        public int SavingThrowDexterityMultiplier { get; set; }

        [Required, Range(0, 2)]
        public int SavingThrowConstitutionMultiplier { get; set; }

        [Required, Range(0, 2)]
        public int SavingThrowIntelligenceMultiplier { get; set; }

        [Required, Range(0, 2)]
        public int SavingThrowWisdomMultiplier { get; set; }

        [Required, Range(0, 2)]
        public int SavingThrowCharismaMultiplier { get; set; }

        [Required, Range(0, 2)]
        public int SavingThrowCorruptionMultiplier { get; set; }
    }
}