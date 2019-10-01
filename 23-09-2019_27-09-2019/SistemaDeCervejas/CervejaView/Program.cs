using System;
using ListagemDeCervejas.Model;
using ListagemDeCervejas.Controller;
using System.Threading;

namespace CervejaView
{
    class Program
    {
        static CervejaController controllerCerveja = new CervejaController();

        static void Main(string[] args)
        {
            controllerCerveja.GetCervejas().ForEach(x => Console.WriteLine($"ID: {x.Id} NOME: {x.Nome}"));

            Console.WriteLine(controllerCerveja.ListaSomaValor());
            Console.WriteLine(controllerCerveja.ListaSomaLitros());

            Console.WriteLine("Cadastrar Cerveja no sistema: ");
            Console.WriteLine();
            Console.Write("Nome da Cerveja: ");

            var nomeCerveja = Console.ReadLine();
            Console.Write("Teor Alcolico: ");
            var alcoolCerveja = double.Parse(Console.ReadLine());
            Console.Write("Valor da Cerveja: ");
            var valorCerveja = double.Parse(Console.ReadLine());
            Console.Write("Litro da Cerveja: ");
            var litrosCerveja = double.Parse(Console.ReadLine());

            controllerCerveja.CadastrarCervejas(new Cerveja()
            {
                Nome = nomeCerveja,
                Alcool = alcoolCerveja,
                Valor = valorCerveja,
                Litros = litrosCerveja

            });
            Console.WriteLine("Cerveja Cadastrada com sucesso!");
            controllerCerveja.GetCervejas().ForEach(x => Console.WriteLine($"ID: {x.Id} NOME: {x.Nome}"));

            Thread.Sleep(1000);

            Console.WriteLine("-porcentagem por litro de sangue-");

            Console.WriteLine(controllerCerveja.CalcularPorcentagemSangue() + " Litros");
            //Console.WriteLine(controllerCerveja.CalcularPorcentagem() + " ");

            Console.ReadKey();
        }
    }
}
