using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace types
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("A class is a Reference Type");
            int x = 32;
            AddToNumber(x);
            Console.WriteLine("by value : " + x);

            AddToNumberByRef(ref x);
            Console.WriteLine("by reference : " + x);
            Console.ReadKey();

        }

        static void AddToNumber(int x)
        {

            x += 4;
        }

        static void AddToNumberByRef(ref int x)
        {

            x += 4;
        }
    }
}
