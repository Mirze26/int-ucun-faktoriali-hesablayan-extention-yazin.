using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Extention.Helpers
{

    public static class Static_Extention
    {
        public static int Num { get; set; } = 1;

        public static int Factorial(this int Num)
        {
            int multiplication = 1;

            for (int i = 1; i <=Num; i++)
            {
                multiplication *= i;
            }
                return multiplication;

        }

    }
}
