// See https://aka.ms/new-console-template for more information

using System;

namespace Arithmetic_operators
{
  class Program
  {
    static void Main(string[] args)
    {
      int x, y, add, sub, mul, div;
      Console.WriteLine("Enter the first number:");
      x = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter the second number:");
      y = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("The number you entered are " + x + "and " + y);
      add = x + y;
      sub = x - y;
      mul = x * y;
      div = x / y;
      Console.WriteLine("The addition of two numbers is " + add);
      Console.WriteLine("The Subtraction of two numbers is " + sub);
      Console.WriteLine("The multiplication of two numbers is " + mul);
      Console.WriteLine("The division of two numbers is " + div);
      
    }
  }
}
