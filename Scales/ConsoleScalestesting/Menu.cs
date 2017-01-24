using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScalestesting
{
    class Menu
    {


        string Scale="";
        string Note="";

        public string[] notesPiano = { "c", "c#", "d", "d#", "e", "f", "f#", "g", "g#", "a", "a#", "b", "c", "c#", "d", "d#", "e", "f", "f#", "g", "g#", "a", "a#", "b" };
        public string[] MajorFormula = { "t", "t", "s", "t", "t", "t", "s" };
        public void SelecScale() {

            Console.WriteLine("select 1 for Major scale");
            Console.WriteLine("select 2 for Minor scale");
            Scale = Console.ReadLine();
            switch (Scale)
            {
                case "1":
                    Console.WriteLine("Major Scale");
                    Scale = "Major";
                break;

                case "2":
                    Console.WriteLine("Minor Scale");
                    Scale = "Minor";
                    break;



                default:
                    Console.WriteLine("Whatever");
                    break;
            }


        }
        public void SelectNote() {

            Console.WriteLine("Select note");
            Note =Console.ReadLine();
            Console.WriteLine("Note selected : " + Note);
        }

        public void DisplayNotesScaleMajor() {
            Console.Clear();
            Console.WriteLine("You Have Selected The " + Note + " " + Scale + " scale");

         
        
            for (int i = 0; i < notesPiano.Length; i++)
            {
                if (notesPiano[i] == Note) {

                    //Console.WriteLine("Index is " + i + "Note var is " + Note + "Note from tab is " + notesPiano[i]);
                    Console.Write(notesPiano[i] + "  ");
                        for (int j=0; j < MajorFormula.Length; j++)
                        {
                            if (MajorFormula[j] == "t")
                            {
                                i += 2;
                                Console.Write(notesPiano[i] + "  ");
                            }
                            else {
                                i += 1;
                                Console.Write(notesPiano[i] + "  ");
                            }
                        }
                    break;
                }
                
            }

        }
    }
}
