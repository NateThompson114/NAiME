using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NAiME.Models.Character
{
    public class CharacterBasics
    {
        public int Age { get; set; }

        [StringLength(10)]
        public string Height { get; set; }

        public int Weight { get; set; }

        [StringLength(10)]
        public string Eyes { get; set; }

        [StringLength(10)]
        public string Skin { get; set; }

        [StringLength(10)]
        public string Hair { get; set; }
    }
}