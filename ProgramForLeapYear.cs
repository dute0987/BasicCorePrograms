using System;
namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter your year = ");
            year = int.Parse(Console.ReadLine());

            if (((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)))
            {
                Console.WriteLine("This is leap year");
            }
            else
            {
                Console.WriteLine("this is not leap year");
            }

        }
    }
}
