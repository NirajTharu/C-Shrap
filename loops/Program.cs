// See https://aka.ms/new-console-template for more information





using System;

namespace loops
{
  class Program
  {
    static void Main(string[] args)
    {
            //  for loops 
            Console.WriteLine("The even number are;");
            for (int i = 2; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            // while loop 
            Console.WriteLine("The odd numbers from 1 to 100 are;");
            {
                int y =0;
                while (y <= 100)
                {
                    if (y % 2 != 0)
                    {
                        Console.WriteLine(y);
                    }
                    y++;
                }
            }

    }
  }
}