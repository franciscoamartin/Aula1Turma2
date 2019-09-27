using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DllPastaWin;

namespace AtividadeDll
{
    class Program
    {
        static DocumentsAutoGenerate dll = new DocumentsAutoGenerate();
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de pastas");
            MenuPastas();
            Console.ReadKey();
        }

        private static void CriarPasta()
        {

            Console.WriteLine("Digite o nome da pasta: ");
            var nomePasta = Console.ReadLine();
            dll.CriarPastaMeusDocumentos(nomePasta);
            Console.WriteLine($"Pasta {nomePasta} foi criado com sucesso.");
            Console.ReadKey();
            Console.Clear();
            MenuPastas();
        }

        private static void ListarPastas()
        {
            Console.WriteLine("Listas de Pastas");
            dll.ObterPastasDiretorioMeuDocumentos().ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
            Console.Clear();

            MenuPastas();
        }

       

            private static void DeletarPasta()
        {
            dll.ObterPastasDiretorioMeuDocumentos().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            Console.WriteLine("Digite o nome da pasta para deletar: ");
            var nomePasta = Console.ReadLine();
            dll.DeletarPastaMeusDocumentos(nomePasta, true);
            Console.WriteLine();
            Console.WriteLine($"Pasta {nomePasta} foi deletada com sucesso.");
            Console.ReadKey();
            Console.Clear();
            MenuPastas();
        }

        private static void MenuPastas()
        {
            var menuEscolhido = int.MinValue;

            while (menuEscolhido != 0)
            {
                Console.Clear();

                Console.WriteLine("1 - Criar Pasta");
                Console.WriteLine("2 - Deletar Pasta");
                Console.WriteLine("3 - Listar Pastas");
                Console.WriteLine("4 - Hora do Show");

                Console.WriteLine("0 - Sair");
                var numeroDigitado = int.Parse(Console.ReadLine());

                switch (numeroDigitado)
                {
                    case 1:
                        CriarPasta();
                        break;
                    case 2:
                        DeletarPasta();
                        break;
                    case 3:
                        ListarPastas();
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saindo...");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                        break;
                    case 3:
                        HoraDoShow();
                        break;
                }
            }
        }

    }
}
