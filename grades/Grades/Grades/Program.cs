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
            book.AddGrade(92);
            book.AddGrade(34);

            GradeBook book2 = new GradeBook();
            book2.AddGrade(75);
        }
    }
}
