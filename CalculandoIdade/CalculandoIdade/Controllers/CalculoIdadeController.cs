using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CalculandoIdade.Controllers
    {
    [EnableCors(origins: "*", headers: "*", methods: "*")]

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


        //outros meios de overrride, ao trocar o nome do metodo precisa-se adicionar [HttpGet]
        //para usar rotas, ou "subpastas" nos links usa-se [Route("Api/nomeDaRota")]


        //EnableCors - Segurança do navegador impede que uma página da web faça solicitações AJAX para outro domínio. 
        //Essa restrição é chamada de política de mesma origeme impede que um site mal-intencionado lendo 
        //dados confidenciais de outro site. No entanto, às vezes, talvez queira permitir que outros sites 
        //chamar sua API da web.
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public string Get(double peso, double altura, string nome)
        {
            var imc = (peso) / (altura*altura);
            return $"Olá {nome} seu IMC é {imc}.";
        }

        [HttpGet]
        public double GetImc(double weight, double height)
        {
            var imc = weight / (height * height);
            return imc;
        }

        [HttpGet]
        [Route("Api/Imc/Msg")]
        public string ShowMsg(double weight, double height)
        {
            var result = "";
            var imcPeople = GetImc(weight, height);

            if (imcPeople < 18.5)
            {
                result = "thinness";
            }
            else if ((imcPeople > 18.5) && (imcPeople < 24.9))
            {
                result = "normal";
            }
            else if ((imcPeople > 25) && (imcPeople < 29.9))
            {
                result = "overweight";
            }
            else if ((imcPeople > 30) && (imcPeople < 39.9))
            {
                result = "obesity";
            }
            else
            {
                result = "severe obesity";
            }

            return result;
        }



    }
}
