using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ConsultaTraduzida.Controllers
{
    //[RoutePrefix("Api/Carroes")] pode se utilizar uma rota padrao de entrada fixa
    // InnerJoinContext db = InnerJoinContext();

    public partial class CarrosController
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

        [HttpGet]
        [Route("Api/Carroes/CarrosComMarcas")]
        public object CustomCarrosOnMarcas()
        {
            var listaDeCarros = db.Carros.ToList();
            var listMarcas = db.Marcas.ToList();

            var conteudoRetorno = from mar in listMarcas
                                  join car in listaDeCarros
                                  on mar.Id equals car.Marca
                                  select new
                                  {
                                      CarrosId = car.Id,
                                      CarroNome = car.Modelo,
                                      MarcaId = mar.Id,
                                      MarcaNome = mar.Nome
                                  };
            return conteudoRetorno;
        }

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
                                      UsuarioNome = usu.Usuario
                                  };
            return conteudoRetorno;
        }


        [HttpGet]
        [Route("Api/Carroes/Vendas/{Ano}")]
        public object CustomVendasOnCarros(int ano)
        {
            var listaDeCarros = db.Carros.ToList();
            var listaDeVendas = db.Vendas.ToList();

            var conteudoRetorno = from ven in listaDeVendas
                                  join car in listaDeCarros
                                  on ven.Carro equals car.Id
                                  where ano == ven.DatInc.Year
                                  select new
                                  {
                                      CarrosId = car.Id,
                                      CarroNome = car.Modelo,
                                      Ano = ven.DatInc.Year
                                      
                                  };
            return conteudoRetorno;
        }

        [HttpGet]
        [Route("Api/Carroes/Vendas/{usuario}/{Ano}")]
        public object CustomVendasOnUsuario(int usuario, int ano)
        {
            var listaDeCarros = db.Carros.ToList();
            var listaDeVendas = db.Vendas.ToList();
            var listaDeUsuarios = db.Usuarios.ToList();


            var conteudoRetorno = from ven in listaDeVendas
                                  join car in listaDeCarros
                                  on ven.Carro equals car.Id
                                  join usu in listaDeUsuarios
                                  on ven.UsuInc equals usu.Id
                                  where ano == ven.DatInc.Year
                                  && usuario == ven.UsuInc
                                  select new
                                  {
                                      CarrosId = car.Id,
                                      CarroNome = car.Modelo,
                                      Ano = ven.DatInc.Year,
                                      Usuario = usu.Usuario,
                                      Quantidade = ven.Quantidade,
                                      Valor = ven.Valor,
                                      Total = ven.Quantidade * ven.Valor

                                  };
            return conteudoRetorno;
        }

        //segunda forma de obter vendas por ano sem entrada
        [HttpGet]
        [Route("Api/Carroes/Vendas/VendasPorAno")]
        public object RelatorioVendasPorAno()
        {
            var listaDeCarros = db.Carros.ToList();
            var listaDeVendas = db.Vendas.ToList();
            var listaDeUsuarios = db.Usuarios.ToList();


            var conteudoRetorno = from ven in listaDeVendas //Linq to Entities
                                  join car in listaDeCarros
                                  on ven.Carro equals car.Id
                                  join usu in listaDeUsuarios
                                  on ven.UsuInc equals usu.Id
                                  orderby ven.Quantidade descending
                                  group new { ven } by new { ven.DatInc.Year, ven.UsuInc } into groupby
                                  select new//objetos anonimos
                                  {
                                      AnoVenda = groupby.Key.Year, 
                                      UsuarioVenda = groupby.Key.UsuInc,
                                      QuantidadeVendida = groupby.Sum(p => p.ven.Quantidade)


                                  };
            return conteudoRetorno;
        }

        [HttpGet]
        [Route("Api/Carroes/MaisVendas/{marca}/{ano}")]
        public object CustomMaisVendas(string marca, int ano)
        {
            var listaDeCarros = db.Carros.ToList();
            var listaDeVendas = db.Vendas.ToList();
            var listaDeUsuarios = db.Usuarios.ToList();
            var listaDeMarcas = db.Marcas.ToList();


            var conteudoRetorno = from ven in listaDeVendas
                                  join car in listaDeCarros
                                  on ven.Carro equals car.Id
                                  join usu in listaDeUsuarios
                                  on ven.UsuInc equals usu.Id
                                  join mar in listaDeMarcas
                                  on car.Marca equals mar.Id
                                  where marca == mar.Nome
                                  orderby ven.Valor descending
                                  where ano == ven.DatInc.Year
                                  
                                  select new
                                  {
                                      CarrosId = car.Id,
                                      CarroNome = car.Modelo,
                                      Ano = ven.DatInc.Year,
                                      Marca = mar.Nome,
                                      Valor = ven.Valor
                                      
                                  };
            return conteudoRetorno;
        }
        //versao 2 de busca por marca e ano
        [HttpGet]
        [Route("Api/PorMarcas/{ano}/{marca}")]
        public object RelAnoMarca(int ano, int marca)
        {
            var listaVendas = db
                .Vendas
                .Where(x =>
                x.DatInc.Year == ano).ToList();

            var listaCarro = db
                .Carros
                .Where(x => x.Marca == marca).ToList();

            var listaMarca = db.Marcas.ToList();

            var conteudoRetorno = from ven in listaVendas
                                  join car in listaCarro
                                  on ven.Carro equals car.Id
                                  join mar in listaMarca
                                  on car.Marca equals mar.Id
                                  group new { ven, car, mar }
                                  by new { ven.DatInc.Month, mar.Nome }
                                  into ingroup
                                  select new
                                  {
                                      PeriodoVenda = ingroup.Key.Month,
                                      MarcaVenda = ingroup.Key.Nome,
                                      ValorTotalVendas = ingroup.Sum(x => x.ven.Quantidade * x.ven.Valor)
                                  };

            return conteudoRetorno.OrderByDescending(x => x.ValorTotalVendas);
        }
    }
}