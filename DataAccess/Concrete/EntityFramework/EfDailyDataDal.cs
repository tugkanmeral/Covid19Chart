using Core.CoreDataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDailyDataDal : EfEntityRepositoryBase<DailyData, DatabaseContext>, IDailyDataDal
    {
    }
}
