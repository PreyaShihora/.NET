using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace P5._2
{
    public class CopyFile
    {
        public void copyFile(string file1, string file2)
        {
            using (StreamReader reader = new StreamReader(file1))
            using (StreamWriter writer = new StreamWriter(file2))
            {
                string line = null;
                while ((line = reader.ReadLine()) != null)
                    writer.WriteLine(line);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CopyFile cp = new CopyFile();
            string file1 = @"F:\16ce023\P5\P5.1\1.txt";
            string file2 = @"F:\16ce023\P5\P5.1\2.txt";
            cp.copyFile(file1, file2);
        }
    }
}
