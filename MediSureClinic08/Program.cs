class Program
{
    static PatientBill? LastBill;
    static bool HasLastBill;

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("================== MediSure Clinic Billing ==================");
            Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid option. Please try again.");
                continue;
            }
            switch (choice)
            {
                case 1:
                    PatientBill bill = new PatientBill();
                    Console.Write("Enter Bill Id: ");
                    bill.BillId = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(bill.BillId))
                    {
                        Console.WriteLine("Bill Id cannot be empty.");
                        break;
                    }
                    Console.Write("Enter Patient Name: ");
                    bill.PatientName = Console.ReadLine();
                    Console.Write("Is the patient insured? (Y/N): ");
                    string? insInput = Console.ReadLine();
                    string ins = string.IsNullOrEmpty(insInput) ? "" : insInput.ToUpper();
                    if (ins != "Y" && ins != "N")
                    {
                        Console.WriteLine("Invalid input for insurance.");
                        break;
                    }
                    bill.HasInsurance = ins == "Y";
                    Console.Write("Enter Consultation Fee: ");
                    if (!decimal.TryParse(Console.ReadLine(), out bill.ConsultationFee) || bill.ConsultationFee <= 0)
                    {
                        Console.WriteLine("Invalid consultation fee.");
                        break;
                    }
                    Console.Write("Enter Lab Charges: ");
                    if (!decimal.TryParse(Console.ReadLine(), out bill.LabCharges) || bill.LabCharges < 0)
                    {
                        Console.WriteLine("Invalid lab charges.");
                        break;
                    }
                    Console.Write("Enter Medicine Charges: ");
                    if (!decimal.TryParse(Console.ReadLine(), out bill.MedicineCharges) || bill.MedicineCharges < 0)
                    {
                        Console.WriteLine("Invalid medicine charges.");
                        break;
                    }
                    LastBill = bill;
                    HasLastBill = true;
                    Console.WriteLine("Bill created successfully.");
                    Console.WriteLine($"Gross Amount: {bill.GrossAmount():F2}");
                    Console.WriteLine($"Discount Amount: {bill.DiscountAmount():F2}");
                    Console.WriteLine($"Final Payable: {bill.FinalPayable():F2}");
                    Console.WriteLine("------------------------------------------------------------");
                    break;
                case 2:
                    if (!HasLastBill)
                    {
                        Console.WriteLine("No bill available. Please create a new bill first.");
                    }
                    else
                    {
                        Console.WriteLine("----------- Last Bill -----------");
                        Console.WriteLine($"BillId: {LastBill?.BillId}");
                        Console.WriteLine($"Patient: {LastBill?.PatientName}");
                        Console.WriteLine($"Insured: {(LastBill?.HasInsurance == true ? "Yes" : "No")}");
                        Console.WriteLine($"Consultation Fee: {LastBill?.ConsultationFee:F2}");
                        Console.WriteLine($"Lab Charges: {LastBill?.LabCharges:F2}");
                        Console.WriteLine($"Medicine Charges: {LastBill?.MedicineCharges:F2}");
                        Console.WriteLine($"Gross Amount: {LastBill?.GrossAmount():F2}");
                        Console.WriteLine($"Discount Amount: {LastBill?.DiscountAmount():F2}");
                        Console.WriteLine($"Final Payable: {LastBill?.FinalPayable():F2}");
                        Console.WriteLine("--------------------------------");
                    }
                    Console.WriteLine("------------------------------------------------------------");
                    break;
                case 3:
                    LastBill = null;
                    HasLastBill = false;
                    Console.WriteLine("Last bill cleared.");
                    break;
                case 4:
                    Console.WriteLine("Thank you. Application closed normally.");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}