using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Reflection
{
    interface ICar
    {
        string Make { get; set; }
        string Model { get; set; }
        string Registration { get; set; }
        string Year { get; set; }
        string Value { get; set; }

    }
}
