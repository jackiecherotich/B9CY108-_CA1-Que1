using System;


public class Program
{
    public static void Main(string[] args)
    {
        //---------------object instantiation----------------------------//
        FileExtension filetype = new FileExtension();
        //--------------------Menu display-------------------------------//
        Console.Title = "File Extension Type Lookup System";
        Console.WriteLine("....................................................");
        Console.WriteLine("To check File Extension Type.........................");
        Console.WriteLine("You can type multiple extensions separated by commas.");
        Console.WriteLine("Example: mp4, jpg, pdf");
        Console.WriteLine("Type 'exit' to quit.");
        Console.WriteLine("-----------------------------------------------\n");

        string input = "";    // initializing input variable

        while (input != "exit")
        {
            Console.Write("Enter file extension(s): ");
            input = Console.ReadLine()?.ToLower().Trim();

            if (input == "exit")
            {
                Console.WriteLine(" Exiting.");
                break;
            }

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error: You must enter at least one extension.\n");
                continue;
            }
            

            try
            {
                Console.WriteLine("\nExtension   Meaning");
                Console.WriteLine("-----------------------------------------------");
                var extensions = input.Split(',');
                
                foreach (var ext in extensions)
                {
                    string trimmedExtension = ext.Trim();

                    if (string.IsNullOrWhiteSpace(trimmedExtension))
                        continue;

                    string meaning = filetype.GetFileExtension(trimmedExtension);
                //------------- formatting console Output............................// 
                    Console.WriteLine($"{trimmedExtension.PadRight(12)}{meaning}");
                }

                Console.WriteLine();

            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong. Check again\n");
            }
        }
    }
}