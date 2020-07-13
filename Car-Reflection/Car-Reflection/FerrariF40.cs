using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Reflection
{
    class FerrariF40 : ICar
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Registration { get; set; }
        public string Year { get; set; }
        public string Value { get; set; }

        public FerrariF40(
            string make = "Ferrari",
            string model = "F40",
            string registration = "F40 DP",
            string year = "1987",
            string value = "1,000,000") 
        {
            Make = make;
            Model = model;
            Registration = registration;
            Year = year;
            Value = value;
        }
    }
}
