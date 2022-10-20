using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_Cheng3001.HelperFunctions_Cheng3001
{
    public class FunctionsUseOftenOrArray_Cheng3001
    {
        public static int CompareTwoData(double a, double b)
        {
            if (a < b)
                return -1;
            else if (a > b)
                return +1;
            else
                return 0;
        }
    }
}
