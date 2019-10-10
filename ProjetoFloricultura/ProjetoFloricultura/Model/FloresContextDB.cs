using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFloricultura.Model
{
    public class FloresContextDB : DbContext
    {
        public DbSet<Flores> GetFlores { get; set; }

    }
}
