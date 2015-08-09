namespace Problem5TheBiggestOf3Numbers
{
    using System;
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a < b)
            {
                a = b;
                if (a < c)
                {
                    a = c;
                }

            }
            else
            {
                if (a < c)
                {
                    a = c;
                }
            }

            Console.WriteLine("biggest: {0}", a);
        }
    }
}
