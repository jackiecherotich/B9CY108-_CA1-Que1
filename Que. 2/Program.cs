
using System;
using System.Collections.Generic;

class Program
{
    private static Dictionary <string,string> fileExtensions = new Dictionary <string, string>();
    
    static void Main(string[] args)
    {

        Console.Clear();
        Console.Title = " File Extensions  Information";
        Console.WriteLine("--------------------------------");

        LoadDictionary(); // Upload the sample data

        int menuChoice;
        while(true)
        {
            DisplayMenu();  
            
            if (!int.TryParse(Console.ReadLine(), out menuChoice))
            {
                Console.WriteLine("Please enter a valid number.");
                Console.Clear();
                continue;
            }
            
            if (menuChoice == 0)
            {
                Console.WriteLine("\nGoodbye!");
                break;
            }
            
            Console.Clear();
            
            switch (menuChoice)
            {
                case 1:
                    SearchExtension();
                    break;
                case 2:
                    ShowAllExtensions();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose 0-2.");
                    break;
            }
            
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
    
    static void DisplayMenu()
    {
        Console.WriteLine("........................");
        Console.WriteLine("1: Search File Extension");
        Console.WriteLine("2: Show All Extensions");
        Console.WriteLine("0: Exit");
        Console.Write("\nEnter your choice: ");
    }
    
    static void SearchExtension()
    {
        Console.WriteLine(".......................................");
        
        Console.Write("Enter file extension (e.g., mp4 or .mp4): ");
        string input = Console.ReadLine().Trim().ToLower();
        
        // Validate input
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Extension cannot be empty!");
            return;
        }
        
        // Add dot if missing
        if (!input.StartsWith("."))
            input = "." + input;
        
        // Search in dictionary
        if (fileExtensions.ContainsKey(input))
        {
            
            Console.WriteLine("\nExtension Found!\n");
            Console.WriteLine($"Extension  : {input}");
            Console.WriteLine($" {fileExtensions[input]} :Description: ");
        }
        else
        
        
        {
            Console.WriteLine($"\nSorry, extension '{input}' not found in database.");
            Console.WriteLine("Please check spelling or try another extension.");
           
        }
    }
    
    static void ShowAllExtensions()
    {
        Console.WriteLine("\n.......................................\n");
        Console.WriteLine($"Total Extensions: {fileExtensions.Count}\n");
        Console.WriteLine($"{"Extension",-15} Description");
      
        
        foreach (var item in fileExtensions)
        {
            Console.WriteLine($"{item.Key,-15} {item.Value}");
        }
    }
    
    static void LoadDictionary()
    {
        // Video Extensions
        fileExtensions.Add(".mp4", "MPEG-4 video file - most common video format");
        fileExtensions.Add(".mov", "Apple QuickTime movie - used by Apple devices");
        fileExtensions.Add(".avi", "Audio Video Interleave - older Windows video format");
        fileExtensions.Add(".mkv", "Matroska video - high quality with multiple audio tracks");
        fileExtensions.Add(".webm", "Web video format - optimized for streaming");
        fileExtensions.Add(".flv", "Flash video - used for online video streaming");
        
        // Audio Extensions
        fileExtensions.Add(".mp3", "MPEG audio layer 3 - most popular audio format");
        fileExtensions.Add(".wav", "Waveform audio - uncompressed high-quality audio");
        fileExtensions.Add(".flac", "Free Lossless Audio Codec - compressed lossless audio");
        fileExtensions.Add(".aac", "Advanced Audio Coding - better quality than MP3");
        fileExtensions.Add(".m4a", "MPEG-4 audio - Apple's audio format");
        
        // Image Extensions
        fileExtensions.Add(".jpg", "JPEG image - compressed photo format");
        fileExtensions.Add(".png", "Portable Network Graphics - lossless with transparency");
        fileExtensions.Add(".gif", "Graphics Interchange Format - supports animation");
        fileExtensions.Add(".svg", "Scalable Vector Graphics - vector image for web");
        fileExtensions.Add(".bmp", "Bitmap image - uncompressed image format");
        fileExtensions.Add(".webp", "Web picture - modern web image format");
        
        // Document Extensions
        fileExtensions.Add(".pdf", "Portable Document Format - universal document format");
        fileExtensions.Add(".docx", "Microsoft Word document - modern Word format");
        fileExtensions.Add(".xlsx", "Microsoft Excel spreadsheet - Excel workbook");
        fileExtensions.Add(".pptx", "Microsoft PowerPoint - presentation format");
        fileExtensions.Add(".txt", "Plain text file - simple unformatted text");
        
        // Archive Extensions
        fileExtensions.Add(".zip", "ZIP archive - most common compression format");
        fileExtensions.Add(".rar", "RAR archive - high compression ratio");
        fileExtensions.Add(".7z", "7-Zip archive - very high compression");
        
        // Programming Extensions
        fileExtensions.Add(".cs", "C# source code - C# programming file");
        fileExtensions.Add(".py", "Python source code - Python programming file");
        fileExtensions.Add(".java", "Java source code - Java programming file");
        fileExtensions.Add(".js", "JavaScript - web programming file");
        fileExtensions.Add(".html", "HTML - web page markup");
        fileExtensions.Add(".css", "CSS - web page styling");
    }
}


