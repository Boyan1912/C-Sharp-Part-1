namespace Problem4Rectangles
{
    using System;
    class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = width * height;
            double perimeter = 2 * (width + height);

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
        }
    }
}
