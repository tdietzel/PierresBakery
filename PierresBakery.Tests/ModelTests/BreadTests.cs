using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryStock.Models;

namespace BakeryStock.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newOrder = new Bread(0);
      Assert.AreEqual(typeof(Bread), newOrder.GetType());
    }
    [TestMethod]
    public void GetPriceNum_ReturnsPriceNum_Int()
    {
      Bread newOrder = new Bread(0);
      int price = newOrder.Price;
      Assert.AreEqual(5, price);
    }
    [TestMethod]
    public void GetQuantityNum_ReturnsQuantityNum_Int()
    {
      Bread newOrder = new Bread(0);
      int quantity = newOrder.Quantity;
      Assert.AreEqual(0, quantity);
    }
    [TestMethod]
    public void SetQuantityNum_SetsQuantityNum_Int()
    {
      int orderAmount = 7;
      Bread newOrder = new Bread(orderAmount);
      Assert.AreEqual(orderAmount, newOrder.Quantity);
    }
  }
}