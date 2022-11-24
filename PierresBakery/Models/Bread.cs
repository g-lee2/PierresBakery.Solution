using System;

namespace Bakery.Models
{
  public class Bread
  {

    public double BreadAmount { get; }

    public Bread(double breadAmount)
    {
      BreadAmount = breadAmount;
    }

    public double TotalBreadCost()
    {
      if (BreadAmount >= 3)
      {
        double totalBreadCost = BreadAmount - Math.Floor(BreadAmount / 3);
        double finalPrice = totalBreadCost * 5;
        return finalPrice;
      }
      else if (BreadAmount == 1)
      {
        return 5;
      }
      else 
      {
        return 10;
      }
    }
  }
}
