using System;

namespace HospitalCareManagementSystem04.Services
{
    public static class DiagnosisService
    {
        public static void Evaluate(in int age, ref string condition, out string riskLevel, params int[] testScores)
        {
            int sum = 0;
            foreach (var s in testScores)
            {
                sum += s;
            }

            static bool IsCritical(int s) => s > 250;

            if (IsCritical(sum) || age > 60)
            {
                condition = "Serious";
                riskLevel = "High";
            }
            else
            {
                // keep condition as-is (caller provided) and assign risk level
                riskLevel = "Moderate";
            }
        }
    }
}
