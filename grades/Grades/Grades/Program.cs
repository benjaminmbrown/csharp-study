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

            g1 = new GradeBook();

            g1.Name = "Ben's Book";

            Console.WriteLine(g2.Name);

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
