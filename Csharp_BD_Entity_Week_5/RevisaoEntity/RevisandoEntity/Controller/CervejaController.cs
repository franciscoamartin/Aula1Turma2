using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevisandoEntity.Model;

namespace RevisandoEntity.Controller
{
    // 1 - deixar ela publica
    //2 - inportar pasta model
    public class CervejaController
    {
        //iniciando nossa lista de dados na controller
        CervejaContextDb contextDb = new CervejaContextDb();
        public void AddCerveja(Cerveja item)
        {
            if (item.Nome.Contains("Cerveja"))
            {
                contextDb.Cervejas.Add(item);
                contextDb.SaveChanges();

            }
        }

        public IQueryable<Cerveja> GetCervejas()
        {
            return contextDb.Cervejas.Where(x => x.Nome.Contains("Cerveja"));
        }
    }
}
