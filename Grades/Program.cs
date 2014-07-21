using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {
        static void GiveBookAName(Gradebook book)
        {
            book.Name = "The Gradebook";
        }

        static void IncrementNumber(int number)
        {
            number += 1;
        }

        static void Main(string[] args)
        {
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("Hello World!");
            Arrays();
            ////assign new instance of Gradebook object
            //Gradebook book = new Gradebook(); //indirectly points to the new object
            //book.AddGrade(91f);
            //book.AddGrade(91.6f);
            //book.AddGrade(85f);
            //book.AddGrade(75);

            ////runs Computestatistics from Gradebook class
            //GradeStatistics stats = book.ComputeStatistics();
            //Console.WriteLine("Average Grade: " + stats.AverageGrade);
            //Console.WriteLine("Lowest Grade: " + stats.LowestGrade);
            //Console.WriteLine("Highest Grade: " + stats.HighestGrade);

            Console.ReadLine();

        }

        private static void Immutable()
        {
            string name = "    Scott    ";
            //strings are immutable!
            name = name.Trim();

            DateTime date = new DateTime(2014, 1, 1);
            date = date.AddHours(25);

            Console.WriteLine(date);
            Console.WriteLine(name);
        }

        private static void Arrays()
        {
            //define variable type
            float[] grades;

            //initialized here; size specified
            grades = new float[3];

            //Arrays are reference types (a reference is passeed here)
            AddGrades(grades);

            foreach(float grade in grades)
            {
                Console.WriteLine(grade);
            }


        }

        //passing pointer to array in memory
        private static void AddGrades(float[] grades)
        {   
            if (grades.Length > 3)
            { 
                grades[0] = 91f;
                grades[1] = 89.1f;
                grades[2] = 75f;
                grades[3] = 100f;
            }
        }


    }
}
