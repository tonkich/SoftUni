using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
class oddLines
{
        static void Main()
        {
            StreamReader reader = new StreamReader("TextFile1.txt");
            using (reader)
            {
                int lineNumber = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lineNumber++;
                    if (lineNumber % 2 == 1)
                    {
                        Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    }
                }
            }
        }
}
