using System;
using System.Globalization;
using System.Collections.Generic;


namespace MetodosPublicos
{
   public class Program
    {
        static void Main(string[] args)

        {
            EntradaDeDados();

            Console.ReadKey();
        }
       

            /// <summary>
            /// Metodo para iniciar programa
            /// </summary>
            public static void EntradaDeDados()
        {

            Console.WriteLine("Sistema conversor de moedas");
            Console.WriteLine("Informe um valor a ser convertido");
            double entradaValor = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe uma moeda para conversão:");
            Console.WriteLine("DOLAR, EURO, IENE, BTC");
            string entradaMoeda = Console.ReadLine().ToUpper();

            List<string> moedas = new List<string>() { "DOLAR", "EURO", "IENE", "BTC" };

            foreach (var item in moedas)
            {
                if (entradaMoeda == item)
                {
                    Console.Write($"Valor da moeda Convertida em {entradaMoeda}: ");
                    ConverterMoeda(entradaValor, entradaMoeda);
                }
            }
            Console.WriteLine("Digite um valor válido");
        }

        /// <summary> 
        /// metodo converte moeda em real para um alvo especifico para converter digite os alvos
        /// euro
        /// yen
        /// btc
        /// dolar
        /// </summary>
        /// <param name="minhaMoeda">moeda em valor real</param>
        /// <param name="moedaAlvo">alvo em que a moeda sera convertida</param>
        /// 
        public static void ConverterMoeda(double minhaMoeda, string moedaAlvo)
        {
            switch (moedaAlvo)
            {

                case "DOLAR":
                    Console.WriteLine(FormataNumeroDecimalEmDolar(minhaMoeda));
                    break;
                case "EURO":
                    Console.WriteLine(FormataNumeroDecimalEuro(minhaMoeda));
                    break;
                case "IENE":
                    Console.WriteLine(FormataNumeroDecimalEmJapao(minhaMoeda));
                    break;
                case "BTC":
                    Console.WriteLine(FormataNumeroDecimalBitCoin(minhaMoeda));
                    break;
                default:
                    Console.WriteLine("Nenhuma opção válida informada");
                    break;
            }

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

