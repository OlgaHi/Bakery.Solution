using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.Tests 
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void PastryConstructor_CreatesPropertyOfPastry_Int()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(newPastry.Quantity, 1);
    }

    [TestMethod]
    public void CalculatePrice_GetPastryPrice_Int()
    {
      int pastryQuantity = 1;
      Pastry newPastry = new Pastry(pastryQuantity);
      Assert.AreEqual(newPastry.CalculatePrice(), 2);
    }


  }
}