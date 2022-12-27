Problem1();
Problem2();
Problem3();
Problem4();
Problem5();
Problem6();
Problem1Arrays();
Problem2Arrays();

// 1. Print Multiples of num 4 from 0 to 100 [for loop]
void Problem1()
{
    Console.WriteLine("*************** Problem 1 ***************");

    for (int i = 0; i <= 100; i++)
    {
        Console.WriteLine($"4 x {i} = {4 * i}");
    }
}

// 2. Calculate multiplication of 10 numbers given by user [for loop].
void Problem2()
{
    Console.WriteLine("*************** Problem 2 ***************");

    int product = 1;

    for (int i = 0; i < 10; i++)
    {
        Console.Write($"{i + 1}- Enter a number to multiply: ");
        int number = int.Parse(Console.ReadLine());
        product *= number;
    }

    Console.WriteLine($"The final product is {product}");
}

// 3. Print ASCII code for all char from 0-255 [for loop]
void Problem3()
{
    Console.WriteLine("*************** Problem 3 ***************");

    for (int i = 0; i <= 255; i++)
    {
        Console.WriteLine($"The ASCII Char for {i} is {Convert.ToChar(i)}");
    }
}

// 4. Get numbers from user until total reaches 100 [while]
void Problem4()
{
    Console.WriteLine("*************** Problem 4 ***************");

    int sum = 0;

    while (sum <= 100)
    {
        Console.Write("Enter a number to add: ");
        int number = int.Parse(Console.ReadLine());
        sum += number;
        Console.WriteLine($"Current sum is {sum}");
    }

    Console.WriteLine($"Current sum is {sum} - Max limit (100) exceeded");
}

// 5. Print ASCII code a char from user until user press x [do while]
void Problem5()
{
    Console.WriteLine("*************** Problem 5 ***************");

    char inputChar;
    int charAsciiCode;

    do
    {
        Console.Write("Enter a character to get its ASCII Code: ");
        inputChar = char.Parse(Console.ReadLine());

        if (inputChar == 'x')
            break;

        charAsciiCode = inputChar;
        Console.WriteLine($"The ASCII Code for {inputChar} is {charAsciiCode}");
    } while (inputChar != 'x');

    Console.WriteLine("Program terminated. 'x' entered");
}

// 6. Print simple menu again inside do while. 
void Problem6()
{
    Console.WriteLine("*************** Problem 6 ***************");

    int choice;

    do
    {

        Console.WriteLine(
"""
Select an item from the list by entering its number
   1) Add
   2) Edit
   3) Display
   4) Exit 
""");

        Console.Write("Enter a number to select: ");
        choice = int.Parse(Console.ReadLine());

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
    } while (choice >= 1 && choice <= 4);

}

// 1. Write a program to get sum of 1 student grades and get average and Greatest num then print message if "Success" or "Fail" 
void Problem1Arrays()
{
    Console.WriteLine("*************** Problem 1 Arrays ***************");

    // Assuming that Student has 5 Grades ONLY.
    // Assumming that Passing is by average more than or equal to 50

    int[] studentGrades = new int[5];
    int sumGrades = 0;
    double averageGrades = 0;
    int greatestGrade = int.MinValue;

    for (int i = 0; i < studentGrades.Length; i++)
    {
        Console.Write($"Enter Student's Grade {i + 1}: ");
        studentGrades[i] = int.Parse(Console.ReadLine());

        sumGrades += studentGrades[i];

        if (studentGrades[i] > greatestGrade)
            greatestGrade = studentGrades[i];
    }

    averageGrades = sumGrades / studentGrades.Length;

    // LINQ Solutions
    //sumGrades = studentGrades.Sum();
    //averageGrades = studentGrades.Average();
    //greatestGrade = studentGrades.Max();

    if (averageGrades >= 50)
        Console.WriteLine("Student is SUCCESS...");
    else
        Console.WriteLine("Student is FAIL...");
}

// 2. For 1D array , Try Resize and Delete by Shifting 
void Problem2Arrays()
{
    Console.WriteLine("*************** Problem 2 Arrays ***************");

    int samplesCount = 10;
    int[] arr = Enumerable.Range(0, samplesCount).ToArray();

    foreach (int item in arr)
    {
        Console.WriteLine($"{item},");
    }

    int indexToDelete;

    Console.Write("Enter the index you want to delete: ");
    indexToDelete = int.Parse(Console.ReadLine());

    if (indexToDelete < 0 || indexToDelete > samplesCount)
    {
        Console.WriteLine("Index number entered not in range. Try again...");
        return;
    }

    int[] newArr = new int[samplesCount - 1];

    // If removed index from Source Array is 0 (First index)
    // Start copying from 1 in Source Array (second index) to 0 in Destination Array
    if (indexToDelete == 0)
    {
        Array.Copy(arr, 1, newArr, 0, arr.Length - 1);

        // for (int i = 1; i <= newArr.Length; i++)
        // {
        //     newArr[i - 1] = arr[i];
        // }
    }
    // If removed index from Source Array is 10 (Last index)
    // Start copying from 0 in Source Array (second index) to 0 in Destination Array
    else if (indexToDelete == arr.Length)
    {
        Array.Copy(arr, 0, newArr, 0, arr.Length - 1);

        //for (int i = 0; i < newArr.Length; i++)
        //{
        //    newArr[i] = arr[i];
        //}
    }
    else
    {
        Array.Copy(arr, 0, newArr, 0, indexToDelete);
        Array.Copy(arr, indexToDelete + 1, newArr, indexToDelete, arr.Length - indexToDelete - 1);

        //for (int i = 0; i < indexToDelete; i++)
        //{
        //    newArr[i] = arr[i];
        //}

        //for (int i = 0; i < arr.Length - indexToDelete - 1; i++)
        //{
        //   newArr[indexToDelete + i] = arr[indexToDelete + i];
        //}
    }

    Console.WriteLine($"New Arr after deleting index {indexToDelete}:");

    foreach (int item in newArr)
    {
        Console.WriteLine($"{item},");
    }

}