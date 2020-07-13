using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Reflection
{
    class Test4000GT
    {
        public string GetTest() 
        {
            _4000GT GT = new _4000GT();
            var make = GT.Make;
            var model = GT.Model;
            var reg = GT.Registration;
            var year = GT.Year;
            var value = GT.Value;

            string test = "This car is the " + make + " " + model + ". It's registration is " + reg + ". The year this was built was " + year + " and it is worth £" + value;
            return test;
        }
    }
}
