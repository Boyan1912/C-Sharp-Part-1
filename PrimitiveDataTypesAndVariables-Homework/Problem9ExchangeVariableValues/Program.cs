namespace Problem9ExchangeVariableValues
{
    using System;
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Now a is {0}, and b is {1}", a, b);

            int exchangeValues = a;
            a = b;
            b = exchangeValues;
            
            Console.WriteLine("Now a is {0}, and b is {1}", a, b);
        }
    }
}
