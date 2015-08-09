namespace Problem3DivideBy7And5
{
    using System;
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool divide = n % 7 == 0 && n % 5 == 0 ? true : false;

            Console.WriteLine(divide);

        }
    }
}
