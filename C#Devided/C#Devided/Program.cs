using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Devided
{
    internal class Program
    {

        static int divide(int a,int b)
        {
            int sign = ((a < 0) ^ (b < 0)) ? -1 : 1;
            a = Math.Abs(a);
            b = Math.Abs(b);

            int c = 0;
            while (a >= b)
            {
                a -= b;
                ++c;

            }

            if (sign == -1)
                c = -c;
            return c;
        }
        static void Main(string[] args)
        {

            int a = 10;
            int b = 3;
            Console.WriteLine(divide(a,b));

             Console.ReadKey();

        }
    }
}
