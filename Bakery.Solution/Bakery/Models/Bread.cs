using System;
using System.Collections.Generic;

namespace Bakery.Models 
{
  public class Bread 
  {
   public int Quantity { get; }

   public Bread(int quantity)
    {
      Quantity = quantity;
    }

  }
}