using System;
using ListagemDeCarros.Controller;

namespace ListarCarrosDoAmigo
{
    class Program
    {
        static CarroController controller = new CarroController();
        static void Main(string[] args)//7
        {
            controller.Listar().ForEach(i => Console.WriteLine($" Id: {i.Id} Marca: {i.Marca} Modelo: {i.Modelo} Porta: {i.Portas}"));
            Console.ReadLine();
        }
    }
}
