using System;

namespace BakeryStock.Models
{
  public class BakeryItem
  {
    public int Price { get; protected set; } = 2;
    public int Quantity { get; set; }

    public int CalculateTotal()
    {
      int initialAmount = Quantity * Price;
      int eligibleDiscount = (int)Math.Floor( (decimal)Quantity / Discount() );
      int totalCost = initialAmount - (eligibleDiscount * Price);
      return totalCost;
    }

    protected virtual int Discount()
    {
      return 1;
    }
  }
}