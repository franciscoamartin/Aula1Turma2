using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CalculandoIdade.Controllers
{
    public class CalculoIdadeController : ApiController
    {
        /// <summary>
        /// retorna o nome da aplicacao e o que ela faz
        /// </summary>
        /// <returns>Retorna o que nosso app faz</returns>
        //public string Get()
        //{
        //    return "App para beber hoje";   
        //}

        //public string Get(int anoNascimento, string nomeUsuario)
        //{
        //    if((DateTime.Now.Year - anoNascimento) >= 18)
        //    {
        //        return $"Olá {nomeUsuario}, de acordo com os calculos realizados em nosso servidor o sistema identificou que você está habilitado a consumir bebidas alcolicas.";
        //    }
        //    else
        //    {
        //       return $"Olá {nomeUsuario} você não está habilitado a consumir bebidas alcolicas.";
        //    }
        //}
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public string Get(double peso, double altura, string nome)
        {
            var imc = (peso) / (altura*altura);
            return $"Olá {nome} seu IMC é {imc}.";
        }


       
    }
}
