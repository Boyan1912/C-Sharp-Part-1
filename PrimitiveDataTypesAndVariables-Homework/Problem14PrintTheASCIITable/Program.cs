
namespace Problem14PrintTheASCIITable
{
    using System;
    using System.Text;
    class Problem14PrintTheASCIITable
    {
        static void Main()
        {
            char symbol = (char) 0;

            for (int i = 0; i <= 255; i++)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.Write(symbol);
                symbol++;
            }
        }
    }
}
