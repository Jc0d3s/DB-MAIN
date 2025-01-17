using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Models;
using Web.Data;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NavbarController : ControllerBase
    {
        private readonly AppDbContext _context;

        public NavbarController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/navbar
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Navbar>>> GetNavbars()
        {
            return await _context.Navbars.ToListAsync();
        }

        // GET: api/navbar/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Navbar>> GetNavbar(int id)
        {
            var navbar = await _context.Navbars.FindAsync(id);

            if (navbar == null)
            {
                return NotFound();
            }

            return navbar;
        }

        // POST: api/navbar
        [HttpPost]
        public async Task<ActionResult<Navbar>> CreateNavbar(Navbar navbar)
        {
            navbar.CreatedAt = DateTime.UtcNow;
            _context.Navbars.Add(navbar);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetNavbar), new { id = navbar.Id }, navbar);
        }

        // PUT: api/navbar/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateNavbar(int id, Navbar navbar)
        {
            if (id != navbar.Id)
            {
                return BadRequest();
            }

            var existingNavbar = await _context.Navbars.FindAsync(id);

            if (existingNavbar == null)
            {
                return NotFound();
            }

            existingNavbar.Title = navbar.Title;
            existingNavbar.EditedBy = navbar.EditedBy;
            existingNavbar.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/navbar/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNavbar(int id)
        {
            var navbar = await _context.Navbars.FindAsync(id);

            if (navbar == null)
            {
                return NotFound();
            }

            _context.Navbars.Remove(navbar);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
