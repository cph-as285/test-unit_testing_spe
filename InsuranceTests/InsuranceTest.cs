using Insurance;
using NUnit.Framework;

namespace InsuranceTest
{
    class InsuranceTest
    {
        [TestCase(true, TypeOfVisit.DoctorsOffice, 50)]
        [TestCase(true, TypeOfVisit.HospitalVisit, 80)]
        [TestCase(false, TypeOfVisit.DoctorsOffice, 0)]
        [TestCase(false, TypeOfVisit.HospitalVisit, 0)]
        public void DecisionTest(bool deductibleMet, TypeOfVisit typeOfVisit, int reimburse)
        {
            Assert.That(Deductible.CalculateReimburse(deductibleMet, typeOfVisit), Is.EqualTo(reimburse));
        }
    }
}
