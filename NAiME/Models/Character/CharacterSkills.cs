using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NAiME.Models.Character
{
    public class CharacterSkills
    {
        [Required]
        public bool AcrobaticsDex { get; set; }

        [Required]
        public bool AnimalHandlingWis { get; set; }

        [Required]
        public bool AthleticsStr { get; set; }

        [Required]
        public bool DeceptionCha { get; set; }

        [Required]
        public bool HistoryInt { get; set; }

        [Required]
        public bool InsightWis { get; set; }

        [Required]
        public bool IntimidationCha { get; set; }

        [Required]
        public bool InvestigationInt { get; set; }

        [Required]
        public bool LoreInt { get; set; }

        [Required]
        public bool MedicineWis { get; set; }

        [Required]
        public bool NatureInt { get; set; }

        [Required]
        public bool PerceptionWis { get; set; }

        [Required]
        public bool PerformanceCha { get; set; }

        [Required]
        public bool PersuasionCha { get; set; }

        [Required]
        public bool RiddleInt { get; set; }

        [Required]
        public bool ShadowLoreInt { get; set; }

        [Required]
        public bool SleightOfHandDex { get; set; }

        [Required]
        public bool StealthDex { get; set; }

        [Required]
        public bool SurvivalWis { get; set; }

        [Required]
        public bool TraditionsInt { get; set; }
    }
}