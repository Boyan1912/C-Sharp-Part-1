namespace _06_CalculateNK
{
    using System;
    class Program
    {
        static void Main()
        {
            
                //  Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
                //  Use only one loop.

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int nFacturiel = 1;
            int kFacturiel = 1;

            for (int i = 1; i <= n; i++)
            {
                nFacturiel *= i;
                
                if (i <= k)
                {
                    kFacturiel *= i;
                    
                }
            }

            int result = nFacturiel / kFacturiel;
            Console.WriteLine(result);
        }
    }
}
