using System;

namespace FafctorialProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p1 = 1;
            Console.Write("Please provide factorial number: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial Number:" +
                " \n----------------------------");
            for (int i = 5; i < input + 1; i++)
            {
                p1 = p1 * i;
                Console.Write(p1+" ");
            }

            Console.ReadLine();
        }
    }
}
