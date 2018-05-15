using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NAiME.Models.Character
{
    public class CharacterHitPoints
    {
        [Display(Name = "Current Hit Points")]
        public int HitPointsCurrent { get; set; }

        [Display(Name = "Maximum Hit Points")]
        public int HitPointsMaximum { get; set; }

        [Display(Name = "Temporary Hit Points")]
        public int HitPointsTemporary { get; set; }
    }
}