using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisandoEntity.Model
{
    public class CervejaContextDb : DbContext //heranca da classe dbcontext que roda o BD
    {
        public DbSet<Cerveja> Cervejas { get; set; } //definimos nossa tabela dentro do BD
    }
}
