using System;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) // Végtelen ciklus
            {
                //kezdeti valtozok
                int num;
                bool isPrime = true;

                //bemenet
                Console.Write("Adjon meg egy számot, és a program megvizsgálja, hogy prímszám-e. (Az 'x' kilép)\nSzám vagy 'x': ");
                string input = Console.ReadLine();

                //kilep ha x
                if (input.ToLower() == "x") 
                {
                    break; 
                }
                //ha szam
                if (int.TryParse(input, out num))
                {
                    //ha 1 vagy kisebb, akkor nem prim
                    if (num <= 1)
                    {
                        isPrime = false;
                    }
                    //ha nagyobb mint 1
                    else
                    {
                        //ha oszthato, akkor a szam nem prim
                        for (int i = 2; i <= Math.Sqrt(num); i++)
                        {
                            if (num % i == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                    }
                    //ha true, prim
                    if (isPrime)
                    {
                        Console.WriteLine($"{num} prímszám.");
                    }
                    else
                    {
                        Console.WriteLine($"{num} nem prímszám.");
                    }
                }
                //ha nem szam
                else
                {
                    Console.WriteLine("Érvénytelen bemenet. Kérem, adjon meg egy érvényes számot vagy 'x'-et a kilépéshez.");
                }
            }
        }
    }
}
