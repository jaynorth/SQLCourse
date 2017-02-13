using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsandProperties
{
    class Program
    {
        static void Main(string[] args)
        {

            Voiture v = new Voiture();
            //v.NbRoues = 5;
            v.Name = "JAck";
            v.setRoues();
            Console.WriteLine(v.NbRoues);
            Console.WriteLine(v.Name);
            Console.ReadKey();



        }
    }
}
