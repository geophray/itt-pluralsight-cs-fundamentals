using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book 
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var sum = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach(var number in grades) {
                sum += number;
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
            }
            var average = sum / grades.Count;

            Console.WriteLine($"The lowest grade is {lowGrade:N1}.");
            Console.WriteLine($"The highest grade is {highGrade:N1}.");
            Console.WriteLine($"The average grade is {average:N1}.");
        }

        private List<double> grades;
        private string name;
    }
}