using System;
using HospitalCareManagementSystem04.Core;

namespace HospitalCareManagementSystem04.Core
{
    public class Appointment
    {
        public void Schedule(Patient p, Doctor d)
        {
            Console.WriteLine($"Scheduled appointment: Patient '{p.Name}' with Doctor '{d.Name}'");
        }

        public void Schedule(Patient p, Doctor d, DateTime date, string mode = "Offline")
        {
            Console.WriteLine($"Scheduled appointment: Patient '{p.Name}' with Doctor '{d.Name}' on {date:MMMM dd, yyyy HH:mm} Mode: {mode}");
        }
    }
}
