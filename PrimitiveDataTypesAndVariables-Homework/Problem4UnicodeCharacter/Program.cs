

namespace Problem4UnicodeCharacter
{
    using System;
    class Program
    {
        static void Main()
        {
            char variable = Convert.ToChar("\u002A");
            Console.WriteLine(variable);
        }
    }
}
