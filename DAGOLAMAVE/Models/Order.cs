using System;
using System.Collections.Generic;

namespace DAGOLAMAVE.Models
{
    public class Order
    {
        public List<MenuItem>? Items = new();

        public double TotalCost = 0;

        public double DeliveryFee = 0;

        public DateTime TimeOrdered;

        public Customer? OrderOwner;

        public Rider? OrderRider;

        public int EstimatedNumberOfMinutesBeforeArrival = 0;

        public Order(List<MenuItem> items)
        {
            Items = items;
            TimeOrdered = DateTime.Now;

            Random random = new();
            DeliveryFee = random.Next(39, 60);
        }

        public double GetTotalCost()
        {
            TotalCost = 0;
            foreach (MenuItem Item in Items)
            {
                TotalCost += Item.IndividualPrice;
            }

            return TotalCost;
        }
    }
}
