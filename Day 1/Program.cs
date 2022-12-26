Problem1();
Problem2();
Problem3();
Problem4();
Problem5();
Problem6();
Problem7();
Problem8();

/// <summary>
/// 1- Write a program to print "Hello World"
/// </summary>
void Problem1()
{
    Console.WriteLine("***** Problem 1 *****");
    Console.WriteLine("Hello World!");
}

/// <summary>
/// 2- Write a program to print area of circle 
/// </summary>
void Problem2()
{
    Console.WriteLine("***** Problem 2 *****");

    Console.Write("Enter radius of Circle: ");
    float radius = float.Parse(Console.ReadLine());

    double circleArea = Math.PI * Math.Pow(radius, 2);
    Console.WriteLine($"The area of circle whose radius is {radius} equals to {circleArea}");
}

/// <summary>
/// 3- Write a program to print + , - , / , * of 2 numbers 
/// </summary>
void Problem3()
{
    Console.WriteLine("***** Problem 3 *****");

    int firstNumber = 0;
    int secondNumber = 0;

    Console.Write("Enter First Number: ");
    firstNumber = int.Parse(Console.ReadLine());

    Console.Write("Enter Second Number: ");
    secondNumber = int.Parse(Console.ReadLine());

    Console.WriteLine($"The result of adding {firstNumber} and {secondNumber} is {firstNumber + secondNumber}");
    Console.WriteLine($"The result of subtracting {firstNumber} and {secondNumber} is {firstNumber - secondNumber}");
    Console.WriteLine($"The result of multiplicating {firstNumber} and {secondNumber} is {firstNumber * secondNumber}");
    Console.WriteLine($"The result of dividing {firstNumber} and {secondNumber} is {firstNumber / secondNumber}");
}

/// <summary>
/// 4- Write a program to print ascii number of any character(bouns)
/// </summary>
void Problem4()
{
    Console.WriteLine("***** Problem 4 *****");

    Console.Write("Enter a Character to get its ASCII value: ");
    char character = char.Parse(Console.ReadLine());

    int asciiValue = character;
    Console.WriteLine($"The ASCII value for \'{character}\' is {asciiValue}");
}

/// <summary>
/// 5. Get a number from a user & checking if it is Even Or Odd Or Zero using if ...else statement.
/// </summary>
void Problem5()
{
    Console.WriteLine("***** Problem 5 *****");

    Console.Write("Enter a number: ");

    int number = int.Parse(Console.ReadLine());

    if (number == 0)
    {
        Console.WriteLine("The number is Zero");
    }
    else if (number % 2 == 0)
    {
        Console.WriteLine("The number is Even");
    }
    else
    {
        Console.WriteLine("The number is Odd");
    }
}

/// <summary>
/// 6. Getting grade of a student as int, and printing it as char using if ...else statement:
///  90 and above      A
///  80 to 90          B
///  70 to 80          C
///  60 to 70          D
///  Below 60          F
/// </summary>
void Problem6()
{
    Console.WriteLine("***** Problem 6 *****");

    Console.Write("Enter the Grade of student: ");
    int studentGrade = int.Parse(Console.ReadLine());

    Console.Write("The student's grade is : ");

    if (studentGrade >= 90)
    {
        Console.WriteLine("A");
    }
    else if (studentGrade < 90 && studentGrade >= 80)
    {
        Console.WriteLine("B");
    }
    else if (studentGrade < 80 && studentGrade >= 70)
    {
        Console.WriteLine("C");
    }
    else if (studentGrade < 70 && studentGrade >= 60)
    {
        Console.WriteLine("D");
    }
    else
    {
        Console.WriteLine("F");
    }
}

/// <summary>
/// 7. Print a simple menu using switch:
///   1. Add
///   2. Edit
///   3. Display
///   4. Exit 
/// </summary>
void Problem7()
{
    Console.WriteLine("***** Problem 7 *****");

    Console.WriteLine(
"""
Select an item from the list by entering its number
   1) Add
   2) Edit
   3) Display
   4) Exit 
""");

    Console.Write("Enter a number to select: ");
    int choice = int.Parse(Console.ReadLine());

    Console.Write("Choice selected: ");

    switch (choice)
    {
        case 1:
            Console.WriteLine("Add");
            break;
        case 2:
            Console.WriteLine("Edit");
            break;
        case 3:
            Console.WriteLine("Display");
            break;
        case 4:
            Console.WriteLine("Exit");
            break;
        default:
            Console.WriteLine("Unidentified Option. Please try again.");
            break;
    }
}

/// <summary>
/// 8- Update in problem no 3, Take 2 numbers And Operator(+,/,-,*), then Print Result
/// </summary>
void Problem8()
{
    Console.WriteLine("***** Problem 8 *****");

    int firstNumber = 0;
    int secondNumber = 0;
    char operation;

    Console.Write("Enter First Number: ");
    firstNumber = int.Parse(Console.ReadLine());

    Console.Write("Enter Second Number: ");
    secondNumber = int.Parse(Console.ReadLine());

    Console.Write("Enter operator (+ - * /): ");
    operation = char.Parse(Console.ReadLine());

    int result;

    switch (operation)
    {
        case '+':
            result = firstNumber + secondNumber;
            break;
        case '-':
            result = firstNumber - secondNumber;
            break;
        case '*':
            result = firstNumber * secondNumber;
            break;
        case '/':
            result = firstNumber / secondNumber;
            break;
        default:
            Console.WriteLine("Unidentified Option. Please try again.");
            return;
    }

    Console.WriteLine($"The result of {firstNumber} {operation} {secondNumber} is {result}");
}