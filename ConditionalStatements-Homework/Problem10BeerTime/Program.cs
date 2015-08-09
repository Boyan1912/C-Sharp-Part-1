namespace Problem10BeerTime
{
    using System;
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter your time (hh:mm tt): ");
            DateTime beerTime;
          
            if (DateTime.TryParse(Console.ReadLine(), out beerTime))
            {
                int hours = beerTime.Hour;
                int minutes = beerTime.Minute;

                if (hours >= 13 || hours <= 3)
                {
                    Console.WriteLine("beer time");
                }

                else
                {
                    Console.WriteLine("non-beer time");
                }

            }
            else
            {
                Console.WriteLine("invalid time");
            }

        }
    }
}
