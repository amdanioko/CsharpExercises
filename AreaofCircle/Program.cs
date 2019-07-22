using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaofCircle
{
    class Program
    {
        static void Main(string[] args)
        {

            while(TryReadNumber(out double number))
                Console.WriteLine($"The area is {CalculateCircleArea(number):F4}.");

            //bool finished = false;
            //while(!finished)
            //{
            //    bool success = TryReadNumber(out double number);
            //    if (success)
            //    {
            //        Console.WriteLine($"The area is {CalculateCircleArea(number): F4}.");
            //    }
            //    else finished = true;
            //}


        }
        static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
  
        }

    static bool TryReadNumber (out double number) // a parameter of type double, who ever calls this number will get it back
        {
            Console.Write("Enter the radius of a number:");
            string sNumber = Console.ReadLine();
            return double.TryParse(sNumber, out number);
        }
    }
}

