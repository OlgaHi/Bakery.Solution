using System;

namespace Bakery.Models 
{
  public class Program 
  {
    public static void Main() 
    {
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("Today we have a special offer: Buy 2, get 1 free. A single loaf costs $5");
      string input = Console.ReadLine();
      int breadQuantity = int.Parse(input);
      
    }
  }
}

