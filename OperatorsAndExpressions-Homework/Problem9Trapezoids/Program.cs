namespace Problem9Trapezoids
{
    using System;
    class Program
    {
        static void Main()
        {
            double sideOne = double.Parse(Console.ReadLine());
            double sideTwo = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = ((sideOne + sideTwo) / 2) * height;

            Console.WriteLine(area);
        }
    }
}
