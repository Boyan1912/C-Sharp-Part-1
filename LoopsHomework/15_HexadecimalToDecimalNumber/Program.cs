namespace _15_HexadecimalToDecimalNumber
{
    using System;
    class Program
    {
        static void Main()
        {

            string inputHex = Console.ReadLine();
                        
            long degree = inputHex.Length - 1;
            int num = 0;
            long resultDecimal = 0;

            for (int i = 0; i < inputHex.Length; i++)
            {

                char digit = inputHex[i];

                switch (digit.ToString())
                {
                    case "A": num = 10;
                        break;
                    case "B": num = 11;
                        break;
                    case "C": num = 12;
                        break;
                    case "D": num = 13;
                        break;
                    case "E": num = 14;
                        break;
                    case "F": num = 15;
                        break;
                    default: num = Convert.ToInt32(digit.ToString());
                        break;

                }

                resultDecimal += num * (long)Math.Pow(16, degree);
                degree--;
            }

            Console.WriteLine(resultDecimal);        
        }
    }
}
