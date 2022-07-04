using System;

namespace DAGOLAMAVE.Models
{
    public class Vendor
    {
        public string? VendorName;

        public bool Is24Hours = false;

        public Address? VendorAddress;

        public bool IsOpen = false;

        public Order? CurrentOrder = null;

        public List<Order>? OrdersForTheDay = new(); // Changed visibility from private to public


        public void AssignRiderToOrder(Rider rider)
        {
            // Assign current order to rider.CurrentOrder field
            rider.CurrentOrder = CurrentOrder;

            // Assign rider to order.OrderRider field
            CurrentOrder.OrderRider = rider;

            // Increment orders for the day
            OrdersForTheDay.Add(CurrentOrder);
        }

        public void ProcessOrder(Order order)
        {
            Console.WriteLine("Order Processing...");

            CurrentOrder = order; // Assuming vendor only accepts one order at a time.

            foreach (MenuItem Item in order.Items)
            {
                Item.AssembleFood(); // Step 4.a
            }
        }

        public void SendOrderToRider(Rider order)
        {
            Console.WriteLine("Rider is on the way. Please Wait");
        }

        public bool CanReceiveOrders()
        {
            return true;
        }
        public double GetTotalSales()
        {
            double totalSales = 0;

            foreach (Order order in OrdersForTheDay)
            {
                totalSales += order.GetTotalCost();
            }

            return totalSales;
        }
    }
}
