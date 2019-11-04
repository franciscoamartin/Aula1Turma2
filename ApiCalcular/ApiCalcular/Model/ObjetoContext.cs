using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCalcular.Model
{
    public class ObjetoContext : DbContext
    {
        public ObjetoContext(DbContextOptions<ObjetoContext> options) : base(options)
        {

        }
        public DbSet<Object> Objeto { get; set; }
    }
}
