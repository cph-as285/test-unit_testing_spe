using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalenderTest
{
    public class CalenderTest
    {
        [Theory]
        [InlineData(1999, 1, 31)]
        [InlineData(2000, 1, 31)]
        [InlineData(2400, 4, 30)]
        [InlineData(2399, 4, 30)]
        [InlineData(2007, 2, 28)]
        [InlineData(2000, 2, 29)]
        public void ValidEquivalencesTest(int year, int month, int days)
        {
            Assert.Equal(Calender.Calender.GetNumDaysinMonth(month, year), days);
        }

        [Theory]
        [InlineData(1900, 0)]
        [InlineData(1900, 15)]
        [InlineData(-5, 5)]
        [InlineData(int.MaxValue, 5)]
        public void InvalidEquivalenceTest(int year, int month)
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => Calender.Calender.GetNumDaysinMonth(month, year)
            );
        }

        [Theory]
        [InlineData(399, 2, 28)]
        [InlineData(400, 2, 29)]
        [InlineData(401, 2, 28)]
        [InlineData(99, 2, 28)]
        [InlineData(100, 2, 28)]
        [InlineData(101, 2, 28)]
        [InlineData(500, 1, 31)]
        [InlineData(500, 2, 28)]
        [InlineData(500, 11, 30)]
        [InlineData(500, 12, 31)]
        public void ValidBoundaryValueAnalysis(int year, int month, int days)
        {
            Assert.Equal(Calender.Calender.GetNumDaysinMonth(month, year), days);
        }

        [Theory]
        [InlineData(500, 0)]
        [InlineData(500, 13)]
        public void InvalidBoundaryValueAnalysis(int year, int month)
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => Calender.Calender.GetNumDaysinMonth(month, year)
            );
        }
    }   
}
