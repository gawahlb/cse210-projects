using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new();

        Square a = new("Red", 3);
        Rectangle b = new("Blue",4,5);
        Circle c = new("Green", 6);

        shapes.Add(a);
        shapes.Add(b);
        shapes.Add(c);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            System.Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }
}