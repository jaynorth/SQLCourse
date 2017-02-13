using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeStatistics
    {
        public GradeStatistics()
        {
           HighestGrade = 0;
           LowestGrade = float.MaxValue ;//Highest Value possible for a float so that it could get overridden
      
        }

        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;

        public int RandomNumber { get; set; }

        private int myVar;

        public int testFullProp
        {
            get { return myVar; }
            set { myVar = value; }
        }





    }
}
