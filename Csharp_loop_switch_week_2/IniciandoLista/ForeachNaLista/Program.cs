using System;
using System.Collections.Generic;
using System.Globalization;

namespace ForeachNaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDateTime();
            ListaString();
            ListaInteiros();
            ListaDeDecimais();
            Console.ReadKey();

        }
        /// <summary>
        /// mostra lista de datas definidas
        /// </summary>
        private static void ListaDateTime()
        {
            Console.WriteLine("------Lista de Datas---------");

            var minhaLista = new List<DateTime>();
            minhaLista.Add(new DateTime(2019, 9, 17));
            minhaLista.Add(new DateTime(2019, 9, 18));
            minhaLista.Add(new DateTime(2019, 9, 15));
            minhaLista.Add(new DateTime(2019, 9, 11));

            minhaLista.ForEach(minhaData => Console.WriteLine(minhaData.ToString("yyyy/MM/dd")));

        }
        /// <summary>
        /// mostra lista de strings definidas
        /// </summary>
        private static void ListaString()
        {
            Console.WriteLine("-------Lista de Strings------");
            var minhaLista = new List<string>();

            minhaLista.Add("XIOMI");
            minhaLista.Add("IPHONE APPLE");
            minhaLista.Add("SAMSUNG");
            minhaLista.Add("NOKIA");

            minhaLista.ForEach(i => Console.WriteLine(i)); // expressao lambda para imprimir a lista na tela com console
            foreach (var item in minhaLista) // foreach padrao para percorrer lista 
            {
                Console.WriteLine(item);
            }
        }
        /// <summary>
        /// metodo que mostra numeros inteiros
        /// </summary>
        private static void ListaInteiros()
        {
            Console.WriteLine("------Lista de Inteiros------");
            var listaNumeros = new List<int>();
            int numeros = 20;
            for (int i = 1; i <= numeros; i++)
                listaNumeros.Add(i);
            listaNumeros.ForEach(item => Console.WriteLine(item));
        }
        /// <summary>
        /// metodo que mostra meus numeros decimais
        /// </summary>
        private static void ListaDeDecimais()
        {
            Console.WriteLine("------Lista de Decimais------");
            var minhaLista = new List<double>();
            minhaLista.Add(3.75);
            minhaLista.Add(4988.888);
            minhaLista.Add(2.42254);
            minhaLista.Add(0.5);

            minhaLista.ForEach(lista => Console.WriteLine(lista.ToString("C2", CultureInfo.CurrentCulture))); // imprimir na moeda real

            minhaLista.ForEach(lista => Console.WriteLine(FormataNumeroDecimalEmDolar(lista))); // imprimir na moeda americana

            minhaLista.ForEach(lista => Console.WriteLine(FormataNumeroDecimalEmJapao(lista))); // imprimir na moeda Japao

            minhaLista.ForEach(lista => Console.WriteLine(FormataNumeroDecimalEuro(lista))); // imprimir na moeda europeia

            minhaLista.ForEach(lista => Console.WriteLine(FormataNumeroDecimalBitCoin(lista))); // imprimir na moeda bitcoin

            Console.WriteLine();

            //imprime em linha unica.
            minhaLista.ForEach(lista => Console.WriteLine(lista.ToString(
              FormataNumeroDecimalEmDolar(lista))
            + FormataNumeroDecimalEmJapao(lista)
            + FormataNumeroDecimalEuro(lista)
            + FormataNumeroDecimalBitCoin(lista)));


            //minhaLista.ForEach(lista => Console.WriteLine("R$ " + lista)); 
        }

        /// <summary>
        /// metodo que converte meu numero em valor Iene
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        private static string FormataNumeroDecimalEmJapao(double meuNumero)
        {
            meuNumero = CotacaoIene(meuNumero);
            return meuNumero.ToString("C2", CultureInfo.CreateSpecificCulture("ja-JP"));
        }
        /// <summary>
        /// metodo que converte meu numero em valor Euro
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        private static string FormataNumeroDecimalEuro(double meuNumero)
        {
            meuNumero = CotacaoEmEuro(meuNumero);
            return meuNumero.ToString("C2", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "EUR ");
        }
        /// <summary>
        /// metodo que converte meu numero em valor Bitcoin
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        private static string FormataNumeroDecimalBitCoin(double meuNumero)
        {
            meuNumero = CotacaoBTC(meuNumero);
            return meuNumero.ToString("C5", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "BTC ");
        }
        /// <summary>
        /// Metodo imprimir na versao em dolar
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        private static string FormataNumeroDecimalEmDolar(double meuNumero)
        {
            meuNumero = CotacaoDolar(meuNumero);
            return meuNumero.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }
        /// <summary>
        /// metodo cotacao de moedas em dolar
        /// </summary>
        /// <param name="dolar"></param>
        /// <returns>retorna a cotacao em dolar</returns>
        private static double CotacaoDolar(double dolar)
        {
            return dolar / 4.5;
        }
        /// <summary>
        /// metodo cotacao de moedas em iene
        /// </summary>
        /// <param name="iene"></param>
        /// <returns>retorna a cotacao em iene</returns>
        private static double CotacaoIene(double iene)
        {
            return iene / 26.44;
        }
        /// <summary>
        /// metodo cotacao de moedas em euro
        /// </summary>
        /// <param name="euro"></param>
        /// <returns>retorna a cotacao em euro</returns>
        private static double CotacaoEmEuro(double euro)
        {
            return euro / 5;
        }
        /// <summary>
        /// metodo cotacao de moedas em bitcoin
        /// </summary>
        /// <param name="bitcoin"></param>
        /// <returns>retorna a cotacao em bitcoin</returns>
        private static double CotacaoBTC(double btc)
        {
            return btc / 40000;
        }
    }
}

