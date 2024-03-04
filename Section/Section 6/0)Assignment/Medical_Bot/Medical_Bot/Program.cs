public class MedicalBot
{
    private const string BotName = "Bob";

    public static string GetBotName()
    {
        return BotName;
    }

    public void PrescribeMedication(Patient patient)
    {
        if (patient.GetSymptoms() == "headache")
        {
            patient.SetPrescription("ibuprofen" + GetDosage("ibuprofen"));
        }
        else if (patient.GetSymptoms() == "skin rashes")
        {
            patient.SetPrescription("diphenhydramine" + GetDosage("diphenhydramine"));
        }
        if (patient.GetSymptoms() == "dizziness")
        {
            if (patient.GetMedicalHistory() == "diabetes")
            {
                patient.SetPrescription("metformin" + GetDosage("metformin"));
            }
            else
            {
                patient.SetPrescription("dimenhydrinate" + GetDosage("dimenhydrinate"));
            }
        }


        string GetDosage(string medicineName)
        {
            if (medicineName == "ibuprofen")
            {
                if (patient.GetAge() < 18)
                    return "400 mg";
                else
                    return "800 mg";
            }
            else if (medicineName == "diphenhydramine")
            {
                if (patient.GetAge() < 18)
                    return "50 mg";
                else
                    return "200 mg";
            }
            else if (medicineName == "dimenhydrinate")
            {
                if (patient.GetAge() < 18)
                    return "50 mg";
                else
                    return "400 mg";
            }
            else if (medicineName == "metformin")
            {
                return "500 mg";
            }
            return "unknow";
        }
    }
}


public class Patient
{
    private string name;
    private int age;
    private string gender;
    private string medicalHistory;
    private string symptomCode;
    private string prescription;

    //Name getter and setter
    public string GetName()
    {
        return name;
    }
    public bool SetName(string newName, out string errorMessage)
    {
        bool isValid;

        if ((newName.Length <= 1))
        {
            errorMessage = "Patient name should contain atleast 2 characters";
            isValid = false;
            return isValid;
        }

        errorMessage = "";
        this.name = newName;
        isValid = true;
        return isValid;
    }

    //Age getter and setter,

    public int GetAge()
    {
        return age;
    }

    public bool SetAge(int newAge, out string errorMessage)
    {
        bool isValid;

        if ((newAge < 0 && newAge > 100))
        {
            errorMessage = "Patient age cannot be negative and it cannot be more than 100";
            isValid = false;
            return isValid;
        }

        errorMessage = "";
        this.age = newAge;
        isValid = true;
        return isValid;
    }

    //gender getter and setter

    public string GetGender()
    {
        return gender;
    }
    public bool SetGender(string newGender, out string errorMessage)
    {
        bool isValid;

        if (newGender != "Male" && newGender != "Female" && newGender != "Others" && newGender != "male" && newGender != "female" && newGender != "others")
        {
            errorMessage = "Patient Gender should be either Male, Female or Others (select any one of above)";
            isValid = false;
            return isValid;
        }

        errorMessage = "";
        this.gender = newGender;
        isValid = true;
        return isValid;
    }
    //medical history getter and setter

    public string GetMedicalHistory()
    {
        return medicalHistory;
    }
    public void SetMedicalHistory(string newMedicalHistory)
    {
        this.medicalHistory = newMedicalHistory;
    }

    //symptoms getter and setter

    public string GetSymptoms()
    {
        string symptom;
        switch (symptomCode)
        {

            case "S1": symptom = "Headache"; break;
            case "S2": symptom = "Skin rashes"; break;
            case "S3": symptom = "Dizziness"; break;
            default: symptom = "Unknown"; break;
        }
        return symptom;
    }
    public bool SetSymptoms(string symptomCode, out string errorMessage)
    {
        bool isValid;

        if (symptomCode != "S1" && symptomCode != "S2" && symptomCode != "S3")
        {
            isValid = false;
            errorMessage = "Symptom Code should either be S1, S2, or S3.";
            return isValid;
        }

        errorMessage = "";
        this.symptomCode = symptomCode;
        isValid = true;
        return isValid;
    }

    //prescription getter and setter

    public string GetPrescription()
    {
        return prescription;
    }
    public void SetPrescription(string newPrescription)
    {
        this.prescription = newPrescription;
    }



}



public class Program
{
    static void Main()
    {
        // Welcome message
        System.Console.WriteLine("Hi, I'm " + MedicalBot.GetBotName() + ". \nI'm here to help you in your medication.");
        System.Console.WriteLine("\nEnter your (patient) details:");

        Patient patient = new Patient();

        System.Console.Write("\nEnter Patient Name: ");
        while (!patient.SetName(System.Console.ReadLine(), out string errorMessage))
        {
            System.Console.WriteLine(errorMessage);
            System.Console.Write("\nEnter Patient Name: ");
        }

        System.Console.Write("Enter Patient Age: ");
        while (!patient.SetAge(System.Convert.ToInt32(System.Console.ReadLine()), out string errorMessage))
        {
            System.Console.WriteLine(errorMessage);
            System.Console.Write("Enter Patient Age: ");
        }

        System.Console.Write("Enter Patient Gender: ");
        while (!patient.SetGender(System.Console.ReadLine(), out string errorMessage))
        {
            System.Console.WriteLine(errorMessage);
            System.Console.Write("Enter Patient Gender: ");
        }

        System.Console.Write("Enter Medical History. Eg: Diabetes. Press Enter for None: ");
        patient.SetMedicalHistory(System.Console.ReadLine());

        System.Console.WriteLine($"\nWelcome, " + patient.GetName() + ", " + patient.GetAge() + ".");
        System.Console.WriteLine("Which of the following symptoms do you have:");
        System.Console.WriteLine("S1. Headache");
        System.Console.WriteLine("S2. Skin rashes");
        System.Console.WriteLine("S3. Dizziness");

        System.Console.Write("Enter the symptom code from above list (S1, S2 or S3): ");
        while (!patient.SetSymptoms(System.Console.ReadLine(), out string errorMessage))
        {
            System.Console.WriteLine(errorMessage);
            System.Console.Write("Enter the symptom code from above list (S1, S2 or S3): ");
        }

        MedicalBot doctorBot = new MedicalBot();
        doctorBot.PrescribeMedication(patient);

        System.Console.WriteLine("\nYour prescription based on your age, symptoms and medical history:");
        System.Console.WriteLine(patient.GetPrescription());

        // Goodbye message
        System.Console.WriteLine("\nThank you for coming.");
        System.Console.ReadKey();
    }
}
