using System;

namespace HospitalCareManagementSystem04.Core
{
    public class Doctor
    {
        public static int TotalDoctors;
        public readonly string LicenseNumber;
        public string Name { get; set; }

        static Doctor()
        {
            TotalDoctors = 0;
        }

        public Doctor(string licenseNumber, string name)
        {
            if (string.IsNullOrWhiteSpace(licenseNumber)) throw new ArgumentException("License number required", nameof(licenseNumber));
            LicenseNumber = licenseNumber;
            Name = name;
            TotalDoctors++;
        }
    }
}
