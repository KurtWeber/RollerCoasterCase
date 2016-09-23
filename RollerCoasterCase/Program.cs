using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using 

namespace RollerCoasterCase
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("..\\..\\..\\RollerCoaster.txt");

            using (reader)
            {
                // Count to determine number of lines
                int lineNumber = 0;

                // Read first line
                string line = reader.ReadLine();

                // Read the other lines in file
                while (line != null)
                {
                    // lineNumber = lineNumber + 1
                    lineNumber++;

                    // Changing single letter
                    string replaceLetter = 
                    
                    // Write to console
                    Console.Write(replaceLetter);

                    // Read next line
                    line = reader.ReadLine();
                    Console.WriteLine();

                }
            }
        }
    }
}
