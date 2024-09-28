using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Devided
{
    internal class DOB
    {
        static void findAge(int c_date,int c_month,int c_year,
                                int b_date,int b_month,int b_year)
        {
            int[] month = {31,28,31,30,31,30,
                31,31,30,31,30, 31,};

            if (b_date > c_date)
            {
                c_month=c_month -1;
                c_date = c_date;
            }
        }
    }
}
