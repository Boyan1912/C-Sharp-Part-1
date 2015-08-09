namespace _16_DecimalToHexadecimalNumber
{
    using System;
    class Program
    {
        static void Main()
        {

            long inputDecimal = long.Parse(Console.ReadLine());
            long remainder = 0;

           string outputHex = "";
                      

            while (inputDecimal > 0)
            {
                
                string hexaDigits = "";

                remainder = inputDecimal % 16;

                switch (remainder)
                {
                    case 10: hexaDigits = "A"; break;
                    case 11: hexaDigits = "B"; break;
                    case 12: hexaDigits = "C"; break;
                    case 13: hexaDigits = "D"; break;
                    case 14: hexaDigits = "E"; break;
                    case 15: hexaDigits = "F"; break;
                    default: hexaDigits = remainder.ToString(); break;
                
                }

                outputHex = hexaDigits;

                inputDecimal /= 16;


                Console.Write(outputHex);
                            
            }
     
       

        }
    }
}
