using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryBread.Models;

namespace BakeryBread.Tests 
{
  [TestClass]
  public class Bread
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfItem_Bread() 
    {
      Bread newBread = new Bread(6);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void SetAmountOfBread_SetAmountOfBread_Int()
    {
      int amountOfBread = 6;
      Bread newPastry = new Bread(amountOfBread);

      int updatedAmount = 3;
      newPastry.AmountOfBread = updatedAmount;
      int result = newPastry.AmountOfBread;

      Assert.AreEqual(updatedAmount, result);
    }
  }
}