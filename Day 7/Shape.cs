namespace PolymorphismLab;

public sealed class Picture
{
    public Shape[] Shapes { get; set; }

    public double CalculateTotalArea()
    {
        double totalArea = 0;

        foreach (Shape sh in Shapes)
        {
            totalArea += sh.CalculateArea();
        }

        return totalArea;
    }
}

public abstract class Shape
{
    /// <summary>
    /// The base dimension for any shape.
    /// Considered as Length in case of rectangle and Side in case of Square and Radius in case of Circle
    /// </summary>
    public int Dimension { get; set; }

    protected Shape(int dimension) 
        => Dimension = dimension;

    public abstract double CalculateArea();
}

public class Square : Shape
{
    public Square(int dimension) : base(dimension)
    {
    }

    public override double CalculateArea()
        => Math.Pow(Dimension, 2);
}

public class Rectangle : Shape
{
    public Rectangle(int dimension, int secondDimension) : base(dimension)
        => SecondDimension = secondDimension;

    public int SecondDimension { get; set; }

    public override double CalculateArea()
        => Dimension * SecondDimension;
}

public class Circle : Shape
{
    public Circle(int dimension) : base(dimension)
    {
    }

    public override double CalculateArea()
        => Math.PI * Math.Pow(Dimension, 2);
}