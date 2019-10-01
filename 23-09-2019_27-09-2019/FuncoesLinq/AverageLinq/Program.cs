using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace AverageLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Venda> vendas = new List<Venda>()
            {
                new Venda()
                {
                    Produto = "XIAOMI Lite 6 quad core",
                    Quantidade = 8,
                    Valor = 1200.00
                },
                new Venda()
                {
                    Produto = "SLIM 3500 APP",
                    Quantidade = 5,
                    Valor = 2800.96
                },
                new Venda()
                {
                    Produto = "IPHONE",
                    Quantidade = 1,
                    Valor = 9999

                }
            };
            Console.Write("Media de produtos vendidos neste mês: ");
            Console.WriteLine(vendas.Average(x => x.Quantidade).ToString("F2", CultureInfo.InvariantCulture));
            Console.Write("Média de produtos vendidos neste mês: ");
            Console.WriteLine(vendas.Average(x => x.Quantidade * x.Valor).ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();

        }
    }
}
