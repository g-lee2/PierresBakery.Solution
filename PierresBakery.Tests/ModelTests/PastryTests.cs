using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(3);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryAmount_ReturnsPastryAmount_Int()
    {
      int pastryAmount = 3;
      Pastry newPastry = new Pastry(pastryAmount);
      int result = newPastry.PastryAmount;
      Assert.AreEqual(pastryAmount, result);
    }

    [TestMethod]
    public void TotalPastryCost_ReturnsTotalPastryCost_Int()
    {
      int pastryAmount = 6;
      Pastry newPastry = new Pastry(pastryAmount);
      int result = newPastry.TotalPastryCost();
      Assert.AreEqual(result, 10);
    }

    [TestMethod]
    public void TotalPastryCost_ReturnsTotalPastryCostTwo_Int()
    {
      int pastryAmount = 8;
      Pastry newPastry = new Pastry(pastryAmount);
      int result = newPastry.TotalPastryCost();
      Assert.AreEqual(result, 14);
    }

    [TestMethod]
    public void TotalPastryCost_ReturnsTotalPastryCostThree_Int()
    {
      int pastryAmount = 15;
      Pastry newPastry = new Pastry(pastryAmount);
      int result = newPastry.TotalPastryCost();
      Assert.AreEqual(result, 27);
    }

    [TestMethod]
    public void TotalPastryCost_ReturnsTotalPastryCostFour_Int()
    {
      int pastryAmount = 2;
      Pastry newPastry = new Pastry(pastryAmount);
      int result = newPastry.TotalPastryCost();
      Assert.AreEqual(result, 4);
    }
  }
}