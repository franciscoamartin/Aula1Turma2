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
        static BicicletaContextDB bicicletaContextDB = new BicicletaContextDB();
        public IQueryable<Bicicleta> ListarBicicletas()
        {
            return bicicletaContextDB.GetBicicleta.Where(x => x.Ativo == true);
        }

        public bool AddBicicleta(Bicicleta item)
        {
            if (string.IsNullOrWhiteSpace(item.Marca)) 
                return false;
            if (string.IsNullOrWhiteSpace(item.Modelo))
                return false;
            if (item.Valor <= 0)
                return false;

            bicicletaContextDB.GetBicicleta.Add(item);
            bicicletaContextDB.SaveChanges();
            return true;
        }

        public bool RemoverBicicleta(int item)
        {
            var remover = bicicletaContextDB.GetBicicleta.FirstOrDefault(x => x.Id == item);
            if (remover == null)
                return false;
            remover.Ativo = false;

            bicicletaContextDB.SaveChanges();
            return true;
        }

        public bool AtualizarBicicleta(Bicicleta item)
        {
            var atualizar = bicicletaContextDB.GetBicicleta.FirstOrDefault(x => x.Id == item.Id);

            if (atualizar == null)
            {
                return false;
            }
            else
            {
                atualizar.DataAlteracao = DateTime.Now;
                bicicletaContextDB.SaveChanges();

            }

            return true;
        }
    }

}
