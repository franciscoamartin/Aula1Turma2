﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SistemaImobiliaria.Models;

namespace SistemaImobiliaria.Controllers
{
    public class ProprietariosController : ApiController
    {
        private ImobiliariaContext db = new ImobiliariaContext();

        // GET: api/Proprietarios
        public IQueryable<Proprietario> GetGetProprietarios()
        {
            return db.GetProprietarios;
        }

        // GET: api/Proprietarios/5
        [ResponseType(typeof(Proprietario))]
        public IHttpActionResult GetProprietario(int id)
        {
            Proprietario proprietario = db.GetProprietarios.Find(id);
            if (proprietario == null)
            {
                return NotFound();
            }

            return Ok(proprietario);
        }

        // PUT: api/Proprietarios/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProprietario(int id, Proprietario proprietario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != proprietario.Id)
            {
                return BadRequest();
            }

            db.Entry(proprietario).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProprietarioExists(id))
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
        [ResponseType(typeof(Proprietario))]
        public IHttpActionResult PostProprietario(Proprietario proprietario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.GetProprietarios.Add(proprietario);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = proprietario.Id }, proprietario);
        }

        // DELETE: api/Proprietarios/5
        [ResponseType(typeof(Proprietario))]
        public IHttpActionResult DeleteProprietario(int id)
        {
            Proprietario proprietario = db.GetProprietarios.Find(id);
            if (proprietario == null)
            {
                return NotFound();
            }

            db.GetProprietarios.Remove(proprietario);
            db.SaveChanges();

            return Ok(proprietario);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProprietarioExists(int id)
        {
            return db.GetProprietarios.Count(e => e.Id == id) > 0;
        }
    }
}