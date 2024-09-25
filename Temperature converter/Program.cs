using System;

namespace Temperature_converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius = 0; // here we created a variable 
            double farenheit = 0;
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Please enter temperature on Celsius");
            celsius = Convert.ToDouble (Console.ReadLine()); // here we have to convert to a double 
            farenheit = (celsius * 9 / 5) + 32; // here we assign a value to a global variable that we created at the top
            Console.WriteLine($" Temperature in Fahrenheit is  {farenheit}");







        }
    }
}
