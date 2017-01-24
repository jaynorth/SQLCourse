using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingModule2courses
{
    class Dice
    {

        //public string name;
        public int value;



        public Dice()
        {
            value = 0;
        }

        public int GetValue() {

            return value;
        }

        public void SetValue(int number) {

            value = number; 

        }
    }
}
