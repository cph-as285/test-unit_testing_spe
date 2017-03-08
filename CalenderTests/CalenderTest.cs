using System;
using NUnit.Framework;

namespace CalenderTests
{
    public class CalenderTest
    {
        [TestCase(1999, 1, 31)]
        [TestCase(2000, 1, 31)]
        [TestCase(2400, 4, 30)]
        [TestCase(2399, 4, 30)]
        [TestCase(2007, 2, 28)]
        [TestCase(2000, 2, 29)]
        public void ValidEquivalencesTest(int year, int month, int days)
        {
            Assert.That(Calender.Calender.GetNumDaysinMonth(month, year), Is.EqualTo(days));
        }

        [TestCase(1900, 0)]
        [TestCase(1900, 15)]
        [TestCase(-5, 5)]
        [TestCase(int.MaxValue, 5)]
        public void InvalidEquivalenceTest(int year, int month)
        {
            Assert.That(() => Calender.Calender.GetNumDaysinMonth(month, year),
                Throws.InstanceOf<ArgumentException>());
        }

        [TestCase(399, 2, 28)]
        [TestCase(400, 2, 29)]
        [TestCase(401, 2, 28)]
        [TestCase(99, 2, 28)]
        [TestCase(100, 2, 28)]
        [TestCase(101, 2, 28)]
        [TestCase(500, 1, 31)]
        [TestCase(500, 2, 28)]
        [TestCase(500, 11, 30)]
        [TestCase(500, 12, 31)]
        public void ValidBoundaryValueAnalysis(int year, int month, int days)
        {
            Assert.That(Calender.Calender.GetNumDaysinMonth(month, year), Is.EqualTo(days));
        }

        [TestCase(500, 0)]
        [TestCase(500, 13)]
        public void InvalidBoundaryValueAnalysis(int year, int month)
        {
            Assert.That(() => Calender.Calender.GetNumDaysinMonth(month, year),
                Throws.InstanceOf<ArgumentOutOfRangeException>());
        }
    }
}