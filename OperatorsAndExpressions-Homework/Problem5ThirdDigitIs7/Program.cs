namespace Problem5ThirdDigitIs7
{
    using System;
    using System.Text;
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool isThirdDigit7 = n % 1000 > 699 && n % 1000 < 800 ? true : false;
            Console.WriteLine(isThirdDigit7);

        }
    }
}
