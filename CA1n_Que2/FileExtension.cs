//
using System;
using System.Collections.Generic;

public class FileExtension
{
    //Dictionary to store the file extensions and meaning
    private Dictionary<string, string> fileextensiontype;

    // Constructor
    public FileExtension()
    {
        fileextensiontype = new Dictionary<string, string>()
        {
            { ".mp4", "MPEG-4 video file" },
            { ".mov", "Apple QuickTime video" },
            { ".avi", "Audio Video Interleave video" },
            { ".mkv", "Matroska video file" },
            { ".webm", "Web media video file" },
            { ".mp3", "MP3 audio file" },
            { ".wav", "Waveform audio file" },
            { ".flac", "Lossless audio file" },
            { ".jpg", "JPEG image file" },
            { ".png", "Portable Network Graphics image" },
            { ".gif", "Graphics Interchange Format image" },
            { ".bmp", "Bitmap image file" },
            { ".pdf", "PDF document file" },
            { ".docx", "Microsoft Word document" },
            { ".xlsx", "Microsoft Excel spreadsheet" },
            { ".pptx", "PowerPoint presentation file" },
            { ".txt", "Plain text file" },
            { ".zip", "ZIP compressed archive" },
            { ".rar", "RAR archive file" },
            { ".html", "Web page (HTML file)" }
        };
    }
    // method  
    public string GetFileExtension(string extension)
    {
        extension = extension.ToLower();
     //If the user did not type the dot
        if (!extension.StartsWith("."))
        {
            extension = "." + extension;
        }
     // Checking if dictionary has that extension
        if (fileextensiontype.ContainsKey(extension))
        {
            return fileextensiontype[extension];
        }
        else
        {
            return "Unknown file extension.";
        }
    }
}
