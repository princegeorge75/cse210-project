public class Circle : Shape
{
    // Private member variable for radius
    private double _radius;

    // Constructor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Override GetArea method
    public override double GetArea()
    {
        return Math.PI * _radius * _radius; // Area of a circle
    }
}
