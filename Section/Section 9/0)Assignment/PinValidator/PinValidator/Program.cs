
class DebitCard
{
    private string _pin;
    public string pin
    {
        set
        {
                if (value.Length == 4 || value.Length == 6)
                {
                    bool isValid = true;
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (value[i] < 48 || value[i] > 57) 
                            isValid = false;
                    }
                    if (isValid)
                        _pin = value; 
                    else
                        System.Console.WriteLine("pin contains one or more non-digit characters.");
                }
                else
                    System.Console.WriteLine("PIN should contain either 4 digits or 6 digits integer");
        }
        get
        {
            return _pin;
        }
    }
}
class AssignmentPINValidation
{
    static void Main()
    {
        DebitCard debitCard = new DebitCard();
        debitCard.pin = "123412"; 
        System.Console.WriteLine(debitCard.pin); 
        System.Console.ReadKey();
    }
}

