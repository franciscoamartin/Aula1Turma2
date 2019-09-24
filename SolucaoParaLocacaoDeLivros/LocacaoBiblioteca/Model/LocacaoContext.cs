using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext
    {
        public int IdContadorLivros { get; set; } = 1;
        public int IdContadorUsuarios { get; set; } = 1;

        //metodo construtor que prepara nossa classe
        public LocacaoContext()
        {
            ListaDeLivros = new List<Livros>();
            ListaDeUsuarios = new List<Usuario>();

            //adiciona o usuario
            ListaDeUsuarios.Add(new Usuario
            {
                Id = IdContadorUsuarios++,
                Login = "admin",
                Senha = "admin"
            });
            ListaDeUsuarios.Add(new Usuario
            {

                Id = IdContadorUsuarios++,
                Login = "admin",
                Senha = "123"
            });
            ListaDeLivros.Add(new Livros
            {
                Id = IdContadorLivros++,
                Nome = "Meu Novo livro",
                DataCriacao = DateTime.Now
                
            });
        }

        public List<Livros> ListaDeLivros { get; set; }
        public List<Usuario> ListaDeUsuarios { get; set; }
    }
}
