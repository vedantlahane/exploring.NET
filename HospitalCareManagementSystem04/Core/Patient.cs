using System;

namespace HospitalCareManagementSystem04.Core
{
    public class Patient
    {
        public readonly string PatientId;
        public string Name { get; set; }
        public int Age { get; set; }

        private string medicalHistory;

        public Patient(string patientId, string name, int age)
        {
            if (string.IsNullOrWhiteSpace(patientId)) throw new ArgumentException("PatientId is required", nameof(patientId));
            PatientId = patientId;
            Name = name;
            Age = age;
        }

        public void SetMedicalHistory(string history)
        {
            medicalHistory = history;
        }

        public string GetMedicalHistory()
        {
            return medicalHistory;
        }
    }
}
