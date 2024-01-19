using System;

namespace BakeryStock.Models
{
  public class Bread : BakeryItem
  {
    public Bread(int numOfLoaves)
    {
      Quantity = numOfLoaves;
      Price = 5;
    }

    protected override int Discount()
    {
      return 3;
    }
  }
}