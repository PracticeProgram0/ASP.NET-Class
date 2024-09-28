using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Devided
{
    internal class Avarage
    {
        static int LargestNum(List<int> arr, int n)
        {

            int maxK = -3;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == -arr[j]
                        && Math.Abs(arr[i]) > maxK)
                        maxK = Math.Abs(arr[i]);
                }
            }
            return maxK;
        }

        static void Main(string[] args)
        {

            // Input array
            List<int> arr = new List<int> { 7, 4, 5,4, 2, 6 };
            int n = arr.Count;

            // Function Call
            Console.WriteLine(LargestNum(arr, n));
            Console.Read();
        }
    }
}


