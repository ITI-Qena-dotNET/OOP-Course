using ClassesLab;

Console.WriteLine("*********************** Lab 5 Problem ***********************");

/*
 * Create a Fraction class to implement fraction mathematics
 * 
 * Class has 2 members: Numerator & Denominator
 * 
 * Functions to implement (Operator Overloaded):
 * 
 * 1) + (Addition of 2 fractions)
 * 2) ++ (Incrementing a fraction by 1)
 * 3) == (Comparing 2 fractions for similarity)
 * 4) Print (To show fraction as "x/y")
 * 5) Copy Constructor
 */

Fraction f1 = new(1, 2);
Fraction f2 = new(3, 5);

Console.WriteLine($"Fraction 1: {f1} \nFraction 2: {f2}\n");

Fraction addResult = f1 + f2;
Console.WriteLine($"Add Result is {addResult}");

Fraction incrementResult = (f2++);
Console.WriteLine($"Increment Result is {incrementResult}");

Fraction f3 = new(2, 4);
Fraction f4 = new(3, 4);

bool isEqual1 = f1 == f3;
bool isEqual2 = f1 == f4;
Console.WriteLine($"Equality 1 Result is {isEqual1}");
Console.WriteLine($"Equality 2 Result is {isEqual2}");

bool isNotEqual1 = f1 != f3;
bool isNotEqual2 = f1 != f4;
Console.WriteLine($"Non-Equality 1 Result is {isNotEqual1}");
Console.WriteLine($"Non-Equality 2 Result is {isNotEqual2}");
