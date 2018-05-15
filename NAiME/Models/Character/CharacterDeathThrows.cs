using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NAiME.Models.Character
{
    public class CharacterDeathThrows
    {
        [Range(0,3)]
        public int Succes { get; set; }

        [Range(0, 3)]
        public int Failure { get; set; }
    }
}