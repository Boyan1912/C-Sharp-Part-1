﻿namespace _09_MatrixOfNumbers
{
    using System;
    class Program
    {
        static void Main()
        {
            // Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                for (int j = 0; j < n; j++)
                {

                    Console.Write(j + i);

                }
                
                Console.WriteLine();
            }
            
        }
    }
}
