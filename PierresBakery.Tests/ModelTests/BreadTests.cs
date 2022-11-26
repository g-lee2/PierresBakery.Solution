using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(3);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadAmount_ReturnsBreadAmount_Double()
    {
      double breadAmount = 3;
      Bread newBread = new Bread(breadAmount);
      double result = newBread.BreadAmount;
      Assert.AreEqual(breadAmount, result);
    }

    [TestMethod]
    public void TotalBreadCost_ReturnsTotalBreadCost_Double()
    {
      double breadAmount = 3;
      Bread newBread = new Bread(breadAmount);
      double result = newBread.TotalBreadCost();
      Assert.AreEqual(result, 10);
    }

    [TestMethod]
    public void TotalBreadCost_ReturnsTotalBreadCostTwo_Double()
    {
      double breadAmount = 4;
      Bread newBread = new Bread(breadAmount);
      double result = newBread.TotalBreadCost();
      Assert.AreEqual(result, 15);
    }

    [TestMethod]
    public void TotalBreadCost_ReturnsTotalBreadCostThree_Double()
    {
      double breadAmount = 1;
      Bread newBread = new Bread(breadAmount);
      double result = newBread.TotalBreadCost();
      Assert.AreEqual(result, 5);
    }

    [TestMethod]
    public void TotalBreadCost_ReturnsTotalBreadCostFour_Double()
    {
      double breadAmount = 2;
      Bread newBread = new Bread(breadAmount);
      double result = newBread.TotalBreadCost();
      Assert.AreEqual(result, 10);
    }
  }
}
