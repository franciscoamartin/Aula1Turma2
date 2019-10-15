using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRelatorio.Model;
using SistemaRelatorio.Controller;

namespace InterfaceSistemaRelatorio
{
    class Program
    {
        static VendasController vendasController = new VendasController();
        static void Main(string[] args)
        {
            Console.WriteLine("Informações das vendas realizadas durante o ano de 2019");
            Console.WriteLine();
            vendasController.GetVendas().ForEach(x => ImprimirInformacoes(x));
            Console.ReadKey();

            MostraMenuRelatorio();
        }

        public static void ImprimirInformacoes(Venda vendas)
        {
            Console.WriteLine(string.Format(
                "Id {0,3} Carro {1,-20} Valor {2,-10} Quantidade {3,3} Data {4,12}",
                vendas.Id, vendas.Carro, vendas.Valor.ToString("C"), vendas.Quantidade, vendas.Data.ToShortDateString()));
        }

        private static void MostraMenuRelatorio()
        {
            Console.Clear();
            Console.WriteLine("Menu de Relatórios: ");
            Console.WriteLine("1 - Relatório por periodo mensal");
            Console.WriteLine("0 - Sair");

            var menuEscolhido = int.MinValue;

            while (menuEscolhido != 0)
            {
                var menuEscolhidos = int.Parse(Console.ReadLine());
                switch (menuEscolhidos)
                {
                    case 1:
                        {
                            Console.WriteLine("Informe o mês para realizar o filtro");
                            var mesEscolhido = int.Parse(Console.ReadLine());
                            var listaPeriodoEscolhido = vendasController.GetVendas(mesEscolhido);

                            vendasController.GetVendas(mesEscolhido).ForEach(i => ImprimirInformacoes(i)); // formatando informacoes no metodo                         Console.ReadKey();

                            var totalMes = listaPeriodoEscolhido.Sum(x => x.Valor * x.Quantidade);
                            Console.WriteLine($"Total mês {mesEscolhido.ToString()} é {totalMes.ToString("C")}");

                            var mediaPeriodo = listaPeriodoEscolhido.Average(x => x.Valor * x.Quantidade);
                            Console.WriteLine($"Média do mês {mesEscolhido} é {mediaPeriodo.ToString("C")}");
                            Console.ReadKey();
                        }
                        break;
                }
            }

        }
    }
}
