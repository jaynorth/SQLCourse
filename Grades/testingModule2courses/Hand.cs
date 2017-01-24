using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingModule2courses
{
    class Hand
    {
        public int[] handArray = new int[3];
        int Count;
        public Hand()
        {
            Count = 1;
            int[] handArray = { 0, 0, 0};
        }

        public void UpdateHand(Dice dice1, Dice dice2, Dice dice3)
        {

            handArray[0] = dice1.GetValue();
            handArray[1] = dice2.GetValue();
            handArray[2] = dice3.GetValue();
        }

        public void ShowHand() {
            int i = 0;
            foreach (int hand in handArray) {
                i++;
                Console.WriteLine("Dice " + i + " :" + hand);


            }
        }


    }



}
