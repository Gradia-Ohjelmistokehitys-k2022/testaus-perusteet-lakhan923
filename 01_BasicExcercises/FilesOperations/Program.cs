using System;
namespace FilesOperations;
public class Program
{
    public static void Main(string[] args)
    {

        List<string> fileContent = new List<string>();
        string directory = "../FileTest/";
        string filePath = "testfile.txt";

        try
        {
            // Using Path.Combine to construct the full path
            string fullPath = Path.Combine(directory, filePath);
            // Check if the file exists
            if (!File.Exists(fullPath))
            {
                Console.WriteLine("File not found at path:" + fullPath);
                return; // or handle the case accordingly
            }

            // Calling the ReadFile method
            fileContent = Files.ReadFile(fileContent, directory, filePath);

            // Processing the file content as needed
            Files.PrintFile(fileContent);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"File not found: {ex.Message}");
        }

    }
}



