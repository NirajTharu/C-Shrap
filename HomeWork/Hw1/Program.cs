// See https://aka.ms/new-console-template for more information
using System;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input;
            int n;
            Console.WriteLine("Enter what do you want even or odd");
            Input = Console.ReadLine();
            Console.WriteLine("Enter the number up_to which you want to print the odd or even");
            n = Convert.ToInt32(Console.ReadLine());           
            if (Input == "even")
            {
                for (int i = 0; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
            else if (Input == "odd")
            {
                for (int i = 0; i <= n; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("The input is invalid! please even or odd according to your need");
            }
        }
    }
}
