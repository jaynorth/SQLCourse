using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileTesting
{
    class Program
    {
        static void Main(string[] args)
        {

            string filePath = @"nameList.txt";
            try
            {
                StreamReader sr = new StreamReader(filePath); //Create StreamReader object (using System.IO)
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] tab = line.Split(';');//adds line to list to array
                    int i = tab.Count();
                    for (int l = 0; l < i; l++)
                    {
                        Console.Write(tab[l] + " ");
                    }
                    Console.WriteLine();
                    line = sr.ReadLine();//Goes to next line
                }

                sr.Close();//closes file

            }
            catch (FileNotFoundException ex)
            {

                Console.WriteLine("Error message :" + ex.Message);
                //throw; if uncommented will make error window appear
            }

            
           
            
           
            //StreamReader sr2 = new StreamReader(filePath);
            //string wholeFile = sr2.ReadToEnd();
            //Console.WriteLine(wholeFile);

           
            Console.ReadKey();


       } 
    }
}
