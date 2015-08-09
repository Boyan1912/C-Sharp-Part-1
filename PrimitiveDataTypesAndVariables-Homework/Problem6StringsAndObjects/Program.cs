


namespace Problem6StringsAndObjects
{
    using System;
    class Program
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";

            object sentence = hello + " " + world;

            string result = (string) sentence;

            Console.WriteLine(result);
        }
    }
}
