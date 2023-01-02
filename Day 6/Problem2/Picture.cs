namespace InheritanceLab.Problem2;

public class Picture
{
    /// <summary>
    /// Circle represented as Composite
    /// </summary>
    private Circle _cir;

    public Circle Circle
    {
        get { return new(_cir); }
        set { _cir = value; }
    }

    /// <summary>
    /// Rectangle represented as Aggregate
    /// </summary>
    public Rectangle[] Rectangles { get; set; }

    public Picture(Circle cir)
    {
        Circle = cir;
    }

    public double GetSquareArea(Square[] associatedSquares)
    {
        double area = 0;

        foreach (Square item in associatedSquares)
        {
            area += item.GetArea();
        }

        return area;
    }

    public double GetTotalArea()
    {
        double rectanglesArea = 0;

        foreach (Rectangle item in Rectangles)
        {
            rectanglesArea += item.GetArea();
        }

        return _cir.DrawCircle() + rectanglesArea + GetSquareArea(new Square[] { new(3), new(2) });
    }

}

public class Square
{
    private int _sideLength;

    public Square(int sideLength)
        => _sideLength = sideLength;

    public double GetArea()
        => Math.Pow(_sideLength, 2);
}

public class Rectangle
{
    private int _length;
    private int _width;

    public Rectangle(int length, int width)
    {
        _length = length;
        _width = width;
    }

    public double GetArea()
        => _length * _width;
}

public class Circle
{
    private int _radius;

    public Circle(int radius)
        => _radius = radius;

    public Circle(Circle cir)
        => _radius = cir._radius;

    public double DrawCircle() 
        => Math.PI * Math.Pow(_radius, 2);
}