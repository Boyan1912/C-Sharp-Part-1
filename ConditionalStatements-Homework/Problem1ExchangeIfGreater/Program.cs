namespace Problem1ExchangeIfGreater
{
    using System;
    class Program
    {
        static void Main()
        {

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                double temp = a;
                a = b;
                b = temp;
            }

        Console.WriteLine("{0} {1}", a, b);
        
        }
    }
}
