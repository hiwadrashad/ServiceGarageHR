using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shared.ViewModels
{
    public class ServiceViewModel
    {
        public List<Services> Services = Enum.GetValues(typeof(Services)).Cast<Services>().ToList();
        [Display(Name = "Extra service")]
        public List<ExtraServices> ExtraServices = Enum.GetValues(typeof(ExtraServices)).Cast<ExtraServices>().ToList();
        public ServiceModel CurrentService { get; set; } = new ServiceModel();
        public List<ServiceModel> PreviousChosenServices { get; set; } = new List<ServiceModel>();
    }
}
