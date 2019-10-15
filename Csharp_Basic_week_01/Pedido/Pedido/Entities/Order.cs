using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pedido.Entities;
using System.Globalization;
using Pedido.Entities.Enums;

namespace Pedido.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<OrderItems> Items { get; set; } = new List<OrderItems>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Cliente cliente)
        {
            Moment = moment;
            Status = status;
            Cliente = cliente;
        }

        public void AddProduct(OrderItems item)
        {
            Items.Add(item);
        }

        public void RemoveProduct(OrderItems item)
        {
            Items.Remove(item);

        }

        public double Total()
        {
            double soma = 0.0;
            foreach (OrderItems item in Items)
            {
                soma += item.SubTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Moment: " + Moment.ToString("dd/MM/yyyy hh:MM:ss"));
            sb.AppendLine("Order Status" + Status);
            sb.AppendLine("Client: " + Cliente);
            sb.AppendLine("Order Items: ");
            foreach (OrderItems itens in Items)
            {
                sb.AppendLine(itens.ToString());
            }
            sb.AppendLine("Total Price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
                return sb.ToString();

        }
    }
}
