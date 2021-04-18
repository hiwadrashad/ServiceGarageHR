using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class ExterneDienstModel
    {
        public string id { get; set; }
        [Display(Name = "Externe dienst naam")]
        public string ExterneDienstNaam { get; set; } = "";
        public string Bedrijf { get; set; } = "";
    }
}
