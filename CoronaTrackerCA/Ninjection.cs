using BusinessLogic.Abstract;
using BusinessLogic.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Ninject;
using Ninject.Modules;

namespace CoronaTrackerCA
{
    public class Ninjection : NinjectModule
    {
        public override void Load()
        {
            Bind<IDataService>().To<DataManager>();
            Bind<ICountryDal>().To<EfCountryDal>();
            Bind<IDailyDataDal>().To<EfDailyDataDal>();
        }
    }
}
