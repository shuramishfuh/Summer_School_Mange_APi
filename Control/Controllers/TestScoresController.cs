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
    public class TestScoresController : ControllerBase
    {
        private readonly ControlContext _context;

        public TestScoresController(ControlContext context)
        {
            _context = context;
        }

        // GET: api/TestScores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TestScore>>> GetTestScores()
        {
            return await _context.TestScores.ToListAsync();
        }

        // GET: api/TestScores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TestScore>> GetTestScore(int id)
        {
            var testScore = await _context.TestScores.FindAsync(id);

            if (testScore == null)
            {
                return NotFound();
            }

            return testScore;
        }

        // PUT: api/TestScores/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTestScore(int id, TestScore testScore)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            if (id != testScore.TestScoreId)
            {
                return BadRequest();
            }

            _context.Entry(testScore).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestScoreExists(id))
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

        // POST: api/TestScores
        [HttpPost]
        public async Task<ActionResult<TestScore>> PostTestScore(TestScore testScore)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _context.TestScores.Add(testScore);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTestScore", new { id = testScore.TestScoreId }, testScore);
        }

        // DELETE: api/TestScores/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TestScore>> DeleteTestScore(int id)
        {
            var testScore = await _context.TestScores.FindAsync(id);
            if (testScore == null)
            {
                return NotFound();
            }

            _context.TestScores.Remove(testScore);
            await _context.SaveChangesAsync();

            return testScore;
        }

        private bool TestScoreExists(int id)
        {
            return _context.TestScores.Any(e => e.TestScoreId == id);
        }
    }
}
