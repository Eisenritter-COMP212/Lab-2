using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    class Program
    {
        public delegate bool GradesPredicate(double number); // Delegate boolean method placeholder
        static void Main(string[] args)
        {
            double[] dblArray = { 45.3, 23.4, 75.3, 65.2, 87.4, 87.3, 96.3, 38.5, 42.7, 52.8 };
            // Call Grade Filter Method, assigning Pass method to delegate boolean method
            GradesFilter(dblArray, Pass);
        }

        // Grade Filter Method
        private static void GradesFilter(double[] gradesArray, GradesPredicate predicate)
        {
            Console.WriteLine("The passing grades are: ");
            // Checks each grade in the array and operate them using the predicate method
            foreach (var grade in gradesArray)
            {
                Console.Write(predicate(grade) ? grade + " " : "");
            }
            Console.WriteLine();
        }

        // Lambda boolean Pass Method
        private static bool Pass(double number) => number > 50;

    }
}
