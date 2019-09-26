using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Model;

namespace ListagemDeCarros.Controller
{
    public class CarroController
    {
        private SistemaCarrosContext contextDB = new SistemaCarrosContext();

        /// <summary>
        /// metodo que retorna nossa lista de carros.//15
        /// </summary>
        /// <returns>Retorna nossa lista de carros</returns>
        public List<Carro> RetornaListaDeCarros()
        {
            return contextDB.ListaCarrosPublica;
        }
    }
}
