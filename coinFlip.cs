using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coinFlip
{
    public class coinFlip
    {
        public static void FlipTheCoin()
        {
            Console.WriteLine("please enter the value number of flips");

            int Head = 0;
            int Tail = 0;
            int HeadCount = 0;
            int TailCount = 0;

            double HeadPercentage;
            double TailPercentage;

            int flipCoin=Convert.ToInt32(Console.ReadLine());

            if (flipCoin > 0)
            {
                for (int i = 0; i < flipCoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    if (number == 1)
                    {
                        Head = 1;
                        HeadCount += Head;
                    }
                    else if (number == 0)
                    {
                        Tail = 1;
                        TailCount += Tail;
                    }

                    Console.WriteLine(number);
                }
                    Console.WriteLine("....................");

                    HeadPercentage = HeadCount * 100 / flipCoin;
                    TailPercentage = TailCount * 100 / flipCoin;

                    Console.WriteLine("HeadPercentage " + HeadPercentage);
                    Console.WriteLine("TailPercentage " + TailPercentage);
            }
        }
    }
}
