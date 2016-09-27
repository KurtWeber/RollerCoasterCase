using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace RollerCoasterCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //int count = 0;

            StreamReader reader = new StreamReader("..\\..\\..\\RollerCoaster.txt");

            using (reader)
            {
                // Count to determine number of lines
                int lineNumber = 0;
                
                // Read first line
                string line = reader.ReadLine();
                
                // Cycle through lines
                while (line != null)
                {
                    lineNumber++;
                    int count = 0;
                    for (int i = 0; i <= line.Length - 1; i++)
                    {
                        char ltr = line[i];
                        {
                            // Counting letters only and capitalizing letters on odd number postion
                            if ((ltr >= 'A' && ltr <= 'Z') || (ltr >= 'a' && ltr <= 'z'))
                            {
                                count++;
                                if (count % 2 != 0)
                                {
                                    ltr = Char.ToUpper(ltr);
                                }
                            }
                            Console.Write(ltr);
                        }
                    }
                    Console.WriteLine();
                    line = reader.ReadLine();
                }
            }
        }
    }
}
