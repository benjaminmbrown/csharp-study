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
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Ben's Book";

            Console.WriteLine(g2.Name);

            int x1 = 4;
            int x2 = x1;

            x1 = 100;

            Console.WriteLine(x2);

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
