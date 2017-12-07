using System.Collections.Generic;

namespace Lecture27
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var shapes = new List<Shape>();
//            shapes.Add(new Shape() {Width = 100, Height = 100, Type = ShapeType.Circle});
//            shapes.Add(new Shape() {Width = 100, Height = 30, Type = ShapeType.Rectangle});
            
            // new shape methods
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}