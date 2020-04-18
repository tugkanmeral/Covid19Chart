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

        [HttpPost]
        public IActionResult AddData(DashboardAddData model)
        {
            var dailyData = new DailyData()
            {
                Case = model.Case,
                CountryId = 1,
                Death = model.Death,
                Recovered = model.Recovered,
                TestAmount = model.TestAmount
            };

            dailyData.Id = _dataService.AddDailyData(dailyData);

            if (dailyData.Id > 0)
                return View(model);
            else
                return View();
        }

        public IActionResult AddData()
        {
            return View();
        }
    }
}