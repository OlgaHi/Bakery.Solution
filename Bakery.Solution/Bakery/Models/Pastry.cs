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

  }
}