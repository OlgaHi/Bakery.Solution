using System;

namespace Bakery.Models 
{
  public class Program 
  {
    public static void Main() 
    {
      Console.WriteLine("Welcome to Pierre's Bakery. We have very tasty bread and pastries. Please what type of our products would you like to choose? ['bread', 'pastry', 'both']");
      string answer = Console.ReadLine().ToLower();
      if (answer == "bread") {
        Console.WriteLine("Today we have a special offer: Buy 2, get 1 free. A single loaf costs $5");
        Console.WriteLine("Please provide how many loaf of bread would you like");
        string input = Console.ReadLine();
        int breadQuantity = int.Parse(input);
        Bread newBread = new Bread();
        Console.WriteLine("Thank you for your order! The total price of your order is " + newBread.CalculatePrice(breadQuantity) + "$.");
      }
      

    }
  }
}

