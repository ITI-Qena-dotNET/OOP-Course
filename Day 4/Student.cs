using System.Text;
using System.Text.RegularExpressions;

namespace EncapsulationLab;

public class Student
{
    private string _name;
    private int _age;
    private string _password;

    public string Name
    {
        get
        {
            return _name;
        }

        set
        {
            if (value.Length > 5)
                _name = value;
        }
    }

    public int Age
    {
        get
        {
            return _age;
        }

        set
        {
            if (value >= 20)
                _age = value;
        }
    }

    public string Address { get; set; }

    //public int Grade { get; set; }

    public int[] Grades { get; set; }

    public string Username 
    { 
        get 
        { 
            return $"{Name}{Age}";
        }
    }

    public string Password 
    { 
        private get
        {
            return _password;
        }

        set
        {
            if (_password is not null)
            {
                Console.WriteLine("Password is already set...");
                return;
            }

            Regex passwordRegex = new("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");

            if (passwordRegex.IsMatch(value))
                _password = value;
            else
                throw new Exception("Password does not match regex...");
        }
    }

    public string ForgetPassword(string username)
    {
        if (username == Username)
        {
            const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ$#%@";

            StringBuilder sb = new();

            for (int i = 0; i < 12; i++)
            {
                int index = Random.Shared.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }

        throw new Exception("Username is not identified.");
    }

    public string PrintStudentGrades()
    {
        StringBuilder builder = new();

        foreach (int grade in Grades)
        {
            builder.Append($"{grade}, ");
        }

        return builder.ToString();
    }

    public void PrintStudentInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Username: {Username}");
    }

}
