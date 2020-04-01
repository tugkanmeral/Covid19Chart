using Core.CoreEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class DailyData : IEntity
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public DateTime Date { get; set; }
        public int? Case { get; set; }
        public int? Death { get; set; }
        public int? Recovered { get; set; }
        public int? TestAmount { get; set; }
    }
}
