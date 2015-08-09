namespace Problem10FibonacciNumbers
{
    using System;
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            

            for (int i = 0; i <= n; i++)
            {
                int temp = 0;
                temp = a;
                Console.Write("{0}, ", a);
                a = b;
                b = temp + b;
                
            }
        }
    }
}