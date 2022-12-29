namespace ClassesLab;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    /// <summary>
    /// Default Constructor
    /// </summary>
    /// <param name="numerator"></param>
    /// <param name="denomerator"></param>
    public Fraction(int numerator, int denomerator)
    {
        _numerator = numerator;
        _denominator = denomerator;
    }

    /// <summary>
    /// Copy Constructor
    /// </summary>
    /// <param name="instance"></param>
    public Fraction(Fraction instance)
    {
        _numerator = instance._numerator;
        _denominator = instance._denominator;
    }

    public int Numerator
    {
        get { return _numerator; }
        set { _numerator = value; }
    }

    public int Denomerator
    {
        get { return _denominator; }
        set { _denominator = value; }
    }

    public override string ToString() 
        => $"{_numerator}/{_denominator}";

    //public string PrintFraction() 
    //    => $"{_numerator}/{Denomerator}";

    /// <summary>
    /// Gets the Greatest Common Divisor (GCD) for 2 integer numbers
    /// </summary>
    /// <param name="num1">First integer</param>
    /// <param name="num2">Second integer</param>
    /// <returns>The Greatest Common Divisor (GCD) of num1 and num2</returns>
    private static int GetGreatestCommonDivisor(int num1, int num2)
    {
        while (num1 != 0 && num2 != 0)
        {
            if (num1 > num2)
                num1 %= num2;
            else
                num2 %= num1;
        }

        return num1 | num2;
    }

    public static Fraction operator +(Fraction first, Fraction second)
    {
        int resultNumerator;

        if (first.Denomerator == second.Denomerator)
        {
            resultNumerator = first.Numerator + second.Numerator;

            return new(resultNumerator, first.Denomerator);
        }

        Fraction f1 = new(first);
        int oldDenominator = f1.Denomerator;
        Fraction f2 = new(second);

        f1.Numerator *= f2.Denomerator;
        f1.Denomerator *= f2.Denomerator;

        f2.Numerator *= oldDenominator;
        f2.Denomerator *= oldDenominator;

        resultNumerator = f1.Numerator + f2.Numerator;
        int gcd = GetGreatestCommonDivisor(resultNumerator, f1.Denomerator);

        return new(resultNumerator / gcd, f1.Denomerator / gcd);
    }

    public static Fraction operator ++(Fraction input)
    {
        Fraction f = new(input.Denomerator, input.Denomerator);

        Fraction result = input + f;

        return result;
    }

    public static bool operator ==(Fraction first, Fraction second)
    {
        int firstGCD = GetGreatestCommonDivisor(first.Numerator, first.Denomerator);
        int secondGCD = GetGreatestCommonDivisor(second.Numerator, second.Denomerator);

        if (first.Numerator == second.Numerator && first.Denomerator == second.Denomerator)
            return true;
        else if (first.Numerator / firstGCD == second.Numerator / secondGCD &&
            first.Denomerator / firstGCD == second.Denomerator / secondGCD)
            return true;

        return false;
    }

    public static bool operator !=(Fraction first, Fraction second)
        => !(first == second);
}
