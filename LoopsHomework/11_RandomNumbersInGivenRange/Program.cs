namespace _11_RandomNumbersInGivenRange
{
    using System;
    class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            Random generator = new Random();

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine("{0} ", generator.Next(min, max + 1));
            }
        }
    }
}
