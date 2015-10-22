using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void GiveBookAName(GradeBook book)
        {
            book.Name = "The Grade Book";
        }

        static void IncrementANumber(int number)
        {
            number += 1;

        }
        
        static void Main(string[] args)
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            GiveBookAName(g1);
            Console.WriteLine(g2.Name);

            g1.Name = "Ben's Book";

            Console.WriteLine(g2.Name);

            int x1 = 4;
     
            IncrementANumber(x1);

            Console.WriteLine(x1);



            //GradeBook book = new GradeBook();
            //book.AddGrade(92);
            //book.AddGrade(34);
            //book.AddGrade(75);

            //GradeStatistics stats = book.ComputeStatistics();

            //Console.WriteLine("Avg:" + stats.AverageGrade);
            //Console.WriteLine("Lowest" + stats.LowestGrade);
            //Console.WriteLine("Highest" + stats.HighestGrade);

        }
    }
}
