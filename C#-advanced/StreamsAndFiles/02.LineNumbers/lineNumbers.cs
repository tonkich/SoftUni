using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
    class lineNumbers
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("TextFile1.txt");
            StreamWriter writer = new StreamWriter("TextFile2.txt.txt");
            using (reader)
            {
                using (writer)
                {
                    int lineNumber = 0;
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lineNumber++;
                        string writeLine = string.Format("Line {0}: {1}", lineNumber, line);
                        writer.WriteLine(writeLine);
                    }
                }
            }
        }
    }
