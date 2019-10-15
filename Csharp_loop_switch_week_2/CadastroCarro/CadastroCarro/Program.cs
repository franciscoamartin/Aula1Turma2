using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using CadastroCarro.Model;

namespace CadastroCarro
{
    class Program

    {
        static List<Carro> carros = new List<Carro>();

        static void Main(string[] args)
        {
            Init();
            Cadastro();

            while (Continuar() == 1)
            {
                Cadastro();
            }
            Imprimir();

            Console.ReadKey();
        }

        private static void Imprimir()
        {
            carros.ForEach(i => Console.WriteLine(i.ToString()));
        }

        private static int Continuar()
        {
            Console.WriteLine("Cadastrar novos veículos? (1)SIM (2)NÃO");
            return int.Parse(Console.ReadKey().KeyChar.ToString());
        }

        private static void Init()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Sistema Cadastro de Carros");
            Console.WriteLine("--------------------------");
            Console.WriteLine();
        }

        private static void VerificacaoDadosCPF(string placaMercosul)
        {

            var r = new Regex(@"^[0-9a-zA-Z]{4}\d{6,7}$");
            if (!r.IsMatch(placaMercosul))
            {
                Console.WriteLine("é mercosul");
            }
            if (!r.IsMatch(placaMercosul))
            {
                Console.WriteLine("nao é");
            }

            //if (placaMercosul.Contains("a"))

            //    Console.WriteLine("É uma placa do Mercosul");

            //else

            //    Console.WriteLine("Não é uma placa do Mercosul");

        }
        private static void Cadastro()
        {

            Carro list = new Carro();
            Console.Write("Marca do veículo: ");
            string marca = Console.ReadLine();
            Console.Write("Modelo do veículo: ");
            string modelo = Console.ReadLine();
            Console.Write("Ano do veículo: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Valor do veículo: ");
            double valor = double.Parse(Console.ReadLine());
            Console.Write("Placa do veículo: ");
            string placa = Console.ReadLine();
           // string verificacao = VerificacaoDadosCPF(placa); 

            carros.Add(new Carro
            {

                Marca = marca,
                Modelo = modelo,
                Ano = ano,
                Valor = valor,
                Placa = placa
            });

            //carros.ForEach(i => Console.WriteLine($"Marca: {i.Marca} - Modelo: {i.Modelo} - Ano: {i.Ano} - Valor: {i.Valor} - Placa: {i.Placa}"));
        }
    }
}
