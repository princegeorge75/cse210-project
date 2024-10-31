using System;

class Program
{
    static void Main(string[] args)
    {
         // Create a list to hold shapes
        List<Shape> shapes = new List<Shape>();

        // Add different shapes to the list
        Square s1 = new Square("Red", 4);
        shapes.Add(s1);
        
        Rectangle r1 = new Rectangle("Blue", 5, 3);
        shapes.Add(r1);

        Circle c1 = new Circle("Purple", 3);
        shapes.Add(c1);

        // Iterate through the list and display their colors and areas
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}