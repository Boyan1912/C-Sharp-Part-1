namespace Problem10PointInsideACircleOutsideOfARectangle
{
    using System;
    class Program
    {
        static void Main()
        {
            // Circle K({1, 1}, 1.5)
            // Rectangle R(top=1, left=-1, width=6, height=2)

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool insideCircle = (Math.Sqrt(x - 1) + Math.Sqrt(y - 1)) <= Math.Sqrt(1.5) ? true : false;
            bool outsideRectangle = ((x < -1) || (x > (-1 + 6))) || ((y > 1) || (y < (1 - 2))) ? true : false;

            if (insideCircle && outsideRectangle)
            {
                Console.WriteLine("yes");
            }
            
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
