using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Reflection
{
    class CarYear
    {
        public string getYear()
        {
            FerrariF40 f40 = new FerrariF40();
            var year = f40.Year;

            return year;
        }
    }
}
