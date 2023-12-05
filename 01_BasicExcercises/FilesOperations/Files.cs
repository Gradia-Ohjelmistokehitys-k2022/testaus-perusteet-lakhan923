using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilesOperations
{
    /// <summary>
    /// the below method take a List<string> as a parameter 
    /// and prints each item in the list to the console.
    /// </summary>
    public class Files
    {
        public static void PrintFile(List<string> systemConfig)
        {
            foreach (string item in systemConfig)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// the below method reads the contents of a text file located at a specified directory 
        /// and file path.The file's content is read line by line and added to a List<string>
        /// </summary>
        /// <param name="fileContent"></param>
        /// <param name="directory"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static List<string> ReadFile(List<string> fileContent, string directory, string filePath)
        {
            // Open a StreamReader for the specified file
            StreamReader reader = new StreamReader(directory + filePath);
            try
            {
                // Read each line of the file until the end
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (line != null)
                    {
                        fileContent.Add(line);
                    }

                }
                while (reader.Peek() != -1) ;
            }
            catch (FileNotFoundException e)
            {
                throw e;
            }
            catch
            {
                fileContent.Add("File is empty");
            }
            finally
            {
                reader.Close();
            }
            // Return the list containing the file content
            return fileContent;
        }
    }
}