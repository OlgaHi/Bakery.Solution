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
      int pastryQuantity = 1;
      Pastry newPastry = new Pastry(pastryQuantity);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void PastryConstructor_CreatesPropertyOfPastry_Int()
    {
      int pastryQuantity = 1;
      Pastry newPastry = new Pastry(pastryQuantity);
      Assert.AreEqual(newPastry.Quantity, pastryQuantity);
    }

    [TestMethod]
    public void CalculatePrice_GetPastryPrice_Int()
    {
      int pastryQuantity = 1;
      Pastry newPastry = new Pastry(pastryQuantity);
      Assert.AreEqual(newPastry.CalculatePrice(), 2);
    }

    [TestMethod]
    public void CalculateOfferPrice_GetOfferPrice_Int()
    {
      int pastryQuantity = 3;
      Pastry newPastry = new Pastry(pastryQuantity);
      Assert.AreEqual(newPastry.CalculateOfferPrice(), 5);
    }

    [TestMethod]
    public void CalculateOfferPrice_GetOfferPriceIfRemainder_Int()
    {
      int pastryQuantity = 4;
      Pastry newPastry = new Pastry(pastryQuantity);
      Assert.AreEqual(newPastry.CalculateOfferPrice(), 7);
    }
  }
}