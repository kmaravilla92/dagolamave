using System;

namespace DAGOLAMAVE.Models
{
    public class Rider
    {
        public string? RiderName;

        public Order? CurrentOrder;

        public List<Order>? DeliveredOrders = new();

        public int NumberofDeliveriesMadeToday;

        public double TotalDeliveryFeesCollectedToday;

        public void DeliverOrder(Order order)
        {
            Customer customer = order.OrderOwner;

            Console.WriteLine("------------");
            Console.WriteLine("Rider Delivering Order!");
            Console.WriteLine($"Rider Name: {RiderName}");
            Console.WriteLine($"Customer Name: {customer.Name}");
            Console.WriteLine("------------");

            // Step 7
            customer.ReceivedOrder(order);
        }
    }
}


         