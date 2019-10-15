using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNomes.Model
{
    public class NomeContextDB : DbContext
    {
        public DbSet<Nome> GetNomes { get; set; }
    }
}
