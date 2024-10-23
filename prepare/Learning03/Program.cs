using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionsString());
        

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionsString());

        Fraction f3 = new Fraction(3,8);
        Console.WriteLine(f3.GetDecimalValue());
    }

    
}

