namespace Problem7SumОf5Numbers
{
    using System;
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int sum = 0;
            
            string[] numbers = input.Split(' ');


            for (int i = 0; i < numbers.Length; i++)
            {
                sum += int.Parse(numbers[i]);
            }
            
            Console.WriteLine(sum);
        }
    }
}
