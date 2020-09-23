using System;
using System.Collections.Generic;


namespace GradeBook
{
 
    class Program
    {
    
        static void Main(string[] args)
        {
           
           
            var book = new Book("Dannys Grade Book");

            while(true)
            {
                Console.WriteLine("Enter a grade or press 'Q' to quit");
                var input = Console.ReadLine();

                if(input == "q")
                {
                    break;
                }
                try
                {
                var grade = double.Parse(input);
                book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                // finally
                // {
                //     //.. good for closing files/ports etc.
                // }
            }
            
            // book.AddGrade(89.1);
            // book.AddGrade(90.5);
            // book.AddGrade(77.5);
            
            var stats = book.GetStats();
            Console.WriteLine($" The Lowest Grade is {stats.Low}");
            Console.WriteLine($" The Highest Grade is {stats.High}");
            Console.WriteLine($" The average grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
            // var grades = new List<double>() {12.7, 10.3, 6.11, 4.1 };
            // grades.Add(56.1);
        }
    }
}
