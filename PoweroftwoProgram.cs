using System;
namespace PowerOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int y = 2;
            int x = 1;
            for (int i = 0; i < n; i++)
            {
                x = x * y;
            }
            Console.WriteLine(x);
        }   
    }
}
