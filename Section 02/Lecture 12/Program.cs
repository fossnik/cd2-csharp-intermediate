using System;
using System.Collections.Generic;

namespace Lecture12
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person(new DateTime(1982, 1, 1));
            Console.WriteLine(person.Age);
        }
    }
}