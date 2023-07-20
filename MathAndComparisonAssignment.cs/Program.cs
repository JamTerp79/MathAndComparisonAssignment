using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonAssignment.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prints "Anonymous Income Comparison Program" to the screen
            Console.WriteLine("Anonymous Income Comparison Program");

            // Prints "Person 1" to the screen and gets the following details from user input:
            // Hourly Rate
            // Hours worked per week
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            float person1HourlyRate = float.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int person1HoursWorkedPerWeek = int.Parse(Console.ReadLine());

            // Prints "Person 2" to the screen and then gets the following details from user input:
            // Hourly rate
            // Hours worked per week
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            float person2HourlyRate = float.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int person2HoursWorkedPerWeek = int.Parse(Console.ReadLine());

            // Calculates the annual salary of Person 1
            float person1AnnualSalary = person1HourlyRate * 40 * 52;

            // Calculates the annual salary of Person 2
            float person2AnnualSalary = person2HourlyRate * 40 * 52;

            // Prints to the screen "Annual salary of Person 1:" and displays the exact salary below it.
            Console.WriteLine("Annual salary of Person 1: {0:0.00}", person1AnnualSalary);

            // Prints to the screen "Annual salary of Person 2:" and displays the exact salary below it.
            Console.WriteLine("Annual salary of Person 2: {0:0.00}", person2AnnualSalary);

            // Prints to the screen "Does Person 1 make more money than Person 2?" and writes the true or false value of this statement below it.
            bool person1MakesMoreMoney = person1AnnualSalary > person2AnnualSalary;
            Console.WriteLine("Does Person 1 make more money than Person 2? {0}", person1MakesMoreMoney);

            Console.ReadLine();
        }
    }
    
}
