using System;
namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[3,3];
            int i, j;
            Console.WriteLine("Enter the elements of 3*3 matrix:");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write($"Elements[{i},{j}]:");
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Display the matrix
            Console.WriteLine("\nThe matrix is:\n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", arr1[i, j]);
                }
                Console.WriteLine();            }
            Console.WriteLine("\n\n");
        }
    }
}