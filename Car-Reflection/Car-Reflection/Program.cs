using System;

namespace Car_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            CarValue Value = new CarValue();
            var val = Value.getValue();
            Console.WriteLine("The value of this car is: £" + val);
            Console.WriteLine();
            CarYear Year = new CarYear();
            var year = Year.getYear();
            Console.WriteLine("The year this car was built was in: " + year);
            Console.WriteLine();
            Test4000GT testGT = new Test4000GT();
            var test = testGT.GetTest();
            Console.WriteLine(test);
        }
    }
}
