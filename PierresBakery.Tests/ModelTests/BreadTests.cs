using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public void GetBreadAmount_ReturnsBreadAmount_Int()
    {
      int breadAmount = 3;
      Bread newBread = new Bread(breadAmount);
      int result = newBread.BreadAmount;
      Assert.AreEqual(breadAmount, result);
    }

    [TestMethod]
    public void SetBreadAmount_SetBreadAmount_Int()
    {

    }
  }
}