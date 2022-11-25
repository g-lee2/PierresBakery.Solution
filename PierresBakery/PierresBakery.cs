using System;
using Bakery.Models;

class Program
{
  static void Main()
  {
    
    Console.WriteLine("Welcome to Pierre's Bakery!");
    Console.WriteLine("A single loaf of bread costs $5. Every 3rd loaf of bread is free!");
    Console.WriteLine("One pastry is $2. Four pastries cost $7, five pastries cost $9, and six pastries cost $10. Dicounts apply respectively if you would like more than 6 pastries.");
    Console.WriteLine("Enter the amount of bread loaves you would like.");
    string breadAmountInput = Console.ReadLine(); 
    double breadInput = double.Parse(breadAmountInput);
    Bread newBread = new Bread(breadInput);
    double finalBreadCost = newBread.TotalBreadCost();
    Console.WriteLine("Enter the amount of pastries you would like.");
    string pastryAmountInput = Console.ReadLine(); 
    int pastryInput = int.Parse(pastryAmountInput);
    Pastry newPastry = new Pastry(pastryInput);
    newPastry.TotalPastryCost();
    int finalPastryCost = newPastry.TotalPastryCost();
    double totalOrderCost = finalBreadCost + finalPastryCost;
    Console.WriteLine("Your total is $" + totalOrderCost + ".");
    Console.WriteLine("Thank you for shopping at Pierre's Bakery!");
    Console.WriteLine("Have a good day!");
  }
}