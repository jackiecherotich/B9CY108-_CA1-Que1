using System;

public class MainProgram
{
    public static void Main(string[] args)
    {
        ContactBook myContactBook = new ContactBook(); 
        int choice = -1; // Variable to store user choice

        while (choice != 0)
        {
            Console.WriteLine("Main Menu\n\n");
            Console.WriteLine("1: Add Contact");
            Console.WriteLine("2: Show All Contacts");
            Console.WriteLine("3: Update Contact");
            Console.WriteLine("4: Delete Contact");
            Console.WriteLine("5: Show Contact Count");
            Console.WriteLine("0: Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                // Adding a new contact
                Console.Write("Enter First Name: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                string lastName = Console.ReadLine();
                Console.Write("Enter Company: ");
                string company = Console.ReadLine();
                Console.Write("Enter Mobile Number: ");
                string mobileNumber = Console.ReadLine();
                Console.Write("Enter Email: ");
                string email = Console.ReadLine();
                Console.Write("Enter Birthdate (yyyy-mm-dd): ");
                DateTime birthdate = DateTime.Parse(Console.ReadLine());

                
            }
            else if (choice == 2)
            {
                

                
            }
            else if (choice == 5)
            {
               
            }
            else if (choice == 0)
            {
                Console.WriteLine("Exiting. GoodBye");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}
