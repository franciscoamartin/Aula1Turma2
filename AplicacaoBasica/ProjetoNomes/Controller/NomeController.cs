using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoNomes.Model;

namespace ProjetoNomes.Controller
{
    public class NomeController
    {
        NomeContextDB nomeContextDB = new NomeContextDB();

        //public void AddNome(Nome item)
        //{
        //    nomeContextDB.GetNomes.Add(item);
        //    nomeContextDB.SaveChanges();
        //}

        public IQueryable<Nome> ListaNomes()
        {
            return nomeContextDB.GetNomes;
        }

        public void AddPessoas(Nome nome)
        {
            nomeContextDB.GetNomes.Add(nome);
            nomeContextDB.SaveChanges();
        }
    }
}
