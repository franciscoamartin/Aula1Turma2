using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca;

namespace AcessandoInformacao
{
     class Program
    {
        static void Main(string[] args)
        {
            CalculaArea();
        }

        public static void CalculaArea()
        {
            Console.WriteLine("Informe o lado do quadrado: ");
            var ladoQuadrado = Console.ReadLine();

            var bibliotecaDeCalculos = new CalculosDeArea();
            Console.WriteLine($"Minha área é {bibliotecaDeCalculos.CalculaAreaDoQuadrado(double.Parse(ladoQuadrado))}");
        }


    }
}
