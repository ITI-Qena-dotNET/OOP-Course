using InheritanceLab.Problem2;

Console.WriteLine("*********************** Lab 6 Problem ***********************");

/*
 * ======================= Problem 1 ===========================
 * Create "Shape" Parent Class with Property:
 * Dimension (Assume it is Radius in case of circle and Length in case of Square and Rectangle)
 * 
 * Functions:
 * CalcArea()
 * 
 * With the child Classes:
 * - Square 
 * - Circle
 * - Rectangle (Add a new Dimension property)
 * 
 * Each should have a CalcArea() Function that returns the area of the shape
 * 
 */

//using InheritanceLab.Problem1;

//Square sq = new(2);
//Console.WriteLine($"The area of Square of side {sq.Dimension} is: {sq.CalculateArea()}");

//Rectangle rec = new(2, 3);
//Console.WriteLine($"The area of Rectangle of length {rec.Dimension} and width {rec.SecondDimension} is: {rec.CalculateArea()}");

//Circle cir = new(2);
//Console.WriteLine($"The area of Circle of radius {cir.Dimension} is: {cir.CalculateArea()}");

/*
 * ======================= Problem 2 ===========================
 * Create "Picture" Class with the function GetTotalArea() which gets area of all shapes in picture
 * and the following classes with their relations:
 * 
 * - Square (Composition)
 *     - GetArea() Function
 * - Rectangle (Aggregation)
 *     - GetArea() Function
 * - Circle (Association)
 *     - GetArea() Function
 */

Circle cir = new(2);

Picture pic = new(cir)
{
    Rectangles = new Rectangle[] { new(2, 3), new(3, 4) }
};

Console.WriteLine($"The total area of shapes in Picture is {pic.GetTotalArea()}");
