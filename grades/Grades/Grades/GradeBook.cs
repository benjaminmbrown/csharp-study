using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        //can access with GradeBook.MaximumGrade
        public static float MinimumGrade = 0;
        public static float MaximumGrade = 100;

        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            return new GradeStatistics();
           // throw new NotImplementedException();
        }

  

        public void AddGrade(float grade)
        {
            //Double and float types
            //Float - 7 digit precision
            //Double - 14 digit precision

            if(grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
      
        }

        private List<float> grades;


    }
}


//Class members can be either:
//1 . State - data to work with inside class (grades here)
//grades user entered

//2. behavior members - do work (methods)
// a. Add a new grade
// b. Calculate stats