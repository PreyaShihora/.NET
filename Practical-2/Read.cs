using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P2
{
    class Read
    {
        static void Main(string[] args)
        {
            String name, country;
            Console.WriteLine("Enter your name");
            name=Console.ReadLine();
            Console.WriteLine("Enter your Country");
            country = Console.ReadLine();
            Console.WriteLine("Hello {0} from {1}" ,name,country);

        }
    }
}
