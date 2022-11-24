namespace Bakery.Models
{
  public class Pastry
  {

    public int PastryAmount { get; }

    public Pastry(int pastryAmount)
    {
      PastryAmount = pastryAmount;
    }
    public int TotalPastryCost()
    {
      if (PastryAmount % 3 == 0)
      {
        return (PastryAmount / 3) * 5;
      }
      else if (PastryAmount % 4 == 0)
      {
        return (PastryAmount / 4) * 7;
      }
      else if (PastryAmount % 5 == 0)
      {
        return (PastryAmount / 5) * 9;
      }
      else 
      {
        return PastryAmount * 2;
      }
    }
  }
}
