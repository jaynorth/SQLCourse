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

                     
            Player player1 = new Player();

            Dice dice1 = new Dice();
            dice1.name = "dice1";
            Dice dice2 = new Dice();
            dice2.name = "dice2";
            Dice dice3 = new Dice();
            dice3.name = "dice3";


            // Round 1 below, player 1
            player1.ThrowDice(dice1);
            player1.ThrowDice(dice2);
            player1.ThrowDice(dice3);

            //Show result in hand 1
            Hand NowHand = new Hand();
            NowHand.UpdateHand(dice1, dice2, dice3);
            NowHand.ShowHand();


            Console.ReadKey();  

        }

 


    }
}
