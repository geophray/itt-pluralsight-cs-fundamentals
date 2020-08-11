using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>() {12.3, 15.78, 44.1};
            var result = 0.0;
            foreach(var number in grades) {
                result += number;
            }
            var average = result / grades.Count;
            Console.WriteLine($"The average grade is {average:N1}.");
        }
    }
}
