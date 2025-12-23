using System;
using HospitalCareManagementSystem04.Core;
using HospitalCareManagementSystem04.Services;
using HospitalCareManagementSystem04.Utilities;

namespace HospitalCareManagementSystem04
{
	class Program
	{
		public const string HospitalName = "Integrated Hospital Care Management System (IHCMS)";

		static Program()
		{
			Console.WriteLine($"Booting {HospitalName}... System initializing.");
		}

		static void Main(string[] args)
		{
			try
			{
				// 1. Initialize (static ctor executed before Main)

				// 2. Read patient details
				Console.Write("Enter Patient ID: ");
				var pid = Console.ReadLine();

				Console.Write("Enter Patient Name: ");
				var pname = Console.ReadLine();

				Console.Write("Enter Patient Age: ");
				var ageInput = Console.ReadLine();
				int age = InputHelper.ReadAge(ageInput);

				// 3. Create Patient object (no default ctor)
				var patient = new Patient(pid, pname, age);

				// 4. Assign medical history
				Console.Write("Enter Medical History (brief): ");
				var mh = Console.ReadLine();
				patient.SetMedicalHistory(mh);

				// 5. Create Doctor
				Console.Write("Enter Doctor Name: ");
				var dname = Console.ReadLine();
				Console.Write("Enter Doctor License Number: ");
				var license = Console.ReadLine();
				var doctor = new Doctor(license, dname);

				// 6. Schedule an appointment
				var appt = new Appointment();
				Console.Write("Schedule basic appointment? (y/n): ");
				var basic = Console.ReadLine();
				if (!string.IsNullOrWhiteSpace(basic) && basic.Trim().ToLower().StartsWith("y"))
				{
					appt.Schedule(patient, doctor);
				}
				else
				{
					Console.Write("Enter appointment date (yyyy-MM-dd HH:mm) or leave blank for now: ");
					var dateInput = Console.ReadLine();
					DateTime date = DateTime.Now;
					if (!string.IsNullOrWhiteSpace(dateInput) && DateTime.TryParse(dateInput, out var parsed)) date = parsed;
					Console.Write("Enter mode (Offline/Online) [default Offline]: ");
					var mode = Console.ReadLine();
					if (string.IsNullOrWhiteSpace(mode)) mode = "Offline";
					appt.Schedule(patient, doctor, date, mode);
				}

				// 7. Diagnosis evaluation
				Console.Write("Enter comma-separated test scores (e.g. 80,90,85): ");
				var scoresInput = Console.ReadLine() ?? string.Empty;
				var parts = scoresInput.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
				var scoresList = new System.Collections.Generic.List<int>();
				foreach (var p in parts)
				{
					if (int.TryParse(p.Trim(), out var v)) scoresList.Add(v);
					else throw new ArgumentException("Invalid test score input");
				}

				string condition = "Stable";
				DiagnosisService.Evaluate(age: age, condition: ref condition, riskLevel: out string riskLevel, testScores: scoresList.ToArray());
				Console.WriteLine($"Diagnosis Result: Condition = {condition}, RiskLevel = {riskLevel}");

				// 8 & 9. Billing and Insurance
				Console.Write("Enter Consultation Fee: ");
				var cf = ReadDoubleOrThrow(Console.ReadLine());
				Console.Write("Enter Test Charges: ");
				var tc = ReadDoubleOrThrow(Console.ReadLine());
				Console.Write("Enter Room Charges: ");
				var rc = ReadDoubleOrThrow(Console.ReadLine());

				// Bill object MUST be created using object initializer only
				var bill = new Billing
				{
					ConsultationFee = cf,
					TestCharges = tc,
					RoomCharges = rc
				};

				var total = bill.Total();
				Console.WriteLine($"Total bill: {total:C}");

				Console.Write("Enter insurance coverage percent (0-100): ");
				if (!int.TryParse(Console.ReadLine(), out int coverage)) coverage = 0;
				var payable = InsuranceService.ApplyCoverage(total, coverage);
				Console.WriteLine($"Final payable after {coverage}% coverage: {payable:C}");

				// 8. Recursion example: hospital stay
				Console.Write("Enter estimated stay days (int): ");
				if (!int.TryParse(Console.ReadLine(), out int stayDays)) stayDays = 0;
				var actualDays = CalculationHelper.CalculateStayDays(stayDays);
				Console.WriteLine($"Calculated stay days: {actualDays}");

				Console.WriteLine($"Total Doctors in system: {Doctor.TotalDoctors}");
			}
			catch (Exception)
			{
				Console.WriteLine("Invalid Input");
			}
		}

		private static double ReadDoubleOrThrow(string? input)
		{
			if (!double.TryParse(input, out var val)) throw new ArgumentException("Invalid numeric input");
			return val;
		}
	}
}

