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

            Immutable();

            PassByValueAndRef();

            ClassesAndTypes();

            Arrays();

        }

        private static void Arrays()
        {

            float[] grades;

            grades = new float[4];//have to pass in a size

            AddGrades(grades);

            foreach(float grade in grades)
            {
                Console.WriteLine("grade:" + grade);
            }


           


        }

        private static void AddGrades(float[] grades)
        {
            
            grades[0] = 91f;
            grades[1] = 89.1f;
            grades[2] = 75f;

        }

        private static void ClassesAndTypes()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(92);
            book.AddGrade(34);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine("Avg:" + stats.AverageGrade);
            Console.WriteLine("Lowest" + stats.LowestGrade);
            Console.WriteLine("Highest" + stats.HighestGrade);
        }

        private static void Immutable()
        {

            string name = " BEN ";
            string trimmedName = name.Trim();
            Console.WriteLine(trimmedName);

            DateTime date = DateTime.Now; //or new DateTime(2014,1,1)
            date = date.AddDays(3);
            Console.WriteLine(date);

            string name1 = "Ben";
            string name2 = "ben";

            bool areEqual = name1.Equals(name2, StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(areEqual);
        }

        private static void PassByValueAndRef()
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
        }
    }
}
