using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            GradeBook book = new GradeBook();
            book.AddGrade(91.7f);
            book.AddGrade(67.7f);
            book.AddGrade(76.8f);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("Average Grade: " + stats.AverageGrade);
            Console.WriteLine("Highest Grade " + stats.HighestGrade);
            Console.WriteLine("Lowest Grade " + stats.LowestGrade);

            Console.ReadKey();

        }
    }
}
