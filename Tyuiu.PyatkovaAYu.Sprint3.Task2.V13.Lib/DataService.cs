﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PyatkovaAYu.Sprint3.Task2.V13.Lib
{
    public class DataService : ISprint3Task2V13
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double SumSeries = 0;
            do
            {
                SumSeries = SumSeries + ((Math.Pow(value, startValue) + (2/(startValue + 1)))*Math.Sin(value));
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(SumSeries, 3);
        }
    }
}
