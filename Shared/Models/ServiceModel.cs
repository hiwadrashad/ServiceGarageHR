using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shared.Models
{
    public enum Services
    { 
      Bandenspanning,
      Olie,
      Lichten,
      Computer,
      Accu,
      Motor,
    }

    public enum ExtraServices
    { 
      Wassen,
      Schoonmaken,
      Winterbanden
    }
    public class ServiceModel
    {
        [Key]
        public string Id { get; set; }
        public bool ServiceChosen { get; set; }
        public bool ExtraServiceChosen { get; set; }
        public bool ExternalServiceChosen { get; set; }
        public Services Service { get; set; } 
        [Display(Name = "Extra service")]
        public ExtraServices ExtraService { get; set; }
        public string Descriptie { get; set; }
        [Display(Name = "Externe dienst")]
        public ExterneDienstModel ExterneDienst { get; set; } = new ExterneDienstModel();

    }
}
