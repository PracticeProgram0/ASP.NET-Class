using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview_test
{
    internal class Area_calculation
    {
        public static int Square(int side)
        {
            int Area;
            Area = side*side;
            Console.WriteLine("Area of Square"+Area);
            return 0;
        }
        public static int Circle(int radios)
        {
            Double Area;
            Area = 3.14*radios*radios;
            Console.WriteLine("Area of Circle" + Area);
            return 0;
        }
        public static int Rectangle(int Lenth,int Berth)
        {
            int Area;
            Area=Lenth*Berth;
            Console.WriteLine("Area of Rectangle" + Area);
            return 0;
        }
        static void Main(string[] args)
        {
            Square(2);
            Circle(6);
            Rectangle(8, 6);
            Console.ReadLine();
        }
    }
}
