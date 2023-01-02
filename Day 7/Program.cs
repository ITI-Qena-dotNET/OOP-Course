using PolymorphismLab;

Console.WriteLine("*********************** Lab 7 Problem ***********************");

/*
 * Modify Problem 1 in Lab 6 to make "Shape" Class Abstract
 * and make CalcArea() abstract
 * 
 * 
 * Create Class "Picture" and add shapes array (as aggreggate)
 * and calculate total area in a function
 * 
 */

Picture pic = new()
{
    Shapes = new Shape[] { new Square(2), new Rectangle(2, 3), new Circle(2) }
};

Console.WriteLine($"The total area of shapes inside picture is {pic.CalculateTotalArea()}");