// Program.cs
using System;

public class Program
{
    public static void Main(string[] args)
    {
        ContactBook myContactBook = new ContactBook();
        int option;
      //..............Main Menu............................//
        do
        {
            Console.Title =  "Contact Book";
            Console.WriteLine("\n.......MAIN MENU.......");
            Console.WriteLine("1. Add Contact...........");
            Console.WriteLine("2. Show All Contacts.....");
            Console.WriteLine("3. Show Contact Details..");
            Console.WriteLine("4. Update Contact........");
            Console.WriteLine("5. Delete Contact........");
            Console.WriteLine("0. Exit..................");
            Console.WriteLine(".........................");

            Console.Write("Choose option: ");

            int.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 1:
                    AddContactMenu(myContactBook);
                    break;
                case 2:
                    myContactBook.ShowAllContacts();
                    break;
                case 3:
                    ShowUpdateDetailsMenu(myContactBook);
                    break;
                case 4:
                    myContactBook.UpdateContact();
                    break;
                case 5:
                    myContactBook.DeleteContact();
                    break;
                case 0:
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (option != 0);
    }


    // ----------------Adding Details Menu  ---------------- //
    static void AddContactMenu(ContactBook myContactBook)
    {
        try
        {
            Console.Write("First Name: ");
            string first = Console.ReadLine();

            Console.Write("Last Name: ");
            string last = Console.ReadLine();

            Console.Write("Company: ");
            string company = Console.ReadLine();

            Console.Write("Mobile (9 digits): ");
            string mobile = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birthdate (yyyy-mm-dd): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            Contact ncontact = new Contact(first, last, company, mobile, email, birthdate);

            Console.WriteLine("\nReview Details:");
            ncontact.Show();

            Console.Write("Save contact? (Y/N): ");
            if (Console.ReadLine().ToUpper() == "Y")
                myContactBook.AddContact(ncontact);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // ----------------UpdateDetails Menu ---------------- //
    static void ShowUpdateDetailsMenu(ContactBook myContactBook)
    {
        Console.WriteLine("\nSearch by:.....");
        Console.WriteLine("1. Mobile........");
        Console.WriteLine("2. Email.........");
        Console.WriteLine(".................");
        Console.Write("\nEnter your choice: ");
        string optionInput = Console.ReadLine();
         
        if (!int.TryParse(optionInput, out int searchOption))
        {
        Console.WriteLine("Invalid choice.");
        return;
        }
         

        Contact found = null;
         if (searchOption == 1)
    {
        Console.Write("\nEnter Mobile Number:");
        string mobileInput = Console.ReadLine();

        if (!long.TryParse(mobileInput, out long mobile))
        {
            Console.WriteLine("Invalid mobile number.");
            return;
        }

        found = myContactBook.SearchContact(mobile);
    }
    else if (searchOption == 2)
    {
        Console.Write("\nEnter Email Address:");
        string email = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(email))
        {
            Console.WriteLine("Invalid email.");
            return;
        }

        found = myContactBook.SearchContact(email);
    }
    else
    {
        Console.WriteLine("Invalid option.");
        return;
    }

    Console.WriteLine(); 
    myContactBook.ShowContactDetails(found);
}
}

        
