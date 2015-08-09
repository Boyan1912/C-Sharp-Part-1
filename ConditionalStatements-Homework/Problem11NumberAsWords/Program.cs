namespace Problem11NumberAsWords
{
    using System;
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            string firstDigit = null;
            string secondDigit = null;
            string thirdDigit = null;

            byte numberOfChars = (byte) number.Length;


            switch (number[0])        // using the string as a char array; Char array се брои от ляво на дясно за разлика от всичко останало. За това започвам от number[0] = one hundred, а не umber[0] = one.
                {

                    case '1': firstDigit = "One Hundred"; break;
                    case '2': firstDigit = "Two Hundred"; break;
                    case '3': firstDigit = "Three Hundred"; break;
                    case '4': firstDigit = "Four Hundred"; break;
                    case '5': firstDigit = "Five Hundred"; break;
                    case '6': firstDigit = "Six Hundred"; break;
                    case '7': firstDigit = "Seven Hundred"; break;
                    case '8': firstDigit = "Eight Hundred"; break;
                    case '9': firstDigit = "Nine Hundred"; break;

                }

                switch (number[1])
                {
                    case '1':
                        if (number[2] == '0') { secondDigit = "Ten"; }
                        if (number[2] == '1') { secondDigit = "Eleven"; }
                        if (number[2] == '2') { secondDigit = "Twelf"; }
                        if (number[2] == '3') { secondDigit = "Thirteen"; }
                        if (number[2] == '4') { secondDigit = "Fourteen"; }
                        if (number[2] == '5') { secondDigit = "Fifteen"; }
                        if (number[2] == '6') { secondDigit = "Sixteen"; }
                        if (number[2] == '7') { secondDigit = "Seventeen"; }
                        if (number[2] == '8') { secondDigit = "Eighteen"; }
                        if (number[2] == '9') { secondDigit = "Nineteen"; }
                        break;

                    case '2': secondDigit = "Twenty"; break;
                    case '3': secondDigit = "Thirty"; break;
                    case '4': secondDigit = "Fourty"; break;
                    case '5': secondDigit = "Fifty"; break;
                    case '6': secondDigit = "Sixty"; break;
                    case '7': secondDigit = "Seventy"; break;
                    case '8': secondDigit = "Eighty"; break;
                    case '9': secondDigit = "Ninety"; break;

                }

                try
                {
                    switch (number[2])
                    {
                        case '0': thirdDigit = "Zero"; break;
                        case '1': thirdDigit = "One"; break;
                        case '2': thirdDigit = "Two"; break;
                        case '3': thirdDigit = "Three"; break;
                        case '4': thirdDigit = "Four"; break;
                        case '5': thirdDigit = "Five"; break;
                        case '6': thirdDigit = "Six"; break;
                        case '7': thirdDigit = "Seven"; break;
                        case '8': thirdDigit = "Eight"; break;
                        case '9': thirdDigit = "Nine"; break;

                    }
                }

                catch (System.IndexOutOfRangeException outsideArray)
                {

                    Console.WriteLine(secondDigit + " " + thirdDigit);
                }


                if (numberOfChars == 3 && number[2] == '0' && number[1] == '0')
                {
                Console.WriteLine(firstDigit);
                }


                else if ((numberOfChars == 3 && number[2] == '0') || (numberOfChars == 3 && number[1] == '1'))
                {
                Console.WriteLine(firstDigit + " and " + secondDigit);
                }

                else
                {
                    Console.WriteLine(firstDigit + " and " + secondDigit + " " + thirdDigit);
                }
          
        // Работи само за 3 цифрени числа. Нямам време да го мъдря повече :)
        
        
        
        }
    }
    
}
