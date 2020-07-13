using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Reflection
{
    class CarValue
    {
        public string getValue()
        { 
            FerrariF40 f40 = new FerrariF40();
            var value = f40.Value;

            return value;
        }
        
        
        
    }
}
