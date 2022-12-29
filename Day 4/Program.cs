using EncapsulationLab;

Console.WriteLine("*********************** Lab 4 Problem ***********************");

/*
 * Create "Student" class with the following properties:
 *  
 *  Name (Must be more than 5 characters)
 *  Age (Must be greater than or equal 20)
 *  Address
 *  Grade (Bonus: Make it an array)
 *  
 *  Password [without GET] (Must be more than or equal characters) 
 *  (Bonus 1: Validate with Regular Expressions)
 *  (Bonus 2: Set password only once)
 *  
 *  Username (Name + Age)
 * 
 *  Functions:
 *  ForgetPassword()
 *    
 *    Parameters: Username
 *    Returns a randomly generated password if parameter matches student's username, else throw an exception
 */

Student newStudent = new();

Console.Write("Enter Student's Name: ");
newStudent.Name = Console.ReadLine();

Console.Write("Enter Student's Age: ");
newStudent.Age = int.Parse(Console.ReadLine());

Console.Write("Enter Student's Address: ");
newStudent.Address = Console.ReadLine();

Console.WriteLine("Enter Student's Grades: ");
//newStudent.Grade = int.Parse(Console.ReadLine());

newStudent.Grades = new int[5];

for (int i = 0; i < newStudent.Grades.Length; i++)
{
    Console.Write($"Enter Grade {i + 1}: ");
    newStudent.Grades[i] = int.Parse(Console.ReadLine());
}

Console.Write("Enter Student's Password: ");

try
{
    newStudent.Password = Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    return;
}

int choice;

do
{
    Console.WriteLine(
"""
Select an Option:
  1) Edit Name
  2) Edit Age
  3) Edit Address
  4) Edit Grade
  5) Forget Password
  6) Show Student Details
  7) Show Student Grades
  0) Exit
""");

    Console.Write("Enter a choice number: ");
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Enter a new name for Student: ");
            newStudent.Name = Console.ReadLine();
            break;

        case 2:
            Console.Write("Enter a new age for Student: ");
            newStudent.Age = int.Parse(Console.ReadLine());
            break;

        case 3:
            Console.Write("Enter a new address for Student: ");
            newStudent.Address = Console.ReadLine();
            break;

        case 4:
            Console.Write("Enter grade index to edit: ");
            int indexEdit = int.Parse(Console.ReadLine());

            if (indexEdit < 0 || indexEdit >= newStudent.Grades.Length)
            {
                Console.WriteLine($"Index {indexEdit} is out of bounds. Enter index between 0 and {newStudent.Grades.Length - 1}");
                break;
            }

            Console.Write("Enter a new grade for Student: ");
            newStudent.Grades[indexEdit] = int.Parse(Console.ReadLine());
            break;

        case 5:
            Console.Write("Enter your username to recover password: ");
            string username = Console.ReadLine();

            try
            {
                string newPassword = newStudent.ForgetPassword(username);

                if (newPassword is not null)
                {
                    Console.WriteLine($"New Password: {newPassword}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            break;

        case 6:
            newStudent.PrintStudentInfo();
            break;

        case 7:
            Console.WriteLine(newStudent.PrintStudentGrades());
            break;

        case 0:
            Console.WriteLine("Exit program...");
            return;
    }


} while (choice >= 0 && choice <= 6);
