public abstract class Shape
{
    // Color member variable
    private string _color;

    // Constructor
    public Shape(string color)
    {
        _color = color;
    }

    // Getter for color
    public string GetColor()
    {
        return _color;
    }

    //public string to set color
    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea(); //declare GetArea as an abstract so that it can be filled by the different classes
}
