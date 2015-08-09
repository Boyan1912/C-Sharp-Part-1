namespace Problem14ModifyABitAtGivenPosition
{
    using System;
    class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            short p = short.Parse(Console.ReadLine());
            byte v = byte.Parse(Console.ReadLine());

            int mask; 
            int result;

            if (v == 1)
            {
                mask = 1 << p;
                result = n | mask;
            }
            else
            {
                mask = ~(1 << p);
                result = n & mask;
            }

            Console.WriteLine(result);
        }
    }
}
