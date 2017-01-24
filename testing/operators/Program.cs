using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {

            //char a = 'p';
            //// char b = 'z';
            //
            //if (a=='p' | a == 'q') {
            //
            //    Console.WriteLine("True");
            //    Console.ReadKey();

       

        int sum = AddNumbers(5, 4, 9);
            Console.WriteLine("Sum is " + sum);
            Console.ReadKey();


         

        }
        static int AddNumbers(params int[] tab)
        {

            int sum = 0;
            for (int i = 0; i < tab.Length; i++)
            {

                sum += tab[i];
            }

            return sum;

        }


    }
}
