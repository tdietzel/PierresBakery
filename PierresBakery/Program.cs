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
      Console.BackgroundColor = ConsoleColor.Cyan;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.WriteLine(WelcomeBanner.Welcome);
      Console.BackgroundColor = ConsoleColor.Red;
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine(Prices.PricesBanner);
      Console.ResetColor();
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("--------------------------------------------------------------");
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("\t\tCurrent Bread Price/Loaf: ${0}", breadPriceCheck.Price);
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("\t\tDiscount: Buy 2, get 1 FREE");
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine();
      Console.WriteLine("\t\tCurrent Pastry Price/Pastry: ${0}", pastryPriceCheck.Price);
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("\t\tDiscount: Buy 3, get 1 FREE");
      Console.ForegroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("--------------------------------------------------------------");
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("Ready to buy some? Enter the amount of each you want");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Enter amount of Loaves of Bread:");
      Console.ResetColor();
      Bread newBreadOrder = new Bread(int.Parse(Console.ReadLine()));
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Enter amount of Pastries:");
      Console.ResetColor();
      Pastry newPastryOrder = new Pastry(int.Parse(Console.ReadLine()));
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.WriteLine(GoodbyeBanner.Receipt);
      Console.WriteLine("\tPierre's Bakery");
      Console.WriteLine("\t{0} loaves of bread: ${1}", newBreadOrder.Quantity, newBreadOrder.CalculateTotal());
      Console.WriteLine("\t{1} pastries: ${1}", newPastryOrder.Quantity, newPastryOrder.CalculateTotal());
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("\tTotal Due: ${0}", (newBreadOrder.CalculateTotal() + newPastryOrder.CalculateTotal()));
      Console.ResetColor();
      Console.WriteLine(GoodbyeBanner.Goodbye);
    }
  }
}