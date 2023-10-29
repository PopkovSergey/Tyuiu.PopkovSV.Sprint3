﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PopkovSV.Sprint3.Task7.V24.Lib
{
    public class DataService : ISprint3Task7V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] arr = new double[stopValue - startValue + 1];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                arr[count] = Math.Round((Math.Sin(x) / (x + 1.2)) - (Math.Sin(x) * 2) - (2 * x), 2);
                count++;
            }
            return arr;
        }
    }
}
