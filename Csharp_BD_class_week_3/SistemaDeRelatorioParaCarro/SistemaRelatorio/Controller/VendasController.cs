using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRelatorio.Model;

namespace SistemaRelatorio.Controller
{
    public class VendasController
    {
        SistemaDeVendasContext vendasContext = new SistemaDeVendasContext();

        public VendasController()
        {
        }

        /// <summary>
        /// metodo que retorna a lista de vendas caso nao informar o valor ele retorna  0
        /// </summary>
        /// <param name="mes"></param>
        /// <returns></returns>
        public List<Venda> GetVendas(int mes = 0)
        {
            if (mes == 0)
                return vendasContext.ListaVendasPublica;
            else
                //retorna nossa lista de vendas sem nenhum filtro
                return vendasContext.ListaVendasPublica.FindAll(x => x.Data.Month == mes);
        }
    }
}
