using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Abstract
{
    public interface IDataService
    {
        List<DailyData> GetCountryData(int countryId);
        DailyData GetFirstData(int countryId);
    }
}
