using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Model;
using ListagemDeCarros.Controller;

namespace ListarCarrosDoAmigo
{
    class Program
    {
        static CarroController controller = new CarroController();
        static void Main(string[] args)//7
        {
            controller.Listar().ForEach(i => Console.WriteLine($"{i.Id} {i.Marca} {i.Modelo} {i.Portas}"));
            Console.ReadLine();
        }
    }
}
