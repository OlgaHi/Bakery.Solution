using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.Tests 
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      int breadQuantity = 1;
      Bread newBread = new Bread(breadQuantity);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadConstructor_CreatesPropertyOfBread_Int()
    {
      int breadQuantity = 1;
      Bread newBread = new Bread(breadQuantity);
      Assert.AreEqual(newBread.Quantity, breadQuantity);
    }

    [TestMethod]
    public void CalculatePrice_MultiplesQuantityByFive_Int()
    {
      int breadQuantity = 1;
      Bread newBread = new Bread(breadQuantity);
      Assert.AreEqual(newBread.CalculatePrice(), 5);
    }

    [TestMethod]
    public void CalculatePrice_GetOfferPrice_Int()
    {
      int breadQuantity = 3;
      Bread newBread = new Bread(breadQuantity);
      Assert.AreEqual(newBread.CalculatePrice(), 10);
    }
  }
}