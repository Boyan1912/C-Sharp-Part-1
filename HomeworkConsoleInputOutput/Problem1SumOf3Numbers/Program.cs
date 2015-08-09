namespace Problem1SumOf3Numbers
{
    using System;
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("The sum of a,b and c is: {0}", a + b + c);
        }
    }
}
