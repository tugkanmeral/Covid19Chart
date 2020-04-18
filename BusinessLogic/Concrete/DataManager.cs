using BusinessLogic.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic.Concrete
{
    public class DataManager : IDataService
    {
        IDailyDataDal _dailyDataDal = new EfDailyDataDal();

        public int AddDailyData(DailyData dailyData)
        {
            dailyData.Date = DateTime.Today;
            return _dailyDataDal.Add(dailyData);
        }

        public List<DailyData> GetCountryData(int countryId)
        {
            return _dailyDataDal.GetList(d => d.CountryId.Equals(countryId))
                .OrderBy(d => d.Date.Year)
                .ThenBy(d => d.Date.Month)
                .ThenBy(d => d.Date.Day)
                .ToList();
        }

        public DailyData GetFirstData(int countryId)
        {
            return _dailyDataDal.Get(d => d.Id > 1);
        }
    }
}
