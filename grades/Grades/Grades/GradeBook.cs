using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {

        public GradeBook()
        {
            grades = new List<float>();
        }

        //Class members can be either:
        //1 . State - data to work with inside class (grades here)
        //grades user entered

        //2. behavior members - do work (methods)
           // a. Add a new grade
           // b. Calculate stats

        public void AddGrade(float grade)
        {
            //Double and float types
            //Float - 7 digit precision
            //Double - 14 digit precision
            grades.Add(grade);
        }

        List<float> grades;

    }
}
