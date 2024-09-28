using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Devided
{
    internal class Student_Grading
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your marks");
            int marks = int.Parse(Console.ReadLine());

           // String Grad;

            if (marks < 25)
            {
                Console.WriteLine("Fail");
            }
            else if (marks >= 25 && marks <= 45)
            {
                Console.WriteLine("Grad = E");
            }
            else if(marks >= 45 &&  marks <= 50)
            {
                Console.WriteLine("Grad = D");
            }
            else if(marks >=50 && marks <=60)
            {
                Console.WriteLine("grad = C");
            }
            else if(marks >=60 && marks <=80)
            {
                Console.WriteLine("Grad  = B");
            }
            else if(marks >= 80)
            {
                Console.WriteLine("Grad = A");
            }
            Console.ReadKey();
        }
    }
}
