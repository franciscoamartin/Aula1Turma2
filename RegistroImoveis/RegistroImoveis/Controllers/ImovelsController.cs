﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistroImoveis.Model;
using RegistroImoveis.Models;

namespace RegistroImoveis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class ImovelsController : ControllerBase
    {
        private readonly RegistroImoveisContext _context;

        public ImovelsController(RegistroImoveisContext context)
        {
            _context = context;
        }

        // GET: api/Imovels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Imovel>>> GetImovel()
        {
            return await _context.Imovel.ToListAsync();
        }

        // GET: api/Imovels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Imovel>> GetImovel(int id)
        {
            var imovel = await _context.Imovel.FindAsync(id);

            if (imovel == null)
            {
                return NotFound();
            }

            return imovel;
        }
              

        // PUT: api/Imovels/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImovel(int id, Imovel imovel)
        {
            if (id != imovel.Id)
            {
                return BadRequest();
            }

            _context.Entry(imovel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImovelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Imovels
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Imovel>> PostImovel(Imovel imovel)
        {
            _context.Imovel.Add(imovel);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetImovel), new { id = imovel.Id }, imovel);
        }

        // DELETE: api/Imovels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Imovel>> DeleteImovel(int id)
        {
            var imovel = await _context.Imovel.FindAsync(id);
            if (imovel == null)
            {
                return NotFound();
            }

            _context.Imovel.Remove(imovel);
            await _context.SaveChangesAsync();

            return imovel;
        }

        
        private bool ImovelExists(int id)
        {
            return _context.Imovel.Any(e => e.Id == id);
        }
    }
}
