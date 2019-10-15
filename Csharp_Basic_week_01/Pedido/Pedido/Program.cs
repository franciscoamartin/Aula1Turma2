using System;
using Pedido.Entities;
using Pedido.Entities.Enums;
using System.Globalization;


namespace Pedido
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter client data: ");
            Console.WriteLine("Name: ");
            string clientName = Console.ReadLine();
            Console.WriteLine("email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.WriteLine("Status: ");
            Enum.TryParse<OrderStatus>(Console.ReadLine(), out OrderStatus status);
            Cliente client = new Cliente(clientName, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine("How Many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i ++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.WriteLine("Product Name: ");
                string productName = Console.ReadLine();
                Console.WriteLine("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto produto = new Produto(productName, productPrice);

                Console.WriteLine("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItems orderItem = new OrderItems(quantity,productPrice, produto);

                order.AddProduct(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
            Console.ReadKey();


        }
    }
}
