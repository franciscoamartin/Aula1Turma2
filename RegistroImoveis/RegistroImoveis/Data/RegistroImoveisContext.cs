using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RegistroImoveis.Model;

namespace RegistroImoveis.Models
{
    public class RegistroImoveisContext : DbContext
    {
        public RegistroImoveisContext (DbContextOptions<RegistroImoveisContext> options)
            : base(options)
        {
        }

        public DbSet<Imovel> Imovel { get; set; }
    }
}
