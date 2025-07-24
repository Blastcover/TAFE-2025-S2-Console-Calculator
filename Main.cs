using System;

namespace MyCalc
{
  class Program
  {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a calculator that takes 2 inputs and find the Product");

            Console.WriteLine("Please Enter Value 1");
            double valOne = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter Value 2");
            double valTwo = Convert.ToDouble(Console.ReadLine());

            double product = valOne * valTwo;
            Console.WriteLine("Product is: " + product);
            
    }
  }
}