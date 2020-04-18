using BusinessLogic.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace CoronaTracker.Controllers
{
    public class DailyDataController : ApiController
    {
        private IDataService _dataService;
        public DailyDataController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpPost]
        public bool Post(DailyData dailyData)
        {
            int id = _dataService.AddDailyData(dailyData);
            return id > 0;
        }
    }
}
