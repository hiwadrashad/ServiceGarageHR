using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Reductions
{
    public static class Methods
    {

        public static ServiceModel GenerateGeneralService(Services item)
        {
            ServiceModel model = new ServiceModel()
            {
                Id = Guid.NewGuid().ToString(),
                Descriptie = "",
                Service = item,
                ServiceChosen = true
            };

            return model;
        }

        public static ServiceModel GenerateExtraService(ExtraServices item)
        {
            ServiceModel model = new ServiceModel()
            {
                Id = Guid.NewGuid().ToString(),
                Descriptie = "",
                ExtraService = item,
                ExtraServiceChosen = true
            };

            return model;
        }
    }
}
