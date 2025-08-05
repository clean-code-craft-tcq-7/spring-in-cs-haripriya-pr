using System;
using Xunit;
using Statistics;
using System.Collections.Generic;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<float>{(float)1.5, (float)8.9, (float)3.2, (float)4.5 });
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.average - 4.525) <= epsilon);
            Assert.True(Math.Abs(computedStats.max - 8.9) <= epsilon);
            Assert.True(Math.Abs(computedStats.min - 1.5) <= epsilon);
        }
        [Fact]
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<float>{});
            // All fields of computedStats (average, max, min) must be
            // Double.NaN (not-a-number), as described in
            // https://docs.microsoft.com/en-us/dotnet/api/system.double.nan?view=netcore-3.1
            // Specify the Assert statements here
            Assert.True(computedStats.average.Equals(Double.NaN));
            Assert.True(computedStats.max.Equals(Double.NaN));
            Assert.True(computedStats.min.Equals(Double.NaN));
        }

        [Fact]
        public void ReportsAvgMinMaxIgnoreNaNInput()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<float> {(float) Double.NaN, (float) 1.5, (float) 8.9 });
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.average - 5.2) <= epsilon);
            Assert.True(Math.Abs(computedStats.max - 8.9) <= epsilon);
            Assert.True(Math.Abs(computedStats.min - 1.5) <= epsilon);
        }

        [Fact]
        public void ReportsNaNForAllNaNInput()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<float> {(float) Double.NaN, (float)Double.NaN, (float)Double.NaN });
            // All fields of computedStats (average, max, min) must be
            // Double.NaN (not-a-number), as described in
            // https://docs.microsoft.com/en-us/dotnet/api/system.double.nan?view=netcore-3.1
            // Specify the Assert statements here
            Assert.True(computedStats.average.Equals(Double.NaN));
            Assert.True(computedStats.max.Equals(Double.NaN));
            Assert.True(computedStats.min.Equals(Double.NaN));
        }
    }
}
