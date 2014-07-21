using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        //constructor of default state
        public GradeStatistics()
        {
            //initializing occurs here 
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        //field for statistics
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;
    }
}
