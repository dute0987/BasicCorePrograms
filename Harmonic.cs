using System;
namespace HarmonicNumber
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter your number :");
            int n = Convert.ToInt32(Console.ReadLine());
            double x = 0.0;

            for (double i = 1; i < n; i++)
            {
                x = x + 1/i;
          
            }
            Console.WriteLine( x + " is the harmonic value ");
        }
    }
}