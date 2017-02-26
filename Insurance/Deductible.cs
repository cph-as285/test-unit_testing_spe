using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance
{
    public static class Deductible
    {
        public static int CalculateReimburse(bool deductibleMet, TypeOfVisit typeOfVisit)
        {
            if (!deductibleMet)
                return 0;

            return typeOfVisit == TypeOfVisit.HospitalVisit ? 80 : 50;
        }
    }
}
