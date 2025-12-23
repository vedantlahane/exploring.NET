using System;

namespace HospitalCareManagementSystem04.Utilities
{
    public static class InputHelper
    {
        public static int ReadAge(string input)
        {
            if (!int.TryParse(input, out int age))
            {
                throw new ArgumentException("Invalid age input");
            }

            return age;
        }
    }
}
