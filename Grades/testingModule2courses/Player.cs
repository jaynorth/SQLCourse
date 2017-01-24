using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingModule2courses
{
    class Player
    {

        public string name;
        Random rnd = new Random();// Generates random number, if put inside method it always gives the same result (why?)






        public void ThrowDice(Dice dice) //parameter is a reference to class Dice with var dice as object instance variable: ex: player1.ThrowDice(dice1);
        {
            

            int result = rnd.Next(1, 7);// Generates random number

            dice.SetValue(result);
            
        }

        

    }

    
}
