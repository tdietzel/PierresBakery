using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryStock.Models;

namespace BakeryStock.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newOrder = new Pastry();
      Assert.AreEqual(typeof(Pastry), newOrder.GetType());
    }
    [TestMethod]
    public void GetPriceNum_ReturnsPriceNum_Int()
    {
      Pastry newOrder = new Pastry();
      int price = newOrder.Price;
      Assert.AreEqual(2, price);
    }
    [TestMethod]
    public void GetQuantityNum_ReturnsQuantityNum_Int()
    {
      Pastry newOrder = new Pastry();
      int quantity = newOrder.Quantity;
      Assert.AreEqual(0, quantity);
    }
  }
}