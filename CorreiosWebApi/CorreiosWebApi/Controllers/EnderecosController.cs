using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CorreiosWebApi.Models;

namespace CorreiosWebApi.Controllers
{
    public class EnderecosController : ApiController
    {
        private EnderecoContextDB db = new EnderecoContextDB();

        // GET: api/Enderecos
        public IQueryable<Endereco> GetEnderecos()
        {
            return db.Enderecos;
        }
        //busca por cep
        [HttpGet]
        [Route("Api/Enderecos/{cep}/InfoCep")]
        public IQueryable<Endereco> EnderecosByCep(int cep)
        {
            return db.Enderecos.Where(x => x.Cep == cep);
        }
        //busca por bairro
        [HttpGet]
        [Route("Api/Enderecos/{bairro}/InfoBairro")]
        public IQueryable<Endereco> EnderecoPorBairro(string bairro)
        {
            return db.Enderecos.Where(x => x.Bairro == bairro);
        }
        //busca por logradouro
        [HttpGet]
        [Route("Api/Enderecos/{logradouro}/InfoLogradouro")]
        public IQueryable<Endereco> EnderecoPorLogradouro(string logradouro)
        {
            return db.Enderecos.Where(x => x.Logradouro == logradouro);
        }
        //busca por municipio
        [HttpGet]
        [Route("Api/Enderecos/{municipio}/InfoMunicipio")]
        public IQueryable<Endereco> EnderecoPorMunicipio(string municipio)
        {
            return db.Enderecos.Where(x => x.Municipio == municipio);
        }
        //busca por Uf
        [HttpGet]
        [Route("Api/Enderecos/{uf}/InfoUf")]
        public IQueryable<Endereco> EnderecoPorUf(string uf)
        {
            return db.Enderecos.Where(x => x.Uf == uf);
        }

        // GET: api/Enderecos/5
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult GetEndereco(int id)
        {
            Endereco endereco = db.Enderecos.Find(id);
            if (endereco == null)
            {
                return NotFound();
            }

            return Ok(endereco);
        }

        // PUT: api/Enderecos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEndereco(int id, Endereco endereco)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != endereco.Id)
            {
                return BadRequest();
            }

            db.Entry(endereco).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnderecoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok("Update realizado com sucesso!");
        }

        // POST: api/Enderecos
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult PostEndereco(Endereco endereco)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Enderecos.Add(endereco);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = endereco.Id }, endereco);
        }

        // DELETE: api/Enderecos/5
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult DeleteEndereco(int id)
        {
            Endereco endereco = db.Enderecos.Find(id);
            if (endereco == null)
            {
                return NotFound();
            }

            db.Enderecos.Remove(endereco);
            db.SaveChanges();

            return Ok(endereco);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EnderecoExists(int id)
        {
            return db.Enderecos.Count(e => e.Id == id) > 0;
        }
    }
}