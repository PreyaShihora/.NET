using System;
using System.IO;

namespace Practical4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Directories = Directory.GetDirectories(@"F:\16ce012");
            Console.WriteLine("Directories are:");
            foreach (string dir in Directories)
                Console.WriteLine(dir);
            string[] files = Directory.GetFiles(@"F:\16ce012");
            Console.WriteLine("File are:");
            foreach (string file in files)
               
                Console.WriteLine(file);
        }
    }
}
