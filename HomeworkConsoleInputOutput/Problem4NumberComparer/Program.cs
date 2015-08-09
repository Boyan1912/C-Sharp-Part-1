namespace Problem4NumberComparer
{
    using System;
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Greater: {0}", Math.Max(a, b));
        }
    }
}
