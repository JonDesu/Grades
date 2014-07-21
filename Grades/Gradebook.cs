using System;
using System.Collections.Generic;

namespace Grades
{   //blueprint for Gradebook class
    public class Gradebook
    {
        public Gradebook()
        {
            //constructor method to initialize this field
            grades = new List<float>();
        }

        //publicly available API
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade < 100)
            {
                //add grade to list of grades created below
                grades.Add(grade);
            }
        }

        //return a GradeStatistics object when running this method
        public GradeStatistics ComputeStatistics()
        {
            //instantiate new gradestatistics object called stats
            GradeStatistics stats = new GradeStatistics();

            float sum = 0f;

            //for each grade in the grades list...
            foreach(float grade in grades)
            {
                //Math.Max compares two value and returns highest
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);

                //Math.Min compares two values and returns lowest
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            //define AverageGrade property of stats object
            stats.AverageGrade = sum / grades.Count; // divide by 0?
            return stats;
        }

        //public members expose with capital letter
        public string Name;

        //field that is a list of grades
        //used because Arrays have a fixed set of items!!
        private List<float> grades;
    }
}
