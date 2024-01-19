using System;
using BakeryStock.Models;
using PierresBakery.UserInterfaceModels;

namespace BakeryUI
{
  class Program
  {
    static void Main()
    {
      Bread breadPriceCheck = new Bread(0);
      Pastry pastryPriceCheck = new Pastry(0);
      Console.WriteLine(WelcomeBanner.Welcome);
      Console.WriteLine(Prices.PricesBanner);
      Console.WriteLine("--------------------------------------------------------------");
      Console.WriteLine("\t\tCurrent Bread Price/Loaf: ${0}", breadPriceCheck.Price);
      Console.WriteLine("\t\tDiscount: Buy 2, get 1 FREE");
      Console.WriteLine();
      Console.WriteLine("\t\tCurrent Pastry Price/Pastry: ${0}", pastryPriceCheck.Price);
      Console.WriteLine("\t\tDiscount: Buy 3, get 1 FREE");
      Console.WriteLine("--------------------------------------------------------------");
      Console.WriteLine("Ready to buy some? Enter the amount of each you want");
      Console.WriteLine("Enter amount of Loaves of Bread:");
      Bread newBreadOrder = new Bread(int.Parse(Console.ReadLine()));
      Console.WriteLine("Enter amount of Pastries:");
      Pastry newPastryOrder = new Pastry(int.Parse(Console.ReadLine()));
      Console.WriteLine(GoodbyeBanner.Receipt);
      Console.WriteLine("\tPierre's Bakery");
      Console.WriteLine("\t{0} loaves of bread: ${1}", newBreadOrder.Quantity, newBreadOrder.CalculateTotal());
      Console.WriteLine("\t{1} pastries: ${1}", newPastryOrder.Quantity, newPastryOrder.CalculateTotal());
      Console.WriteLine("\tTotal Due: ${0}", (newBreadOrder.CalculateTotal() + newPastryOrder.CalculateTotal()));
      Console.WriteLine(GoodbyeBanner.Goodbye);
    }
  }
}