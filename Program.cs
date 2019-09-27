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
      while (sunflower.IsAlive())
      {
        Console.WriteLine("What would you like to do? \n\tPlant Status? (enter 'status')\n\tWater? (enter 'water')\n\tFertilize? (enter 'water')\n\tSolarize? (enter 'solarize')");
        string input = Console.ReadLine();
        
        if (input.ToUpper() == "STATUS")
        {
          Console.WriteLine("-------------------------------");
          Console.WriteLine("Water: " + sunflower.GetWater()); 
          Console.WriteLine("-------------------------------");
          Console.WriteLine("Fertilizer: " + sunflower.GetFertilizer());
          Console.WriteLine("-------------------------------");
          Console.WriteLine("Sunshine: " + sunflower.GetSunshine()); 
          Console.WriteLine("-------------------------------");
          
        }
        else if (input.ToUpper() == "WATER")
        {
          sunflower.Water();
          Console.WriteLine("You watered your sunflower, but she is not yet fulfilled");
        }
        else if (input.ToUpper() == "FERTILIZE")
        {
          sunflower.Fertilizer();
          Console.WriteLine("You fertilized your sunflower, but she is not yet fulfilled");
        }
        else if (input.ToUpper() == "SOLARIZE")
        {
          sunflower.Fertilizer();
          Console.WriteLine("You solarized your sunflower, but she is not yet fulfilled");
        }
      }
      Console.WriteLine("Your sunflower has chosen to commit suicide rather than remain in your company")
    }
  }
}