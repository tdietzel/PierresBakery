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
      return Price * Quantity;
    }
  }
}