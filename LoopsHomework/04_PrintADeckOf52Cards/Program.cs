namespace _04_PrintADeckOf52Cards
{
    using System;
    class Program
    {
        static void Main()
        {
            // Print a Deck of 52 Cards

            

            for (int i = 2; i <= 14; i++)
            {

                for (int j = 1; j <= 4; j++)
                {
                      string card = i.ToString();
                   
                    switch (i)
                    {
                        case 11: card = "J"; break;
                        case 12: card = "Q"; break;
                        case 13: card = "K"; break;
                        case 14: card = "A"; break;
                    }
                    
                    switch (j)
                    {
                        case 1: Console.Write("{0}♠ ", card); break;
                        case 2: Console.Write("{0}♣ ", card); break;
                        case 3: Console.Write("{0}♥ ", card); break;
                        case 4: Console.Write("{0}♦ ", card); break;

                    }
                    
                }

                Console.WriteLine();
            }

        }
    }
}
