using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Model;

namespace EntityClass.Controller
{
    public class PessoaController
    {
        //realizo minha conexao com BD
        EntityContextDB contextDB = new EntityContextDB();

        public IQueryable//aqui temos nossa primeira interface com a classe Iqueryable essa classe contem varias funcionalidades prontas para usar igual ao BD como selects.
            <Pessoa>//definimos o tipo que ira retornar
            GetPessoas()//damos nome ao nosso metodo
        {
            return contextDB.ListaDePessoas; //retornamos a lista
        } 
        /// <summary>
        /// Metodo para adicionar pessoa no banco de dados
        /// </summary>
        /// <param name="item">Item Pessoa</param>
        public void AddPessoa(Pessoa item)
        {
            contextDB.ListaDePessoas.Add(item); //nosso banco de dados.tabelap pessoa.adicionamos o item
            contextDB.SaveChanges();//salvar no BD
        }

        
        
    }
}
