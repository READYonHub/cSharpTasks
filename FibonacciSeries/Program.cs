using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The Fibonacci sequence is a series of numbers where the next term is the sum of previous two terms.");
            Console.WriteLine("Formula. fn=f(n-1)+f(f-n)");
            Console.WriteLine("The first two terms of the Finbonacci sequence is 0 followed by 1.");
            Console.WriteLine("0 1 1 2 3 5 8 13 21 34 55 89 ...\n");

            while (true)
            {
                try
                {
                    //Simple solution
                    int p1 = 0, p2 = 1, p3, count = 0;

                    Console.Write("Please provide input value: ");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "x")
                    {
                        Environment.Exit(0);
                    }

                    count = Convert.ToInt32(input);

                    Console.Write(p1 + " " + p2);
                    for (int i = 2; i < count; i++)
                    {
                        p3 = p1 + p2;
                        Console.Write(" " + p3);
                        p1 = p2;
                        p2 = p3;
                    }
                    Console.WriteLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nem egész számot adtál meg!");
                }
            }
        }
    }
}
