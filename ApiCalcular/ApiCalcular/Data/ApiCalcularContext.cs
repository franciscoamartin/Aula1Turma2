using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiCalcular.Controllers;

namespace ApiCalcular.Models
{
    public class ApiCalcularContext : DbContext
    {
        public ApiCalcularContext (DbContextOptions<ApiCalcularContext> options)
            : base(options)
        {
        }

        public DbSet<ApiCalcular.Controllers.Objeto> Objeto { get; set; }
    }
}
