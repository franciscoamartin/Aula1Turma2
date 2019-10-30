using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BancoExistente.Controllers
{
    public partial class CarroesController
    {
        [HttpGet]
        [Route("Api/Carroes/CustomQuery")]
        public object CustomCarrosQuery()
        
        {
            var listaDeCarros = db.Carros.ToList();

            var retornoCarros = from carros in listaDeCarros
                                select new
                                {
                                    NomeCarro = carros.Modelo,
                                    CarrosId = carros.Id
                                };

            return retornoCarros;
        }
        
    }
}