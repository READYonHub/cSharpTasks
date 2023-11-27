using System;

namespace FafctorialProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kezdeti valtozok
            int p1 = 1;

            //bemenet
            Console.Write("Please provide factorial number: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("Factorial Number:" +
                " \n----------------------------");

            for (int i = 1; i < input + 1; i++)
            {
                p1 = p1 * i;
                Console.Write(p1+" ");
            }

            Console.ReadLine();
        }
    }
}
