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

        //private LocacaoContext contexDB = new LocacaoContext();
        LivrosContextDB contextDB = new LivrosContextDB();
        public LivrosController()
        {

        }


        public IQueryable<Livro> GetLivro()
        {
            return contextDB.Livro.Where(x => x.Ativo == true); //acesso ao BD com filtro where e as condicoes
        }

        //private List<Livros> Livros { get; set; }

        /// <summary>
        /// Metodo que adiciona o livro em nossa lista ja instanciada criada dentro do construtor
        /// </summary>
        /// <param name="parametroLivro">informacaoes do livro que vamos adicionar</param>
        public bool AdicionarLivro(Livro item)
        {
            if (string.IsNullOrWhiteSpace(item.Nome)) //nosso tipo contem varios metodos prontos para string e metodo que identifica espacos em branco e campo que vai validar
                return false;

            contextDB.Livro.Add(item);
            contextDB.SaveChanges();
            return true;


            //adicionamos o livro em nossa lista
            //parametroLivro.DataCriacao = DateTime.Now;
            //parametroLivro.Id = contexDB.IdContadorLivros++;
            //contexDB.ListaDeLivros.Add(parametroLivro);
        }
        public List<Livro> RetornaListaDeLivros()
        {
            return contextDB.Livro.Where(x => x.Ativo).ToList<Livro>();
        }
        public void RemoverLivro(int identification)
        {
            var livro = contextDB.Livro.FirstOrDefault(x => x.Id == identification);
            //tratamento de valores inválidos.
            if (livro != null)
            {
                livro.Ativo = false;
                contextDB.SaveChanges();//salva no BD

                Console.WriteLine("Livro removido com sucesso");
            }
            //Console.WriteLine("Digite um valor valido");
        }

        public bool AtualizarLivro(Livro item)
        {
            var livro = contextDB.Livro.FirstOrDefault(x => x.Id == item.Id); //buscando na tabela o celular e regra para realizar a busca
            if (livro == null)//falamos que nosso celular da tabela vai ser igual nosso celular que estamos passando, e verificamos se ele realmente encontrou um celular
            {
                return false; //caso nao encontramos retornando false
            }
            else
            {
                // nosso celular da tabela vai ser igual nosso celular que estamos passando
                livro.DataAlteracao = DateTime.Now;
                contextDB.SaveChanges();
            }
            return true; //retornando a atualizacao
        }
    }
}
