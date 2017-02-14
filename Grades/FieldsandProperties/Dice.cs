using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FieldsandProperties;

namespace FieldsandProperties
{
    public class Dice
    {

        private static int numberObjects = 0;
        

        public Dice()
        {
            numberObjects++;
            


        }

        public static int NumberObjects() {

            return numberObjects;
        }

        public int DiceNumber { get; private set; }

        public void Throwdice() {
            
            int result = StaticRandom.rnd.Next(1, 7);
            this.DiceNumber = result;

        }




    }
}
