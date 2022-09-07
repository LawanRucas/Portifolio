using System.Diagnostics;

internal class NewBaseType
{
    static void Main(string[] args)
    {
   
      Console.WriteLine("quanto pesa sua mae? ");
      int peso = Convert.ToInt32(Console.ReadLine());
      if (peso > 100)
      {
          Console.WriteLine("sua mae é gorda");
      }
      else
      {
          Console.WriteLine("sua mae é magra");
      }
    }
}
