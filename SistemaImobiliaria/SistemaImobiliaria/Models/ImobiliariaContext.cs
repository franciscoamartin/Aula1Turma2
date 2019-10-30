using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SistemaImobiliaria.Models
{
    public class ImobiliariaContext : DbContext
    {
        public virtual DbSet<Imovel> GetImovels { get; set; }

        public virtual DbSet<Proprietario> GetProprietarios { get; set; }

    }
}