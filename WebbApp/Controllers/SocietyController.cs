using Microsoft.AspNetCore.Mvc;
using Service.Implementations;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbApp.Models;

namespace WebbApp.Controllers
{
    public class SocietyController : Controller
    {
        private ISocietyInterface _societyInterface;
        public SocietyController(ISocietyInterface _societyInterface)
        {
            this._societyInterface = _societyInterface;
        }
        public async Task<IActionResult> Index()
        {
            var vm = new SocietyViewModel();
            vm.ListSociety = await _societyInterface.GetAll();
            return View(vm);
        }
        public IActionResult AddSociety()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddSociety(SocietyViewModel societyViewModel)
        {
            var data = await _societyInterface.Add(societyViewModel.Society);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdateSociety(int id)
        {
            var vm = new SocietyViewModel();
            vm.Society = await _societyInterface.Get(id);
            return View(vm);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateSociety(SocietyViewModel societyViewModel)
        {
            await _societyInterface.Update(societyViewModel.Society);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteSociety(int id)
        {
            await _societyInterface.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
