// Contact Book Class - Stores and manages all contacts
using System;
using System.Collections.Generic;
using ConsoleTables;

public class ContactBook
{
    // List to store Contact objects
    private List<Contact> contacts = new List<Contact>();

     //Adding Sample contacts
       public ContactBook()
    {
        AddingSampleContacts();   // load sample data
    }

    public void AddContact(Contact newContact)
    {
        
        contacts.Add(newContact);
        Console.WriteLine("Contact added successfully.");
    }


    // Displaying All contacts
    public void ShowAllContacts()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts available.");
            return;
        }

        var table = new ConsoleTable("First Name", "Last Name", "Company",
                                     "Mobile", "Email", "Birthdate");

        foreach (var c in contacts)
        {
            table.AddRow(
                c.FirstName,
                c.LastName,
                c.Company,
                c.MobileNumber,
                c.Email,
                c.BirthDate.ToString("dd/MM/yyyy")
            );
        }

        table.Write(Format.Alternative);
    }


    // Searching with email and mobile number
    public Contact SearchContact(string email)
    {
        foreach (var c in contacts)
            if (c.Email == email)
                return c;

        return null;
    }

    public Contact SearchContact(long mobile)
    {
        foreach (var c in contacts)
            if (c.MobileNumber == mobile.ToString())
                return c;

        return null;
    }


    // Showing details of a specific contact
    public void ShowContactDetails(Contact contact)
    {
        if (contact == null)
            Console.WriteLine("Contact not found.");
            
        else
        contact.Show();
    }


    // ..............Updating Contact Details..................//
    public void UpdateContact()
    {
        Console.WriteLine("\nSearch contact by:");
        Console.WriteLine("1. Mobile Number");
        Console.WriteLine("2. Email");
        Console.Write("Please type the options you like to use: ");

        if (!int.TryParse(Console.ReadLine(), out int userChoice))
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

       Contact targetContact  = null;

        if (userChoice == 1)
        {
            Console.Write("Enter mobile number: ");
            string mobileInput = Console.ReadLine();

            if (!long.TryParse(mobileInput, out long mobile))
            {
                Console.WriteLine("Invalid mobile number!");
                return;
            }

            targetContact = SearchContact(mobile);
        }
        else if (userChoice == 2)
        {
            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            targetContact = SearchContact(email);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        if (targetContact == null)
        {
            Console.WriteLine("Contact not found.");
            return;
        }

        Console.WriteLine("\nContact Found:");
        ShowContactDetails(targetContact);

        // Ask user what to update
        Console.WriteLine("\nWhich detail do you want to update?");
        Console.WriteLine("1. First Name");
        Console.WriteLine("2. Last Name");
        Console.WriteLine("3. Company");
        Console.WriteLine("4. Mobile Number");
        Console.WriteLine("5. Email");
        Console.WriteLine("6. Birthdate");
        Console.Write("Please enter the option to update: ");

        int.TryParse(Console.ReadLine(), out int fieldToUpdate);
 
        try
        {
            switch (fieldToUpdate)
            {
                case 1:
                    Console.Write(" First Name: ");
                    targetContact.FirstName = Console.ReadLine();
                    break;
                case 2:
                    Console.Write(" Last Name: ");
                    targetContact.LastName = Console.ReadLine();
                    break;

                case 3:
                    Console.Write("Company: ");
                    targetContact.Company = Console.ReadLine();
                    break;
                case 4:
                    Console.Write(" Mobile Number: ");
                    targetContact.MobileNumber = Console.ReadLine();
                    break;

                case 5:
                    Console.Write("Email: ");
                    targetContact.Email = Console.ReadLine();
                    break;

                case 6:
                    Console.Write("Birthdate (yyyy-mm-dd): ");
                    targetContact.BirthDate = DateTime.Parse(Console.ReadLine());
                    break;

                default:
                    Console.WriteLine("Invalid selection.");
                    return;
            }

            Console.WriteLine("Contact updated successfully!");
            Console.WriteLine("\nUpdated Contact Details:");
            ShowContactDetails(targetContact);

        }
        catch (Exception )
        {
            Console.WriteLine($"Contact details Update failed");
        }
    }


    
    // ...............Deleting Contact Details..................//
    public void DeleteContact()
    {
        Console.WriteLine("\nDelete contact by:");
        Console.WriteLine("1. Mobile Number");
        Console.WriteLine("2. Email");
        Console.Write("Enter choice: ");

        int.TryParse(Console.ReadLine(), out int fieldToSearchWith);
  
        Contact targetContact = null;

        if (fieldToSearchWith == 1)
        {
            Console.Write("Enter mobile number: ");
            string mobileInput = Console.ReadLine();

            if (!long.TryParse(mobileInput, out long mobile))
            {
                Console.WriteLine("Invalid number.");
                return;
            }

            targetContact = SearchContact(mobile);
        }

        else if (fieldToSearchWith == 2)
        {
            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            targetContact = SearchContact(email);
        }
        else
        {
            Console.WriteLine("Invalid option.");
            return;
        }

        if (targetContact == null)
        {
            Console.WriteLine("Contact not found.");
            return;
        }

        Console.WriteLine("\nContact to delete:");
        ShowContactDetails(targetContact);

        Console.Write("\nConfirm delete? (Y/N): ");
        string confirm = Console.ReadLine().ToUpper();

        if (confirm == "Y")
        {
            contacts.Remove(targetContact);
            Console.WriteLine("Contact deleted successfully.");
        }
        else
        {
            Console.WriteLine("Delete cancelled.");
        }
    }



    // .............Sample Contact Details......................//
    public void AddingSampleContacts()
    {
        contacts.Add(new Contact("Emily", "Blackwell", "Dublin Business School",
            "123456789", "emily.blackwell@dbs.ie", DateTime.Parse("1990-01-01")));

        contacts.Add(new Contact("John", "Doe", "Tech Innovate",
            "234567891", "john.doe@techinnovate.com", DateTime.Parse("1985-05-20")));

        contacts.Add(new Contact("Sarah", "Walsh", "IT Solutions Ltd",
            "345678912", "sarah.walsh@itsolutions.ie", DateTime.Parse("1993-03-12")));

        contacts.Add(new Contact("Paul", "Murphy", "Finance Plus",
            "456789123", "paul.murphy@financeplus.ie", DateTime.Parse("1988-02-14")));

        contacts.Add(new Contact("Anna", "Kelly", "Retail Hub",
            "567891234", "anna.kelly@retailhub.com", DateTime.Parse("1994-09-03")));

        contacts.Add(new Contact("Mark", "Wilson", "Digital Innovations",
            "678912345", "mark.wilson@digital.ie", DateTime.Parse("1989-07-07")));

        contacts.Add(new Contact("Linda", "OBrien", "Education First",
            "789123456", "linda.obrien@educationfirst.ie", DateTime.Parse("1992-04-27")));

        contacts.Add(new Contact("Tom", "Hall", "Corp A",
            "891234567", "tom.hall@corpa.com", DateTime.Parse("1991-06-10")));

        contacts.Add(new Contact("Mia", "Lewis", "Corp B",
            "912345678", "mia.lewis@corpb.com", DateTime.Parse("1996-11-22")));
        
    }
}
