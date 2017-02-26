using Insurance;
using Xunit;

namespace InsuranceTest
{
    class InsuranceTest
    {
        [Theory]
        [InlineData(true, TypeOfVisit.DoctorsOffice, 50)]
        [InlineData(true, TypeOfVisit.HospitalVisit, 80)]
        [InlineData(false, TypeOfVisit.DoctorsOffice, 0)]
        [InlineData(false, TypeOfVisit.HospitalVisit, 0)]
        public void DecisionTest(bool deductibleMet, TypeOfVisit typeOfVisit, int reimburse)
        {
            Assert.Equal(Deductible.CalculateReimburse(deductibleMet, typeOfVisit), reimburse);
        }
    }
}
