
namespace Problem12ExtractBitFromInteger
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
            Console.WriteLine(result >> p);
        }
    }
}
