using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    public class QuotientRemindar
    {
        public static void FindQuotientAndRemindar()
        {
            int dividend = 50, divisor = 4;
            int quotient = dividend / divisor;

            int remainder = dividend % divisor;

            Console.WriteLine("Dividend : {0},Divisor : {1}", divisor, dividend);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remaindar = " + remainder);

        }
    }
}
