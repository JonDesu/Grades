using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;

namespace Grades
{
    [TestClass] //used for Visual Studio 
    public class GradeBookTests
    {
        [TestMethod]
        public void CalculateHighestGrade()
        {
            Gradebook book = new Gradebook();

            book.AddGrade(90f);
            book.AddGrade(50f);
            book.AddGrade(100);

            GradeStatistics stats = book.ComputeStatistics();

            Assert.AreEqual(90f, stats.HighestGrade);
        }

        [TestMethod]
        public void PassByValue()
        {
            Gradebook book = new Gradebook();
            book.Name = "Not set";
            SetName(book);

            Assert.AreEqual("Name is set", book.Name);
        }

        //reference passed
        void SetName(Gradebook book)
        {
            book.Name = "Name is set";
        }
    }
}
