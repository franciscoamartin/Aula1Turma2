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

        private LocacaoContext contexDB = new LocacaoContext();
        public LivrosController()
        {

        }
        //private List<Livros> Livros { get; set; }

        /// <summary>
        /// Metodo que adiciona o livro em nossa lista ja instanciada criada dentro do construtor
        /// </summary>
        /// <param name="parametroLivro">informacaoes do livro que vamos adicionar</param>
        public void AdicionarLivro(Livros parametroLivro)
        {
            //adicionamos o livro em nossa lista
            parametroLivro.DataCriacao = DateTime.Now;
            parametroLivro.Id = contexDB.IdContadorLivros++;
            contexDB.ListaDeLivros.Add(parametroLivro);
        }
        public List<Livros> RetornaListaDeLivros()
        {
            return contexDB.ListaDeLivros.Where(x => x.Ativo).ToList<Livros>();
        }
        public void RemoverLivro(int identification)
        {
            var livro = contexDB.ListaDeLivros.FirstOrDefault(x => x.Id == identification);
            //tratamento de valores inválidos.
            if (livro != null)
            {
                livro.Ativo = false;
                Console.WriteLine("Livro removido com sucesso");
            }
            //Console.WriteLine("Digite um valor valido");
        }
    }
}
