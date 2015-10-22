using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void CalculatesHighestGrade()
        {
            bool value = true;
            GradeBook book = new GradeBook();


            book.AddGrade(90f);
            book.AddGrade(33f);

            GradeStatistics stats = book.ComputeStatistics();

            Assert.AreEqual(90f, stats.HighestGrade);
        }
    }
}
