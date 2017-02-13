using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            Scoreboard s = new Scoreboard();

            s.Score = 9;

            int t = 8;
            float d = -1;
            Console.WriteLine("Enter number");


            while (d <0)
            { 
                try
                {
                    d = float.Parse(Console.ReadLine());
                }

                catch (Exception ex) {

                    Console.WriteLine("try again " + ex.Message);

                }
            }
            //try
            //{
            //
            //    
            //    float f = float.Parse(t);
            //
            //    Console.WriteLine(f);
            //}
            //
            //catch (Exception ex) {
            //
            //    Console.WriteLine("Something went wrong" + ex.Message);
            //}
            //       
            ////Console.WriteLine(s.Score);
            //Console.WriteLine(d);


            Console.ReadKey();

          


        }
    }
}
