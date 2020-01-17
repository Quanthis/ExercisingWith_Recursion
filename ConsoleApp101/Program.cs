using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp101
{
    class Program
    {
        static long ciag_rek(long n)
        {
            if (n == 0) return 3;
            else
            {
                return 3 + 2 * ciag_rek(n-1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("For n=1: {0}.", ciag_rek(1));
            Console.WriteLine("For n=2: {0}.", ciag_rek(2));
            Console.WriteLine("For n=100: {0}.", ciag_rek(50));
            Console.ReadKey();
        }
    }
}
