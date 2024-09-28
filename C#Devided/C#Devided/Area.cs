using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview_test
{
    internal class Area
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();


            Console.Write("Enter a character to remove: ");
            char charToRemove = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // Remove the character by looping through the string
            string resultString = "";
            foreach (char c in inputString)
            {
                if (c != charToRemove)
                {
                    resultString += c; // Append character if it doesn't match charToRemove
                }
            }

            // Output the result
            Console.WriteLine("String after removing character '" + charToRemove + "': " + resultString);
            Console.ReadKey();
        }
    }

}

