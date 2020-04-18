using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaTracker.Models
{
    public class DashboardAddData
    {
        public int? Case { get; set; }
        public int? Death { get; set; }
        public int? Recovered { get; set; }
        public int? TestAmount { get; set; }
    }
}
