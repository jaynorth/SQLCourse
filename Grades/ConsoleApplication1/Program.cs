using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTesting
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> ListeNombres = new List<int>();
            List<int> ListeNombres2 = new List<int>() { 2, 6, 9, 4, 5 };

            //ListeNombres.Add(3);

            foreach (int num in ListeNombres2)
            {
                Console.WriteLine(num);
            }

        }
    }
}
