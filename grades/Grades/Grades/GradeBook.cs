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
            GradeStatistics stats = new GradeStatistics();

            //Do calculations
            float sum = 0f;
            

            foreach (float grade in grades)
            {
                //if (grade > stats.HighestGrade)
                //{stats.HighestGrade = grade;}
                //else if(grade < stats.LowestGrade)
                //{ stats.LowestGrade = grade;}

                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            if (grades.Count > 0) { 
            stats.AverageGrade = sum / grades.Count;
            }

            return stats;
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

        public string Name;
        private List<float> grades;


    }
}


//Class members can be either:
//1 . State - data to work with inside class (grades here)
//grades user entered

//2. behavior members - do work (methods)
// a. Add a new grade
// b. Calculate stats