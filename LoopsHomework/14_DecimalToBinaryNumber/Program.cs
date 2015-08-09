namespace _14_DecimalToBinaryNumber
{
    using System;
    class Program
    {
        static void Main()
        {

            long inputNumber = long.Parse(Console.ReadLine());

            string binaryOutput = "";
            

            while (inputNumber > 0)
            {
                if (inputNumber % 2 != 0)
                {
                    binaryOutput += "1";
                }

                else
                {

                    binaryOutput += "0";
                }

                inputNumber /= 2;
            }

            char[] reversedBinaryOutput = new char[binaryOutput.Length];

            for (int i = 0; i < binaryOutput.Length; i++)
            {

            reversedBinaryOutput[i] = binaryOutput[binaryOutput.Length - 1 - i];

            }

            Console.WriteLine(reversedBinaryOutput);
        }
    }
}
