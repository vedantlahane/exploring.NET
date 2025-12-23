using System;

namespace HospitalCareManagementSystem04.Services
{
    public static class InsuranceService
    {
        public static double ApplyCoverage(double billAmount, int coveragePercent)
        {
            double discount = billAmount * (coveragePercent / 100.0);
            double payable = billAmount - discount;
            return payable;
        }
    }
}
