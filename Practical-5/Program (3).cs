using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace P5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1 = @"F:\16ce012\P5\P5.1\a.txt";
            string file2 = @"F:\16ce012\P5\P5.1\b.txt";
            using (StreamReader reader = new StreamReader(file1))
            using (StreamWriter writer = new StreamWriter(file2))
                writer.Write(reader.ReadToEnd());
        }
    }
}
