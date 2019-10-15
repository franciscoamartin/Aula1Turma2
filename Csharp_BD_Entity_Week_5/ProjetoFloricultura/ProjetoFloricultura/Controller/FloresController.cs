using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoFloricultura.Model;

namespace ProjetoFloricultura.Controller
{
    
    public class FloresController
    {
        FloresContextDB floresContextDB = new FloresContextDB();

        public IQueryable<Flores> GetFlores()
        {
            return floresContextDB.GetFlores;
        }

        public void AddFlores(Flores flores)
        {
            floresContextDB.GetFlores.Add(flores);
            floresContextDB.SaveChanges();
        }

    }
}
