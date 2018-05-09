using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NAiME.Models
{
    public class ChangeLog
    {
        public int Id { get; set; }

        [Required, StringLength(40)]
        public string VersionNumber { get; set; }

        [Required, StringLength(300)]
        public string Information { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}