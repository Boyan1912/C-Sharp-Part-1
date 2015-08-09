
namespace Problem13CheckABitAtGivenPosition
{
    using System;
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            short p = short.Parse(Console.ReadLine());
            int mask = 1 << p;
            int result = n & mask;
            result >>= p;
            bool isBitOne = result == 1 ? true : false;
            Console.WriteLine(isBitOne);
        }
    }
}
