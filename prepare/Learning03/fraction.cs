public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _denominator = 1;
        _numerator = 1;
    }

    public Fraction (int wholeNumber)
    {
        _denominator = 1;
        _numerator = wholeNumber;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public string GetFractionsString()
    {
        string text = $"{_numerator}/{_denominator}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_numerator/(double)_denominator;
    }
}