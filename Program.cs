// See https://aka.ms/new-console-template for more information

using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      //C sharp variables Example
      string name = "Niraj";
      int age = 22;
      /* C sharp multiple line comment 
      with the concatenation example
      */
      Console.WriteLine("Warm Welcome everyone my name is " + name + " and my age is " + age);
      Console.WriteLine("Enter your name:");
      name = Console.ReadLine();
      Console.WriteLine("Enter your age:");
      age = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Your name is "+name+" and age is "+age);
    }
  }
}