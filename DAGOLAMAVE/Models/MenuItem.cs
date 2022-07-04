using System;
using System.Threading;

namespace DAGOLAMAVE.Models
{
    public class MenuItem
    {
        public string? FoodName;

        public double IndividualPrice = 0;

        // Changed from visibility private to public
        public int TimeToMakeInMinutes = 0;

        public string? ImageName;

        public void AssembleFood()
        {
            Console.WriteLine("------------");
            Console.WriteLine("Assembling Menu Item");
            Console.WriteLine($"FoodName: {FoodName}");
            Console.WriteLine($"IndividualPrice: PHP {IndividualPrice}");
            Console.WriteLine($"TimeToMakeInMinutes: {TimeToMakeInMinutes}");
            Console.WriteLine("------------");

            // Uncomment the code below to apply
            // real world waiting time in minutes when building a menu item.

            // Thread.Sleep(TimeToMakeInMinutes * 60 * 1000); // Step 4.b
        }
    }
}