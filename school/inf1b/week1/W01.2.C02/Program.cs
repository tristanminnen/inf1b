using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        var fileList = new List<string>()
        {
            "OODP assignment.docx",
            "Project Presentation.pptx",
            "TODO list.xlsx",
        };

        string whichFileToDelete = fileList[0];

        Console.WriteLine("File selected to delete: " + whichFileToDelete);
        Console.WriteLine("Really delete this file? (y/n)");
        string confirm = Console.ReadLine();
        Console.WriteLine(confirm);
        while (confirm != "y" && confirm != "n")
        {
            Console.WriteLine("Really delete this file? (y/n)");
            confirm = Console.ReadLine();
        }

        if (confirm == "y")
        {
            fileList.Remove(whichFileToDelete);
            Console.WriteLine("File deleted");
        }
    }
}