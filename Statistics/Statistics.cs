using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Stats
    {
        public float average { get; set; }
        public float max { get; set; }
        public float min { get; set; }
    }
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers)
        {
            //Implement statistics here
            Stats currentStats = new();
            if (numbers.Count > 0)
            {
                currentStats.average = (float)numbers.Sum() / numbers.Count();
                currentStats.max = numbers.Max();
                currentStats.min = numbers.Min();
            }
            return currentStats;
        }
    }
}
