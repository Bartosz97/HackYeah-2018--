using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackYeah_2018_.Interfaces;
using HackYeah_2018_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HackYeah_2018_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RankController : ControllerBase
    {
        private readonly HackContext _context;

        public RankController(HackContext context)
        {
            _context = context;
        }

        // GET: api/Rank
        [HttpGet]
        public IEnumerable<Rank> GetRanks()
        {
            return _context.Ranks;
        }

        // GET: api/Rank/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRank([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var rank = await _context.Ranks.FindAsync(id);

            if (rank == null)
            {
                return NotFound();
            }

            return Ok(rank);
        }

        // PUT: api/Rank/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRank([FromRoute] int id, [FromBody] Rank rank)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rank.Id)
            {
                return BadRequest();
            }

            _context.Entry(rank).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RankExists(id))
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

        // POST: api/Rank
        [HttpPost]
        public async Task<IActionResult> PostRank([FromBody] Rank rank)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Ranks.Add(rank);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRank", new {id = rank.Id}, rank);
        }

        // DELETE: api/Rank/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRank([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var rank = await _context.Ranks.FindAsync(id);
            if (rank == null)
            {
                return NotFound();
            }

            _context.Ranks.Remove(rank);
            await _context.SaveChangesAsync();

            return Ok(rank);
        }

        private bool RankExists(int id)
        {
            return _context.Ranks.Any(e => e.Id == id);
        }
    }
}
   
