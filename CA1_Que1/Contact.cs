// To represent one contact

using System;
using System.Linq;

public class Contact
{
    // Fields
    private string _firstName;
    private string _lastName;
    private string _company;
    private string _mobileNumber;
    private string _email;
    private DateTime _birthDate;

    // Properties
    public string FirstName
    {
        get { return _firstName; }
        set
        {
            if (IsValidName(value))
                _firstName = value;
            else
                throw new ArgumentException("First name must contain letters only.");
        }
    }


    public string LastName
    {
        get { return _lastName; }
        set
        {
            if (IsValidName(value))
                _lastName = value;
            else
                throw new ArgumentException("Last name should contain letters only.");
        }
    }

    public string Company
    {
        get { return _company; }
        set
        {
            if (IsValidCompany(value))
                _company = value;
            else
                throw new ArgumentException("Company name should not contain numbers.");
        }
    }

    public string MobileNumber
    {
        get { return _mobileNumber; }
        set
        {
            if (IsValidMobile(value))
                _mobileNumber = value;
            else
                throw new ArgumentException("Mobile number must be a 9-digit, non-zero positive number.");
        }
    }

    public string Email
    {
        get { return _email; }
        set
        {
            if (IsValidEmail(value))
                _email = value;
            else
                throw new ArgumentException("Invalid email format.");
        }
    }

    public DateTime BirthDate
    {
        get { return _birthDate; }
        set
        {
            if (IsValidBirthDate(value))
                _birthDate = value;
            else
                throw new ArgumentException(
                    "Invalid birthdate. Birthdate cannot be in the future and must be after 1900.");
        }
    }

    // Validation   
    private bool IsValidName(string name)
    {
        return !string.IsNullOrWhiteSpace(name)
               && name.All(char.IsLetter);
    }

    private bool IsValidMobile(string mobile)
    {
        return mobile != null &&
               mobile.Length == 9 &&
               mobile.All(char.IsDigit) &&
               !mobile.Contains('0');
    }

    private bool IsValidCompany(string company)
    {
        return !string.IsNullOrWhiteSpace(company)
               && company.All(letter => char.IsLetter(letter) || letter == ' ' || letter == '-');
    }

    private bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return false;

        if (!email.Contains("@"))
            return false;

        var parts = email.Split('@');
        if (parts.Length != 2)
            return false;

        if (string.IsNullOrWhiteSpace(parts[0]) || string.IsNullOrWhiteSpace(parts[1]))
            return false;

        if (email.Contains(" "))
            return false;

        return true;
    }

    private bool IsValidBirthDate(DateTime date)
    {
        if (date > DateTime.Today)
            return false;
        if (date.Year < 1900)
            return false;
        return true;
    }



// Constructor
    public Contact()
    {
    }

    public Contact(string firstName, string lastName, string company,
        string mobileNumber, string email, DateTime birthdate)
    {
        FirstName = firstName;
        LastName = lastName;
        Company = company;
        MobileNumber = mobileNumber;
        Email = email;
        BirthDate = birthdate;
    }

    // To display the details
    public void Show()
    {
        Console.WriteLine("..............................");


        Console.WriteLine($"First Name : {FirstName} ");

        Console.WriteLine($"Last Name  : {LastName}");
        Console.WriteLine($"Company    : {Company}");
        Console.WriteLine($"Mobile     : {MobileNumber}");
        Console.WriteLine($"Email      : {Email}");
        Console.WriteLine($"Birthdate  : {BirthDate:dd MM yyyy}");
        Console.WriteLine(".................................");
    }
}

