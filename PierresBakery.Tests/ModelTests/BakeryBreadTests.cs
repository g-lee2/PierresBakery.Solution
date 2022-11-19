using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryBread.Models;

namespace BakeryBread.Models.Tests 
{
  [TestClass]
  public class Bread
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfItem_Bread() 
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
  }
}