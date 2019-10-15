using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    public class EntityContexDB : DbContext
    {
        public DbSet<Aluno> ListaDeAlunos { get; set; }
    }
}
