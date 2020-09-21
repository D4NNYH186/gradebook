using System;
using System.Collections.Generic;


namespace GradeBook
{
 
    class Program
    {
    
        static void Main(string[] args)
        {
           
           
            var book = new Book("Dannys Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            
            var stats = book.GetStats();
            Console.WriteLine($" The Lowest Grade is {stats.Low}");
            Console.WriteLine($" The Highest Grade is {stats.High}");
            Console.WriteLine($" The average grade is {stats.Average:N1}");
            // var grades = new List<double>() {12.7, 10.3, 6.11, 4.1 };
            // grades.Add(56.1);
        }
    }
}
