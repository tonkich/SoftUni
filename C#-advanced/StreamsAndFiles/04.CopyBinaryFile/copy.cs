using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
    class copy
    {
        static void Main()
        {
                const string filePath = "../../file.txt";
    const string copiedPath = "../../copied.txt";

    static void Main()
    {
        using (var source = new FileStream(filePath, FileMode.Open))
        {
            using (var destination = new FileStream(copiedPath, FileMode.Create))
            {
                var buffer = new byte[4096];
                while (true)
                {
                    int readBytes = source.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }
                    destination.Write(buffer, 0, readBytes);
                    Console.WriteLine("{0:P}", source.Position / source.Length);
                }
            }
        }
    }
        }
