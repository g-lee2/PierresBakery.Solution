using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryPastry.Models;

namespace BakeryPastry.Tests 
{
  [TestClass]
  public class Pastry
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfItem_Pastry() 
    {
      Pastry newPastry = new Pastry(9);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void SetAmountOfPastry_SetAmountOfPastry_Int()
    {
      int amountOfPastry = 6;
      Pastry newPastry = new Pastry(amountOfPastry);

      int updatedAmount = 3;
      newPastry.AmountOfPastry = updatedAmount;
      int result = newPastry.AmountOfPastry;

      Assert.AreEqual(updatedAmount, result);
    }
  }
}
