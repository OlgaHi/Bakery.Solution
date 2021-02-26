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
      Bread newBread = new Bread(1);
      Assert.AreEqual(newBread.Quantity, 1);
    }

    [TestMethod]
    public void CalculatePrice_MultiplesQuantityByFive_Int()
    {
      
      Bread newBread = new Bread(1);
      Assert.AreEqual(newBread.CalculatePrice(), 5);
    }

    [TestMethod]
    public void CalculatePrice_GetOfferPrice_Int()
    {
      
      Bread newBread = new Bread(3);
      Assert.AreEqual(newBread.CalculatePrice(), 10);
    }
  }
}