using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NAiME.Models.Character
{
    public class CharacterSavingThrows
    {
        [Range(0, 4)]
        public int SavingThrowStrengthMultiplier { get; set; }

        [Range(0, 4)]
        public int SavingThrowDexterityMultiplier { get; set; }

        [Range(0, 4)]
        public int SavingThrowConstitutionMultiplier { get; set; }

        [Range(0, 4)]
        public int SavingThrowIntelligenceMultiplier { get; set; }

        [Range(0, 4)]
        public int SavingThrowWisdomMultiplier { get; set; }

        [Range(0, 4)]
        public int SavingThrowCharismaMultiplier { get; set; }

        [Range(0, 4)]
        public int SavingThrowCorruptionMultiplier { get; set; }
    }
}