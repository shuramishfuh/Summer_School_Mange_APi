using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Control.Context;
using Control.Models;

[assembly:ApiConventionType(typeof(DefaultApiConventions))]
namespace Control.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachesController : ControllerBase
    {
        private readonly ControlContext _context;

        public TeachesController(ControlContext context)
        {
            _context = context;
        }

        // GET: api/Teaches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Teach>>> GetTeaches()
        {
            return await _context.Teaches.ToListAsync();
        }

        // GET: api/Teaches/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Teach>> GetTeach(short id)
        {
            var teach = await _context.Teaches.FindAsync(id);

            if (teach == null)
            {
                return NotFound();
            }

            return teach;
        }

        // PUT: api/Teaches/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeach(short id, Teach teach)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            if (id != teach.TeachId)
            {
                return BadRequest();
            }

            _context.Entry(teach).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeachExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok("Done");
        }

        // POST: api/Teaches
        [HttpPost]
        public async Task<ActionResult<Teach>> PostTeach(Teach teach)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _context.Teaches.Add(teach);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTeach", new { id = teach.TeachId }, teach);
        }

        // DELETE: api/Teaches/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Teach>> DeleteTeach(short id)
        {
            var teach = await _context.Teaches.FindAsync(id);
            if (teach == null)
            {
                return NotFound();
            }

            _context.Teaches.Remove(teach);
            await _context.SaveChangesAsync();

            return teach;
        }

        private bool TeachExists(short id)
        {
            return _context.Teaches.Any(e => e.TeachId == id);
        }
    }
}
