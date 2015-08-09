namespace Problem7Sort3NumbersWithNestedIfs
{
    using System;
    class Program
    {
        static void Main()
        {

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double smallest = 0;
            double middle = 0;
            double biggest = 0;


            if (a <= b && a <= c)
            {
                smallest = a;
                if (b < c)
                {
                    middle = b;
                    biggest = c;
                }

                else
                {
                    middle = c;
                    biggest = b;
                }

            }

            else if (a >= b && b <= c)
            {
                smallest = b;
                
                if (a < c)
                {
                    middle = a;
                    biggest = c;

                }

                else
                {
                    middle = c;
                    biggest = a;
                }

            }

            else if (a <= b && b >= c)
            {
                biggest = b;

                if (a < c)
                {
                    smallest = a;
                    middle = c;

                }

                else
                {
                    smallest = c;
                    middle = a;

                }

            }

            else if (a >= b && b >= c)

            {
                biggest = a;

                if (b < c)
                {
                    smallest = b;
                    middle = c;

                }
                else
                {
                    smallest = c;
                    middle = b;

                }
            
            }
            Console.WriteLine(biggest.ToString() + " " + middle.ToString() + " " + smallest.ToString());
        }
    }
}
