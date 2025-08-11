using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Stats
    {
        public double average { get; set; }
        public double max { get; set; }
        public double min { get; set; }
    }
    public class StatsComputer
    {
        public static bool IsAbsurdValue(List<double> numbers)
        {
            return numbers.Where(x => x < 0 || x > 200).Any();
        }

        public Stats CalculateStatistics(List<double> numbers)
        {
            //Implement statistics here
            Stats currentStats = new();
            List<double> numbersNoNaN = numbers.Where(x => !x.Equals(double.NaN)).ToList();
            if(numbersNoNaN.Count > 0 && !IsAbsurdValue(numbers)) {
                currentStats.average = (double)numbersNoNaN.Sum() / numbersNoNaN.Count;
                currentStats.max = numbersNoNaN.Max();
                currentStats.min = numbersNoNaN.Min();
            }
            else
            {
                currentStats.average = double.NaN;
                currentStats.max = double.NaN;
                currentStats.min = double.NaN;
            }
            return currentStats;
        }
    }
}
