namespace Problem9PlayWithIntDoubleAndString
{
    using System;
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Please choose a type:\n 1 --> int\n 2 --> double\n 3 --> string");
            byte type = byte.Parse(Console.ReadLine());
                        
            switch (type)
            {
                case 1: Console.Write("Please enter an integer: ");
                    int integer = int.Parse(Console.ReadLine());
                    integer++;
                    Console.WriteLine(integer);
                    break;
                case 2: Console.Write("Please enter an a double: ");
                    double realNumber = double.Parse(Console.ReadLine());
                    realNumber++;
                    Console.WriteLine(realNumber);
                    break;
                case 3: Console.Write("Please enter a string: ");
                    string text = Console.ReadLine();
                    Console.WriteLine(text + "*");
                    break;
                default: Console.WriteLine("Please enter a valid value!");
                    break;
                        
            }


        }
    }
}
