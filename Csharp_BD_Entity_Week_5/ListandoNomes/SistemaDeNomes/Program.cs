using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListandoNomes.Controller;
using ListandoNomes.Model;

namespace SistemaDeNomes
{
    class Program
    {
        static NomesController nomesController = new NomesController();
        static void Main(string[] args)
        {
            nomesController.Menu();

            Console.ReadKey();
        }
    }
}
