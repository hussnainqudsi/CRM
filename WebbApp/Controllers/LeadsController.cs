using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using System;
using System.Threading.Tasks;
using WebbApp.Models;

namespace WebbApp.Controllers
{
    public class LeadsController : Controller
    {
        private ILeadsInterface _leadsInterface;
        private IDescriptionInterface _descriptionInterface;
        private ISocietyInterface _societyInterface;
        public LeadsController(ILeadsInterface _leadsInterface, ISocietyInterface _societyInterface, IDescriptionInterface _descriptionInterface)
        {
            this._leadsInterface = _leadsInterface;
            this._societyInterface = _societyInterface;
            this._descriptionInterface = _descriptionInterface;
        }
        public async Task<IActionResult> Index()
        {
            var vm = new LeadsViewModel();
            vm.ListLeads = await _leadsInterface.GetAll();
            return View(vm);
        }
        public async Task<IActionResult> AddLead()
        {
            var vm = new LeadsViewModel();
            vm.ListSociety = await _societyInterface.GetAll();
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> AddLead(LeadsViewModel leadsViewModel)
        {
            await _leadsInterface.Add(leadsViewModel.Leads);
            return RedirectToAction("Index");
        }
    }
}
