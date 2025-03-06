using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Blue", 6);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle(4, 3, "Purple");
        shapes.Add(s2);

        Circle s3 = new Circle(12, "Brown");
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
        
    }
}