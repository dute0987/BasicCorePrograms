using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialProgram
{
    public class FactorialProgram
    {
        public static void ProgramFactorail()
        {
            int n = 6;
            double fact = 1;

            for (int i=1; i<= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial of {0}={1}", n, fact);
            Console.ReadLine();
        }
    }
}
