namespace _03_MinMaxSumAndAverage
{
    using System;
    class Program
    {
        static void Main()
        {

            //  Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers 
            //    (displayed with 2 digits after the decimal point).
            //    The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.

             int n = int.Parse(Console.ReadLine());

             int sum = 0;
             int min = 0;
             int max = 0;
             double average = 0;

             for (int i = 1; i <= n; i++)
             {
                 int number = int.Parse(Console.ReadLine());

                 if (number >= max)
                 {
                     max = number;
                 }

                 if (number <= min && number < max)
                 {
                     min = number;
                 }

                 sum += number;

             }
            
             average = (double) sum / (double) n;

             Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:0.00}", min, max, sum, average);

        }
    }
}
