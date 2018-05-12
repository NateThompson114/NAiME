using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NAiME.Models.Character
{
    public class CharacterTraits
    {
        [StringLength(500)] public string DistinctiveQuality { get; set; }
        [StringLength(500)] public string Speciality { get; set; }
        [StringLength(500)] public string Hope { get; set; }
        [StringLength(500)] public string Despair { get; set; }

    }
}