using System;

namespace Bakery.Models 
{
  public class Bread 
  {
   public int Price { get; set; } = 5;
   public int Quantity { get; set; }
   public Bread(int quantity)
    {
      Quantity = quantity;
    }
    public int CalculatePrice()
    { if (Quantity % 3 == 0 && Quantity > 0) 
        {
          return (Quantity-(Quantity / 3)) * 5;
        }
        else 
        {
          return (Price = Quantity * 5);
        }
    }
  }
}