using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroImoveis.Controllers;

namespace RegistroImoveis.Controllers
{
    public partial class ImovelsController
    {
        [HttpGet]
        [Route("CustomQuery")]
        public async Task<ActionResult<object>> CustomImoveisQuery()
        {

            var listaImoveis = _context.Imovel.ToList();

            var retornaLista = from imoveis in listaImoveis
                               select new
                               {
                                   NameImovel = imoveis.NomeImovel,
                                   ImovelId = imoveis.Id
                               };

            return Ok(retornaLista);
        }


        //[HttpGet]
        //[Route("Consulta")]
        //public object Consulta()
        //{
        //    var listaImoveis = _context.Imovel.ToList();

        //    var retornaLista = from imoveis in listaImoveis
        //                       select new
        //                       {
        //                           NameImovel = imoveis.NomeImovel,
        //                           ImovelId = imoveis.Id
        //                       };

        //    return retornaLista;


        //}

    }
}
