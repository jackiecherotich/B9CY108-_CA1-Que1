// Class Contact

using System;

public class Contact
{
   // Fields
    private string _firstName;
    private string _lastName;
    private string _company;
    private string _mobileNumber;
    private string _email;
    private DateTime _birthdate;



// Constructor for  new contact object
public Contact() { }

public Contact(string firstName, string lastName, string company,
               string mobileNumber, string email, DateTime birthdate)
{
    FirstName = firstName;
    LastName = lastName;
    Company = company;
    MobileNumber = mobileNumber;
    Email = email;
    Birthdate = birthdate;
}

// To display the details
public void Show()
{
    Console.WriteLine("..............................");
    Console.WriteLine($"First Name : {firstName} ");
    Console.WriteLine($"Last Name  : {lastName}");
    Console.WriteLine($"Company    : {company}");
    Console.WriteLine($"Mobile     : {mobileNumber}");
    Console.WriteLine($"Email      : {email}");
    Console.WriteLine($"Birthdate  : {birthdate:dd MM yyyy}");
    Console.WriteLine(".................................");
}
}
