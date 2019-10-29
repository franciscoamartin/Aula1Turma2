using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiListaDeNomes.Models;

namespace WebApiListaDeNomes.Controllers
{
    public class PessoaController : ApiController
    {

        List<Pessoa> Pessoas = new List<Pessoa>()
        {
                new Pessoa(){Nome = "Joao", Idade=20},
                new Pessoa(){Nome = "Maria", Idade=10},
                new Pessoa(){Nome = "Teste3", Idade=30},
                new Pessoa(){Nome = "Teste4", Idade=50},
                new Pessoa(){Nome = "Teste5", Idade=60},
                new Pessoa(){Nome = "Joao2", Idade=60},
                new Pessoa(){Nome = "Maria2", Idade=20},
                new Pessoa(){Nome = "Teste6", Idade=32},
                new Pessoa(){Nome = "Teste7", Idade=56},
                new Pessoa(){Nome = "Teste8", Idade=66}

        };

        public List<Pessoa> Get()
        {
            return Pessoas;
        }

      public Pessoa Post(Pessoa item) //metodo Post
        {
            Pessoas.Add(item);

            return item;
        }
    }
}
