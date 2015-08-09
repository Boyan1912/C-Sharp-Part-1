namespace Problem3CheckForAPlayCard
{
    using System;
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a card sign: ");
            string playCard = Console.ReadLine();

            switch (playCard)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "Q":
                case "K":
                case "A":
                    Console.WriteLine("Valid card sign?: yes"); break;
                default: 
                    Console.WriteLine("Valid card sign?: no"); break;
            }
        }
    }
}
