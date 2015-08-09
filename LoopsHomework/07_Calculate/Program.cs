namespace _07_Calculate
{
    using System;
    using System.Numerics;
    class Program
    {
        static void Main()
        {
            BigInteger n = long.Parse(Console.ReadLine());
            BigInteger k = long.Parse(Console.ReadLine());

            BigInteger nFacturiel = 1;
            BigInteger kFacturiel = 1;
            BigInteger brackets = n - k;
            BigInteger bracketsFacturiel = 1;

            for (int i = 1; i <= n; i++)
            {

                nFacturiel *= i;
                
                if (i <= k)
                {
                    kFacturiel *= i;
                }

            }

            for (int i = 1; i <= brackets; i++)
            {
                bracketsFacturiel *= i;
            }

            BigInteger denominator = kFacturiel * bracketsFacturiel;

            Console.WriteLine("{0}", nFacturiel / denominator);
        }
    }
}
