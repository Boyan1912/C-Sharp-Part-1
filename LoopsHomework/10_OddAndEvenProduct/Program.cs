namespace _10_OddAndEvenProduct
{
    using System;
    class Program
    {
        static void Main()
        {
            
  //  You are given n integers (given in a single line, separated by a space).
  //  Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
  //  Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

            string input = Console.ReadLine();
            string[] digits = input.Split(' ');
            int productEvenDigits = 1;
            int productOddDigits = 1;

            for (int i = 0; i < digits.Length; i++)
            {
               if (i % 2 == 0)
               {
                   productOddDigits *= int.Parse(digits[i]);

               }

               else
               {
                   productEvenDigits *= int.Parse(digits[i]);

               }

            }
            if (productEvenDigits == productOddDigits)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            Console.WriteLine("{0}   {1}", productOddDigits, productEvenDigits);
        }
    }
}
