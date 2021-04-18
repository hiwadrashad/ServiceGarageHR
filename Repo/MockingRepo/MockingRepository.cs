using Repo.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repo.MockingRepo
{
    public class MockingRepository : IMockingRepository
    {
        private List<ServiceModel> Services { get; set; }
        private static MockingRepository _mockingRepo;

        public MockingRepository()
        {

        }

        public static MockingRepository GetMockingRepo()
        {
            if (_mockingRepo == null)
            {
                _mockingRepo = new MockingRepository();
                _mockingRepo.InitData();
            }
            return _mockingRepo;
        }

        public void InitData()
        {
            Services = new List<ServiceModel>();
        }

        public List<ServiceModel> ReturnValues()
        {
            return Services;
        }

        public bool AddValue(ServiceModel model)
        {
            List<ServiceModel> GeneralServices = Services.Where(a => a.ServiceChosen).ToList();
            List<ServiceModel> ExtraServices = Services.Where(a => a.ExtraServiceChosen).ToList();
            List<ServiceModel> ExternalServices = Services.Where(a => a.ExternalServiceChosen).ToList();
            if (model.ServiceChosen)
            { 
                    if (!GeneralServices.Any(a => a.Service == model.Service))
                    {

                        Services.Add(model);

                    }              
            }
            if (model.ExtraServiceChosen)
            {
                if (!ExtraServices.Any(a => a.ExtraService == model.ExtraService))
                {
            
                    Services.Add(model);

                }
            }
            if (model.ExternalServiceChosen)
            {
                if (!ExternalServices.Any(a => a.ExterneDienst.ExterneDienstNaam == model.ExterneDienst.ExterneDienstNaam))
                {
       
                    Services.Add(model);

                }
            }
            return true;
        }

        public bool Empty()
        {
            Services.Clear();
            return true;
        }
    }
}
