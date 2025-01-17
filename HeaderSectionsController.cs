using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HeaderSectionController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HeaderSectionController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/headersection
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HeaderSection>>> GetHeaderSections()
        {
            return await _context.HeaderSections.ToListAsync();
        }

        // GET: api/headersection/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<HeaderSection>> GetHeaderSection(int id)
        {
            var headerSection = await _context.HeaderSections.FindAsync(id);

            if (headerSection == null)
            {
                return NotFound();
            }

            return headerSection;
        }

        // POST: api/headersection
        [HttpPost]
        public async Task<ActionResult<HeaderSection>> CreateHeaderSection(HeaderSection headerSection)
        {
            headerSection.CreatedDate = DateTime.UtcNow;
            _context.HeaderSections.Add(headerSection);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetHeaderSection), new { id = headerSection.OrderNumber }, headerSection);
        }

        // PUT: api/headersection/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHeaderSection(int id, HeaderSection headerSection)
        {
            if (id != headerSection.OrderNumber)
            {
                return BadRequest();
            }

            var existingHeader = await _context.HeaderSections.FindAsync(id);

            if (existingHeader == null)
            {
                return NotFound();
            }

            existingHeader.Title = headerSection.Title;
            existingHeader.Description = headerSection.Description;
            existingHeader.ModifiedDate = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/headersection/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHeaderSection(int id)
        {
            var headerSection = await _context.HeaderSections.FindAsync(id);

            if (headerSection == null)
            {
                return NotFound();
            }

            _context.HeaderSections.Remove(headerSection);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
