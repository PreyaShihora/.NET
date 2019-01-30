using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P2
{
    class Pattern2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                int k = 1;
                for (int j = 1; j <= i; j++)
                {
                   
                    Console.Write(k);
                    k++;
                }
                Console.WriteLine();
            }

        }
    }
}
