
namespace Problem12NullValuesArithmetic
{
    using System;
    class Program
    {
        static void Main()
        {
            int? nullInteger = null;
            double? nullDouble = null;

            Console.WriteLine("{0}\n{1}", nullInteger, nullDouble);

            nullInteger = null + 3;
            nullDouble = null + 0.35;
            
            Console.WriteLine("{0}\n{1}", nullInteger, nullDouble);
        }
    }
}
