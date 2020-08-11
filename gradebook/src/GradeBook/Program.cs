using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("My Math Gradebook");
            book.AddGrade(89.1);
            book.AddGrade(90.6);
            book.AddGrade(73.2);
            book.ShowStatistics();
        }
    }
}
