using System;
using System.Windows;

namespace BakeryStock.Models
{
  public class BakeryItem
  {
    public int Price { get; protected set; } = 2;
    public int Quantity { get; set; }

    public int CalculateTotal()
    {
      int initialAmount = PriceBeforeDiscount();
      int eligibleDiscount = (int)Math.Floor( (decimal)Quantity / Discount() );
      int totalCost = initialAmount - (eligibleDiscount * Price);
      return totalCost;
    }

    protected virtual int Discount()
    {
      return 1;
    }

    public int PriceBeforeDiscount()
    {
      return Quantity * Price;
    }

    public DateTime Timestamp()
    {
      DateTime currentTimestamp = DateTime.Now;
      return currentTimestamp;
    }

    public int ReferenceNumber()
    {
      Random randomReference = new Random();
      return randomReference.Next();
    }
  }
}