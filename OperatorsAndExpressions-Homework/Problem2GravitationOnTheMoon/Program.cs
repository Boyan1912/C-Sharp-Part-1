
namespace Problem2GravitationOnTheMoon
{
    using System;
    class Program
    {
        static void Main()
        {
            float weightOnEarth = float.Parse(Console.ReadLine());
            float weightOnMoon = weightOnEarth * 17 / 100;

            Console.WriteLine(weightOnMoon);
        }
    }
}
