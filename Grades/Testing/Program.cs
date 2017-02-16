using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = 34;
            int age = 18;

            string Pass = age > 21 ? "Can drink" : "Too young";

            int[] someNumbers = { 4, 7, 9 };


            if (number > 65)
            {
                Console.WriteLine("bigger than 2");

            }
            else if (number <= 36)
            {
                Console.WriteLine("smaller than 36");

            }
            else
            {
                Console.WriteLine("Out of Range");
            }

            //Console.ReadKey();


            
            foreach(int value in someNumbers)
            {
                Console.WriteLine(value);
            }


            Console.WriteLine(Pass);
            Console.ReadKey();

            


        }
    }
}
