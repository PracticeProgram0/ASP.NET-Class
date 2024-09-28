using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Devided
{
    internal class String
    {
        public static void Main(string[]ar)
        {
            Console.WriteLine("Enter a name ");
           string input= Console.ReadLine();

            Console.WriteLine("Enter a charter Remove...");
           char remove= Console.ReadLine()[0];
            string resultstring = "";
            foreach (char ch in input)
            {
                if (ch!=remove)
                {
                    resultstring += ch;                    
                }
                Console.WriteLine("string after remove"+" :"+resultstring);
            }
            Console.ReadKey();
        }
       
    }

}

