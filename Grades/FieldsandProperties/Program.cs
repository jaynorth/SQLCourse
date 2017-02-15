using FieldsandProperties;
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

            //Voiture v = new Voiture();
            ////v.NbRoues = 5;
            //v.Name = "JAck";
            //v.setRoues();
            //Console.WriteLine(v.NbRoues);
            //Console.WriteLine(v.Name);
            //Console.ReadKey();

            //Dice dice1 = new Dice();
            //Dice dice2 = new Dice();
            //Dice dice3 = new Dice();
            //Dice dice4 = new Dice();
            //Dice dice5 = new Dice();
            //Dice dice6 = new Dice();
            //
            //Console.WriteLine("Number of Dice Objects is " + Dice.NumberObjects());
            //
            //
            //dice1.Throwdice();
            //dice2.Throwdice();
            //dice3.Throwdice();
            //dice4.Throwdice();
            //dice5.Throwdice();
            //dice6.Throwdice();
            //Console.WriteLine("dice1 number: " + dice1.DiceNumber);
            //Console.WriteLine("dice2 number: " + dice2.DiceNumber);
            //Console.WriteLine("dice3 number: " + dice3.DiceNumber);
            //Console.WriteLine("dice4 number: " + dice4.DiceNumber);
            //Console.WriteLine("dice5 number: " + dice5.DiceNumber);
            //Console.WriteLine("dice6 number: " + dice6.DiceNumber);

            ListProperties l = new ListProperties();


            l.NumberList.Add(76);
            l.NumberList.Add(87);

            foreach (int i in l.NumberList) { 

            Console.WriteLine(i);
            }

            Console.ReadKey();






        }
    }
}
