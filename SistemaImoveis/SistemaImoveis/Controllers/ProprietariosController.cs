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
using SistemaImoveis.Models;

namespace SistemaImoveis.Controllers
{
    public class ProprietariosController : ApiController
    {
        private ImobiliariaContext db = new ImobiliariaContext();

        // GET: api/Proprietarios
        public IQueryable<Proprietarios> GetGetProprietarios()
        {
            return db.GetProprietarios;
        }

        // GET: api/Proprietarios/5
        [ResponseType(typeof(Proprietarios))]
        public IHttpActionResult GetProprietarios(int id)
        {
            Proprietarios proprietarios = db.GetProprietarios.Find(id);
            if (proprietarios == null)
            {
                return NotFound();
            }

            return Ok(proprietarios);
        }

        // PUT: api/Proprietarios/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProprietarios(int id, Proprietarios proprietarios)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != proprietarios.Id)
            {
                return BadRequest();
            }

            db.Entry(proprietarios).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProprietariosExists(id))
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

        // POST: api/Proprietarios
        [ResponseType(typeof(Proprietarios))]
        public IHttpActionResult PostProprietarios(Proprietarios proprietarios)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.GetProprietarios.Add(proprietarios);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = proprietarios.Id }, proprietarios);
        }

        // DELETE: api/Proprietarios/5
        [ResponseType(typeof(Proprietarios))]
        public IHttpActionResult DeleteProprietarios(int id)
        {
            Proprietarios proprietarios = db.GetProprietarios.Find(id);
            if (proprietarios == null)
            {
                return NotFound();
            }

            db.GetProprietarios.Remove(proprietarios);
            db.SaveChanges();

            return Ok(proprietarios);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProprietariosExists(int id)
        {
            return db.GetProprietarios.Count(e => e.Id == id) > 0;
        }
    }
}