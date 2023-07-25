﻿namespace SahrotunShop.Service.Common.Helpers;

public class MediaHelper
{
    public static string MakeImageName(string fileName)
    {
        FileInfo fileInfo = new FileInfo(fileName);     
        string extension = fileInfo.Extension;  
        string name = "IMG_" + Guid.NewGuid() + extension;
        return name;    
    }

    public static string[] GetImageExtensions()
    {
        return new string[]
        {
            // JPG files
            ".jpg", ".jpeg",

            // PNG files
            ".png",

            //Bmp files
            ".bmp",

            // Heic files (iPhone)
            "/heic"
        };
    }
}
