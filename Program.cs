using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("FizzBuzz!");
            Console.WriteLine("---------");
            int one = 1;
            bool onetest = true;
            if (onetest)
            {
                int onetest1 = one / 3;
                onetest1 = 0;
                Console.WriteLine("1");
            }

            int two = 1;
            bool twotest = true;
            if (twotest)
            {
                int twotest1 = two / 3;
                twotest1 = 0;
                Console.WriteLine("2");
            }

            int one = 1;
            bool onetest = true;
            if (onetest)
            {
                int onetest1 = one / 3;
                onetest1 = 0;
                Console.WriteLine("Fizz");
            }

        }
    }
}
