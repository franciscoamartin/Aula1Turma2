using System;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;
using System.Collections.Generic;
using System.Threading;

namespace InterfaceBiblioteca
{
    class Program
    {
        static LivrosController livros = new LivrosController();//instanciar
        static UsuarioController usuarios = new UsuarioController();


        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVROS 1.0");
            Console.WriteLine();
            while (!RealizaLoginSistema())
            {
                Console.WriteLine("Login e senha inválidos");
            }
            MostraMenuSistema();

        }
        /// <summary>
        /// Metodo que realiza os preocedimento completos de login dentro do sitema como solicitacao de login e 
        /// senha pelo console assim como a respectivas validacoes que mo mesmo precisa para entrar no sitema
        /// </summary>
        /// <returns>retorna verdadeiro quando o login e senha informados estiverem corretos</returns>
        private static bool RealizaLoginSistema()
        {
            Console.WriteLine("Informe seu login e senha para acessar o sistema: ");

            Console.Write("Login: ");
            var loginDoUsuario = Console.ReadLine();

            Console.Write("Senha: ");
            var senhaDoUsuario = Console.ReadLine();

            UsuarioController controller = new UsuarioController();

            return controller.LoginSistema(new Usuario() //com construtor

            {
                Login = loginDoUsuario,       //sem construtor
                Senha = senhaDoUsuario
            });

        }
        /// <summary>
        /// Mostrar no console o menu do sistema
        /// </summary>
        private static void MostraMenuSistema()
        {

            var menuEscolhido = int.MinValue;
            while (menuEscolhido != 0)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");

                Console.WriteLine("Menu Sistema");
                Console.WriteLine("1 - Listar usuários");
                Console.WriteLine("2 - Livros");
                Console.WriteLine("3 - Cadastrar Livros");
                Console.WriteLine("4 - Trocar de Usuário");
                Console.WriteLine("0 - Sair");
                int numeroDigitado = int.Parse(Console.ReadKey().KeyChar.ToString());

                switch (numeroDigitado)
                {
                    case 1:
                        MostrarUsuarios();
                        break;
                    case 2:
                        MostrarLivros();
                        break;
                    case 3:
                        MostrarLivros();
                        break;
                    case 4:
                        TrocarUsuario();
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saindo...");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                        break;

                }
                //aqui vamos pegar numero digitado
                //executar proxima funcao
            }
        }

        private static void MostrarLivros()
        {
            Console.Clear();
            livros.Livros.ForEach(i => Console.WriteLine($"Nome do Livro: {i.Nome}"));
            Console.ReadKey();

        }
        /// <summary>
        /// metodo para mostrar a lista de usuarios ha cadastrados no sistema
        /// </summary>
        private static void MostrarUsuarios()
        {
            usuarios.Usuario.ForEach(i => Console.WriteLine($"Nome do Usuário: {i.Login} "));
            Console.ReadKey();

        }

        private static void TrocarUsuario()
        {
            Console.Clear();
            RealizaLoginSistema();

            Console.ReadKey();
        }
    }
}
