using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Testing Git 2nd commit");
            Console.WriteLine(ThrowDice());
            Console.ReadKey();


        }

        static int ThrowDice() {
            Random rnd = new Random();
            int dice = rnd.Next(1, 7);
            return dice;
        }
    }
}
