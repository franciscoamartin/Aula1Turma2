using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    public class EntityContextDB : DbContext // classe pronta que contem os processos de conexao com BD e listagem de tabelas
    {

        public DbSet//Dbset - palavra reservada para Entity que indica que vamos definir uma tabela do nosso BD
            <Pessoa> //aqui definimos nossa tabela pessoas ou seja especificamos qual de nossas classe sera uma referencia de uma tabela no BD, ela vai ao BD com o nome que definimos em nossa classe
            ListaDePessoas { get; set; } //nesta parte liberamos nossa tabela para acessar

    }
}
