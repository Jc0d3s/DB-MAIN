using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Models;
using Web.Data;


namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LogosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LogosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/logos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Logo>>> GetLogos()
        {
            return await _context.Logos.ToListAsync();
        }

        // GET: api/logos/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Logo>> GetLogo(int id)
        {
            var logo = await _context.Logos.FindAsync(id);

            if (logo == null)
            {
                return NotFound();
            }

            return logo;
        }

        // POST: api/logos
        [HttpPost]
        public async Task<ActionResult<Logo>> CreateLogo(Logo logo)
        {
            logo.CreatedDate = DateTime.UtcNow;
            _context.Logos.Add(logo);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetLogo), new { id = logo.Id }, logo);
        }

        // PUT: api/logos/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLogo(int id, Logo logo)
        {
            if (id != logo.Id)
            {
                return BadRequest();
            }

            var existingLogo = await _context.Logos.FindAsync(id);

            if (existingLogo == null)
            {
                return NotFound();
            }

            existingLogo.Name = logo.Name;
            existingLogo.ModifiedDate = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/logos/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLogo(int id)
        {
            var logo = await _context.Logos.FindAsync(id);

            if (logo == null)
            {
                return NotFound();
            }

            _context.Logos.Remove(logo);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
