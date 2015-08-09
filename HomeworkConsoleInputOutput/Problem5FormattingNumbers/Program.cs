namespace Problem5FormattingNumbers
{
    using System;
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            string aInBinary = Convert.ToString(a, 2).PadLeft(10, '0');

            Console.WriteLine("{0:X} | {1} | {2, 7:0.00} | {3, -6:F3} |", a, aInBinary, b, c);
        }
    }
}
