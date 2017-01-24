using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingModule2courses
{
    class Dice
    {

        
        public int value;
        public bool hold;
        public string name;
        


        public Dice()
        {
            value = 0;
            hold = false;
            
            
        }

        public int GetValue() {

            return value;
        }

        public void SetValue(int number) {

            value = number; 

        }
    }
}
