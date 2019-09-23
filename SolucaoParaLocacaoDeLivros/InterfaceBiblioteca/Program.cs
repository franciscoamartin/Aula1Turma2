using System;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;
using System.Collections.Generic;
using System.Threading;

namespace InterfaceBiblioteca
{
    class Program
    {
        static LivrosController livrosController = new LivrosController();//instanciado
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
            Console.Clear();
            Console.WriteLine("Informe seu login e senha para acessar o sistema: ");

            Console.Write("Login: ");
            var loginDoUsuario = Console.ReadLine();

            Console.Write("Senha: ");
            var senhaDoUsuario = Console.ReadLine();

            //UsuarioController controller = new UsuarioController();

            return usuarios.LoginSistema(new Usuario() //com construtor

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
                Console.WriteLine("1 - Listar de usuários");
                Console.WriteLine("2 - Lista de Livros");
                Console.WriteLine("3 - Cadastrar Livros");
                Console.WriteLine("4 - Cadastrar Usuário");
                Console.WriteLine("5 - Trocar de Usuário");
                Console.WriteLine("6 - Desativar Usuário");
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
                        AdicionarLivro();
                        break;
                    case 4:
                        CadastrarUsuario();
                        break;
                    case 5:
                        while (!RealizaLoginSistema())
                            Console.WriteLine("Login e senha inválidos");
                        break;
                    case 6:
                        RemoverUsuarioId();
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

        private static void RemoverUsuarioId()
        {
            Console.WriteLine("Remover usuário pelo id no sistema");
            usuarios.RetornaListaDeUsuarios().ForEach(i => Console.WriteLine($"id: {i.Id} - Nome do Usuário: {i.Login} e data criação: {i.DataCriacao}"));
            Console.WriteLine();
            Console.WriteLine("Informe o ID para desativar do sistema");
            var usuarioID = int.Parse(Console.ReadLine());
            usuarios.RemoverUsuario(usuarioID);
        }

        private static void CadastrarUsuario()
        {
            Console.Clear();
            Console.WriteLine("Cadastrar Usuário no sistema: ");
            Console.WriteLine();
            Console.Write("Nome do Usuário: ");
            //obtemos essa informação do usuário
            var nomeUsuario = Console.ReadLine();
            Console.Write("Senha do Usuário: ");
            //obtemos essa informação do usuário
            var senhaUsuario = Console.ReadLine();

            usuarios.AdicionarUsuario(new Usuario()
            {
                Login = nomeUsuario,
                Senha = senhaUsuario
            });
            Console.WriteLine("Usuário Cadastrado com sucesso!");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// metodo que adiciona dentro da nossa lista um novo registro de livro.
        /// </summary>
        private static void AdicionarLivro()
        {
            Console.Clear();
            //identificamos que o mesmo esta na parte de cadastro de livros do sistema
            Console.WriteLine("Cadastrar livro dentro do sistema: ");
            Console.WriteLine();
            //informamos que para dar continuidade ele deve informar um nome para o livro
            Console.Write("Nome do Livro: ");
            //obtemos essa informação do usuário
            var nomeLivro = Console.ReadLine();


            //livroscontroller livros controle e nossa objeto em memoria com isso temos disponivel nele ferramentas que 
            //nos ajudam a realizar as tarefas
            //como adicionar um item a nossa lista de livros.
            livrosController.AdicionarLivro(new Livros()
            {
                //aqui atribuimos o nome que demos ao livro na propriedade nome de nossa livro com o sinal
                //de apenas um = temos a atribuicao passagem de valor
                Nome = nomeLivro


            });
            //indico que finalizamos o processo de cadastro de livro assim o usuario ja sabe que o mesmo foi realizado e sem erros
            Console.WriteLine("Livro Cadastrado com sucesso!");
            Thread.Sleep(1000);
        }

        private static void MostrarLivros()
        {
            Console.Clear();
            livrosController.RetornaListaDeLivros().ForEach(i => Console.WriteLine($"id do livro: {i.Id} - Nome do Livro: {i.Nome} e data de criação: {i.DataCriacao}"));
            Console.WriteLine();
            Console.WriteLine("Enter para voltar para o menu");
            Console.ReadKey();
            MostraMenuSistema();

        }
        /// <summary>
        /// metodo para mostrar a lista de usuarios ha cadastrados no sistema
        /// </summary>
        private static void MostrarUsuarios()
        {
            Console.Clear();
            usuarios.RetornaListaDeUsuarios().ForEach(i => Console.WriteLine($"id: {i.Id} - Nome do Usuário: {i.Login} e data criação: {i.DataCriacao}"));
            Console.WriteLine();
            Console.WriteLine("Enter para voltar para o menu");
            Console.ReadKey();
            MostraMenuSistema();
        }

        //private static void TrocarUsuario()
        //{
        //    Console.Clear();
        //    RealizaLoginSistema();

        //    Console.ReadKey();
        //} 
    
    }

}
