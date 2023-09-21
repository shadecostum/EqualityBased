using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityBased
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 120;
            int c = 10;
            Console.WriteLine("Equality based");
            Console.WriteLine(a==b); 
            Console.WriteLine(a==c);
            Console.WriteLine("Value  based");
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.Equals(c));

            Customer c1 = new Customer(1, "akash");
            Customer c2 = new Customer(1, "akash");
            Customer c3 = c1;
            Console.WriteLine("referntial");
            Console.WriteLine(c1==c2);
            Console.WriteLine(c1==c3);

            Console.WriteLine("value based Equals");
            Console.WriteLine(c1.Equals(c3));
            Console.WriteLine(c1.Equals(c2));
        }
    }
}
