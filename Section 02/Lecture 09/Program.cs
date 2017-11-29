using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Se2Le9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
            {
                Console.WriteLine("Conversion failed.");
            }
        }

        public static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }

        public static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at ({0}, {1}", point.X, point.Y);
            }
            catch
            {
                Console.WriteLine("an unexpected error occcurred");
                throw;
            }  
        }
    }
}