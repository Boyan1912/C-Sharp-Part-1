
namespace Problem1OddOrEvenIntegers
{
    using System;
    class Program
    {
        static void Main()
        {
            int oddOrEven = int.Parse(Console.ReadLine());

            bool isOdd = oddOrEven % 2 == 0 ? false : true;

            Console.WriteLine(isOdd);
        }
    }
}
