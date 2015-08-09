using System;


class Print10MembersSequence
    {
        static void Main()
        {
            int even = 0;
            int odd = -1;

            for (int i = 1; i <= 10; i++)
            {
                
                    even += 2;
                    odd -= 2;
                    Console.WriteLine("{0}, {1}", even, odd);
       
            }
            
        }
        
    }

