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
        public Stats CalculateStatistics(List<float> numbers)
        {
            //Implement statistics here
            Stats currentStats = new();
            List<float> numbersNoNaN = numbers.Where(x => !x.Equals(Double.NaN)).ToList();
            if(numbersNoNaN.Count > 0) {
                currentStats.average = (double)numbers.Sum() / numbers.Count;
                currentStats.max = numbers.Max();
                currentStats.min = numbers.Min();
            }
            else
            {
                currentStats.average = Double.NaN;
                currentStats.max = Double.NaN;
                currentStats.min = Double.NaN;
            }
            return currentStats;
        }
    }
}
