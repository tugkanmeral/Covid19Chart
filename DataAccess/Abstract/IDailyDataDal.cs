﻿using Core.CoreDataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IDailyDataDal : IEntityRepository<DailyData>
    {
    }
}
