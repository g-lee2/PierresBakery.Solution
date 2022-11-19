using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryPastry.Models;

namespace BakeryPastry.Models.Tests 
{
  [TestClass]
  public class Pastry
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfItem_Pastry() 
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
  }
}
