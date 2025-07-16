// See https://aka.ms/new-console-template for more information



// Array in c# 
// Array declaration and initialization of type int with length 5. 
using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("The first element of the array is " + array[0]);
            Console.WriteLine("The second element of the array is " + array[1]);
            Console.WriteLine("The Third  element of the array is " + array[2]);
            Console.WriteLine("The fourth element of the array is " + array[3]);
            Console.WriteLine("The fifth element of the array is " + array[4]);
        }
    }
}