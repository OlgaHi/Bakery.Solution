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
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadConstructor_CreatesPropertyOfBread_Int()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(newBread.Price, 5);
    }

    [TestMethod]
    public void CalculatePrice_MultiplesQuantityByFive_Int()
    {
      int quantityBread = 1;
      Bread newBread = new Bread(5);
      Assert.AreEqual(newBread.CalculatePrice(quantityBread), 5);
    }
  }
}