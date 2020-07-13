using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Reflection
{
    class _4000GT : ICar
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Registration { get; set; }
        public string Year { get; set; }
        public string Value { get; set; }

        public _4000GT(
            string make = "Mitsubishi",
            string model = "4000GT",
            string registration = "4000 GT",
            string year = "2020",
            string value = "500,000,000")
        {
            Make = make;
            Model = model;
            Registration = registration;
            Year = year;
            Value = value;
        }
    }
}
