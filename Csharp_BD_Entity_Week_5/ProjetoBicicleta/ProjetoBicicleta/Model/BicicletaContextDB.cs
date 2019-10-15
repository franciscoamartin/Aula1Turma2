using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBicicleta.Model
{
    class BicicletaContextDB : DbContext
    {
        public DbSet<Bicicleta> GetBicicleta { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
