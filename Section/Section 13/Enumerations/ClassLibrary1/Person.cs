using System;

public class Person
{
    public string PersonName { get; set; }
    public string Email { get; set; }

    public Person(string personName):this(personName,string.Empty) 
    {
        Console.WriteLine("first constructor");
        this.PersonName = personName;
    }
    public Person(string personName, string Email):this(personName)
    {
        Console.WriteLine("second constructor");
        this.Email = Email;
        
    }



    // so the field AgeGroupEnumerations can only have the inputs that are defined in enuma
    public AgeGroupEnumeration AgeGroup { get; set; }
}

public enum AgeGroupEnumeration : short
{
    Child,
    Teenager,
    Adult = 100,
    Senior
}

