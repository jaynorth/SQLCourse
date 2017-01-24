using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScalestesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu();
            
            m.SelecScale();
            m.SelectNote();
            m.DisplayNotesScaleMajor();
            Console.ReadKey();
            
        }
    }
}
