using System;

namespace Bakery.Models 
{
  public class Pastry 
  {
   public int Price { get; set; } = 2;
   public int Quantity { get; set; }
   public Pastry(int quantity)
    {
      Quantity = quantity;
    }
    public int CalculatePrice()
    { 
      return (Price * Quantity);
    }

    public int CalculateOfferPrice()
    { 
      if (Quantity % 3 == 0) {
        return (Price = (Quantity / 3) * 5);
      }
      else
      {
        return ((Quantity / 3) * 5) + ((Quantity % 3) * Price);
      }
     }
  }
}