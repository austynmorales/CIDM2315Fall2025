namespace Week3;

class Program
{
    static void Main(string[] args)
    {
        //Q1
        Console.Write("Input an integer:");
        int N = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(N))
            Console.WriteLine($"{N} is a prime number.");
        else
            Console.WriteLine($"{N} is not a prime number.");
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
    {   //Q2
        Console.Write("Assign an int value to N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
        

         //Q3
        Console.Write("Assign an int value to N: ");
        int S = Convert.ToInt32(Console.ReadLine());

         for (int row = 1; row <= S; row++)
    {
            for (int col = 1; col <= row; col++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }

    Console.ReadKey();

         //Bonus Q
        Console.Write("Assign an int value to N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= i ;j++)
            {
                Console.Write("i");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    
}       

