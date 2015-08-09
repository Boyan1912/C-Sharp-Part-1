namespace Problem3CirclePerimeterAndArea
{
    using System;
    class Program
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Perimeter | Area \n  {0:0.00}   | {1:0.00}", 2 * Math.PI * r, Math.PI * r * r);
        }
    }
}
