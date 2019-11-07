using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ImoveisProprietarios.Models
{
    public class ImobiliariaContext : DbContext
    {
        public virtual DbSet<Proprietarios> Proprietarios { get; set; }

        public virtual DbSet<Imoveis> Imoveis { get; set; }

    }
}