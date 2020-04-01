using BusinessLogic.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System.Collections.Generic;

namespace BusinessLogic.Concrete
{
    public class DataManager : IDataService
    {
        IDailyDataDal _dailyDataDal = new EfDailyDataDal();

        public List<DailyData> GetCountryData(int countryId)
        {
            return _dailyDataDal.GetList(d => d.CountryId.Equals(countryId));
        }

        public DailyData GetFirstData(int countryId)
        {
            return _dailyDataDal.Get(d => d.Id > 1);
        }
    }
}
