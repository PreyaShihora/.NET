using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace P5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Directories = Directory.GetDirectories(@"F:\16ce023");
            Console.WriteLine("Directories are");
            foreach (string dir in Directories)
            Console.WriteLine(dir);
            string[] files = Directory.GetFiles(@"F:\16ce023");
            Console.WriteLine("Files are");
            foreach (string file in files)
            Console.WriteLine(file);
        }
    }
}
