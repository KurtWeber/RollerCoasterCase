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
            StreamReader reader = new StreamReader("..\\..\\..\\RollerCoaster.txt");

            using (reader)
            {
                // Count to determine number of lines
                //int lineNumber = 0;
                //int ltrNumber = 0;

                // Read first line
                string line = reader.ReadLine();
                Console.WriteLine("Line Length: {0}", line.Length);
                
                for (int i = 0; i <= line.Length - 1; i++)
                {
                    char ltr = line[i];
                    do
                    {
                        if (char.IsUpper(ltr))
                        {
                            ltr = char.ToUpper(ltr);
                        }
                        
                    } while (ltr > 'A' && ltr < 'z');
                    
                }
                Console.WriteLine(line);

            }
        }
    }
}
