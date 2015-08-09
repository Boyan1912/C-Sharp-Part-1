namespace Problem6FourDigitNumber
{
    using System;
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int fourthDigit = n % 10;
            n /= 10;
            int thirdDigit = n % 10;
            n /= 10;
            int secondDigit = n % 10;
            n /= 10;
            int firstDigit = n;

            int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;

            Console.WriteLine(sum);
            Console.WriteLine(fourthDigit.ToString() + thirdDigit.ToString() + secondDigit.ToString() + firstDigit.ToString());
            Console.WriteLine(fourthDigit.ToString() + firstDigit.ToString() + secondDigit.ToString() + thirdDigit.ToString());
            Console.WriteLine(firstDigit.ToString() + thirdDigit.ToString() + secondDigit.ToString() + fourthDigit.ToString());
        }
    }
}
