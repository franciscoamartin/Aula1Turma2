namespace SistemaImoveis.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ImobiliariaContext : DbContext
    {

        public ImobiliariaContext()
            : base("name=ProprietarioContext")
        {
        }

        public virtual DbSet<Proprietarios> GetProprietarios { get; set; }

        //public virtual DbSet<Imovel> GetImoveis { get; set; }


        public  virtual DbSet<Imovel> Imovels { get; set; }
    }

}