using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeitorDados.Model;

namespace LeitorDados.Controller
{
    public class CarrosController
    {
        private RelatorioContext contexDB = new RelatorioContext();
        public CarrosController()
        {
        }

        public void AdicionandoCarros(Carros parametroLivro)
        {
            //Adicionamos  em nossa lista.
            parametroLivro.Id = contexDB.IdContadorCarros++;
            contexDB.Carros.Add(parametroLivro);
        }

        public List<Carros> RetornaListaDeCarros()
        {
            return contexDB.Carros;
        }

        public List<Carros> FiltrarCarrosMes(int valor)
        {

            return contexDB.Carros
                .Where(x => x.Data.Month == (valor)).ToList<Carros>();
        }

    }

 

}
