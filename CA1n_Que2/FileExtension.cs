using System;
using System.Collections.Generic;

public class FileExtension
{
    // Dictionary
    private Dictionary<string, string> _fileExtensionTypes;
    
    //-----------------------------Constructor---------------------------------//
    public FileExtension()
    {
        _fileExtensionTypes = new Dictionary<string, string>()
        {
            { ".mp4",  "MPEG-4 Part 14 video container, widely used for online streaming and playback" },
            { ".mov",  "Apple QuickTime multimedia file, high-quality video used in editing workflows" },
            { ".avi",  "Audio Video Interleave file, a classic Microsoft video container" },
            { ".mkv",  "Matroska multimedia container supporting multiple audio/video tracks and subtitles" },
            { ".webm", "Open-source media container optimized for HTML5 video streaming" },

            { ".mp3",  "Lossy compressed audio format widely used for music distribution" },
            { ".wav",  "Uncompressed Waveform Audio providing studio-level sound quality" },
            { ".flac", "Free Lossless Audio Codec, preserving full audio fidelity" },

            { ".jpg",  "JPEG image using lossy compression, ideal for photos and web graphics" },
            { ".png",  "Lossless image format supporting transparency (alpha channel)" },
            { ".gif",  "Animated or static image format supporting limited colors" },
            { ".bmp",  "Bitmap image storing raw pixel data with no compression" },

            { ".pdf",  "Portable Document Format for sharing fixed-layout documents" },
            { ".docx", "Microsoft Word document using the Open XML structure" },
            { ".xlsx", "Microsoft Excel spreadsheet using Open XML formatting" },
            { ".pptx", "Microsoft PowerPoint presentation file" },
            { ".txt",  "Plain text file with no formatting metadata" },

            { ".zip",  "ZIP archive used for file compression and packaging" },
            { ".rar",  "RAR archive offering advanced compression and splitting options" },

            { ".html", "HyperText Markup Language file used to build webpages" }
        };
    }
    //----------------------------------------------------------------------------------//
    //----------------method to lookup the file extensions and give meaning............//
    public string GetFileExtension(string extension)
    {
        if (string.IsNullOrWhiteSpace(extension))
            return "Invalid input. Please enter a file extension.";

        extension = extension.ToLower().Trim();

        // Add dot if missing
        if (!extension.StartsWith("."))
            extension = "." + extension;
        // Key : Value lookup
        if (_fileExtensionTypes.ContainsKey(extension))
            return _fileExtensionTypes[extension];

        return "Unknown file extension.";
    }
}
