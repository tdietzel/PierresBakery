using System;

namespace BakeryStock.Models
{
  public class Pastry : BakeryItem
  {
    public Pastry(int numOfDonuts, int numOfCinnamonRolls, int numOfCroissants)
    {
      Quantity = numOfDonuts + numOfCinnamonRolls + numOfCroissants;
      Price = 2;
    }

    protected override int Discount()
    {
      return 4;
    }
  }
}