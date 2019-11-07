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
using ImoveisProprietarios.Models;

namespace ImoveisProprietarios.Controllers
{
    public class ImoveisController : ApiController
    {
        private ImobiliariaContext db = new ImobiliariaContext();

        // GET: api/Imoveis
        public IQueryable<Imoveis> GetImoveis()
        {
            return db.Imoveis;
        }

        // GET: api/Imoveis/5
        [ResponseType(typeof(Imoveis))]
        public IHttpActionResult GetImoveis(int id)
        {
            Imoveis imoveis = db.Imoveis.Find(id);
            if (imoveis == null)
            {
                return NotFound();
            }

            return Ok(imoveis);
        }

        // PUT: api/Imoveis/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutImoveis(int id, Imoveis imoveis)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != imoveis.Id)
            {
                return BadRequest();
            }

            db.Entry(imoveis).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImoveisExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Imoveis
        [ResponseType(typeof(Imoveis))]
        public IHttpActionResult PostImoveis(Imoveis imoveis)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Imoveis.Add(imoveis);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = imoveis.Id }, imoveis);
        }

        // DELETE: api/Imoveis/5
        [ResponseType(typeof(Imoveis))]
        public IHttpActionResult DeleteImoveis(int id)
        {
            Imoveis imoveis = db.Imoveis.Find(id);
            if (imoveis == null)
            {
                return NotFound();
            }

            db.Imoveis.Remove(imoveis);
            db.SaveChanges();

            return Ok(imoveis);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ImoveisExists(int id)
        {
            return db.Imoveis.Count(e => e.Id == id) > 0;
        }
    }
}