using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7
{
    class Program
    {
        static void Main(string[] args)
        {
            new PlayWithRecursion().Add(3, 4);
            var a = new PlayWithRecursion();
            Console.WriteLine(PlayWithRecursion.GetFactorial(4));
        }
    }
    class PlayWithRecursion
    {
        public void Add(int a, int b)
        {
            if (a> 10) { return; }

            Add(++a, --b);

        }
        public static long GetFactorial(int number)
        {
            Console.WriteLine(number);
            if (number == 0) { return 1; }

            return number * GetFactorial(number - 1);

        }
    }
}
