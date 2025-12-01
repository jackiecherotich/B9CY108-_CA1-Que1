// Main Program 
using System;

public class Program
{
    public static void Main(string[] args)
    {
        FileExtension filetype = new FileExtension();

        Console.WriteLine("....................");
        Console.WriteLine("To check File Extension Type");
        Console.WriteLine("Type 'exit' to quit.");
        Console.WriteLine("--------------------------------\n");


        string input = "";  // Initialize input to empty
        // Loop  until the user types "exit"
        while (input != "exit")
        {
            Console.Write("Enter a file extension (or 'exit' to quit): ");
            input = Console.ReadLine().ToLower().Trim();

            // Stop the loop if user types exit
            if (input == "exit")
            {
                Console.WriteLine("Thank you for using the program.");
                break;
            }

            // Show the result
            Console.WriteLine($" {input} : {filetype.GetFileExtension(input)}\n");
        }
    }
}