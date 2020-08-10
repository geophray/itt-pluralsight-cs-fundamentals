using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new [] {12.3, 15.78, 44.1};
            var result = 0.0;
            foreach(var number in numbers) {
                result += number;
            }
            Console.WriteLine(result);

            if (args.Length > 0) {
                Console.WriteLine($"Hello {args[0]}!");
            } else {
                Console.WriteLine("Hello!");
            }
        }
    }
}
