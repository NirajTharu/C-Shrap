// See https://aka.ms/new-console-template for more information
using System;
namespace Jagged
{
    
    class Program
    {       static void Main(string[] args)
        {
            //Jagged Array example: It is array of the 3 rows and undefined columns
            int[][] j_array = new int[3][];
            j_array[0] = new int[5] { 1, 2, 3, 4, 5 };
            j_array[1] = new int[3] { 11, 12, 13 };
            j_array[2] = new int[] { 111, 222, 333 };


            // The element of first row
            Console.WriteLine("This one is the first row");
            Console.WriteLine("The first element of the row is " + j_array[0][0]);
            Console.WriteLine("The Second element of the row is " + j_array[0][1]);
            Console.WriteLine("The third element of the row is " + j_array[0][2]);
            Console.WriteLine("The fourth element of the row is " + j_array[0][3]);
            Console.WriteLine("The fifth element of the row is " + j_array[0][4]);

            Console.WriteLine("This is the second row:");
            Console.WriteLine("The first element of the row is " + j_array[1][0]);
            Console.WriteLine("The Second element of the row is " + j_array[1][1]);
            Console.WriteLine("The third element of the row is " + j_array[1][2]);

            Console.WriteLine("This is the 3rd row:");
            Console.WriteLine("The first element of the row is " + j_array[2][0]);
            Console.WriteLine("The Second element of the row is " + j_array[2][1]);
            Console.WriteLine("The third element of the row is " + j_array[3][2]);
        }
    }
    
}
