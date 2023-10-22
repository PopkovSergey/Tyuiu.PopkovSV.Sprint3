using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PopkovSV.Sprint3.Task1.V15.Lib
{
    public class DataService : ISprint3Task1V15
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double MultiplySeries = 1;
            while (startValue <= stopValue)
            {
                MultiplySeries = MultiplySeries * ((Math.Pow(value, 2) * startValue) + 1);
                startValue++;
            }
            return Math.Round(MultiplySeries, 3);
        }
    }
}
