﻿namespace _05_Calculate
{
    using System;
    class Program
    {
        static void Main()
        {

            //  Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
            //  Use only one loop. Print the result with 5 digits after the decimal point.

            double n = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double sumN = 1;
            double result = 1;

            for (int i = 1; i <= n;  i++)
            {
                sumN *= i;
                result += sumN / Math.Pow(x, i);
                
            }
            
            Console.WriteLine("{0:F5}", result);
        }
    }
}
