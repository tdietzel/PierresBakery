using System;

namespace BakeryStock.Models
{
  public class Bread
  {
    public int Price { get; } = 5;
    public int Quantity { get; set; }

    public Bread(int numOfLoaves)
    {
      Quantity = numOfLoaves;
    }

    public int CalculateTotal()
    {
      int initialAmount = Quantity * Price;
      int eligibleDiscount = (int)Math.Floor((decimal)Quantity / 3);
      int totalCost = initialAmount - (eligibleDiscount * Price);
      return totalCost;
    }
  }
}