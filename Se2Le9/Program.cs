using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Se2Le9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
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