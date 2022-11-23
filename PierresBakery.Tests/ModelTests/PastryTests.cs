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
  }
}