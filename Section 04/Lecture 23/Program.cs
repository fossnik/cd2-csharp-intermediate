using System;
using System.Collections.Generic;

namespace Lecture23
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Text text = new Text();
            Shape shape = new Shape();

            text.Width = 200;
            shape.Width = 100;
            
            // both text and shape are references to the same object
            // this is converting an object to a base class reference.
            Console.WriteLine(text.Width);
        }
    }
}