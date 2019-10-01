using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class Livros
    {
        public int Id { get; set; }


        public string Nome { get; set; }

        public bool Ativo { get; set; } = true; // tornar default todos os livros

        public int UsuarioCriacao { get; set; }

        public int UsuarioAlteracao { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime DataAlteracao { get; set; }

        //public Livros()
        //{
        //}

        //public Livros(int id, string nome)
        //{
        //    Id = id;
        //    Nome = nome;
        //}
    }
}
