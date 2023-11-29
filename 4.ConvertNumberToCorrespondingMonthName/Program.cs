using System;
//MEGOLDÁS 1 using System.Globalization;
namespace ConvertNumberToCorrespondingMonthName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            //Console.WriteLine(MonthName(num));

            //MEGOLDÁS 1 Console.WriteLine( MonthName(num));

            Console.ReadLine();
        }
        /*MEGOLDÁS 2
        public static string MonthName(int num)
        {
            string[] tomb = {
                "January", "February", "March", "April",
                "May", "June", "July", "August",
                "September", "October","November", "December"
            };

            return tomb[num-1];
        }
        */

        /*MEGOLDAS 1
            public static string MonthName(int num) { 
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(num);
            }
        */
    }
}

/*
 * Feladat:
 https://edabit.com/challenge/uevxL5FNM77otyo9Z
 */
