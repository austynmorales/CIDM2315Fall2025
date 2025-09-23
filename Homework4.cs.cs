namespace Homework4
{
    class Program
    {
        //Q1: Mehtod to return the larges of two numbers
        static int GetLargest(int num1, int num2)
        {
            if (num1 > num2)
                return num1;
            else
                return num2;
        }

        //Q2: Method to print a triangle (left or right)
        static void PrinTriangle(int N, string shape)
        {
            Console.WriteLine($"N is: {N}; shape is {shape}");
            if (shape.ToLower() == "left")
            {
                //Left-Side triangle
                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.WriteLine("*");
                    }
                    Console.WriteLine();
                }
            }
            else if (shape.ToLower() == "right")
            {
                //Right-side triangle
                for (int i = 1; i <= N; i++)
                {
                    //Print spaces first
                    for (int j = 1; j <= N - i; j++)
                    {
                        Console.Write(" ");
                    }
                    // Then print stars
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid shape! Use 'left' or 'right'.");
            }
        }
        static void Main(string[] args)
        {
            // =====Q1=====
            int a = 3;
            int b = 5;

            //Call the method
            int largest = GetLargest(a, b);

            //Print results
            Console.WriteLine($"a = {a}; b = {b}");
            Console.WriteLine($"The largest number is: {largest}");

            // =====Q2=====
            int N = 5;
            string shape = "left";

            PrinTriangle(N, shape);
        }
    }
}