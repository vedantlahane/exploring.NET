using System;

namespace HospitalCareManagementSystem04.Utilities
{
    public static class CalculationHelper
    {
        public static int CalculateStayDays(int days)
        {
            if (days <= 0) return 0;
            return 1 + CalculateStayDays(days - 1);
        }
    }
}
