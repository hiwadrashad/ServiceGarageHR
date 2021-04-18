using Repo.Interfaces;
using Repo.MockingRepo;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.DelegateLogic
{
    public class DelegateMethods
    {
        IMockingRepository _repo = MockingRepository.GetMockingRepo();

        public void InitialMethod()
        {
        }
        public void AddBandenSpanning()
        {
          _repo.AddValue(Reductions.Methods.GenerateGeneralService(Services.Bandenspanning));
        }

        public void AddOlie()
        {
            _repo.AddValue(Reductions.Methods.GenerateGeneralService(Services.Olie));
        }

        public void AddLichten()
        {
            _repo.AddValue(Reductions.Methods.GenerateGeneralService(Services.Lichten));
        }

        public void AddComputer()
        {
            _repo.AddValue(Reductions.Methods.GenerateGeneralService(Services.Computer));
        }

        public void AddAccu()
        {
            _repo.AddValue(Reductions.Methods.GenerateGeneralService(Services.Accu));
        }

        public void AddMotor()
        {
            _repo.AddValue(Reductions.Methods.GenerateGeneralService(Services.Motor));
        }

        public void AddExtraWassen()
        {
            _repo.AddValue(Reductions.Methods.GenerateExtraService(ExtraServices.Wassen));
        }

        public void AddExtraSchoonmaken()
        {
            _repo.AddValue(Reductions.Methods.GenerateExtraService(ExtraServices.Schoonmaken));
        }
        public void AddExtraWinterBanden()
        {
            _repo.AddValue(Reductions.Methods.GenerateExtraService(ExtraServices.Winterbanden));
        }

    }
}
