namespace Problem7PointInACircle
{
    using System;
    class Program
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine(((x * x) + (y * y)) <= (2 * 2) ? true : false);
        }
    }
}
