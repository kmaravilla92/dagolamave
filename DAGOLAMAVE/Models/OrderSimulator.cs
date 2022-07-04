namespace DAGOLAMAVE.Models
{
    public class OrderSimulator
    {
        // public static List<Order>? Orders = new();

        public static Order? CurrentOrder;

        public static Customer? Customer;

        public static Vendor? Vendor;

        public static Rider? Rider;

        public static Order Order(
            Customer customer,
            List<MenuItem> menuItems
        )
        {
            // Step 1
            OrderSimulator.Customer = customer;

            // Step 2
            Order order = customer.CreateOrder();

            // Add menu items to order
            order.Items = menuItems;

            // Step 3
            Vendor vendor = NewVendor();
            OrderSimulator.Vendor = vendor;

            Rider rider = new()
            {
                RiderName = "Benito Dela Cruz"
            };
            OrderSimulator.Rider = rider;

            customer.SendOrderToVendor(order, vendor);

            // Step 5
            vendor.AssignRiderToOrder(rider);

            // Step 6
            rider.DeliverOrder(order);

            // OrderSimulator.Orders.Add(order);
            OrderSimulator.CurrentOrder = order;

            return order;
        }

        public static Customer NewCustomer1()
        {
            Address customerAddress = new()
            {
                City = "Makati City",
                PostalCode = "1214",
                Street = "south Cembo Palacio",
                Building = "1",
                FloorNumber = 5
            };

            // Step 1
            Customer customer = new()
            {
                CustomerAddress = customerAddress,
                Name = "Gian Marco Te",
                PhoneNumber = "09223456789"
            };

            return customer;
        }

        public static Customer NewCustomer2()
        {
            Address customerAddress = new()
            {
                City = "Quezon City",
                PostalCode = "2200",
                Street = "#44B Road 5",
                Building = "N/A",
                FloorNumber = 2
            };

            // Step 1
            Customer customer = new()
            {
                CustomerAddress = customerAddress,
                Name = "Bambini Ambing",
                PhoneNumber = "12345678901"
            };

            return customer;
        }

        public static Vendor NewVendor()
        {
            Address vendorAddress = new()
            {
                City = "Makati City",
                PostalCode = "1223",
                Street = "San Lorenzo Street",
                Building = "2",
                FloorNumber = 2
            };

            Vendor vendor = new()
            {
                VendorName = "DAGOLAMAVE Coffee Shop",
                Is24Hours = true,
                VendorAddress = vendorAddress,
                IsOpen = true
            };

            return vendor;
        }

        public static List<MenuItem> NewMenuItemsSet1()
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            menuItems.Add(
                new MenuItem
                {
                    FoodName = "Cinnamon Sugar Donut",
                    IndividualPrice = 45.00,
                    TimeToMakeInMinutes = 5,
                    ImageName = "donut.jpg"
                }
            );

            menuItems.Add(
                new MenuItem
                {
                    FoodName = "Mocha Frappuccino",
                    IndividualPrice = 120.00,
                    TimeToMakeInMinutes = 5,
                    ImageName = "frappe.jpg"
                }
            );

            menuItems.Add(
                new MenuItem
                {
                    FoodName = "Hot Vanilla Latte",
                    IndividualPrice = 60.25,
                    TimeToMakeInMinutes = 2,
                    ImageName = "kopi.jpg"
                }
            );

            return menuItems;
        }

        public static List<MenuItem> NewMenuItemsSet2()
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            menuItems.Add(
                new MenuItem
                {
                    FoodName = "Frappe",
                    IndividualPrice = 120.00,
                    TimeToMakeInMinutes = 5,
                    ImageName = "frappe.jpg"
                }
            );

            menuItems.Add(
                new MenuItem
                {
                    FoodName = "Crispy Donut",
                    IndividualPrice = 15,
                    TimeToMakeInMinutes = 2,
                    ImageName = "donut.jpg"
                }
            );

            return menuItems;
        }
    }
}
