using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    public class FindingLargest
    {
        public static void FindTheLargeNumber()
        {
            Console.WriteLine("Find the largest number of three number");
            int num1, num2, num3;

            Console.WriteLine("Input the first number");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("input the third number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1>num2 && num1>num3)
            {
                Console.WriteLine("num1 is greater then num2 and num3");
            }
            else if (num2> num1 && num2>num3)
            {
                Console.WriteLine("num2 is greater than num1 and num3");
            }
            else
            {
                Console.WriteLine("num3 is greater than num1 and num2");
            }
        }
    }
}
