using Logic.DelegateLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repo.Interfaces;
using Shared.Models;
using Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceGarageHR.Controllers
{
    public class Services : Controller
    {
        // GET: AddServices
        public delegate void ServiceDelegates();
        ServiceDelegates DEL;
        DelegateMethods Methods = new DelegateMethods();
        private readonly IMockingRepository _repo = Repo.MockingRepo.MockingRepository.GetMockingRepo();

        
        public ActionResult AddServices()
        {
            ServiceViewModel VM = new ServiceViewModel()
            {
                PreviousChosenServices = _repo.ReturnValues()
            };
            return View(VM);
        }  

        [HttpPost]
        public ActionResult AddBandenSpanning()
        {
 
            DEL -= Methods.AddBandenSpanning;
            DEL += Methods.AddBandenSpanning;
            DEL?.Invoke();

            return RedirectToAction("AddServices", "Services");
        }

        [HttpPost]
        public ActionResult AddOlie()
        {

            DEL -= Methods.AddOlie;
            DEL += Methods.AddOlie;
            DEL?.Invoke();

            return RedirectToAction("AddServices", "Services");
        }


        [HttpPost]
        public ActionResult AddLichten()
        {

            DEL -= Methods.AddLichten;
            DEL += Methods.AddLichten;
            DEL?.Invoke();

            return RedirectToAction("AddServices", "Services");
        }

        [HttpPost]
        public ActionResult AddComputer()
        {

            DEL -= Methods.AddComputer;
            DEL += Methods.AddComputer;
            DEL?.Invoke();

            return RedirectToAction("AddServices", "Services");
        }

        [HttpPost]
        public ActionResult AddAccu()
        {

            DEL -= Methods.AddAccu;
            DEL += Methods.AddAccu;
            DEL?.Invoke();

            return RedirectToAction("AddServices", "Services");
        }

        [HttpPost]
        public ActionResult AddMotor()
        {

            DEL -= Methods.AddMotor;
            DEL += Methods.AddMotor;
            DEL?.Invoke();

            return RedirectToAction("AddServices", "Services");
        }

        [HttpPost]
        public ActionResult AddExtraWassen()
        {

            DEL -= Methods.AddExtraWassen;
            DEL += Methods.AddExtraWassen;
            DEL?.Invoke();

            return RedirectToAction("AddServices", "Services");
        }

        [HttpPost]
        public ActionResult AddExtraSchoonmaken()
        {

            DEL -= Methods.AddExtraSchoonmaken;
            DEL += Methods.AddExtraSchoonmaken;
            DEL?.Invoke();

            return RedirectToAction("AddServices", "Services");
        }

        [HttpPost]
        public ActionResult AddExtraWinterBanden()
        {

            DEL -= Methods.AddExtraWinterBanden;
            DEL += Methods.AddExtraWinterBanden;
            DEL?.Invoke();

            return RedirectToAction("AddServices", "Services");
        }
        // GET: AddServices/Details/5
        [HttpPost]
        public ActionResult Clear()
        {

            DEL = null;
            _repo.Empty();
            return RedirectToAction("AddServices", "Services");
        }

        [HttpPost]

        public ActionResult AddExterneDienst(ServiceViewModel model)
        {
            model.CurrentService.ExternalServiceChosen = true;
            _repo.AddValue(model.CurrentService);
            return RedirectToAction("AddServices", "Services");
        }
    }
}
