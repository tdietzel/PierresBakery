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
      Pastry pastryPriceCheck = new Pastry(0, 0, 0);
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
      Console.WriteLine("Enter amount of Donuts:");
      Console.ResetColor();
      int totalDonuts = int.Parse(Console.ReadLine());
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Enter amount of CinnamonRolls:");
      Console.ResetColor();
      int totalCinnamonRolls = int.Parse(Console.ReadLine());
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Enter amount of Croissants:");
      Console.ResetColor();
      int totalCroissants = int.Parse(Console.ReadLine());
      Pastry newPastryOrder = new Pastry(totalDonuts, totalCinnamonRolls, totalCroissants);
      Pastry donut = new Pastry(totalDonuts, 0, 0);
      Pastry cinnamonRoll = new Pastry(0, totalCinnamonRolls, 0);
      Pastry croissant = new Pastry(0, 0, totalCroissants);
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.WriteLine(GoodbyeBanner.Receipt);
      Console.WriteLine("\tPierre's Bakery");
      Console.WriteLine("\t{0}", newBreadOrder.Timestamp());
      Console.WriteLine("\tReference #: {0}", newBreadOrder.ReferenceNumber());
      Console.WriteLine("\t---------------------------");
      Console.WriteLine("\tQty |  Description  | Price");
      Console.WriteLine("\t---------------------------");
      Console.WriteLine("\t {0}\tBread\t\t${1}", newBreadOrder.Quantity, newBreadOrder.PriceBeforeDiscount());
      Console.WriteLine("\t {0}\tDonut\t\t${1}", donut.Quantity, donut.PriceBeforeDiscount());
      Console.WriteLine("\t {0}\tCinnamonRoll\t${1}", cinnamonRoll.Quantity, cinnamonRoll.PriceBeforeDiscount());
      Console.WriteLine("\t {0}\tCroissant\t${1}", croissant.Quantity, croissant.PriceBeforeDiscount());
      Console.WriteLine("\t---------------------------");
      int beforeDiscount = newBreadOrder.PriceBeforeDiscount() + newPastryOrder.PriceBeforeDiscount();
      int orderTotal = newBreadOrder.CalculateTotal() + newPastryOrder.CalculateTotal();
      int discountAmount = beforeDiscount - orderTotal;
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("\tDiscount applied: ${0}", discountAmount);
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("\tTotal Due: ${0}", orderTotal);
      Console.ResetColor();
      Console.WriteLine(GoodbyeBanner.Goodbye);
    }
  }
}