using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RussianWeb.Models;

namespace RussianWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AxesController : ControllerBase
    {
        private readonly RussianWebDbContext _context;

        public AxesController(RussianWebDbContext context)
        {
            _context = context;
        }

        // GET: api/Axes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ax>>> GetAxes()
        {
            return await _context.Axes.ToListAsync();
        }

        // GET: api/Axes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ax>> GetAx(Guid id)
        {
            var ax = await _context.Axes.FindAsync(id);

            if (ax == null)
            {
                return NotFound();
            }

            return ax;
        }

        // PUT: api/Axes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAx(Guid id, Ax ax)
        {
            if (id != ax.id)
            {
                return BadRequest();
            }

            _context.Entry(ax).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AxExists(id))
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

        // POST: api/Axes
        [HttpPost]
        public async Task<ActionResult<Ax>> PostAx(Ax ax)
        {
            _context.Axes.Add(ax);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAx", new { id = ax.id }, ax);
        }

        // DELETE: api/Axes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ax>> DeleteAx(Guid id)
        {
            var ax = await _context.Axes.FindAsync(id);
            if (ax == null)
            {
                return NotFound();
            }

            _context.Axes.Remove(ax);
            await _context.SaveChangesAsync();

            return ax;
        }

        private bool AxExists(Guid id)
        {
            return _context.Axes.Any(e => e.id == id);
        }
    }
}
