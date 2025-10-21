using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataLayer.Context;
using Models.Models;

namespace IDStation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistributorController : ControllerBase
    {
        private readonly AzureContext _context;

        public DistributorController(AzureContext context)
        {
            _context = context;
        }

        // GET: api/Distributors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Distributor>>> GetDistributors()
        {
            return await _context.Distributors.ToListAsync();
        }

        // GET: api/Distributors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Distributor>> GetDistributor(int id)
        {
            var distributor = await _context.Distributors.FindAsync(id);

            if (distributor == null)
            {
                return NotFound();
            }

            return distributor;
        }

        // PUT: api/Distributors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDistributor(int id, Distributor distributor)
        {
            if (id != distributor.DistributorID)
            {
                return BadRequest();
            }

            _context.Entry(distributor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DistributorExists(id))
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

        // POST: api/Distributors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Distributor>> PostDistributor(Distributor distributor)
        {
            _context.Distributors.Add(distributor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDistributor", new { id = distributor.DistributorID }, distributor);
        }

        // DELETE: api/Distributors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDistributor(int id)
        {
            var distributor = await _context.Distributors.FindAsync(id);
            if (distributor == null)
            {
                return NotFound();
            }

            _context.Distributors.Remove(distributor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DistributorExists(int id)
        {
            return _context.Distributors.Any(e => e.DistributorID == id);
        }
    }
}
