using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string, string, string> min = Minimum;
            Console.WriteLine("The minimum of pasta, rice, burger is " + min("pasta", "rice", "burger"));

            Action<int, int, int> avg = AvgGrade;
            avg(7, 7, 8);
        }

        // Method to compare and return the minimum string value
        private static string Minimum(string string1, string string2, string string3)
        {
            if (String.Compare(string1, string2) < 0) // Compare string1 to string 2
            {
                return (String.Compare(string1, string3) < 0) ? string1 : string3; // return string 1 or 3 depends on which is smaller
            }
            else
            {
                return (String.Compare(string2, string3) < 0) ? string2 : string3; // return string 2 or 3 depends on which is smaller
            }
        } // End Method


        // Method to calculate average grade
        private static void AvgGrade(int value1, int value2, int value3) =>
            Console.WriteLine($"The average of {value1},{value2} and {value3} is " + (Math.Round((value1 + value2 + value3) / 3.0)));
    }
}
