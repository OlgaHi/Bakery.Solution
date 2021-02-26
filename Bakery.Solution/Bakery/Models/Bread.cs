using System;

namespace Bakery.Models 
{
  public class Bread 
  {
   public int Price { get; set; }

   public Bread(int price)
    {
      Price = price;
    }
    public int CalculatePrice(int quantity)
    {
      return (Price = quantity * 5);
    }

  }
}