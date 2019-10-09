using System;
using System.Collections.Generic;

namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext
    {
        //contador 
        public int IdContadorLivros { get; set; } = 1;
        public int IdContadorUsuarios { get; set; } = 1;

        //instanciação
        public List<Livro> ListaDeLivros { get; set; }
        public List<Usuario> ListaDeUsuarios { get; set; }

        //metodo construtor que prepara nossa classe
        public LocacaoContext()
        {
            ListaDeLivros = new List<Livro>();
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
            ListaDeLivros.Add(new Livro
            {
                Id = IdContadorLivros++,
                Nome = "Meu Novo livro",
                DataCriacao = DateTime.Now
                
            });
        }

    }
}
