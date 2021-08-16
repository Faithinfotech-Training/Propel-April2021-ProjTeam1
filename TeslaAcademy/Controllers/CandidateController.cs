using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeslaAcademy.Models;

namespace TeslaAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private TeslaContext _context;

        public CandidateController(TeslaContext context)
        {
            _context = context;
        }

        // GET: api/Candidate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Candidatedetails>>> GetCandidatedetails()
        {
            return await _context.Candidatedetails.ToListAsync();
        }

        // GET: api/Candidate/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Candidatedetails>> GetCandidatedetail(int id)
        {
            var candidatedetail = await _context.Candidatedetails.FindAsync(id);

            if (candidatedetail == null)
            {
                return NotFound();
            }

            return candidatedetail;
        }

        // PUT: api/Candidate/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCandidatedetail(int id, Candidatedetails candidatedetail)
        {
            if (id != candidatedetail.Candidateid)
            {
                return BadRequest();
            }

            _context.Entry(candidatedetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CandidatedetailExists(id))
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

        // POST: api/Candidate
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Candidatedetails>> PostCandidatedetail(Candidatedetails candidatedetail)
        {
            _context.Candidatedetails.Add(candidatedetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCandidatedetail", new { id = candidatedetail.Candidateid }, candidatedetail);
        }

        // DELETE: api/Candidate/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCandidatedetail(int id)
        {
            var candidatedetail = await _context.Candidatedetails.FindAsync(id);
            if (candidatedetail == null)
            {
                return NotFound();
            }

            _context.Candidatedetails.Remove(candidatedetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CandidatedetailExists(int id)
        {
            return _context.Candidatedetails.Any(e => e.Candidateid == id);
        }
    }
}
