using System;

namespace Lecture27
{
    public class Circle : Shape
    {
        // new loose-coupling inheritance method
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");

            // base is a reference to the parent class
//            base.Draw();
        }
    }

    public class Rectangle : Shape
    {
        // new loose-coupling inheritance method
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");

        }
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Position Position { get; set; }
//        public ShapeType Type { get; set; }

        public virtual void Draw()
        {

        }
    }
}