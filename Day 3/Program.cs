Problem1();
Problem2();
Problem3();

#region 1. Fill and Print a 2D Array (Using Functions)
void Problem1()
{
    Console.WriteLine("*************** Problem 1 ***************");

    int[,] arr = new int[3, 2];

    //Read2DArrayByRowFromUser(arr);
    Read2DArrayByColumnFromUser(arr);

    Print2DArrayToConsole(arr);
}

void Print2DArrayToConsole(int[,] arr)
{
    Console.WriteLine("The Final array is: ");

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }

        Console.WriteLine();
    }
}

void Read2DArrayByRowFromUser(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"Enter array element ({i},{j}): ");
            arr[i, j] = int.Parse(Console.ReadLine());
        }
    }
}

void Read2DArrayByColumnFromUser(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            Console.Write($"Enter array element ({j},{i}): ");
            arr[j, i] = int.Parse(Console.ReadLine());
        }
    }
}
#endregion

#region 2. Sum of every 'Column' in 2D Array (Using Functions)
void Problem2()
{
    Console.WriteLine("*************** Problem 2 ***************");

    int[,] arr = new int[2, 3];
    int[] columnSumArray = new int[arr.GetLength(1)];

    InsertIntoArrayAndStoreSumInArray(arr, columnSumArray);

    Print2DArrayToConsole(arr);

    Console.WriteLine("The columns Sum is: ");

    foreach (int item in columnSumArray)
    {
        Console.Write($"{item},");
    }
}

void InsertIntoArrayAndStoreSumInArray(int[,] arr, int[] columnSumArray)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"Enter array element ({i},{j}): ");
            arr[i, j] = int.Parse(Console.ReadLine());
            columnSumArray[j] += arr[i, j];
        }
    }
}
#endregion

#region 3. Simple Menu on Array (Refer to Problem 6 in Lab 2)
void Problem3()
{
    Console.WriteLine("*************** Problem 3 ***************");

    int choice;
    int[] arr = new int[5];
    int currentIndex = 0;

    do
    {

        Console.WriteLine(
"""
Select an item from the list by entering its number
   1) Add
   2) Edit
   3) Delete
   4) Display
   5) Exit 
""");

        Console.Write("Enter a number to select: ");
        choice = int.Parse(Console.ReadLine());

        Console.Write("Choice selected: ");

        switch (choice)
        {
            case 1:
                Console.WriteLine("Add");

                if (currentIndex >= arr.Length)
                {
                    Console.WriteLine("Cannot enter a new value. No Space available.");
                    break;
                }

                AddNewElementInArray(arr, ref currentIndex);
                break;

            case 2:
                Console.WriteLine("Edit");
                Console.Write($"Enter the index to edit: ");
                int indexEdit = int.Parse(Console.ReadLine());

                if (indexEdit < 0 || indexEdit >= arr.Length)
                {
                    Console.WriteLine($"Index {indexEdit} is out of Array bounds.");
                    return;
                }

                EditArrayElementAtIndex(arr, indexEdit);
                break;

            case 3:
                Console.WriteLine("Delete");

                Console.Write($"Enter the index to delete at: ");
                int indexDelete = int.Parse(Console.ReadLine());

                if (indexDelete < 0 || indexDelete >= arr.Length)
                {
                    Console.WriteLine("Index number entered not in range. Try again...");
                    return;
                }

                DeleteArrayElementAtIndex(arr, indexDelete, ref currentIndex);

                Console.WriteLine("Deleted");

                break;
            case 4:
                Console.WriteLine("Display");
                Display1DArray(arr);
                break;

            case 5:
                Console.WriteLine("Exit");
                return;
            default:
                Console.WriteLine("Unidentified Option. Please try again.");
                break;
        }
    } while (choice >= 1 && choice <= 5);
}

void AddNewElementInArray(int[] arr, ref int currentIndex)
{
    Console.Write($"Enter the value to add in index {currentIndex}: ");
    arr[currentIndex] = int.Parse(Console.ReadLine());
    currentIndex++;
    Console.WriteLine("Added");
}

void EditArrayElementAtIndex(int[] arr, int indexEdit)
{
    Console.Write($"Enter the value to edit in index {indexEdit}: ");
    arr[indexEdit] = int.Parse(Console.ReadLine());
    Console.WriteLine($"Edited index {indexEdit} with value {arr[indexEdit]}");
}

void DeleteArrayElementAtIndex(int[] arr, int indexDelete, ref int currentIndex)
{

    Array.Copy(arr, indexDelete + 1, arr, indexDelete, arr.Length - indexDelete - 1);

    //for (int i = indexDelete; i < arr.Length - indexDelete; i++)
    //{
    //    arr[indexDelete] = arr[indexDelete + 1];
    //}

    arr[arr.Length - 1] = 0;
    currentIndex--;
}

void Display1DArray(int[] arr)
{
    Console.WriteLine("Current Values in Array: ");

    foreach (int item in arr)
    {
        Console.Write($"{item}, ");
    }

    Console.WriteLine();
}
#endregion
