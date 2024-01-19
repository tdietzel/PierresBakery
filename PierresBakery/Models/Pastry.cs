using System;

namespace BakeryStock.Models
{
  public class Pastry
  {
    public int Price { get; } = 2;
    public int Quantity { get; set;}

    public Pastry(int numOfPastries)
    {
      Quantity = numOfPastries;
    }

    public int CalculateTotal()
    {
      int initialAmount = Quantity * Price;
      int eligibleDiscount = (int)Math.Floor((decimal)Quantity / 4);
      int totalCost = initialAmount - (eligibleDiscount * Price);
      return totalCost;
    }
  }
}