using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PyatkovaAYu.Sprint3.Task4.V12.Lib
{
    public class DataService : ISprint3Task4V12
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x != 0)
                {
                    double y = x / (x + Math.Sin(x)) + 2.5;
                    res *= y;
                }
                else
                {
                    continue;
                }
            }
            return Math.Round(res, 3);
        }
    }
}
