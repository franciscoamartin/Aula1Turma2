using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoBicicleta.Model;

namespace ProjetoBicicleta.Controller
{
    public class BicicletaController
    {
        BicicletaContextDB bicicletaContextDB = new BicicletaContextDB();
        public IQueryable<Bicicleta> ListarBicicletas()
        {
            return bicicletaContextDB.GetBicicleta;
        }

        public void AddBicicleta(Bicicleta item)
        {
            bicicletaContextDB.GetBicicleta.Add(item);
            bicicletaContextDB.SaveChanges();
        }
    }

}
