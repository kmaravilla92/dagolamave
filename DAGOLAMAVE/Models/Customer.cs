using System;

namespace DAGOLAMAVE.Models
{
    public class Customer
    {
        public Address? CustomerAddress;

        public string? Name;

        public string? PhoneNumber;

        public void ReceivedOrder(Order order)
        {
            Rider rider = order.OrderRider;

            Console.WriteLine("------------");
            Console.WriteLine("Order Received! Thank you!");

            rider.DeliveredOrders.Add(order);

            // Step 7.a
            rider.NumberofDeliveriesMadeToday += 1;

            // Step 7.b
            rider.TotalDeliveryFeesCollectedToday += order.DeliveryFee;

            Console.WriteLine("------------");
        }

        public Order CreateOrder()
        {
            List<MenuItem> items = new List<MenuItem>();
            Order order = new(items);
            order.OrderOwner = this;

            return order;
        }

        public void SendOrderToVendor(Order order, Vendor vendor)
        {
            // Step 4
            // Can be inside of Customer@SendOrderToVendor
            vendor.ProcessOrder(order);
        }
    }
}
