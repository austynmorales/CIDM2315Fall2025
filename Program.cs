using System;

namespace week5;

class Program
{
    //Q1//
    public static int GetMaxOfTwo(int a, int b)
    {
        if (a > b)
            return a;
        else
            return b;
    }

    //Q2//
    public static int GetMaxOfFour(int a, int b, int c, int d)
    {
        int max1 = GetMaxOfTwo(a, b);
        int max2 = GetMaxOfTwo(c, d);
        int maxFinal = GetMaxOfTwo(max1, max2);
        return maxFinal;
    }

    //Q3 method 1: checkAge
    public static bool CheckAge(int birth_year)
    {
            int currentYear =
        DateTime.Now.Year;
            int age = currentYear -
        birth_year;
        return age >= 18;
    }

    //Q3 method 2: CreateAccount
    public static void CreateAccount()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine() ?? string.Empty;
        Console.Write("Enter password: ");
        string password1 = Console.ReadLine() ?? string.Empty;
        Console.Write("Re-enter password: ");
        string password2 = Console.ReadLine() ?? string.Empty;
        int birthYear = ReadInt("Enter your birth year: ");

        if (CheckAge(birthYear))
        {
            if (password1 == password2)
                Console.WriteLine("Account is created succesfully\n");
            else
                Console.WriteLine("Wrong password\n");
        }
        else
        {
            Console.WriteLine("Could not create an account (age must be 18+)\n");
        }
    }
    static void Main(string[] args)
    {
        // Simple menu to run each question/demo
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Q1: Largest of two numbers");
            Console.WriteLine("2) Q2: Largest of four numbers");
            Console.WriteLine("3) Q3: Create account (age check)");
            Console.WriteLine("0) Exit");
            Console.Write("Option: ");

            string? choice = Console.ReadLine();
            if (choice == "0" || choice == null)
                break;

            Console.WriteLine();
            switch (choice)
            {
                case "1": RunQ1(); break;
                case "2": RunQ2(); break;
                case "3": CreateAccount(); break;
                default: Console.WriteLine("Invalid option\n"); break;
            }
        }
    }

    static void RunQ1()
    {
        Console.WriteLine("Q1: Find largest of two numbers");
        int a1 = ReadInt("Enter first number (a): ");
        int b1 = ReadInt("Enter second number (b): ");

        int largestTwo = GetMaxOfTwo(a1, b1);
        Console.WriteLine("The largest number is: " + largestTwo + "\n");
    }

    static void RunQ2()
    {
        Console.WriteLine("Q2: Find largest of four numbers");
        int a = ReadInt("Enter number a: ");
        int b = ReadInt("Enter number b: ");
        int c = ReadInt("Enter number c: ");
        int d = ReadInt("Enter number d: ");

        int largestFour = GetMaxOfFour(a, b, c, d);
        Console.WriteLine("The largest number is: " + largestFour + "\n");
    }

    // Helper: read an integer with validation
    private static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int value))
                return value;
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}

