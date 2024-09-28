using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Devided
{
    internal class Check_Status
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int age =int.Parse( Console.ReadLine());
            Console.WriteLine("Enter your sex");
            string sex = Console.ReadLine();
            Console.WriteLine("maritle");
            string maritle = Console.ReadLine();
            if(sex == "Female")
            {
                Console.WriteLine("Work will only in urban");
            }
            else if(sex == "Male" && age >= 20 && age <=40)
            {
                Console.WriteLine("Apply any where");
            }
            else if(sex == "Male" && age >= 40 &&  age <= 60)
            {
                Console.WriteLine("Work is urban areas");
            }
            else 
                {
                Console.WriteLine("Error");
                }
        }
    }
}
