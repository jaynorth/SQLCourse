using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingModule2courses
{
    class Program
    {
        static void Main(string[] args)
        {

            
            
            //Console.WriteLine("Please enter your name");
            Player player1 = new Player();
            //Console.WriteLine(player1.Dice1);
            //player1.name = Console.ReadLine();
            //player1.Hello();
            //Console.WriteLine(player1.name + " please Throw Dice");
            // player1.Dice1 = player1.ThrowDice();
            // player1.Dice2 = player1.ThrowDice();
            // player1.Dice3 = player1.ThrowDice();
            // 
            Dice dice1 = new Dice();
            Dice dice2 = new Dice();
            Dice dice3 = new Dice();

            Console.WriteLine("dice 1 value: " + dice1.GetValue());
            
            dice1.SetValue(3);
            Console.WriteLine("dice 1 value: " + dice1.GetValue());

            Console.WriteLine("Now player is throwing dice1");
            Console.WriteLine("dice 1 value before: " + dice1.GetValue());
            Console.WriteLine("dice 1 value before: " + dice2.GetValue());

            player1.ThrowDice(dice1);
            Console.WriteLine("dice 1 value after : " + dice1.GetValue());
            player1.ThrowDice(dice2);
            Console.WriteLine("dice 2 value after : " + dice2.GetValue());

            Console.ReadKey();  

        }
    }
}
