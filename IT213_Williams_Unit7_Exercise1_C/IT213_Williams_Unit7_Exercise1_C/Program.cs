﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Williams_Unit7_Exercise1_C
{
    class MaximumFinder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three floating-point values,\n" +
                "pressing 'Enter' after each one:");

            double number1 = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());
            double number3 = Convert.ToDouble(Console.ReadLine());

            double result = Maximum(number1, number2, number3);

            Console.WriteLine("Maximum is " + result);
        }

        private static double Maximum (double x, double y, double z)
        {
            double maximumValue = x;

            if (y > maximumValue)
                maximumValue = y;

            if (z > maximumValue)
                maximumValue = z;

            return maximumValue;
        }
    }
}
