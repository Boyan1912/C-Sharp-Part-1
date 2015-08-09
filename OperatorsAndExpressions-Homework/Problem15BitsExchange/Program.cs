namespace Problem15BitsExchange
{
    using System;
    class Program
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());

            long result = 0;
            long maskThirdBit = 1 << 3;
            long maskFourthBit = 1 << 4;
            long maskFifthBit = 1 << 5;
            long maskTwentyFour = 1 << 24;
            long maskTwentyFive = 1 << 25;
            long maskTwentySix = 1 << 26;

            long resultThirdBit = n & maskThirdBit;
            long resultFourthBit = n & maskFourthBit;
            long resultFifthBit = n & maskFifthBit;
            long resultTwentyFour = n & maskTwentyFour;
            long resultTwentyFive = n & maskTwentyFive;
            long resultTwentySix = n & maskTwentySix;

            resultThirdBit >>= 3;
            resultFourthBit >>= 4;
            resultFifthBit >>= 5;
            resultTwentyFour >>= 24;
            resultTwentyFive >>= 25;
            resultTwentySix >>= 26;

            bool nUsed = false;
            
                if ((resultThirdBit != resultTwentyFour) && (resultThirdBit == 0))
                {
                    // resultThirdBit is 0 and resultTwentyFour is 1
                    maskThirdBit = ~maskTwentyFour; // maskTwentyFour = 1 << 24;
                    result = n & maskThirdBit; // makes 24th Bit = 0
                    maskTwentyFour = 1 << 3;
                    result = result | maskTwentyFour; // makes 3rd Bit 1
                    nUsed = true;
                }

                else if ((resultThirdBit != resultTwentyFour) && (resultThirdBit == 1))
                {
                    // resultThirdBit is 1 and resultTwentyFour is 0
                    maskThirdBit = maskTwentyFour;
                    result = n | maskThirdBit; // makes 24th Bit 1
                    maskTwentyFour = ~(1 << 3);
                    result = result & maskTwentyFour; // makes 3rd Bit 0
                    nUsed = true;
                }

                 if ((resultFourthBit != resultTwentyFive) && (resultFourthBit == 0))
                {
                    if (nUsed)
                    {
                        maskFourthBit = ~maskTwentyFive;
                        result = result & maskFourthBit;
                        maskTwentyFive = 1 << 4;
                        result = result | maskTwentyFive;
                    }
                    else
                    {
                        maskFourthBit = ~maskTwentyFive;
                        result = n & maskFourthBit;
                        maskTwentyFive = 1 << 4;
                        result = result | maskTwentyFive;
                        nUsed = true;

                    }
               
                }

                else if ((resultFourthBit != resultTwentyFive) && (resultFourthBit == 1))
                {
                    if (nUsed)
                    {
                        maskFourthBit = maskTwentyFive;
                        result = result | maskFourthBit;
                        maskTwentyFive = ~(1 << 4);
                        result = result & maskTwentyFive;
                    }
                    else
                    {
                        maskFourthBit = maskTwentyFive;
                        result = n | maskFourthBit;
                        maskTwentyFive = ~(1 << 4);
                        result = result & maskTwentyFive;
                        nUsed = true;
                    }

                }
                
                if ((resultFifthBit != resultTwentySix) && (resultFifthBit == 0))
                {
                    if (nUsed)
                    {
                        maskFifthBit = ~maskTwentySix;
                        result = result & maskFifthBit;
                        maskTwentySix = 1 << 5;
                        result = result | maskTwentySix;
                    }
                    else
                    {
                        maskFifthBit = ~maskTwentySix;
                        result = n & maskFifthBit;
                        maskTwentySix = 1 << 5;
                        result = result | maskTwentySix;
                        nUsed = true;

                    }

                }

                else if ((resultFifthBit != resultTwentySix) && (resultFifthBit == 1))
                {
                    if (nUsed)
                    {
                        maskFifthBit = maskTwentySix;
                        result = result | maskFifthBit;
                        maskTwentySix = ~(1 << 5);
                        result = result & maskTwentySix;

                    }
                    else
                    {
                        maskFifthBit = maskTwentySix;
                        result = n | maskFifthBit;
                        maskTwentySix = ~(1 << 5);
                        result = result & maskTwentySix;
                    }
                    
                }
                
            Console.WriteLine(result); 
        }
    }
}
