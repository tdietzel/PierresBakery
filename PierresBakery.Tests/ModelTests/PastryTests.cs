using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryStock.Models;

namespace BakeryStock.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod] // Test #1
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newOrder = new Pastry(0);

      Assert.AreEqual(typeof(Pastry), newOrder.GetType());
    }

    [TestMethod] // Test #2
    public void GetPriceNum_ReturnsPriceNum_Int()
    {
      Pastry newOrder = new Pastry(0);
      int price = newOrder.Price;

      Assert.AreEqual(2, price);
    }

    [TestMethod] // Test #3
    public void GetQuantityNum_ReturnsQuantityNum_Int()
    {
      Pastry newOrder = new Pastry(0);
      int quantity = newOrder.Quantity;

      Assert.AreEqual(0, quantity);
    }

    [TestMethod] // Test #4
    public void SetQuantityNum_SetsQuantityNum_Int()
    {
      int orderAmount = 7;
      Pastry newOrder = new Pastry(orderAmount);

      Assert.AreEqual(orderAmount, newOrder.Quantity);
    }

    [TestMethod] // Test #5
    public void GetsInitialAmount_ReturnsInitialAmount_Int()
    {
      Pastry newOrder = new Pastry(5);
      int total = newOrder.Price * newOrder.Quantity;

      Assert.AreEqual(10, total);
    }

    [TestMethod] // Test #6
    public void GetsTotalCost_ReturnsTotalCost_Int()
    {
      int orderAmount = 8;
      Pastry newOrder = new Pastry(orderAmount);
      int total = newOrder.CalculateTotal();

      Assert.AreEqual(12, total);
    }
  }
}