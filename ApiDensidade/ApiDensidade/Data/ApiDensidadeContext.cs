using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiDensidade.Controllers;

namespace ApiDensidade.Models
{
    public class ApiDensidadeContext : DbContext
    {
        public ApiDensidadeContext (DbContextOptions<ApiDensidadeContext> options)
            : base(options)
        {
        }

        public DbSet<Objeto> Objeto { get; set; }
    }
}
