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
        [Route("Api/Usuario/UsuarioComCarros/{idCarros}")]
        public object CustomUsuarioOnCarros(int idCarros)
        {
            var listaDeCarros = db.Carros.Where(p => p.Id == idCarros).ToList();
            var listUsuarios = db.Usuarios.ToList();

            var conteudoRetorno = from usu in listUsuarios
                                  join car in listaDeCarros
                                  on usu.Id equals car.UsuInc
                                  select new
                                  {
                                      CarrosId = car.Id,
                                      CarroNome = car.Modelo,
                                      Usuario = usu.Id,
                                      UsuarioNome = usu.Usuario1
                                  };
            return conteudoRetorno;
        }
    }
}