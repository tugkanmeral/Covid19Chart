using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Abstract;
using CoronaTracker.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoronaTracker.Controllers
{
    public class DashboardController : Controller
    {
        private IDataService _dataService;
        public DashboardController(IDataService dataService)
        {
            _dataService = dataService;
        }

        public IActionResult Index(int countryId = 1)
        {
            DashboardIndex model = new DashboardIndex()
            {
                DailyDatas = _dataService.GetCountryData(countryId)
            };

            return View(model);
        }

        [HttpGet]
        public JsonResult GetRawDataByCountryId(int id)
        {
            var rawData = _dataService.GetCountryData(id);
            return Json(rawData);
        }

    }
}