using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NAiME.Models.Character
{
    public class CharacterHitDices
    {
        [StringLength(6), Display(Name = "Hit Dice")]
        public string HitDice { get; set; }
        
        public int Total { get; set; }
    }
}