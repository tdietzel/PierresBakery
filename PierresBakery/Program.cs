using System;
using BakeryStock.Models;

namespace BakeryUI
{
  class Program
  {
    static void Main()
    {
      Bread breadPriceCheck = new Bread(0);
      Pastry pastryPriceCheck = new Pastry(0);
      Console.WriteLine("Welcome to the Bakery!");
      Console.WriteLine("Our current prices & discounts are listed below:");
      Console.WriteLine("Bread Price: {0}", breadPriceCheck.Price);
      Console.WriteLine("Discount: Buy 2, get 1 free");
      Console.WriteLine("Pastry Price: {0}", pastryPriceCheck.Price);
      Console.WriteLine("Discount: Buy 3, get 1 free");
      Console.WriteLine("-------------------------------------------------");
      Console.WriteLine("Ready to buy some? Enter the amount of each you want");
      Console.WriteLine("Enter amount of Loaves of Bread:");
      Bread newBreadOrder = new Bread(int.Parse(Console.ReadLine()));
      Console.WriteLine("Enter amount of Pastries:");
      Pastry newPastryOrder = new Pastry(int.Parse(Console.ReadLine()));

      Console.WriteLine("For {0} loaves of bread and {1} pastries your total is...", newBreadOrder.Quantity, newPastryOrder.Quantity);
      Console.WriteLine((newBreadOrder.CalculateTotal() + newPastryOrder.CalculateTotal()));
    }
  }
}