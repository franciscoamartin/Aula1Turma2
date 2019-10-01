using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pedido.Entities;
using System.Globalization;

namespace Pedido.Entities
{
    class OrderItems
    {
        public int Quantidade { get; set; }
        public double Price { get; set; }

        public Produto Produto { get; set; }

        public OrderItems()
        {
        }

        public OrderItems(int quantidade, double price, Produto product)
        {
            Quantidade = quantidade;
            Price = price;
            Produto = product;
        }

        public double SubTotal()
        {
            return Price * Quantidade;

        }

        public override string ToString()
        {
            return Produto.Name
                + ", $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantidade: "
                + Quantidade
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
                
        }
    }
}
