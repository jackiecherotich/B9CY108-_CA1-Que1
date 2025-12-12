// Main

using System;

public class MainProgram
{
    public static void Main(string[] args)
    {
        ContactBook newContactBook = new ContactBook();
        int choice = -1;

        while (choice != 0)
        {
            Console.WriteLine(".....Main Menu..... ");
            Console.WriteLine("1: Add Contact");
            Console.WriteLine("2: Show All Contacts");
            Console.WriteLine("3: Show Contact Details");
            Console.WriteLine("4: Update Contact");
            Console.WriteLine("5: Delete Contact");
            Console.WriteLine("0: Exit");
            Console.Write("Enter your choice: ");

            if (choice == 1)
            {
               
                    Console.Write("First Name: ");
                    string firstName = Console.ReadLine();

                    Console.Write("Last Name: ");
                    string lastName = Console.ReadLine();

                    Console.Write("Company: ");
                    string company = Console.ReadLine();

                    Console.Write("Mobile Number (9 digits): ");
                    string mobileNumber = Console.ReadLine();

                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    Console.Write("Birthdate (yyyy-mm-dd): ");
                    DateTime birthDate = DateTime.Parse(Console.ReadLine());

                    Contact newContact = new Contact(firstName, lastName, company, mobileNumber, email, birthDate);
                    newContactBook.AddContact(newContact);
                
               
            }

            // Show All contact
            else if (choice == 2)
            {
                newContactBook.ShowAllContacts();
            }

            // Show Selected Contact
            else if (choice == 3)
            {
                Console.Write("Enter Mobile Number: ");
                newContactBook.ShowContactDetails(Console.ReadLine());
            }

            // Update Contact
            else if (choice == 4)
            {
                Console.Write("Enter Mobile Number to update: ");
                newContactBook.UpdateContact(Console.ReadLine());
            }

            // Delete contact
            else if (choice == 5)
            {
                Console.Write("Enter Mobile Number to delete: ");
                newContactBook.DeleteContact(Console.ReadLine());
            }

            // Exit
            else if (choice == 0)
            {
                Console.WriteLine("Exiting.Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
