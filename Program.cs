using System;
using System.Collections.Generic;
using Planties;

namespace Garden
{
  public class Program
  { 
    public static void Main()
    {
      Plant sunflower = new Plant(8, 5, 9);
      Console.WriteLine("What would you like to do? (Status/Water/Fertilizer/Sunshine)");
      string input = Console.ReadLine();
      
      if (input.ToUpper() == "STATUS")
      {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Water: " + sunflower.Water); 
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Water: " + sunflower.Fertilizer);
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Sunshine: " + sunflower.Sunshine); 
        Console.WriteLine("-------------------------------");
      }
    }
  }
}