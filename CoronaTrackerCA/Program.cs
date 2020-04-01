using BusinessLogic.Abstract;
using Entities.Concrete;
using Ninject;
using System;
using System.Collections.Generic;

namespace CoronaTrackerCA
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(new Ninjection());
            var dataManager = kernel.Get<IDataService>();

            List<DailyData> datas = dataManager.GetCountryData(1);
            Console.WriteLine("\t\tVaka\tÖlüm\tİyileşme\tTest-Vaka oranı");
            for (int i = 1; i < datas.Count; i++)
            {
                var caseIncreaseAmount = datas[i].Case - datas[i - 1].Case;
                var deathIncreaseAmount = datas[i].Death - datas[i - 1].Death;
                var recoveredIncreaseAmount = datas[i].Recovered - datas[i - 1].Recovered;

                var testAmount = datas[i].TestAmount;

                double testCaseRate = 0;

                if (testAmount != null)
                {
                    testCaseRate = Convert.ToDouble(caseIncreaseAmount) / Convert.ToDouble(testAmount);
                    Console.WriteLine(datas[i].Date.ToString("dd/MM/yyyy") + "\t" + caseIncreaseAmount + "\t" + deathIncreaseAmount + "\t" + recoveredIncreaseAmount + "\t\t%" + String.Format("{0:0}", testCaseRate * 100));
                }
                else
                {
                    Console.WriteLine(datas[i].Date.ToString("dd/MM/yyyy") + "\t" + caseIncreaseAmount + "\t" + deathIncreaseAmount + "\t" + recoveredIncreaseAmount);
                }
            }
        }
    }
}
