using System;
using Bakery;
using Bakery.Models;

namespace Bakery 
{
  public class Program 
  {
    public static void Main() 
    {
      Console.WriteLine("Welcome to Pierre's Bakery. We have very tasty bread and pastries. Please what type of our products would you like to choose? ['bread', 'pastry', 'both']");
      string answer = Console.ReadLine().ToLower();
      if (answer == "bread") {
        Console.WriteLine("Today we have a special offer: Buy 2, get 1 free. A single loaf costs $5");
        Console.WriteLine("Please enter how many loaves of bread would you like");
        string input = Console.ReadLine();
        int breadQuantity = int.Parse(input);
        Bread newBread = new Bread(breadQuantity);
        if (breadQuantity > 0) 
        {
          Console.WriteLine("Thank you for your order! The total price of your order is " + newBread.CalculatePrice() + "$.");
        } 
        else 
        {
          Console.WriteLine("Please enter a quantity of more than 0!");
          Main();
        }
        
      }
      else if (answer == "pastry")
      {
        Console.WriteLine("Today we have a special offer: Buy 3 for $5. A single pastry costs $2");
        Console.WriteLine("Please enter how many pastries would you like");
        string input = Console.ReadLine();
        int pastryQuantity = int.Parse(input);
        Pastry newPastry = new Pastry(pastryQuantity);
        if (pastryQuantity > 0 && pastryQuantity < 3)
          {
            Console.WriteLine("Thank you for your order! The total price of your order is " + newPastry.CalculatePrice() + "$.");
          }
          else if (pastryQuantity > 3)
          {
            Console.WriteLine("Thank you for your order! The total price of your order is " + newPastry.CalculateOfferPrice() + "$.");
          }
          else 
          {
            Console.WriteLine("Please enter a quantity of more than 0!");
            Main();
          }
      }
    }
  }
}
  


