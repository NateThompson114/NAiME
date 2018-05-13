using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NAiME.Models.Character
{
    public class CharacterWeapon
    {
        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(6), Display(Name = "Attack Bonus")]
        public string AttackBonus { get; set; }

        [StringLength(60), Display(Name = "Damage Type")]
        public string DamageType { get; set; }
    }
}