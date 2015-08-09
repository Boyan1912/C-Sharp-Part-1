namespace Problem11BitwiseExtractBit3
{
    using System;
    class Program
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            uint mask = 1 << 3;
            uint result = n & mask;
            Console.WriteLine(result >> 3);
        }
    }
}
