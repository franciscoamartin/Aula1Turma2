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

        public LivrosController()
        {
            Livros = new List<Livros>();

            Livros.Add(new Livros
            {
                Nome = "Meu primeiro"
            });

            Livros.Add(new Livros
            {
                Nome = "Meu Segundo"
            });
        }
        public List<Livros> Livros { get; set; }
    }
}
