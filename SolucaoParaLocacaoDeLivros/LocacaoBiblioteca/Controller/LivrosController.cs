using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    public class LivrosController
    {
        private int idCount = 1;
        public LivrosController()
        {
            
            Livros = new List<Livros>();

            //Console.WriteLine( "Numero um livro" );
            //string addId = Console.ReadLine();

            //Console.WriteLine("Adicione um livro");
            //string addLivro = Console.ReadLine();

            //Livros.Add(new Livros(int.Parse(addLivro),addId));

            //Livros.Add(new Livros
            //{
            //    Nome = "Meu primeiro"
            //});

            //Livros.Add(new Livros
            //{
            //    Nome = "Meu Segundo"
            //});
        }
        private List<Livros> Livros { get; set; }

        /// <summary>
        /// Metodo que adiciona o livro em nossa lista ja instanciada criada dentro do construtor
        /// </summary>
        /// <param name="parametroLivro">informacaoes do livro que vamos adicionar</param>
        public void AdicionarLivro(Livros parametroLivro)
        {

            //adicionamos o livro em nossa lista
            Livros.Add(parametroLivro);
            parametroLivro.DataCriacao = DateTime.Now;
            parametroLivro.Id = idCount;
            idCount++;

        }
        public List<Livros> RetornaListaDeLivros()
        {
            return Livros;
        }
    }
}
