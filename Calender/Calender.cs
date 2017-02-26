using System;
using System.Collections.Generic;

namespace Calender
{
    public class Calender
    {
        private static Dictionary<int, int> _daysInMonth = new Dictionary<int, int>
        {
            {1, 31},
            {2, 28},
            {3, 31},
            {4, 30},
            {5, 31},
            {6, 30},
            {7, 31},
            {8, 31},
            {9, 30},
            {10, 31},
            {11, 30},
            {12, 31}
        };

        public static int GetNumDaysinMonth(int month, int year)
        {
            if(month < 1 || month > 12 || year < 0 || year > int.MaxValue - 1)
                throw new ArgumentOutOfRangeException();

            int numOfDays = _daysInMonth[month];

            if (month == 2 && IsLeapYear(year))
                numOfDays++;

            return numOfDays;
        }

        private static bool IsLeapYear(int year)
        {
            if (year%400 == 0)
                return true;
            if (year%100 == 0)
                return false;
            if (year%4 == 0)
                return true;
            return false;
        }
    }
}
