using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeitorDados.Model;
using LeitorDados.Controller;
using System.Globalization;

namespace LeituraDeDadosExterno
{
    class Program
    {
        static CarrosController carrosController = new CarrosController();
        //static RelatorioContext relatorioContext = new RelatorioContext();

        static void Main(string[] args)
        {
            Console.WriteLine("Leitor de Carros");
            MenuPrincipal();
            Console.ReadKey();
        }

        public static void MenuPrincipal()
        {
            var menuEscolhido = int.MinValue;
            //Aqui definimos se for diferente de 0 mantemos o sistema aberto se não finalizamos
            while (menuEscolhido != 0)
            {
                Console.Clear();

                //Mostra as opções de menu dentro do nosso sistema.
                Console.WriteLine("Menu sistema");
                Console.WriteLine("1 - Listar Carros");
                Console.WriteLine("2 - Filtrar por data");

                menuEscolhido = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                //Executar proxima funcao
                switch (menuEscolhido)
                {
                    case 1:
                        //Realiza a chamada do menu de listagem de carros
                        MostrarCarros();
                        break;
                    case 2:
                        //Realiza a chamada do menu de filtro por data
                        FiltrarCarrosData();
                        break;
                    default: Console.WriteLine("Escolha um valor válido. ");
                        break;
                   
                }
            }
        }

        private static void MostrarCarros()
        {
            Console.WriteLine();
            carrosController.RetornaListaDeCarros().ForEach(i =>
            //Para cada Carro da lista temos a demostração no console por esta parte
            Console.WriteLine($"Id: {i.Id}|| Carro: {i.Carro}|| Valor: {i.Valor}|| Qtd: {i.Quantidade}|| Data: {i.Data.ToShortDateString()}"));
            Console.ReadKey();
        }

        private static void FiltrarCarrosData()
        {
            Console.WriteLine("Filtrando a lista por mês");
            Console.WriteLine();
            Console.Write("Digite o mês: ");
            int entradaFiltroData = int.Parse(Console.ReadLine());

            //listando carros
            carrosController.FiltrarCarrosMes(entradaFiltroData).ForEach(i => Console.WriteLine($"id Carro: {i.Id} - Nome do Carro: {i.Carro}- Valor: {i.Valor.ToString("F2", CultureInfo.InvariantCulture)} Quantidade: {i.Quantidade}  - data: {i.Data.ToShortDateString()} - total: {i.Valor * i.Quantidade}"));
            Console.WriteLine();
            //total venda
            Console.WriteLine("Valor Total de vendas no mês: " + carrosController.FiltrarCarrosMes(entradaFiltroData).Sum(x => x.Quantidade * x.Valor).ToString("F2", CultureInfo.InvariantCulture));
            //media da venda
            Console.WriteLine();
            Console.WriteLine("Média de vendas no mês: " + carrosController.FiltrarCarrosMes(entradaFiltroData).Average(x => x.Valor * x.Quantidade).ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}















//var teste = carrosController.FiltrarCarrosMes(entradaFiltroData);
//carrosController.FiltrarCarrosMes(entradaFiltroData).ForEach(i => Console.WriteLine($" Valor: {(i.Valor) * (i.Quantidade)}"));
//carrosController.FiltrarCarrosMes(entradaFiltroData).ForEach(i => Console.WriteLine($" Média: {(i.Valor) / (i.Quantidade)}"));




//soma
//double total1 = carrosController.FiltrarCarrosMes(entradaFiltroData).Sum(item => total);

//double totalQuantidade = carrosController.FiltrarCarrosMes(entradaFiltroData).Sum(item => item.Quantidade);

//Console.WriteLine("total: " + total1.ToString("F2", CultureInfo.InvariantCulture));
//Console.WriteLine(totalQuantidade);

//Console.WriteLine("Total do mês: " + total * totalQuantidade);

//var media = valor / quantidade;


//public float PriceAllContent
//{
//    get { return _cartList.Sum(p => p.Price); }
//}


//private static void VendasDoMes(int somaTotal)
//{

//    carrosController.FiltrarCarrosMes(somaTotal).ForEach(i => Console.WriteLine($" Valor: {(i.Valor) * (i.Quantidade)}"));

//    var soma = 0;
//    somaTotal


//}

