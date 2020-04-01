using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace CoronaTracker.Models
{
    public class DashboardIndex
    {
        public List<DailyData> DailyDatas { get; set; } = new List<DailyData>();
    }
}
