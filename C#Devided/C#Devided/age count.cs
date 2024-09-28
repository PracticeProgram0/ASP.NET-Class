using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Devided
{
    internal class age_count
    {
        public static void Main(string[]ar)
        {
            Console.WriteLine("Enter your birthdate (yyyy-mm-dd):");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime birthDate))
            {
                int age = CalculateAge(birthDate);
                int month = CalculateAge(birthDate);
                Console.WriteLine($"You are {age} years old.{month}");
            }
            else
            {
                Console.WriteLine("Invalid date format. Please use yyyy-mm-dd.");
            }

            Console.ReadKey();  
        }

        static int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;

            // Adjust age if the birthday hasn't occurred yet this year
            if (birthDate > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }        
    }
}
