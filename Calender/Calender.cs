using System;

namespace Calender
{
    public class Calender
    {
        public static int GetNumDaysinMonth(int month, int year)
        {
            return DateTime.DaysInMonth(year, month);
        }
    }
}
