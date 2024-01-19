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
      return Price * Quantity;
    }
  }
}