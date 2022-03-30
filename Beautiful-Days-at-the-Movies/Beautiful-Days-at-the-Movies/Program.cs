using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beautiful_Days_at_the_Movies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = beautifulDays(20, 23, 6);
            var b = beautifulDays(949488, 1753821, 5005440);
            var c = beautifulDays(1, 2000000, 23047885);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadKey();
        }

        public static int beautifulDays(int i, int j, int k)
        {
            var beautifulDays = 0;
            for (int l = i; l <= j; l++)
            {
                if (Math.Abs(l - reverseNumber(l)) % k == 0)
                    beautifulDays++;
            }
            return beautifulDays;
        }

        public static int reverseNumber(int number)
        {
            int reverse = 0;
            while (number > 0)
            {
                int remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }

            return reverse;
        }

    }
}
